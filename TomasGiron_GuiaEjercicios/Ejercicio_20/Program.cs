using System;
using Billetes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";

            Dolar d = new Dolar(1);
            Pesos p = new Pesos(1);
            Euro e = new Euro(1);

            Pesos resPeso = p + d;
            Dolar resDolar = d + p;
            Euro resEuro = e + p;

            Console.WriteLine("Resultado dolar {0}",resDolar.GetCantidad());
            Console.WriteLine("Resultado euro {0}", resEuro.GetCantidad());
            Console.WriteLine("Resultado peso {0}", resPeso.GetCantidad());

            Console.ReadKey();

        }
    }
}
