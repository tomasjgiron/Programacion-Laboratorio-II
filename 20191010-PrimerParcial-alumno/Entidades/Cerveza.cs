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
        private const int MEDIDA = 330;
        private Tipo tipo;
        #endregion

        #region constructor
        /// <summary>
        /// constructor de cerveza que setea tipo que por defecto es de vidrio
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
        public Cerveza(int capacidadML, int contenidoML, string marca) 
            : this(capacidadML, contenidoML, marca, Tipo.Vidrio)
        {
        }

        /// <summary>
        /// Constructor de Cerveza que usa atributos heredados y setea tipo
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        public Cerveza(int capacidadML, int contenidoML, string marca, Tipo tipo)
            : base(capacidadML, contenidoML, marca)
        {
            this.tipo = tipo;
        }
        #endregion

        #region metodo
        /// <summary>
        /// Método que muestra datos de cerveza
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            StringBuilder cadenaCerveza = new StringBuilder();
            cadenaCerveza.AppendFormat(base.GenerarInforme());
            cadenaCerveza.AppendFormat("Medida: {0}\r\n", MEDIDA.ToString());
            cadenaCerveza.AppendFormat("Tipo: {0}\r\n", this.tipo);
            cadenaCerveza.AppendLine("-------------------------------");
            return cadenaCerveza.ToString();
        }

        /// <summary>
        /// Implementa el metodo ServirMedida de la clase base
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            int retorno;
            if (MEDIDA <= this.Contenido)
            {
                retorno = (MEDIDA * 80) / 100;
            }
            else
            {
                retorno = this.Contenido;
            }

            this.Contenido -= retorno;

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
