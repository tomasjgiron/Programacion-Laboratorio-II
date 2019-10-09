using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            Alumno alumno1 = new Alumno("girón", 462872, "tomás");
            Alumno alumno2 = new Alumno("magnaghi", 462871, "susana");
            Alumno alumno3 = new Alumno("girón", 462870, "javier");

            alumno1.Estudiar(8, 5);
            alumno2.Estudiar(3, 8);
            alumno3.Estudiar(6, 10);

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
