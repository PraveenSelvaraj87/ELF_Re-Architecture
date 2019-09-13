using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    [Serializable]
    public class ELFInfo
    {
        public DateTime InstallDate { get; set; }

        public Version SoftwareVersion { get; set; }

        public Version PreviousSoftwareVersion { get; set; }
    }
}
