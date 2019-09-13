using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    [Serializable]
    public class Site
    {
        public double Id { get; set; }

        public double Name { get; set; }

        public double Address { get; set; }

       

        public Person Audiologist { get; set; }

        public Person ENTDoctor { get; set; }


    }
}
