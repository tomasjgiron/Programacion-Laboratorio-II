using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        #region atributos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region constructores
        /// <summary>
        /// Contructor de botellas que setea marca, contenido y capacidad
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            this.marca = marca;
            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }

        }
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedad de capacidad
        /// </summary>
        public int CapacidadLitros
        {
            get
            {

                return capacidadML / 1000;
            }
        }

        /// <summary>
        /// Propiedad de contenido
        /// </summary>
        public int Contenido
        {
            get
            {
                return contenidoML;
            }
            set
            {
                contenidoML = value;
            }
        }

        /// <summary>
        /// Propiedad de porcentaje de contenido
        /// </summary>
        public float PorcentajeContenido
        {
            get
            {
                return (contenidoML * 100) / capacidadML;
            }

        }
        #endregion

        #region metodo
        /// <summary>
        /// Método que muestra datos de Botella
        /// </summary>
        /// <returns></returns>
        protected virtual string GenerarInforme()
        {
            StringBuilder cadenaBotella = new StringBuilder();
            cadenaBotella.AppendFormat("Capacidad: {0}\r\n", this.capacidadML.ToString());
            cadenaBotella.AppendFormat("Contenido: {0}\r\n", this.contenidoML.ToString());
            cadenaBotella.AppendFormat("Marca: {0}\r\n", this.marca);
            cadenaBotella.AppendLine("-------------------------------");
            return cadenaBotella.ToString();
        }

        /// <summary>
        /// Método abstracto
        /// </summary>
        /// <returns></returns>
        public abstract int ServirMedida();
        #endregion

        #region sobrecarga
        /// <summary>
        /// Sobrecarga método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GenerarInforme().ToString();
        }
        #endregion



        #region enumeracion
        /// <summary>
        /// Enumeración de Tipo
        /// </summary>
        public enum Tipo
        {
            Plastico,
            Vidrio
        }
        #endregion
    }
}
