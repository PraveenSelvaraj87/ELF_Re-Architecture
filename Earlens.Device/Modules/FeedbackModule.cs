using Earlens.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice.Modules
{
    public class FeedbackModule : IFeedbackModule
    {
        FeedbackModule(ICommunication comm)
        {

        }

        public bool CloseFeedback()
        {
            throw new NotImplementedException();
        }

        public bool OpenFeedbackSession()
        {
            throw new NotImplementedException();
        }

        public bool RunFeedback()
        {
            throw new NotImplementedException();
        }
    }
}
