using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661
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
        public List<Llamada> ListLlamadas
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
            cadena.AppendLine("\n--------------------------------------------");
            cadena.AppendLine("--------------------------------------------\n");
            foreach (Llamada call in listaLlamadas)
            {
                if (call is Local)
                {
                    //accedo al Mostrar de Local
                    aux = ((Local)call).ToString();
                }
                else
                {
                    //accedo al Mostrar de Provincial
                    aux = ((Provincial)call).ToString();
                }
                cadena.AppendLine(aux);
                cadena.AppendLine("--------------------------------------------\n");
            }
            return cadena.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaLlamadas.Add(nuevaLlamada);
        }

        public void OrdenarLlamadas()
        {
            listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita central, Llamada call)
        {
            bool retorno = false;
            if (!(central is null && call is null))
            {
                foreach (Llamada newCall in central.listaLlamadas)
                {
                    if(newCall == call)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita central, Llamada call)
        {
            bool retorno = false;
            if (!(central == call))
            {
                retorno = true;
            }
            return retorno;
        }

        public static Centralita operator +(Centralita central,Llamada call)
        {
            Centralita retorno = null;
            if(!(central is null && call is null))
            {
                retorno = central;//cargamos la null con la que recibimos
                if(central != call)
                {
                    central.AgregarLlamada(call);
                    retorno = central;
                }
            }
            return retorno;
        }
    }
}
