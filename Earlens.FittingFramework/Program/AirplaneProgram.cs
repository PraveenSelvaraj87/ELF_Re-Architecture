using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Earlens.DataModel;

namespace Earlens.Framework.Program
{
    public class AirplaneProgram : MainProgram
    {
        public override void SetRecommendedPrescription(Rx prescription)
        {
            base.SetRecommendedPrescription(prescription);
        }

        public override Rx GetRecommendedPrescription()
        {
            return base.GetRecommendedPrescription();
        }
    }
}
