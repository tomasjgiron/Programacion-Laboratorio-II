using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return (precioUnidad * cantidad) * porcentajeIva / 100;
        }

        public string ObtenerDescripcionBreve()
        {
            return string.Format("Fecha {0} -- descripcion {1} -- precioFinal {2:#.##}", this.Fecha, producto.Descripcion, this.precioFinal);
        }

        public void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio,cantidad);
        }

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        public static int OrdenarPorFecha(Venta v1, Venta v2)
        {
            int retorno = 0;

            if(v1.Fecha < v2.Fecha)
            {
                retorno = 1;
            }
            else if(v1.Fecha > v2.Fecha)
            {
                retorno = -1;
            }

            return retorno;
        }
    }
}
