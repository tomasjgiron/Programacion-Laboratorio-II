using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        #region atributo
        private static int medida = 330;
        private Tipo tipo;
        #endregion

        #region constructor
        /// <summary>
        /// Constructor de Cerveza que usa atributos heredados
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
        public Cerveza(int capacidadML, int contenidoML, string marca) 
            : base(capacidadML, contenidoML, marca)
        {
            this.tipo = Tipo.Vidrio;
        }

        /// <summary>
        /// constructor de cerveza que setea tipo que por defecto es de vidrio
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        public Cerveza(int capacidadML, int contenidoML, string marca, Tipo tipo)
            : this(capacidadML, contenidoML, marca)
        {
            this.tipo = tipo;
        }
        #endregion

        #region metodo
        /// <summary>
        /// Método que muestra datos de cerveza
        /// </summary>
        /// <returns></returns>
        protected new string GenerarInforme()
        {
            StringBuilder cadenaCerveza = new StringBuilder();
            cadenaCerveza.AppendFormat(base.ToString());
            cadenaCerveza.AppendFormat("Medida: {0}\r\n", this, medida.ToString());
            cadenaCerveza.AppendFormat("Tipo: {0}\r\n", this.tipo.ToString());
            cadenaCerveza.AppendLine("-------------------------------");
            return cadenaCerveza.ToString();
        }

        /// <summary>
        /// metodo servir medida
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            int retorno;
            if (medida <= contenidoML)
            {
                retorno = (medida * 80) / 100;
            }
            else
            {
                retorno = contenidoML;
            }

            return retorno;
        }
        #endregion

        #region operador
        /// <summary>
        /// conversos implicito del tipo de cerveza
        /// </summary>
        /// <param name="cerveza"></param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        #endregion
    }
}
