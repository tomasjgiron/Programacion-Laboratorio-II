using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }
        public double Precio
        {
            get
            {
               return precio;
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }

        public override string ToString()
        {
            StringBuilder cadenaProducto = new StringBuilder();
            
            cadenaProducto.AppendFormat("CODIGO : {0}\r\n", (Guid)this);
            cadenaProducto.AppendFormat("DESCRIPCION : {0}\r\n", this.descripcion);
            cadenaProducto.AppendFormat("PRECIO : {0}\r\n", this.precio);
            cadenaProducto.AppendFormat("STIOCK : {0}\r\n", this.stock);
            cadenaProducto.AppendLine("");
            cadenaProducto.AppendLine("---------------------");

            return cadenaProducto.ToString();
        }
    }
}
