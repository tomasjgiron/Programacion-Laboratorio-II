using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public enum TipoComic
        {
            Occidental, Oriental
        }

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) 
            : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder cadenaComic = new StringBuilder();

            cadenaComic.AppendLine(base.ToString());
            cadenaComic.AppendFormat("AUTOR : {0}\r\n", this.autor);
            cadenaComic.AppendFormat("TIPO COMIC : {0}\r\n", this.tipoComic);
            cadenaComic.AppendLine("");
            cadenaComic.AppendLine("---------------------");

            return cadenaComic.ToString();
        }
    }
}
