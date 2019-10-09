using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660, CS0661 //desactivar los warning con los codigos 1-getHashCode 2-getEquals (los tres metodos hacen el mismo procesamiento)

    public class Euro
    {
        private double cantidad;
        private static double cotizRespectDolar;

        static Euro()
        {
            cotizRespectDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectDolar;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectDolar = cotizacion;
        }

        #region Conversiones
        public static explicit operator Dolar(Euro p)
        {
            return (p.GetCantidad() * Dolar.GetCotizacion());
        }

        public static explicit operator Peso(Euro p)
        {
            return (p.GetCantidad() * Peso.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            Euro nuevo = new Euro(d);
            return nuevo;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;

            if ((Euro)d == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool retorno = false;

            if (d == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            bool retorno = false;

            if ((Euro)p == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            bool retorno = false;

            if (p == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (e1.GetCantidad() == e2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (!(e1 == e2))
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion

        #region Operaciones
        public static Euro operator +(Euro e, Peso p)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)p).cantidad);
            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)e).cantidad);
            return retorno;
        }

        public static Euro operator -(Euro e, Peso p)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)p).cantidad);
            return retorno;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)d).cantidad);
            return retorno;
        }
        #endregion
    }
}
