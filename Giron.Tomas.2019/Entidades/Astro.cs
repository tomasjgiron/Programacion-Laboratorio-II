using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        protected Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            StringBuilder cadenaAstro = new StringBuilder();
            cadenaAstro.AppendFormat("Nombre: {0}\r\n", this.nombre);
            cadenaAstro.AppendFormat("Duracion orbita: {0}\r\n", this.duracionOrbita);
            cadenaAstro.AppendFormat("Duracion rotacion: {0}\r\n", this.duracionRotacion);
            cadenaAstro.AppendLine("--------------------------------");

            return cadenaAstro.ToString();
        }

        public abstract string Orbitar();

        public string Rotar()
        {
            return string.Format("Rotando. Tiempo estimado: {0}\r\n", this.duracionRotacion);
        }

        public static explicit operator string(Astro astro)
        {
            return astro.nombre;
        }
    }
}
