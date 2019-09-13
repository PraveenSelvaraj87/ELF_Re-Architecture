using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Framework
{
    [Serializable]
    public abstract class ProcessorData : IProcessorData
    {
        public ProcessorType SystemType { get; set; }

        public ProcessorGeneration ProcessorGen { get; set; }

        public Version NordicFirmwareVersion { get; }

        public Version DSPFirmwareVersion { get; }

        public FittingData FitingData { get; set; }

        public DeviceConfigSetting DeviceConfigSettings { get; set; }

        //Processor Modules
        List<ProcessorModule> ProcessorModules { get; set; }
    }
}
