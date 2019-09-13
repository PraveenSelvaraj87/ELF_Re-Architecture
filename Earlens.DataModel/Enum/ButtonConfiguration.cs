using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public enum ButtonConfiguration
    {
        [Description("Volume and Program")]
        UseBoth,

        [Description("Volume only")]
        UseVolume,

        [Description("Program only")]
        UseProgram,

        [Description("No Program or Volume")]
        UseNeither
    }
}
