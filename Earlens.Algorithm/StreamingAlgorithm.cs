using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Algorithm
{
    public class StreamingAlgorithm : FittingAlgorithm
    {
        public override Rx CalculateRx()
        {
            return new Rx();
        }
    }
}
