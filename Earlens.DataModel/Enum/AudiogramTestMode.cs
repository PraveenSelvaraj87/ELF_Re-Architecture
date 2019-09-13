using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public enum AudiogramTestMode
    {
        [Description("Air Conduction")]
        AirConduction = 0,

        [Description("Bone Conduction")]
        BoneConduction = 1,

        [Description("Uncomfortable Level")]
        UncomfortableLevel = 2,     
    }
}
