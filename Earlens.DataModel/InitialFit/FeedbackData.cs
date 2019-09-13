using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    [Serializable]
    public class FeedbackData
    {
        List<double> TestSignal { get; set; }

        List<double> MaxStableGainOn { get; set; }

        List<double> MaxStableGainOff { get; set; }
    }
}
