using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaSolar sistema = new SistemaSolar();
            Planeta planeta = new Planeta(365, 24, "Tierra", 1, ETipo.Gaseoso);
            Planeta planeta1 = new Planeta(500, 76, "Marte", 2, ETipo.Rocoso);
            Satelite sat1 = new Satelite(200, 12, "Luna");
            Satelite sat2 = new Satelite(468, 100, "Titán");

            sistema.Planetas.Add(planeta);

            if(planeta + sat1 && planeta + sat2)
            {
                Console.WriteLine(sistema.MostrarInformacionAstros());
            }
            Console.ReadKey();
            //planeta.Satelites.Add(sat1);
            //planeta.Satelites.Add(sat2);


        }
    }
}
