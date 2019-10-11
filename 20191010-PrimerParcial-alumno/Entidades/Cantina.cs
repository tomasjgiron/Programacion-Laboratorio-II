using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public List<Botella> Botella
        {
            get
            {
                return botellas;
            }
        }
        
        public static Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                singleton = new Cantina(espacios);
                return singleton;
            }
            else
            {
                espacios--;
                return singleton;
            }
        }

        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false;
            if(!(c is null) && !(b is null))
            {
                if(c.espaciosTotales < c.botellas.Count())
                {
                    c.botellas.Add(b);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
