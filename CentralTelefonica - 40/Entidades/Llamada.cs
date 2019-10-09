using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661
    public abstract class Llamada
    {
        #region atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region propiedades
        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }
        #endregion

        #region constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region metodos
        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Duracion: " + this.duracion.ToString());
            cadena.AppendLine("Nro destino: " + this.nroDestino.ToString());
            cadena.AppendLine("Nro origen: " + this.nroOrigen.ToString());
            return cadena.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = -1;

            if(llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if(llamada1.duracion == llamada2.duracion)
            {
                retorno = 0;
            }
            return retorno;
        }
        #endregion

        #region operadores
        public static bool operator ==(Llamada call1, Llamada call2)
        {
            bool retorno = false;
            if(!(call1 is null && call2 is null))
            {
                if(call1.Equals(call2) && call1.nroDestino == call2.nroDestino && call1.nroOrigen == call2.nroOrigen)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Llamada call1, Llamada call2)
        {
            bool retorno = false;
            if(!(call1 == call2))
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region enumeracion
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion
    }
}
