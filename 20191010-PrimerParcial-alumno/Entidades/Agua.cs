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
        /// <summary>
        /// Constructor de agua que usa atributos de la clase padre
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
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
        protected override string GenerarInforme()
        {
            StringBuilder cadenaAgua = new StringBuilder();
            cadenaAgua.AppendFormat(base.GenerarInforme());
            cadenaAgua.AppendFormat("Medida: {0}\r\n", MEDIDA);
            cadenaAgua.AppendLine("-------------------------------");
            return cadenaAgua.ToString();
        }

        /// <summary>
        /// Reutiliza el metodo ServirMedida de agua
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// Implementa el metodo ServirMedida de la clase base
        /// </summary>
        /// <param name="medida"></param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {
            int retorno;
            if (medida <= this.Contenido)
            {
                retorno = medida;
            }
            else
            {
                retorno = this.Contenido;
            }

            this.Contenido -= retorno;

            return retorno;
        }
        #endregion
    }
}
