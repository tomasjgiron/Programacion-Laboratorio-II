using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validacion
    {
        public static bool Validar(int valor,int minimo,int maximo)
        {
            bool validacion = false;

            if (valor >= minimo && valor <= maximo)
            {
                validacion = true;
            }
            return validacion;
        }
    }
}
