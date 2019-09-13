using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Communication
{
    public class BLEWrapper : IBLEWrapper
    {
        public List<byte> AcquireMDA()
        {
            throw new NotImplementedException();
        }

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public bool DisConnect()
        {
            throw new NotImplementedException();
        }

        public bool IsConnected()
        {
            throw new NotImplementedException();
        }

        public List<byte> ReadMDA(int startAddress,int byteCount)
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }      

        public bool UpdateDSPFirmware()
        {
            throw new NotImplementedException();
        }

       public bool UpdateNordicFirmware()
        {
            throw new NotImplementedException();
        }
    }
}
