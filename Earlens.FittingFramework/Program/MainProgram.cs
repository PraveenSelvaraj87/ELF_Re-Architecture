using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Earlens.Framework
{
    [Serializable]
    public class MainProgram : IProgram
    {
        public string ProgramName;
        public Rx Prescription { get; set; }

        public Rx CurrentPrescription { get; set; }

        public bool IsFeedbackApplied { get; set; }

        public double Max_CR { get; set; }
        List<Feature> Features { get; set; }

        public void AdjustGain(int step)
        {
            throw new NotImplementedException();
        }

        public void AdjustMPO(int step)
        {
            throw new NotImplementedException();
        }

        public virtual Rx GetRecommendedPrescription()
        {
            throw new NotImplementedException();
        }

        public virtual void SetRecommendedPrescription(Rx prescription)
        {
            Prescription = new Rx(prescription);
        }
    }
}
