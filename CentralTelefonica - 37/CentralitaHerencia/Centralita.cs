using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
        }

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada call in listaLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas && call is Local)
                {
                    //accedo al CostoLlamada de Local
                    ganancia += ((Local)call).CostoLlamada;
                }
                else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas && call is Provincial)
                {
                    //accedo al CostoLlamada de Provincial
                    ganancia += ((Provincial)call).CostoLlamada;
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            string aux;
            cadena.AppendLine("Razon social: " + this.razonSocial);
            cadena.AppendLine("\nGanancia total: " + GananciasPorTotal);
            foreach (Llamada call in listaLlamadas)
            {
                if (call is Local)
                {
                    //accedo al Mostrar de Local
                    aux = ((Local)call).Mostrar();
                }
                else
                {
                    //accedo al Mostrar de Provincial
                    aux = ((Provincial)call).Mostrar();
                }
                cadena.AppendLine(aux);
            }
            return cadena.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
