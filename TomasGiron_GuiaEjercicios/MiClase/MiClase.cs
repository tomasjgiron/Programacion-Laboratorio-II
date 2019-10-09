using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class MiClase
    {
        static void MetodoEstatico()
        {
            throw new DivideByZeroException("Fallo metodo estatico");
        }

        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("Fallo primer constructor");
            }
        }

        public MiClase(int numero)
        {
            try
            {
                MiClase clasecita = new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("NANA NANA NANA NANA LIDER", e);
            }
        }
    }
}
