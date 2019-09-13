using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    [Serializable]
    public class Rx
    {
        public Rx()
        {

        }

        public Rx(Rx prescription)
        {

        }
        public List<double> Igct { get; set; }
        public List<double> CT { get; set; }
        public List<double> CR { get; set; }
        public List<double> Mepo { get; set; }
        public List<double> Mpo { get; set; }
    }
}
