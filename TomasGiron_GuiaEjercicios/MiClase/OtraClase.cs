using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class OtraClase
    {
        int numerito = 12;

        public void MetodoInstancia()
        {
            try
            {
                MiClase clasecita = new MiClase(numerito);
            }
            catch(UnaException e)
            {
                throw new MiException("Fallo metodo instancia", e);
            }
        }
    }
}
