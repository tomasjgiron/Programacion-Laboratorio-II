using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class UnaException : Exception
    {
        public UnaException(string message, Exception innerException) : base(message, innerException)
        {
 
        }
    }
}
