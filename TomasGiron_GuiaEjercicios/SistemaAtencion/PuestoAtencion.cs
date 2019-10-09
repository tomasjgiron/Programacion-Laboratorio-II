using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SistemaAtencion
{
#pragma warning disable CS0660, CS0661 //desactivar los warning con los codigos 1-getHashCode 2-getEquals (los tres metodos hacen el mismo procesamiento)
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(5000);
            return true;
        }
    }
}
