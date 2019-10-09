using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            String aux;
            int valor;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float promedio;
            float acumulador = 0;
            int respuesta = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un número: ");
                aux = Console.ReadLine();

                if (int.TryParse(aux, out valor))
                {
                    if(Validacion.Validar(valor, -100, 100))
                    {
                        acumulador += valor;

                        if(valor > maximo)
                        {
                            maximo = valor;
                        }
                        if(valor < minimo)
                        {
                            minimo = valor;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("No está dentro del rango. Reingrese: ");
                    }

                    respuesta++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es un número. Reingresar: ");
                }
            } while (respuesta < 10);

            promedio = acumulador / 10;

            Console.WriteLine("El promedio es: {0}, el valor mínimo: {1} y el valor máximo: {2}",
                              promedio, minimo, maximo);
            Console.ReadKey();

        }
    }
}
