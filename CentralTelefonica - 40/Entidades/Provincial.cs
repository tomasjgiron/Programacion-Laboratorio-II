using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0659
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
        public override float CostoLlamada
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

        protected new string Mostrar()
        {
            StringBuilder cadenaProvincial = new StringBuilder();
            string auxLlamada;
            auxLlamada = base.Mostrar();
            cadenaProvincial.AppendLine("Costo llamada: " + this.CostoLlamada.ToString());
            cadenaProvincial.AppendLine("Franja horaria: " + this.franjaHoraria.ToString());
            return auxLlamada + cadenaProvincial;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(!(obj is null))
            {
                if(obj is Provincial)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base(duracion, destino, origen)//cambio this por base cuando la clase madre es abstracta y porque
            //no puedo instanciar a la clase madre con el new
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
           : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }
        #endregion

    }
}
