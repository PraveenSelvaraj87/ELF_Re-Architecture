using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Communication
{
    public interface IComWrapper
    {
        bool Connect();

        bool IsConnected();

        bool DisConnect();

        /// <summary>
        /// Return MDA byte data from start address
        /// </summary>
        /// <param name="startAddress"></param>
        /// <param name="byteCount"></param>
        /// <returns></returns>
        List<byte> ReadMDA(int startAddress,int byteCount);

        List<byte> AcquireMDA();
    }
}
