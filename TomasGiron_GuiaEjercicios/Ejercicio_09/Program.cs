using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 9";

            int alto;
            int i;
            int respuesta = 0;
            string character = "*";
            string aux;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese altura de la pirámide: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out alto) && alto > 0)
                {
                    respuesta++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es una altura válida ¡Reingresar!: ");
                }
            } while (respuesta < 1);

            for(i = 1; i <= alto; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(character);
                character += "**";
            }
            Console.ReadKey();
        }
    }
}
