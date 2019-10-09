using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660, CS0661 //desactivar los warning con los codigos 1-getHashCode 2-getEquals (los tres metodos hacen el mismo procesamiento)

    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectDolar;

        static Dolar()
        {
            cotizRespectDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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
            Dolar.cotizRespectDolar = cotizacion;
        }

        #region Conversiones
        public static explicit operator Euro(Dolar d)
        {
            return (d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return (d.GetCantidad() * Peso.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            Dolar nuevo = new Dolar(d);
            return nuevo;
            // return d; acá devolvía double y no Dolar
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            if ((Euro)d == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool retorno = true;

            if (d == e)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            bool retorno = false;

            if ((Peso)d == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            bool retorno = true;

            if (d == p)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1.GetCantidad() == d2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (!(d1 == d2))
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion

        #region Operaciones
        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return retorno;
        }
        #endregion
    }
}
