using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        #region atributos
        protected Franja franjaHoraria;
        #endregion

        #region enumerados
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion

        #region propiedades
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region metodos
        private float CalcularCosto()
        {
            double costo;
            if(this.franjaHoraria == Franja.Franja_1)
            {
                costo = base.duracion * 0.99; // 0.99f == casteo (float)
            }
            else if(this.franjaHoraria == Franja.Franja_2)
            {
                costo = base.duracion * 1.25;
            }
            else
            {
                costo = base.duracion * 0.66;//Franja_3
            }
            return Convert.ToSingle(costo);
        }

        public new string Mostrar()
        {
            StringBuilder cadenaProvincial = new StringBuilder();
            string auxLlamada;
            auxLlamada = base.Mostrar();
            cadenaProvincial.AppendLine("Costo llamada: " + this.CostoLlamada.ToString());
            cadenaProvincial.AppendLine("Franja horaria: " + this.franjaHoraria.ToString());
            return auxLlamada + cadenaProvincial;
        }
        #endregion

        #region constructores
        public Provincial(Franja miFranja, Llamada llamada) 
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : this(miFranja, new Llamada(duracion, destino, origen))
        {
        }
        #endregion

    }
}
