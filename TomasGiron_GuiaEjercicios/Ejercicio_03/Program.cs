using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";

            int num;
            string aux;
            int i = 0;
            int j;

            Console.Write("Ingrese un número: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out num) && num > 1) // mayor a 1 porque los primos son a partir del 2
                {
                    i++;
                }
                else
                {
                    Console.Write("ERROR ¡Reingrese número!: ");
                }

            } while (i < 1);

            for (i = 2; i <= num; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }

                if (i == j) // se completó el loop que evaluaba %
                {
                    Console.WriteLine("{0} es primo", i);
                }
            }

            Console.ReadKey();
        }
    }
}
