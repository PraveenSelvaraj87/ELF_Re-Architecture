using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Communication
{
    public interface IAdrocomWrapper : IComWrapper
    {
        void ConfigureAdrocom();
    }
}
