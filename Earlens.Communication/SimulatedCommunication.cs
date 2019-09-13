using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Earlens.DataModel;

namespace Earlens.Communication
{
    public class SimulatedCommunication : Communication
    {
        public SimulatedCommunication(Ear ear)
        {

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
            _isConnected = true;
            Thread.Sleep(5000);
            return _isConnected;
        }

        public override bool Disconnect()
        {
            _isConnected = false;
            return _isConnected;
        }

        public override bool IsConnected()
        {   
            return _isConnected;
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
