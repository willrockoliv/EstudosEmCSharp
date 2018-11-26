using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados
{
    public class NodoLista
    {
        private Midia midia;

        public Midia Midia
        {
            get { return midia; }
            set { midia = value; }
        }

        NodoLista proximo;

        public NodoLista Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }


        /// <summary>
        /// Construtor parametrizado
        /// </summary>
        /// <param name="dado"></param>
        /// <param name="proximo"></param>
        public NodoLista(Midia dado, NodoLista proximo)
        {
            this.midia = dado;
            this.proximo = proximo;
        }

        /// <summary>
        /// construtor sem parâmetros
        /// </summary>
        public NodoLista()
        {
            proximo = null;
        }
    }
}
