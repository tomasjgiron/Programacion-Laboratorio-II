using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;

        public Figura(string descripcion, int stock, double precio, double altura)
            : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }

        public Figura(int stock, double precio, double altura) 
            : this(string.Format("Figura {0} cm", altura),stock, precio,altura)//el string.Format acepta cualquier tipo de dato por eso altura no lleva el .ToString()
        {
        }

        public override string ToString()
        {
            StringBuilder cadenaFigura = new StringBuilder();

            cadenaFigura.AppendLine(base.ToString());
            cadenaFigura.AppendFormat("ALTURA : {0}\r\n", this.altura);
            cadenaFigura.AppendLine("");
            cadenaFigura.AppendLine("---------------------");

            return cadenaFigura.ToString();
        }
    }
}
