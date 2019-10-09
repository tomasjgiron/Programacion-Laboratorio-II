using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
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
        public string Mostrar()
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

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
