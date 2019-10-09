using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Vehiculo
    {
        private DateTime ingreso;
        private string patente;

        protected Vehiculo(string patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                if(value.Length == 6)
                {
                    patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("Patente {0}\r\n", this.patente.ToString());
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder cadenaVehiculo = new StringBuilder();
            cadenaVehiculo.AppendFormat(this.ToString());
            cadenaVehiculo.AppendFormat("Fecha de ingreso {0}: ", this.ingreso.ToString("dd/MM HH:mm"));

            return cadenaVehiculo.ToString();
        }

    }
}
