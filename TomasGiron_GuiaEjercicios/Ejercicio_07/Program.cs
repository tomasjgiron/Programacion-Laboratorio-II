using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";

            int dia;
            int mes;
            int año;
            int respuesta = 0;
            string aux;
            int bisiesto = 0;
            int i;
            int j;
            int acumuladorDías = 0;
            DateTime nacimiento;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingrese fecha de nacimiento: ");
            Console.Write("Ingrese año: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out año) && año > 0 && año < 2020)
                {
                    respuesta++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es año válido ¡Reingresar!: ");
                }
            } while (respuesta < 1);

            if (año % 4 == 0 && año % 100 != 0)
            {
                bisiesto = 1;
            }
            else if (año % 100 == 0 && año % 400 == 0)
            {
                bisiesto = 1;
            }

            respuesta = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese mes: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out mes) && mes > 0 && mes <= 12)
                {
                    respuesta++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es mes válido ¡Reingresar!: ");
                }
            } while (respuesta < 1);

            respuesta = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese dia: ");

            do
            {
                aux = Console.ReadLine();

                if (int.TryParse(aux, out dia))
                {
                    switch (mes)
                    {
                        case 2:
                            {
                                if (bisiesto == 1 && dia > 0 && dia <= 29) //es bisiesto
                                {
                                    respuesta++;
                                }
                                else if(bisiesto == 0 && dia > 0 && dia <= 28)
                                {
                                    respuesta++;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("No es día válido ¡Reingresar!: ");
                                }
                                break;
                            }
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            {
                                if(dia > 0 && dia <= 30)
                                {
                                    respuesta++;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("No es día válido ¡Reingresar!: ");
                                }
                                break;
                            }
                        default:
                            {
                                if(dia > 0 && dia <= 31)
                                {
                                    respuesta++;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("No es día válido ¡Reingresar!: ");
                                }
                                break;
                            }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("No es dia válido ¡Reingresar!: ");
                }
            } while (respuesta < 1);

            nacimiento = new DateTime(año, mes, dia);

            for (i = nacimiento.Year; i <= DateTime.Now.Year; i++)
            {
                if (i == nacimiento.Year)
                {
                    for (j = nacimiento.Month; j <= 12; j++)
                    {
                        acumuladorDías += DateTime.DaysInMonth(i, j);
                    }
                    acumuladorDías -= nacimiento.Day;
                }

                if (i > nacimiento.Year && i < DateTime.Now.Year)
                {
                    for (j = 1; j <= 12; j++)
                    {
                        acumuladorDías += DateTime.DaysInMonth(i, j);
                    }
                }
                if (i == DateTime.Now.Year)
                {
                    for (j = 1; j < DateTime.Now.Month; j++)
                    {
                        acumuladorDías += DateTime.DaysInMonth(i, j);
                    }
                }

            }
            acumuladorDías += DateTime.Now.Day;

            Console.WriteLine("Cantidad de días vividos desde el {0}/{1}/{2} hasta el {3}/{4}/{5}: {6}",
                            dia, mes, año, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, acumuladorDías);

            Console.ReadKey();  
        }
    }
}
