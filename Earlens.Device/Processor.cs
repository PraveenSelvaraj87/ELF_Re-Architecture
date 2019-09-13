using Earlens.Communication;
using Earlens.DataModel;
using Earlens.PhysicalDevice.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice
{
    public class Processor : IProcessor
    {
        private ICommunication _communicator;

        private Dictionary<string,IModule> _deviceModules;
        public DeviceCommunicationType DeviceCommType  { get; private set; }

        
        public Processor(Ear ear, DeviceCommunicationType deviceConnectionType)
        {
            InitializeDevice(ear,deviceConnectionType);
        }

        private void InitializeDevice(Ear ear,DeviceCommunicationType deviceConnectionType)
        {
            SwitchCommInterface(ear,deviceConnectionType);

            //Create the Module and Initialize here 
            // Need memory map or json file to create and initialize all modules
            _deviceModules = new Dictionary<string, IModule>
            {
                { ModuleName.MDA_MODULE, new MDAModule(_communicator) },

                { ModuleName.WDRC_MODULE, new WDRCModule(_communicator) }
            };
        }

        public bool SwitchCommInterface(Ear ear,DeviceCommunicationType deviceConnectionType)
        {
            bool isCommSwitched = false;
            try
            {
                if (DeviceCommType != deviceConnectionType || _communicator == null)
                {
                    //Diconnect Current Communication
                    _communicator?.Disconnect();

                    switch (deviceConnectionType)
                    {
                        case DeviceCommunicationType.Simulation:
                            {
                                _communicator = new SimulatedCommunication(ear);
                                break;
                            }
                        case DeviceCommunicationType.Wired:
                            {
                                _communicator = new WiredCommunication(ear);
                                break;
                            }
                        case DeviceCommunicationType.WiredCTK:
                            {
                                _communicator = new WiredCTKCommunication(ear);
                                break;
                            }
                        case DeviceCommunicationType.Wireless:
                            {
                                _communicator = new WirelessCommunication(ear);
                                break;
                            }
                    }
                    DeviceCommType = deviceConnectionType;
                    isCommSwitched = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isCommSwitched = false;
            }
            return isCommSwitched;
        }

        public string ReadSerialNumber()
        {   
            return (GetModule(ModuleName.MDA_MODULE) as IMDAModule).ReadSerialNumber();
        }

        public int ReadMDAVersion()
        {   
            return (GetModule(ModuleName.MDA_MODULE) as IMDAModule).ReadMDAVersion();
        }

        public bool Connect()
        {
            return _communicator.Connect();
        }

        public bool Disconnect()
        {
            return _communicator.Disconnect();
        }

        public bool IsConnected()
        {
            return _communicator.IsConnected();
        }

        public void Program()
        {
            throw new NotImplementedException();
        }

        public void ReadDevice()
        {
            throw new NotImplementedException();
        }

        public void Activate()
        {
            throw new NotImplementedException();
        }

        public bool OpenFeedbackMeasurement()
        {
            throw new NotImplementedException();
        }

        public bool RunFeedbackMeasurement()
        {
            throw new NotImplementedException();
        }

        public bool CloseFeedbackMeasurement()
        {
            throw new NotImplementedException();
        }

        public bool Reset()
        {
            throw new NotImplementedException();
        }

        public bool UpdateNordicFirmware()
        {
            throw new NotImplementedException();
        }

        public bool UpdateDSPFirmware()
        {
            throw new NotImplementedException();
        }

        private IModule GetModule(string moduleName)
        {
            return _deviceModules.FirstOrDefault((mod) => mod.Key == ModuleName.MDA_MODULE).Value;
        }
    }
}
