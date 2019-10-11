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
        private const int MEDIDA = 400;
        #endregion

        #region constructor
        public Agua(int capacidadML, int contenidoML, string marca) 
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
            cadenaAgua.AppendFormat("Medida: {0}\r\n", MEDIDA.ToString());
            cadenaAgua.AppendLine("-------------------------------");
            return cadenaAgua.ToString();
        }

        public override int ServirMedida()//preguntar
        {
            int retorno;
            if(MEDIDA <= this.Contenido)
            {
                retorno = MEDIDA;
            }
            else
            {
                retorno = this.Contenido;
            }

            this.Contenido -= retorno;

            return retorno;
        }

        public int ServirMedida(int medida)
        {
            return this.Contenido -= medida;
        }
        #endregion
    }
}
