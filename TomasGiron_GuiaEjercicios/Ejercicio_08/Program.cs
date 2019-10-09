using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 8";

            string respuesta;
            string auxValor;
            string auxHoras;
            string auxAntigüedad;
            string nombre;
            float valorHora;
            float horasTrabajadas;
            int antigüedad;
            float sueldoBruto;
            float sueldoNeto;
            float descuento;
            float totalNeto = 0;

            List<Employee> employeeList = new List<Employee>();

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese nombre de empleado: ");
                nombre = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese antigüedad de empleado: ");
                auxAntigüedad = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese horas trabajadas: ");
                auxHoras = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese valor por hora trabajada: ");
                auxValor = Console.ReadLine();

                if (int.TryParse(auxAntigüedad, out antigüedad) && antigüedad > 0)
                {
                    if (float.TryParse(auxHoras, out horasTrabajadas) && horasTrabajadas > 0)
                    {
                        if (float.TryParse(auxValor, out valorHora) && valorHora > 0)
                        {
                            employeeList.Add(new Employee(valorHora, nombre, antigüedad, horasTrabajadas));
                        }
                        else
                        {
                            Console.WriteLine("ERROR. Reingrese valor por hora");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Reingrese cantidad de horas trabajadas");
                    }

                }
                else
                {
                    Console.WriteLine("ERROR. Reingrese antigüedad");
                }

                Console.Write("Quiere agregar otro empleado? - s/n");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            foreach(var elemento in employeeList)
            {
                sueldoBruto = elemento.CalcularImporte(elemento.horasTrabajadas, elemento.ValorHora);
                sueldoBruto += elemento.CalcularIncentivo(elemento.antigüedad, 150);
                descuento = elemento.CalcularDescuentos(sueldoBruto, 13);
                sueldoNeto = sueldoBruto - descuento;
                totalNeto += sueldoNeto;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nombre: {0}\nAntiguedad: {1}\nValor por hora: {2}\n" +
                                  "Sueldo bruto: ${3}\nSueldo neto: ${4}\nDescuentos totales: ${5}\n" +
                                  "Total neto de empleados: ${6}.",
                                  elemento.nombre, elemento.antigüedad, elemento.ValorHora,
                                  sueldoBruto, sueldoNeto, descuento);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Total neto de empleados: ${0}", totalNeto);
            Console.ReadKey();
        }
    }
}
