using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class MiException : Exception
    {
        public MiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
