using System.Collections.Generic;
using Earlens.DataModel;


namespace Earlens.Communication
{
    public abstract class Communication : ICommunication
    {
        public Communication()
        {           
        }

        protected IComWrapper ComWrapper;     

        protected bool _isConnected;        
        public abstract void Activate();
        public abstract bool CloseFeedbackMeasurement();      
        public abstract bool Connect();       
        public abstract bool Disconnect();       
        public abstract bool IsConnected();
        public abstract bool OpenFeedbackMeasurement();
        public abstract void Program();
        public abstract void ReadDevice();        
        public abstract bool Reset();
        public abstract bool RunFeedbackMeasurement();
        public abstract bool UpdateDSPFirmware();
        public abstract bool UpdateNordicFirmware();
        public abstract string ReadSerialNumber();       
        public abstract int ReadMDAVersion();
        public abstract List<byte> AcquireMDA();
        public abstract bool SubmitMDA(List<byte> mdaData);
    }
}
