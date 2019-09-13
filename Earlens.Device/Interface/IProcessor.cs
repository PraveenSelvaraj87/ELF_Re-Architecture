using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice
{
    public interface IProcessor
    {
        string ReadSerialNumber();

        int ReadMDAVersion();

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
        bool SwitchCommInterface(Ear ear, DeviceCommunicationType deviceConnectionType);

        #endregion Feedback
    }
}
