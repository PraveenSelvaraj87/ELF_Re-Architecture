using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Framework.Interface
{
    public interface IFittingSession
    {
        bool SetSessionType(ProcessorType? leftProcessorType, ProcessorType? rightProcessorType);
        bool CalculateRx();
    }
}
