
using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Framework
{
    public interface IFittingFramework
    {
        #region session
        FittingSession Session { get; set; }

        bool CreateSession();

        #endregion session

        bool Activate();

        bool Mute();

        bool Program();

        bool Connect(Ear ear);

        bool DisConnect(Ear ear);

        bool IsConnected(Ear ear);

        //bool UpdateFiremware();

        bool SwitchCommunicationType(DeviceCommunicationType connectionType);

        bool LoadFitting();

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

        #region MDA
        string ReadSerialNumber(Ear ear);

        ProcessorType ReadProcessorType(Ear ear);

        #endregion MDA
    }
}
