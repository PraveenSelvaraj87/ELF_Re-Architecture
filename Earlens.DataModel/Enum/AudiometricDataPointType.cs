using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public enum AudiometricDataPointType
    {
        [Description("Unmeasured")]
        Unmeasured = 0,

        [Description("Unmasked")]
        Unmasked = 1,

        [Description("Masked")]
        Masked = 2,

        [Description("No Response")]
        NoResponse = 3
    }
}
