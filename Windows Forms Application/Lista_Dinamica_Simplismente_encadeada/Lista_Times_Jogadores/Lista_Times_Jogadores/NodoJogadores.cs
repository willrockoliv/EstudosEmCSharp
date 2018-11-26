using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Times_Jogadores
{
    public class NodoJogadores
    {
        public string Jogador { get; set; }
        public string Numero { get; set; }
        public NodoTimes Proximo { get; set; }

        public NodoJogadores()
        {
            Jogador = string.Empty;
            Numero = string.Empty;
            Proximo = null;
        }
    }
}
