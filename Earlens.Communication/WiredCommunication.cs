using Earlens.DataModel;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Earlens.Communication
{
    public class WiredCommunication : Communication
    { 
        public WiredCommunication(Ear ear)
        {
            // Configure Adrocom for Wired Communication
            ComWrapper = new AdrocomWrapper(ear, AdrocomMode.Wired);
        }

        public override void Activate()
        {
            throw new NotImplementedException();
        }
      
        public override bool CloseFeedbackMeasurement()
        {
            // Close Adrocom
            throw new NotImplementedException();
        }

        public override bool Connect()
        {
            return ComWrapper.Connect();
        }

        public override bool Disconnect()
        {
            return ComWrapper.DisConnect(); 
        }

        public override bool IsConnected()
        {
            return ComWrapper.IsConnected();
        }
       
        public override bool OpenFeedbackMeasurement()
        {
            // Close Adrocom
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

        public override List<byte> AcquireMDA()
        {
            return ComWrapper.AcquireMDA();
        }

        public override int ReadMDAVersion()
        {
            //List<byte> byteArray = ComWrapper.ReadMDA(MDAAddress.MDA_VERSION, 1);
            //return byteArray.FirstOrDefault();
            return 0;
        }

        public override string ReadSerialNumber()
        {
            string serialNumber = string.Empty;
            //List<byte> byteArray = ComWrapper.ReadMDA(MDAAddress.SERIAL_NUMBER, 8);
            //foreach(byte b in byteArray)
            //{
            //    serialNumber += (char)b;
            //}
            return serialNumber;
        }

        public override bool Reset()
        {
            // Close Adrocom
            throw new NotImplementedException();
        }
       
        public override bool RunFeedbackMeasurement()
        {
            // Close Adrocom
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
