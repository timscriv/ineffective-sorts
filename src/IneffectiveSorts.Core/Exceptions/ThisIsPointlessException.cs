using System;
using System.Collections.Generic;
using System.Text;

namespace IneffectiveSorts.Core.Exceptions
{
    public class ThisIsPointlessException: Exception
    {
        public ThisIsPointlessException() : base()
        {
        }

        public ThisIsPointlessException(string message) : base(message)
        {
        }

        public ThisIsPointlessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
