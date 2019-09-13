using Earlens.Communication;
using Earlens.PhysicalDevice.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice.Modules
{
    public class MDAModule : BaseModule, IMDAModule
    {   
        public List<byte> MDAData { get; set; }
        public bool IsMDADataAcquired = false;
        public MDAModule(ICommunication communication)
        {
            _communication = communication;

            MDAData = new List<byte>();
        }

        public override bool Initialize()
        {
            throw new NotImplementedException();
        }

        public override void Acquire()
        {
            MDAData = _communication.AcquireMDA();
            IsMDADataAcquired = true;
        }

        public override void Submit()
        {
            throw new NotImplementedException();
        }

        public int ReadMDAVersion()
        {
            int mdaVersion = -1;            

            if (_communication.IsConnected())
            {
                if (!IsMDADataAcquired)
                    Acquire();

                mdaVersion = MDAData.FirstOrDefault();
            }
            return mdaVersion;
        }

        public string ReadSerialNumber()
        {            
            string serialNumber = string.Empty;

            if (_communication.IsConnected())
            {
                if (!IsMDADataAcquired)
                    Acquire();

                for (int i = MDAAddress.SERIAL_NUMBER; i < 8; i++)
                {
                    serialNumber += (char)MDAData[i];
                }
            }
            return serialNumber;
        }
    }
}
