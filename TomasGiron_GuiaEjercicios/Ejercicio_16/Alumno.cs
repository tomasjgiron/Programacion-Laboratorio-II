using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }

        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random valor = new Random();

            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = valor.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string retorno = string.Format("Nombre: {0}, Apellido: {1}, Legajo: {2}, Nota final: ",this.nombre,this.apellido,this.legajo);

            CalcularFinal();
            if(this.notaFinal != -1)
            {
                retorno += this.notaFinal.ToString();
            }
            else
            {
                retorno += "Alumno desaprobado";
            }
            return retorno;
        }

    }
}
