using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    public class Employee
    {
        //atributos privadas si las usa la clase Empleado
        /*private float valorHora;
        private string nombre;
        private int antigüedad;
        private float horasTrabajadas;
        */

        //preguntar como usar el backing field a la hora de crear los getter y setter
        //de las propiedades
        public float valorHora;
        public string nombre;
        public int antigüedad;
        public float horasTrabajadas;

        public Employee()
        {
        }

        public Employee(float valorHora, string nombre, int antigüedad, float horasTrabajadas)
        {
            this.ValorHora = valorHora;
            this.nombre = nombre;
            this.antigüedad = antigüedad;
            this.horasTrabajadas = horasTrabajadas;
        }

        public float ValorHora
        {
            get
            {
                return valorHora;
            }
            set
            {
                valorHora = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Antigüedad
        {
            get => antigüedad;
            set => antigüedad = value;
        }

        public float HorasTrabajadas
        {
            get => horasTrabajadas;
            set => horasTrabajadas = value;
        }


        //multiplico la cantidad de horas por el valor de cada hora
        public float CalcularImporte(float valor, float horas)
        {
            return valor * horas;
        }

        //multiplico la antigüedad por el inecentivo dado($150)
        public int CalcularIncentivo(int antigüedad,int incentivo)
        {
            return antigüedad * incentivo;
        }

        //calculo el descuento total que se le hace a cada empleado
        public float CalcularDescuentos(float montoBruto, float porcentaje)
        {
            return (montoBruto * porcentaje) / 100;
        }
    }
}
