using Earlens.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice.Modules
{
    public class CalibrationModule : ICalibrationModule
    {
        public CalibrationModule(ICommunication comm)
        {

        }

        public bool CloseCalibration()
        {
            throw new NotImplementedException();
        }

        public bool OpenCalibration()
        {
            throw new NotImplementedException();
        }

        public bool PlayTone()
        {
            throw new NotImplementedException();
        }
    }
}
