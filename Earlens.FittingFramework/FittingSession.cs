using Earlens.Algorithm;
using Earlens.DataModel;
using Earlens.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Framework
{
    [Serializable]
    public class FittingSession : IFittingSession
    {
        public FittingSession(ProcessorType? leftprocessorType, ProcessorType? rightprocessorType)
        {
            SetSessionType(leftprocessorType, rightprocessorType);
        }

        #region Properties
        public bool IsSessionDirty { get; set; } = false;

        public SessionType SessionTyp { get; set; }

        public Ear ear { get; set; }

        public string SessionFilePath { get; set; }

        public DateTime SessionDate { get; set; }

        public string SessionNotes { get; set; }

        public ELFInfo SoftwareDetails { get; set; }

        public Site SiteDetails { get; set; }

        public Person PatientDetails { get; set; }

        public IProcessorData RightHI {get;set;}

        public IProcessorData LeftHI { get; set; }

        private IFittingAlgorithm _fittingAlgorithm { get; set; }

        #endregion Properties

        #region Public Methods

        public bool CalculateRx()
        {
            //_fittingAlgorithm.CalculateRx();
            return true;
        }

        public bool SetSessionType(ProcessorType? leftprocessorType, ProcessorType? rightprocessorType)
        {
            if (leftprocessorType.HasValue && rightprocessorType.HasValue)
            {
                SessionTyp = SessionType.Binaural;
                ear = Ear.Both;
                LeftHI = (leftprocessorType == ProcessorType.Photonic) ? new PhotonicProcessorData() as IProcessorData : new InductiveProcessorData() as IProcessorData;
                RightHI = (rightprocessorType == ProcessorType.Photonic) ? new PhotonicProcessorData() as IProcessorData : new InductiveProcessorData() as IProcessorData;
            }
            else
            {

                SessionTyp = SessionType.Monoural;
                if (leftprocessorType.HasValue)
                {
                    ear = Ear.Left;
                    LeftHI = (leftprocessorType == ProcessorType.Photonic) ? new PhotonicProcessorData() as IProcessorData : new InductiveProcessorData() as IProcessorData;
                    RightHI = null;
                }
                else
                {
                    ear = Ear.Right;
                    LeftHI = null;
                    RightHI = (rightprocessorType == ProcessorType.Photonic) ? new PhotonicProcessorData() as IProcessorData : new InductiveProcessorData() as IProcessorData;
                }
            }

            return true;
        }

        #endregion Public Methods

        #region Private Methods

       

        #endregion
    }
}
