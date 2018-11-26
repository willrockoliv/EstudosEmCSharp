using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados.Pilha
{
    public class NodoPilha
    {
        private NodoPilha anterior;
        Midia dado;

        public Midia Dado
        {
            get { return dado; }
            set { dado = value; }
        }

        /// <summary>
        /// Endereço do nodo anterior na pilha
        /// </summary>
        public NodoPilha Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
