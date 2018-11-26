using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Times_Jogadores
{
    public class NodoTimes
    {
        public string Time { get; set; }
        public string Treinador { get; set; }
        public ListaJogadores ListaJogadores { get; set; }
        public NodoTimes Proximo { get; set; }

        public NodoTimes()
        {
            Time = string.Empty;
            Treinador = string.Empty;
            ListaJogadores = new ListaJogadores();
            Proximo = null;
        }
    }
}
