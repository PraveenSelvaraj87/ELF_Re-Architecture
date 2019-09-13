using Earlens.DataModel;

namespace Earlens.Controller
{
    public interface IDeviceController
    {
        bool SwitchCommunicationMode(DeviceCommunicationType communicationType);
        bool Connect(Ear ear);

        bool DisConnect(Ear ear);

        bool IsConnected(Ear ear);

        void ProgramProcessor();

        void ReadProcessor();

        string ReadSerialNumber(Ear ear);

        int ReadMDAVersion(Ear ear);

        void WriteMDA();

        #region Feedback
        bool OpenFeedbackMeasurement(Ear ear);

        bool RunFeedbackMeasurement(Ear ear);

        bool CloseFeedbackMeasurement(Ear ear);

        bool Reset(Ear ear);

        #endregion Feedback

        #region calibration
        bool StartCalibration();

        bool CloseCalibration();

        #endregion calibration

        #region wireless
        bool Scan();

        #endregion wireless
    }
}
