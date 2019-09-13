using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Controller
{
    public interface ICloudController
    {

        bool UploadLog();

        bool UploadFitting();

        bool IsUpdateAvailable();

        bool ValidateSite();
    }
}
