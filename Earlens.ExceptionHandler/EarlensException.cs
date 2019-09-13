using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.ExceptionHandler
{
    public class EarlensException : Exception
    {
        public EarlensException()
            : base()
        {
        }
        public EarlensException(string message)
            : base(message)
        {
        }

        public EarlensException(string message, Exception innerException)
           : base(message, innerException)
        {
            // Log here the exception details
        }
    }

    public class ProgramException : EarlensException
    {
        public ProgramException()
            : base()
        {
        }
        public ProgramException(string message)
            : base(message)
        {
        }

        public ProgramException(string message, Exception innerException)
           : base(message, innerException)
        {
        }
    }

    public class ReadException : EarlensException
    {
        public ReadException()
            : base()
        {
        }
        public ReadException(string message)
            : base(message)
        {
        }

        public ReadException(string message, Exception innerException)
           : base(message, innerException)
        {
        }
    }

    public class ConnectException : EarlensException
    {
        public ConnectException()
            : base()
        {
        }
        public ConnectException(string message)
            : base(message)
        {
        }

        public ConnectException(string message, Exception innerException)
           : base(message, innerException)
        {
        }
    }

    public class DisConnectException : EarlensException
    {
        public DisConnectException()
            : base()
        {
        }
        public DisConnectException(string message)
            : base(message)
        {
        }

        public DisConnectException(string message, Exception innerException)
           : base(message, innerException)
        {
        }
    }
}
