using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice.Modules
{
    public interface IMDAModule
    {
    
        int ReadMDAVersion();
        string ReadSerialNumber();
    }
}
