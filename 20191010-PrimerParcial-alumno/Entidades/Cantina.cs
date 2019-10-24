using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        #region atributos
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;
        #endregion

        #region constructor
        /// <summary>
        /// Constructor de Cantina que inicializa la lista y los espacios
        /// </summary>
        /// <param name="espacios"></param>
        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
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
                return botellas;
            }
        }
        
        /// <summary>
        /// Patron singleton hace que Cantina sea instanciado una sola vez
        /// en caso de existir modifica el atributo de espaciosTotales
        /// </summary>
        /// <param name="espacios"></param>
        /// <returns></returns>
        public static Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }

            return singleton;
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
                if(c.espaciosTotales > c.botellas.Count())
                {
                    c.botellas.Add(b);
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
