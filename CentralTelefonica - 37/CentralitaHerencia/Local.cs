using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        #region atributos
        protected float costo;
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

        #region constructores
        public Local(Llamada llamada, float costo) 
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) 
            : this(new Llamada(duracion, destino, origen), costo)
        {
        }
        #endregion

        #region metodos
        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        public new string Mostrar()
        {
            StringBuilder cadenaLocal = new StringBuilder();
            string auxLlamada;
            auxLlamada = base.Mostrar();
            cadenaLocal.AppendLine("Costo llamada: " + this.CostoLlamada.ToString());
            return auxLlamada + cadenaLocal;
        }
        #endregion
    }
}
