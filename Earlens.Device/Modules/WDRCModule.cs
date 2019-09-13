using Earlens.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice.Modules
{
    public class WDRCModule : BaseModule,IWDRCModule
    {
        public WDRCModule(ICommunication comm)
        {
            _communication = comm;
        }

        public override void Acquire()
        {
            throw new NotImplementedException();
        }

        public override bool Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
