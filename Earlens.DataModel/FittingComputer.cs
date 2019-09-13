using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public class FittingComputer
    {
        public Guid ID { get; }
        public Version WindowsVersion { get; set; }

        public bool Is64BitMachine { get; set; }

        public Version NoahVersion { get; set; }

        public List<Version> DotNetVersions { get; set; }

        public FittingComputer(Guid id)
        {
            ID = id;
        }
    }
}
