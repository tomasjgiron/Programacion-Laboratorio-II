using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 26";

            List<int> lista = new List<int>();
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();

            Random numero = new Random();
            int i;
            for(i = 0; i < 20; i++)
            {
                int aux = numero.Next(-100, 100);
                if(aux != 0)
                {
                    lista.Add(aux);
                    if (aux > 0)
                    {
                        listaPositivos.Add(aux);
                    }
                    else
                    {
                        listaNegativos.Add(aux);
                    }
                }
                else
                {
                    i--;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Primera lista. ");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }


            listaPositivos.Sort();
            listaPositivos.Reverse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLista positivos ordenados decreciente. ");
            foreach (int num in listaPositivos)
            {
                Console.WriteLine(num);
            }

            listaNegativos.Sort();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nLista negativos ordenados creciente. ");
            foreach (int num in listaNegativos)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
