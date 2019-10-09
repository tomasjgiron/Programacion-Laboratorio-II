using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas = new List<Astro>();

        static SistemaSolar()
        {
        }

        public List<Astro> Planetas
        {
            get
            {
                return planetas;
            }
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder cadenaSistema = new StringBuilder();
            foreach(Planeta p in planetas)
            {
                cadenaSistema.AppendFormat(p.ToString());
                foreach(Satelite s in p.Satelites)
                {
                    cadenaSistema.AppendFormat(s.ToString());
                    cadenaSistema.AppendFormat(s.Orbitar());
                }
            }
            return cadenaSistema.ToString();
        }
    }
}
