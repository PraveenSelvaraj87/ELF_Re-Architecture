using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public interface IProgram
    {
        /// <summary>
        /// Apply program specific correction to Cam2 RX
        /// </summary>
        /// <param name="prescription"></param>
        void SetRecommendedPrescription(Rx prescription);

        Rx GetRecommendedPrescription();

        void AdjustGain(int step);

        void AdjustMPO(int step);

    }
}
