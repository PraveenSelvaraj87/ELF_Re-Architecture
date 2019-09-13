using Earlens.Communication;
using Earlens.DataModel;
using Earlens.PhysicalDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Controller
{
    public class DeviceController : IDeviceController
    {
        /// <summary>
        /// Left Processor
        /// </summary>
        private IProcessor _leftHearinAid;
        /// <summary>
        /// Right Processor
        /// </summary>
        private IProcessor _righttHearinAid;

        public DeviceController(DeviceCommunicationType deviceConnectionType)
        {
            _leftHearinAid = new Processor(Ear.Left, deviceConnectionType);
            _righttHearinAid = new Processor(Ear.Right,deviceConnectionType);
        }     

        public bool SwitchCommunicationMode(DeviceCommunicationType deviceConnectionType)
        {
            bool isCommSwitched = false;
            try
            {
                _leftHearinAid.Disconnect();
                _righttHearinAid.Disconnect();
                _leftHearinAid = new Processor(Ear.Left,deviceConnectionType);
                _righttHearinAid = new Processor(Ear.Right,deviceConnectionType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isCommSwitched = false;
            }
            return isCommSwitched;
        }

        public bool CloseFeedbackMeasurement(Ear ear)
        {
            throw new NotImplementedException();
        }      

        public bool OpenFeedbackMeasurement(Ear ear)
        {
            return _leftHearinAid.OpenFeedbackMeasurement();
        }

        public void ProgramProcessor()
        {
            throw new NotImplementedException();
        }

        public string ReadSerialNumber(Ear ear)
        {
            return (ear == Ear.Left) ? _leftHearinAid.ReadSerialNumber() : _righttHearinAid.ReadSerialNumber();
        }

        public int ReadMDAVersion(Ear ear)
        {
            return (ear == Ear.Left) ? _leftHearinAid.ReadMDAVersion() : _righttHearinAid.ReadMDAVersion();
        }

        public void ReadProcessor()
        {
            throw new NotImplementedException();
        }

        public bool Reset(Ear ear)
        {
            throw new NotImplementedException();
        }

        public bool RunFeedbackMeasurement(Ear ear)
        {
            throw new NotImplementedException();
        }

        public void WriteMDA()
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

        public bool Connect(Ear ear)
        {
            return (ear == Ear.Left) ? _leftHearinAid.Connect() : _righttHearinAid.Connect();
        }

        public bool IsConnected(Ear ear)
        {
            return (ear == Ear.Left) ? _leftHearinAid.IsConnected() : _righttHearinAid.IsConnected();
        }

        public bool DisConnect(Ear ear)
        {
            return (ear == Ear.Left) ? _leftHearinAid.Disconnect() : _righttHearinAid.Disconnect();
        }
    }
}
