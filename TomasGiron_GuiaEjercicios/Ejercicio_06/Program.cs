using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";

            int valor1;
            int valor2;
            int respuesta = 0;
            string aux;
            int i;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese primer año: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor1) && valor1 > 0)
                {
                    respuesta++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es año válido ¡Reingresar!: ");
                }
            } while (respuesta < 1);

            respuesta = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese segundo año: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor2) && valor2 > valor1)
                {
                    respuesta++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es año válido ¡Reingresar!: ");
                }
            } while (respuesta < 1);

            for(i = valor1; i <= valor2; i++)
            {
                if(i % 4 == 0 && i % 100 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("{0} es bisiesto", i);
                }
                else if(i % 100 == 0 && i % 400 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("{0} es bisiesto", i);
                }
            }
            Console.ReadKey();
        }
    }
}
