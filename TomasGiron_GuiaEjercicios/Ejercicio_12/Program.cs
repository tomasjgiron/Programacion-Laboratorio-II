using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            string aux;
            string auxChar;
            int valor;
            int acumulador = 0;
            char continuar;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ingrese un número: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor))
                {
                    acumulador += valor;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es un número. Reingresar: ");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Desea continuar? S/N: ");
                auxChar = Console.ReadLine();
                if (char.TryParse(auxChar, out continuar))
                {
                    continue;
                }
            } while (ValidarRespuesta.ValidarS_N(continuar));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("La suma de todos los números es: {0}", acumulador);
            Console.ReadKey();
        }
    }
}
