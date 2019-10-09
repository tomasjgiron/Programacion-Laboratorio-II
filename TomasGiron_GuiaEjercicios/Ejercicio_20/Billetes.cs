using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
#pragma warning disable CS0660, CS0661 //desactivar los warning con los codigos 1-getHashCode 2-getEquals (los tres metodos hacen el mismo procesamiento)
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectDolar;

        static Pesos()
        {
            cotizRespectDolar = 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Pesos p)
        {
            return (p.GetCantidad() * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            double retorno = ((Dolar)p).GetCantidad() / Euro.GetCotizacion();
            return new Euro(retorno);
        }

        public static implicit operator Pesos(double d)
        {
            Pesos nuevo = new Pesos(d);
            return nuevo;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;

            if ((Pesos)d == p)
            {
               retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            bool retorno = false;

            if (d == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool retorno = false;

            if ((Pesos)e == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            bool retorno = false;

            if (e == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;

            if (p1.GetCantidad() == p2.GetCantidad())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool retorno = false;

            if (!(p1 == p2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.cantidad + ((Pesos)d).cantidad);
            return retorno;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.cantidad + ((Pesos)e).cantidad);
            return retorno;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.cantidad - ((Pesos)d).cantidad);
            return retorno;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.cantidad - ((Pesos)e).cantidad);
            return retorno;
        }


    }

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

        public Dolar(double cantidad, double cotizacion) : this (cantidad)
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

        public static explicit operator Euro(Dolar d)
        {
                return (d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
                return (d.GetCantidad() / Pesos.GetCotizacion());
        }
        // 

        public static implicit operator Dolar(double d)
        {
            Dolar nuevo = new Dolar(d);
            return nuevo;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            if((Euro)d == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool retorno = true;

            if(d == e)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;

            if ((Pesos)d == p)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            bool retorno = true;

            if(d == p)
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

            if(!(d1 == d2))
            {
                retorno = true;
            }

            return retorno;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return retorno;
        }

    }

    public class Euro
    {
        private double cantidad;
        private static double cotizRespectDolar;

        static Euro()
        {
            cotizRespectDolar = 0.86;
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

        public static explicit operator Dolar(Euro e)
        {
            return (e.GetCantidad() * Dolar.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (e.GetCantidad() * Pesos.GetCotizacion());
        }

        public static implicit operator Euro(double d)
        {
            Euro nuevo = new Euro(d);
            return nuevo;
        }

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

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;

            if ((Euro)p == e)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Euro e, Pesos p)
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

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)p).cantidad);
            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)e).cantidad);
            return retorno;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)p).cantidad);
            return retorno;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.cantidad - ((Euro)d).cantidad);
            return retorno;
        }

    }
}
