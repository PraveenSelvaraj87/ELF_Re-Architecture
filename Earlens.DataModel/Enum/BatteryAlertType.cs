using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public enum BatteryAlertType
    {
        [Description("Melody")]
        Melody,

        [Description("Voice")]
        Voice
    }
}
