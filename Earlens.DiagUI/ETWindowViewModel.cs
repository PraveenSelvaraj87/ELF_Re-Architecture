using Earlens.DataModel;
using Earlens.Framework;
using Earlens.Framework.Interface;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Earlens.ETUI
{
    public class ETWindowViewModel : BindableBase
    {
        private IFittingFramework _fittingFramework;

        #region Commands

        public DelegateCommand ConnectCommand { get; private set; }
        public DelegateCommand DisConnectCommand { get; private set; }

        public DelegateCommand CalibrationCommand { get; private set; }
        public DelegateCommand FeedbackCommand { get; private set; }

        public DelegateCommand ProgramCommand { get; private set; }
        public DelegateCommand ReadCommand { get; private set; }

        public DelegateCommand ProgramLeftCommand { get; private set; }
        public DelegateCommand ReadLeftCommand { get; private set; }

        public DelegateCommand ProgramRightCommand { get; private set; }
        public DelegateCommand ReadRightCommand { get; private set; }

        public DelegateCommand LoadAudiogramCommand { get; private set; }

        public DelegateCommand ReadMDACommand { get; private set; }

        #endregion

        private bool _isLeftConnected;
        public bool IsLeftConnected
        {
            get { return _isLeftConnected; }
            set
            {
                SetProperty(ref _isLeftConnected, value);
                RaisePropertyChanged("IsAnyDeviceConnected");
            }
        }

        private bool _isRightConnected;
        public bool IsRightConnected
        {
            get { return _isRightConnected; }
            set
            {
                SetProperty(ref _isRightConnected, value);
                RaisePropertyChanged("IsAnyDeviceConnected");
            }
        }

        private double _statusInPercent;
        public double StatusInPercent
        {
            get { return _statusInPercent; }

            set { SetProperty(ref _statusInPercent, value); }
        }

        private string _statusString;
        public string StatusString
        {
            get { return _statusString; }

            set { SetProperty(ref _statusString, value); }
        }

        public bool IsAnyDeviceConnected
        {
            get { return _isLeftConnected || _isRightConnected; }
        }

        public bool IsLeftFittingCalculated { get; set; }

        public bool IsRightFittingCalculated { get; set; }

        public bool IsLeftProgramable => IsLeftConnected && IsLeftFittingCalculated;

        public bool IsRightProgramable => IsRightConnected && IsRightFittingCalculated;

        public List<Ear> Earvalues => Enum.GetValues(typeof(Ear)).Cast<Ear>().ToList();

        public List<DeviceCommunicationType> CommunicationTypes => Enum.GetValues(typeof(DeviceCommunicationType)).Cast<DeviceCommunicationType>().ToList();

        private Ear _selectedEar;
        public Ear SelectedEarType
        {
            get { return _selectedEar; }
            set
            {
                if (_selectedEar != value)
                {
                    if (!_fittingFramework.IsConnected(_selectedEar))
                    {
                        SetProperty(ref _selectedEar, value);
                    }
                    else
                    {
                        MessageBox.Show("DisConnect Current Connection before changing the Ear Type");
                    }
                }
            }
        }

        private DeviceCommunicationType _selectedCommunicationType;
        public DeviceCommunicationType SelectedCommunicationType
        {
            get
            {
                return _selectedCommunicationType;
            }
            set
            {
                if (_selectedCommunicationType != value)
                {
                    if (!_fittingFramework.IsConnected(_selectedEar))
                    {
                        SetProperty(ref _selectedCommunicationType, value);
                        _fittingFramework.SwitchCommunicationType(_selectedCommunicationType);
                    }
                    else
                    {
                        MessageBox.Show("DisConnect Current Connection before changing the Communication Type");
                    }
                }
            }
        }
        public ETWindowViewModel()
        {
            _fittingFramework = new FittingFramework();
            SelectedCommunicationType = DeviceCommunicationType.Simulation;
            SelectedEarType = Ear.Both;
            _fittingFramework.SwitchCommunicationType(SelectedCommunicationType);

            ConnectCommand = new DelegateCommand(Connect, CanConnect);
            DisConnectCommand = new DelegateCommand(DisConnect, CanDisConnect);

            ReadMDACommand = new DelegateCommand(ReadMDA, CanReadMDA);
        }

        private bool CanReadMDA()
        {
            bool canRead = false;
            if (SelectedEarType == Ear.Both)
            {
                canRead = IsLeftConnected && IsRightConnected;
            }
            else if (SelectedEarType == Ear.Left)
            {
                canRead = IsLeftConnected;
            }
            else if (SelectedEarType == Ear.Right)
            {
                canRead = IsRightConnected;
            }

            return canRead;
        }

        private void ReadMDA()
        {
            try
            {
                if (SelectedEarType == Ear.Both)
                {
                    string leftSerialNumber = _fittingFramework.ReadSerialNumber(Ear.Left);
                    string rightSerialNumber = _fittingFramework.ReadSerialNumber(Ear.Right);

                    ProcessorType leftMdaversion = _fittingFramework.ReadProcessorType(Ear.Left);
                    ProcessorType rightMdaversion = _fittingFramework.ReadProcessorType(Ear.Right);
                }
                else
                {
                    string serialNumber = _fittingFramework.ReadSerialNumber(SelectedEarType);
                    ProcessorType mdaversion = _fittingFramework.ReadProcessorType(SelectedEarType);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to read MDA + {ex.Message}");
            }
        }

        private bool CanDisConnect()
        {
            bool canDisconnect = false;
            if (SelectedEarType == Ear.Both)
            {
                canDisconnect = IsLeftConnected && IsRightConnected;
            }
            else if (SelectedEarType == Ear.Left)
            {
                canDisconnect = IsLeftConnected;
            }
            else if (SelectedEarType == Ear.Right)
            {
                canDisconnect = IsRightConnected;
            }

            return canDisconnect;
        }

        CancellationTokenSource cancellationToken = new CancellationTokenSource();
        private async void DisConnect()
        {
            Task[] disConnectTask = new Task[2];

            IProgress<int> progress = UpdateProgress();
            StatusString = string.Empty;
            if (SelectedEarType == Ear.Both)
            {
                disConnectTask[0] = Task.Run(() =>
                {
                    StatusString = $"Disconnecting Left Processor..";
                    IsLeftConnected = _fittingFramework.DisConnect(Ear.Left);

                    StatusString = $"Disconnecting Right Processor..";
                    IsRightConnected = _fittingFramework.DisConnect(Ear.Right);                   
                });

                disConnectTask[1] = InvokeProgressTask(progress, cancellationToken.Token, 50);
            }
            else
            {
                disConnectTask[0] = Task.Run(() =>
                {
                    StatusString = $"Disconnecting {SelectedEarType.ToString()} Processor..";
                    if (SelectedEarType == Ear.Left)
                        IsLeftConnected = _fittingFramework.DisConnect(SelectedEarType);
                    else
                        IsRightConnected = _fittingFramework.DisConnect(SelectedEarType);
                });

                disConnectTask[1] = InvokeProgressTask(progress, cancellationToken.Token ,25);
            }

            await Task.WhenAll(disConnectTask).ContinueWith(t => DisConnectCommand.RaiseCanExecuteChanged(),TaskContinuationOptions.OnlyOnRanToCompletion);

            ReadMDACommand.RaiseCanExecuteChanged();
        }      
        
        public async void Connect()
        {
            try
            {
                Task[] connectTask = new Task[2];
                StatusString = string.Empty;
                IProgress<int> progress = UpdateProgress();

                if (SelectedEarType == Ear.Both)
                {
                    connectTask[0] = Task.Run(() =>
                  {
                      StatusString = $"Connecting Left Processor..";
                      IsLeftConnected = _fittingFramework.Connect(Ear.Left);

                      StatusString = $"Connecting Right Processor..";
                      IsRightConnected = _fittingFramework.Connect(Ear.Right);
                  });

                    connectTask[1] = InvokeProgressTask(progress, cancellationToken.Token, 100);
                }
                else
                {
                    connectTask[0] = Task.Run(() =>
                    {
                        StatusString = $"Connecting {SelectedEarType.ToString()} Processor..";
                        if (SelectedEarType == Ear.Left)
                            IsLeftConnected = _fittingFramework.Connect(SelectedEarType);
                        else
                            IsRightConnected = _fittingFramework.Connect(SelectedEarType);
                    });
                    connectTask[1] = InvokeProgressTask(progress, cancellationToken.Token, 50);
                }
                await Task.WhenAll(connectTask).ContinueWith(t => DisConnectCommand.RaiseCanExecuteChanged(), TaskContinuationOptions.OnlyOnRanToCompletion);

                ReadMDACommand.RaiseCanExecuteChanged();
            }
            catch (Exception ex)
            {
                cancellationToken.Cancel();
                MessageBox.Show($"Connection Failed \n {ex.Message}");
            }         
        }

        private IProgress<int> UpdateProgress()
        {
            return new Progress<int>(x =>
            {
                StatusInPercent = x;

                StatusString = StatusString.Substring(0, StatusString.LastIndexOf("."));

                StatusString += $".{StatusInPercent} % ";
            });
        }

        public bool CanConnect()
        {
            return true;
        }

        public void DoProcessing(IProgress<int> progress)
        {
            for (int i = 0; i <= 100; ++i)
            {
                Thread.Sleep(200); // CPU-bound work
                if (progress != null)
                    progress.Report(i);
            }
        }

        #region Private Methods

        private Task InvokeProgressTask(IProgress<int> progress, CancellationToken cancellationToken, int sleepTime)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; ++i)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    Thread.Sleep(sleepTime); // CPU-bound work                    
                    progress.Report(i);
                }
            });
        }

        #endregion
    }
}
