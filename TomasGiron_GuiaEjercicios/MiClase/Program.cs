using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase aux = new OtraClase();
                aux.MetodoInstancia();
            }
            catch (MiException e)
            {
                Exception aux = e;
                do
                {
                    Console.WriteLine(aux.Message);
                    aux = aux.InnerException;
                }
                while (!(aux is null));
            }
            Console.ReadKey();
        }
    }
}
