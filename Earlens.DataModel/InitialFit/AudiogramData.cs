using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public class AudiogramData : InitialFitData
    {
        public AudiogramTestMode AudiogramTest { get; set; }

        public override bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public bool Has10kData()
        {
            return true;
        }

        public override bool Compare()
        {
            throw new NotImplementedException();
        }

        public override bool CompareAll()
        {
            throw new NotImplementedException();
        }
    }
}
