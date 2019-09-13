using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Algorithm
{
    public class FittingAlgorithm : IFittingAlgorithm
    {
        private bool UseInexperiencedTarget { get; set; } = true;

        private double MaxCR { get; set; }

        private double MaxGain { get; set; } = 60;

        public virtual void CalculateMepo()
        {
            throw new NotImplementedException();
        }

        public virtual Rx CalculateRx()
        {
            throw new NotImplementedException();
        }       
    }
}
