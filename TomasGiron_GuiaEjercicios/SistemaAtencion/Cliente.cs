using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtencion
{
#pragma warning disable CS0660, CS0661 //desactivar los warning con los codigos 1-getHashCode 2-getEquals (los tres metodos hacen el mismo procesamiento)
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if (!(c1 is null && c2 is null))
            {
                if (c1.Numero == c2.Numero)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if (!(c1 is null && c2 is null))
            {
                if (!(c1 == c2))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
