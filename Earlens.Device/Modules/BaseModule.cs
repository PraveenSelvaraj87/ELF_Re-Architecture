using Earlens.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice.Modules
{
    public abstract class BaseModule : IModule
    {
        protected ICommunication _communication;
        public abstract void Acquire();
        public abstract bool Initialize();
        public abstract void Submit();
    }
}
