using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
#pragma warning disable CS0660,CS0661
    public class Comiqueria
    {
        private List<Producto> listaProductos;
        private List<Venta> listaVentas;

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto prod in listaProductos)
                {
                    if (((Guid)prod).Equals(codigo))
                    {
                        return prod;
                    }
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.listaProductos = new List<Producto>();
            this.listaVentas = new List<Venta>();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> cadenaDiccionario = new Dictionary<Guid, string>();
            foreach(Producto prod in listaProductos)
            {
                cadenaDiccionario.Add((Guid)prod, prod.Descripcion);
            }
            return cadenaDiccionario;
        }

        public string ListarVentas()
        {
            this.OrdenarVentas();
            StringBuilder cadenaVentas = new StringBuilder();

            foreach(Venta sale in listaVentas)
            {
                cadenaVentas.AppendLine(sale.ObtenerDescripcionBreve());
            }
            return cadenaVentas.ToString();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = false;
            if (!(comiqueria is null) && !(producto is null))
            {
                foreach (Producto prod in comiqueria.listaProductos)
                {
                    if (prod.Descripcion.Equals(producto.Descripcion))
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = true;
            if (!(comiqueria is null) && !(producto is null))
            {
                if (comiqueria == producto)
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (!(comiqueria is null) && !(producto is null))
            {
                if (comiqueria != producto)
                {
                    comiqueria.listaProductos.Add(producto);
                }
            }
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            listaVentas.Add(venta);
        }

        public void OrdenarVentas()
        {
            this.listaVentas.Sort(Venta.OrdenarPorFecha);
        }
    }
}
