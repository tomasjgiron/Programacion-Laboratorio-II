using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            int alto;
            int i;
            int j;
            int respuesta = 0;
            string character = "*";
            string espacio = "";
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

            for (i = 1; i <= alto; i++)
            {
                espacio += " ";
            }
            for(j = 1; j <= alto; j++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("{0}{1}",espacio,character);
                character += "**";

                if(espacio.Length > 0)
                {
                    espacio = espacio.Substring(1);
                }
            }

            Console.ReadKey();
        }
    }
}
