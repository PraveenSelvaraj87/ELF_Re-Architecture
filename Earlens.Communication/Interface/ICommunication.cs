using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Communication
{
    public interface ICommunication
    {
        #region MDA Module

        List<byte> AcquireMDA();

        bool SubmitMDA(List<byte> mdaData);

        string ReadSerialNumber();

        int ReadMDAVersion();

        #endregion

        bool Connect();

        bool Disconnect();

        bool IsConnected();

        void Program();

        void ReadDevice();

        void Activate();

        #region Feedback
        bool OpenFeedbackMeasurement();

        bool RunFeedbackMeasurement();

        bool CloseFeedbackMeasurement();

        bool Reset();

        bool UpdateNordicFirmware();

        bool UpdateDSPFirmware();

        #endregion Feedback
    }
}
