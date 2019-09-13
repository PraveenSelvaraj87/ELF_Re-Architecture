using Earlens.Controller;
using Earlens.DataModel;
using Earlens.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Framework
{
    public class FittingFramework : IFittingFramework
    {
        
        #region Properties        
      
        /// <summary>
        /// Controller Responsible Left and Right Device Communication
        /// </summary>
        public IDeviceController DeviceController { get; set; }

        /// <summary>
        /// Contraoller Responsible for Maintain the State
        /// </summary>
        public IStateController StateController { get; set; }

        /// <summary>
        /// Responsible for Undo & Redo Operation
        /// </summary>
        public IActionController ActionController { get; set; }

        /// <summary>
        /// Fitting Session 
        /// </summary>
        public FittingSession Session { get; set; }

        /// <summary>
        /// Responsible to manage Host -- Noah,Standalone
        /// </summary>
        public IHostController HostController { get; set; }

        #endregion Properties

        public FittingFramework()
        {
            HostController = new HostController();
            DeviceController = new DeviceController(DeviceCommunicationType.Simulation);
            Session = new FittingSession(ProcessorType.Inductive,ProcessorType.Inductive);
            ActionController = new ActionController();
        }

        public bool Activate()
        {
            throw new NotImplementedException();
        }

        public bool Program()
        {
            throw new NotImplementedException();
        }

        public bool Connect(Ear ear)
        {
            return DeviceController.Connect(ear);
        }

        public bool DisConnect(Ear ear)
        {
            return DeviceController.DisConnect(ear);
        }       

        public bool IsConnected(Ear ear)
        {
            return DeviceController.IsConnected(ear);
        }

        public bool LoadFitting()
        {
            throw new NotImplementedException();
        }

        public bool OpenFeedbackMeasurement(Ear ear)
        {
            throw new NotImplementedException();
        }

        public bool RunFeedbackMeasurement(Ear ear)
        {
            throw new NotImplementedException();
        }

        public bool CloseFeedbackMeasurement(Ear ear)
        {
            throw new NotImplementedException();
        }

        public bool Reset(Ear ear)
        {
            throw new NotImplementedException();
        }

        public bool StartCalibration()
        {
            throw new NotImplementedException();
        }

        public bool CloseCalibration()
        {
            throw new NotImplementedException();
        }

        public bool Scan()
        {
            throw new NotImplementedException();
        }

        public bool Mute()
        {
            throw new NotImplementedException();
        }

        public bool CreateSession()
        {
            throw new NotImplementedException();
        }

        public bool SwitchCommunicationType(DeviceCommunicationType connectionType)
        {
            return DeviceController.SwitchCommunicationMode(connectionType);
        }

        public string ReadSerialNumber(Ear ear)
        {
            return DeviceController.ReadSerialNumber(ear);
        }

        public ProcessorType ReadProcessorType(Ear ear)
        {
           return GetProcessorType(DeviceController.ReadMDAVersion(ear));
        }

        private ProcessorType GetProcessorType(int mdaVersion)
        {
            ProcessorType processorType = ProcessorType.Inductive;
            switch (mdaVersion)
            {
                case 0:
                case 1:
                case 2:
                    {
                        processorType = ProcessorType.Photonic;
                        break;
                    }
                case 0x21:
                    {
                        processorType = ProcessorType.Inductive;
                        break;
                    }
                case 0x22:
                    {
                        processorType = ProcessorType.Inductive;
                        break;
                    }
            }

            return processorType;
        }
    }
}
