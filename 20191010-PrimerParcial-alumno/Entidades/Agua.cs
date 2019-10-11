using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        #region atributo
        private static int medida = 400;
        #endregion

        #region constructor
        protected Agua(int capacidadML, int contenidoML, string marca) 
            : base(capacidadML, contenidoML, marca)
        {
        }
        #endregion

        #region metodo
        /// <summary>
        /// Método que muestra datos de agua
        /// </summary>
        /// <returns></returns>
        protected new string GenerarInforme()
        {
            StringBuilder cadenaAgua = new StringBuilder();
            cadenaAgua.AppendFormat(base.ToString());
            cadenaAgua.AppendFormat("Medida: {0}\r\n", this,medida.ToString());
            cadenaAgua.AppendLine("-------------------------------");
            return cadenaAgua.ToString();
        }

        public override int ServirMedida()
        {
            int retorno;
            if(medida <= contenidoML)
            {
                retorno = medida;
            }
            else
            {
                retorno = contenidoML;
            }

            return retorno;
        }

        public int ServirMedida(int medida)
        {
            return contenidoML - medida;
        }
        #endregion
    }
}
