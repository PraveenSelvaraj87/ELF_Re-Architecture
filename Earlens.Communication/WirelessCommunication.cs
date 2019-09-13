using System;
using System.Collections.Generic;
using Earlens.DataModel;

namespace Earlens.Communication
{
    public class WirelessCommunication : Communication
    {
        /// <summary>
        /// Device scaning and paring Object
        /// </summary>
        private IBLEWrapper _bleWrapper;
        public WirelessCommunication(Ear ear)
        {
            // Configure Adrocom for Wireless Communication
            ComWrapper = new AdrocomWrapper(ear, AdrocomMode.Wireless);          
            _bleWrapper = new BLEWrapper();
        }

        public override List<byte> AcquireMDA()
        {
            throw new NotImplementedException();
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }

        public override bool CloseFeedbackMeasurement()
        {
            throw new NotImplementedException();
        }

        public override bool Connect()
        {
            throw new NotImplementedException();
        }

        public override bool Disconnect()
        {
            throw new NotImplementedException();
        }

        public override bool IsConnected()
        {
            throw new NotImplementedException();
        }

        public override bool OpenFeedbackMeasurement()
        {
            throw new NotImplementedException();
        }

        public override void Program()
        {
            throw new NotImplementedException();
        }

        public override void ReadDevice()
        {
            throw new NotImplementedException();
        }

        public override int ReadMDAVersion()
        {
            throw new NotImplementedException();
        }

        public override string ReadSerialNumber()
        {
            throw new NotImplementedException();
        }

        public override bool Reset()
        {
            throw new NotImplementedException();
        }

        public override bool RunFeedbackMeasurement()
        {
            throw new NotImplementedException();
        }

        public override bool SubmitMDA(List<byte> mdaData)
        {
            throw new NotImplementedException();
        }

        public override bool UpdateDSPFirmware()
        {
            throw new NotImplementedException();
        }

        public override bool UpdateNordicFirmware()
        {
            throw new NotImplementedException();
        }
    }
}
