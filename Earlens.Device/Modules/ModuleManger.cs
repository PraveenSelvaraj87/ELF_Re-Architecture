using Earlens.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice
{
    public class ModuleManger
    {
        List<IModule> Modules = new List<IModule>();
        private ICommunication _communicator;


        public ModuleManger(ICommunication communicator)
        {
            Modules = new List<IModule>();
            foreach(IModule mod in Modules)
            {
                mod.Initialize();
            }

            _communicator = communicator;
        }

        public string ReadMDA(IModule module)
        {
            return string.Empty;
        }
    }
}
