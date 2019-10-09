using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660, CS0661 //desactivar los warning con los codigos 1-getHashCode 2-getEquals

    public class Peso
     {
        private double cantidad;
        private static double cotizRespectDolar;

        static Peso()
        {
            cotizRespectDolar = 38.33;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
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
            Peso.cotizRespectDolar = cotizacion;
        }

        #region Conversiones
        public static explicit operator Dolar(Peso p)
        {
            return (p.GetCantidad() / Dolar.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (p.GetCantidad() / Euro.GetCotizacion());
        }

        public static implicit operator Peso(double d)
        {
            Peso nuevo = new Peso(d);
            return nuevo;
            //return d; acá estaba devolviendo double y no Pesos
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Peso p, Dolar d)
        {
            bool retorno = false;

            if ((Peso)d == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            bool retorno = false;

            if (d == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            bool retorno = false;

            if ((Peso)e == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            bool retorno = false;

            if (e == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool retorno = false;

            if (p1.GetCantidad() == p2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            bool retorno = false;

            if (!(p1 == p2))
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion

        #region Operaciones
        public static Peso operator +(Peso p, Dolar d)
        {
            Peso retorno = new Peso(p.cantidad + ((Peso)d).cantidad);
            return retorno;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            Peso retorno = new Peso(p.cantidad + ((Peso)e).cantidad);
            return retorno;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            Peso retorno = new Peso(p.cantidad - ((Peso)d).cantidad);
            return retorno;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            Peso retorno = new Peso(p.cantidad - ((Peso)e).cantidad);
            return retorno;
        }
        #endregion
    }
}