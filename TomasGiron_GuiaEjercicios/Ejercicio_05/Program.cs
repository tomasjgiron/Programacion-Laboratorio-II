using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";

            int valor;
            int respuesta = 0;
            string aux;
            int centro;
            int j;
            int acumuladorDerecha;
            int acumuladorIzquierda;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese un número: ");
            aux = Console.ReadLine();

            do
            {
                if (int.TryParse(aux, out valor) && valor > 0)
                {
                    respuesta++;
                    for (centro = 2; centro <= valor; centro++)//la i arranca en 2 porque el centro tiene que tener numeros a la izquierda y a la derecha
                    {
                        acumuladorIzquierda = 0;
                        for (j = 1; j < centro; j++)//sumo a izquierda
                        {
                            acumuladorIzquierda += j;
                        }
                        acumuladorDerecha = 0;
                        for (j = centro + 1; j <= valor; j++)//sumo a derecha
                        {
                            acumuladorDerecha += j;
                            if (acumuladorIzquierda == acumuladorDerecha) // si son iguales: i es el centro numérico
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0} es el centro numerico", centro);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es número ¡Reingresar!: ");
                    Console.ReadLine();
                }
            } while (respuesta == 0);
            Console.ReadKey();
        }
    }
}
