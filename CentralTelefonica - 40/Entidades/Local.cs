using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0659
    public class Local : Llamada
    {
        #region atributos
        protected float costo;
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

        #region constructores
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)//cuando no es abstracta la clase padre arriba
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        #endregion

        #region metodos
        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        protected new string Mostrar()
        {
            StringBuilder cadenaLocal = new StringBuilder();
            string auxLlamada;
            auxLlamada = base.Mostrar();
            cadenaLocal.AppendLine("Costo llamada: " + this.CostoLlamada.ToString());
            return auxLlamada + cadenaLocal;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null))
            {
                if (obj is Local)
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
    }
}
