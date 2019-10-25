using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        #region atributos
        private Cantina[] cantinas;
        const short limiteCantinas = 2;
        static Edificio singleton;
        int index;
        #endregion

        #region constructores
        /// <summary>
        /// Constructor de edificio inicializa el array de cantinas
        /// </summary>
        private Edificio()
        {
            this.cantinas = new Cantina[limiteCantinas];
        }

        /// <summary>
        /// Constructor de edificio inicializa el singleton
        /// </summary>
        static Edificio()
        {
            singleton = new Edificio();
        }
        #endregion

        #region metodo
        /// <summary>
        /// Metodo que retorna el singleton
        /// </summary>
        /// <returns></returns>
        public Edificio GetBar()
        {
            return singleton;
        }
        #endregion

        #region operadores
        /// <summary>
        /// Operador que busca posicion libre en el array
        /// </summary>
        /// <param name="e"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Edificio e, Cantina c)
        {
            bool retorno = false;
            if (!(e is null) && !(c is null))
            {
                for (int index = 0; index <= limiteCantinas; index++)
                {
                    if(e.cantinas[index] is null)
                    {
                        e.cantinas[index] = c;
                        retorno = true;
                    }
                }    
            }
            return retorno;
        }
        #endregion
    }
}
