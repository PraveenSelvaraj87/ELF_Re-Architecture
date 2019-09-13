using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice
{
    public interface ICalibrationModule 
    {
        bool OpenCalibration();

        bool PlayTone();

        bool CloseCalibration();
    }
}
