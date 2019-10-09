using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10b";

            int alto;
            int i;
            int j;
            int respuesta = 0;
            string character = "*";
            int espaciado = 0;
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

            espaciado = alto;
            for (j = 1; j <= alto; j++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                //Console.WriteLine("{0,"+ (espaciado + character.Length) + "}", character);
                //espaciado--;
                Console.WriteLine("{0," + espaciado + "}", character);
                espaciado++;

                character += "**";
            }

            Console.ReadKey();
        }
    }
}
