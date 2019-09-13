using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    [Serializable]
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + LastName;
            }
        }
    }
}
