using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            int i = 1; // arranca en 1 porque los números perfectos son positivos
            int j;
            int contador = 0;
            int acumulador = 0;

            while (contador < 4)
            {
                if (i % j == 0)
                {
                    acumulador += j;
                }

                if (i == acumulador) // si el acumulador es igual a i entonces es un número perfecto
                {
                    Console.WriteLine("{0} es número perfecto", i); 

                    contador++; // cuenta 1 cada vez que encuentra un número perfecto
                }

                acumulador = 0;

                i++;
            }

            Console.ReadKey();
        }
    }
}
