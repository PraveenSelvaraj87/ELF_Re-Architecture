using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Algorithm
{
    public interface IFittingAlgorithm
    {
        Rx CalculateRx();

        void CalculateMepo();
             
    }
}
