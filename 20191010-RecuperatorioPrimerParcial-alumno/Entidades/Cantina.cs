using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0661, CS0660
    public class Cantina
    {
        #region atributos
        private List<Botella> listaBotellas;
        private int espaciosTotales;
        #endregion

        #region constructor
        /// <summary>
        /// Constructor de Cantina que inicializa la lista y los espacios
        /// </summary>
        /// <param name="espacios"></param>
        public Cantina(int espacios)
        {
            this.listaBotellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedad que devuelve la lista de botellas
        /// </summary>
        public List<Botella> Botellas
        {
            get
            {
                return listaBotellas;
            }
        }
        #endregion

        #region operador
        /// <summary>
        /// Agrega una botella a la lista de botellas de la cantina
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false;
            if(!(c is null) && !(b is null))
            {
                if(c.espaciosTotales > c.listaBotellas.Count())
                {
                    c.listaBotellas.Add(b);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ==(Cantina cantina, Botella botella)
        {
            bool retorno = false;
            if (!(cantina is null && botella is null))
            {
                foreach (Botella bottle in cantina.listaBotellas)
                {
                    if (cantina.listaBotellas.Contains(bottle) && bottle == botella)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Cantina cantina, Botella botella)
        {
            return !(cantina == botella);
        }
        #endregion
    }
}
