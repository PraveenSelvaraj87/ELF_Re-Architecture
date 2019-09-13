using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Earlens.DataModel;

namespace Earlens.Framework
{
    public class MusicProgram : MainProgram
    {
        public override void SetRecommendedPrescription(Rx prescription)
        {

        }
        public override Rx GetRecommendedPrescription()
        {
            return base.GetRecommendedPrescription();
        }
    }
}
