using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private ETipo tipo;

        private List<Astro> satelites;

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre) 
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            this.satelites = new List<Astro>();
        }

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantSatelites, ETipo tipo)
            : this(duracionOrbita, duracionRotacion, nombre)
        {
            this.tipo = tipo;
            this.cantSatelites = cantSatelites;
        }

        public List<Astro> Satelites
        {
            get
            {
                return satelites;
            }
        }

        public override string Orbitar()
        {
            return string.Format("Orbita el planeta: {0}\r\n", this.nombre);
        }

        public new string Rotar()
        {
            return string.Format("Orbita el planeta: {0}\r\n", this.nombre);
        }

        public override string ToString()
        {
            StringBuilder cadenaPlaneta = new StringBuilder();
            cadenaPlaneta.AppendFormat(base.Mostrar());
            cadenaPlaneta.AppendFormat(Orbitar());//consultar
            cadenaPlaneta.AppendFormat(Rotar()); ;//consultar
            cadenaPlaneta.AppendFormat("Cantidad de satelites: {0}\r\n", this.cantSatelites);
            cadenaPlaneta.AppendFormat("Tipo: {0}\r\n", this.tipo);
           
            return cadenaPlaneta.ToString();
        }

        public static bool operator ==(Planeta p1, Planeta p2)
        {
            bool retorno = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if((string)p1 == (string)p2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Planeta p1, Satelite s1)
        {
            bool retorno = false;
            if (!(p1 is null) && !(s1 is null))
            {
                foreach(Satelite sat in p1.satelites)
                {
                    if(sat.Nombre == s1.Nombre)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Planeta p1, Satelite s1)
        {
            return !(p1 == s1);
        }

        public static bool operator +(Planeta planeta, Astro astro)
        {
            bool retorno = false;
            if (!(planeta is null) && !(astro is null))
            {
                if(astro is Satelite)
                {
                    planeta.satelites.Add(astro);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
