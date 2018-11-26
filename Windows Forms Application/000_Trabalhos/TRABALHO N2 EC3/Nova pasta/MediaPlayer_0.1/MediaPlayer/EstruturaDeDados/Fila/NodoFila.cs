using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados.Fila
{
    public class NodoFila
    {
        private Midia midia;
        private NodoFila proximo = null;
        
        public Midia Midia
        {
            get { return midia; }
            set { midia = value; }
        }

        public NodoFila Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
    }
}
