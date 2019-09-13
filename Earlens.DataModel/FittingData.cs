using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    [Serializable]
    public class FittingData
    {
        public Rx RecommendedPrescription { get; set; }

       // public Audiogram AudiogramData { get; set; }

        public Calibration CalibrationData { get; set; }

        public FeedbackData Feedback { get; set; }

       public List<IProgram> Programs { get; set; }

        public void SetRecommendedPresciption(Rx rxPrescription)
        {
            foreach(IProgram prg in Programs )
            {
                prg.SetRecommendedPrescription(rxPrescription);
            }
        }      
    }   
    
}

