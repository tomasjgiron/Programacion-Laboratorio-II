using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 27";

            List<int> lista = new List<int>();
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();

            Queue<int> queue = new Queue<int>();//FIFO first in first out
            Queue<int> queuePositivos = new Queue<int>();
            Queue<int> queueNegativos = new Queue<int>();

            Stack<int> stack = new Stack<int>();//LIFO last in first out
            Stack<int> stackPositivos = new Stack<int>();
            Stack<int> stackNegativos = new Stack<int>();

            Random numero = new Random();
            int i;
            for (i = 0; i < 20; i++)
            {
                int aux = numero.Next(-100, 100);
                if (aux != 0)
                {
                    lista.Add(aux);
                    queue.Enqueue(aux);
                    stack.Push(aux);
                    if (aux > 0)
                    {
                        listaPositivos.Add(aux);
                        queuePositivos.Enqueue(aux);
                        stackPositivos.Push(aux);
                    }
                    else
                    {
                        listaNegativos.Add(aux);
                        queueNegativos.Enqueue(aux);
                        stackNegativos.Push(aux);
                    }
                }
                else
                {
                    i--;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nLista negativos ordenados creciente. ");
            foreach (int num in listaNegativos)
            {
                Console.WriteLine(num);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPrimera queue. ");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            queuePositivos.OrderByDescending(q => q);
            //listaPositivos.Reverse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nQueue positivos ordenados decreciente. ");
            foreach (int num in listaPositivos)
            {
                Console.WriteLine(num);
            }

            queueNegativos.OrderBy(q => q);
            //listaNegativos.Sort();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nQueue negativos ordenados creciente. ");
            foreach (int num in listaNegativos)
            {
                Console.WriteLine(num);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPrimer stack. ");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            stackPositivos.OrderBy(s => s);
            //listaPositivos.Sort();
            //listaPositivos.Reverse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nStack positivos ordenados decreciente. ");
            foreach (int num in listaPositivos)
            {
                Console.WriteLine(num);
            }

            stackNegativos.OrderByDescending(s => s);
            //listaNegativos.Sort();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nStack negativos ordenados creciente. ");
            foreach (int num in listaNegativos)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
