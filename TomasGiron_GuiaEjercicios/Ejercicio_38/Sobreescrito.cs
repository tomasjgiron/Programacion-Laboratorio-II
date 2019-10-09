using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Sobreescrito
    {
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }
    }
}
