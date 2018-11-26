using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDinamica
{
    public class Nodo
    {
        string dado;

        public string Dado
        {
            get { return dado; }
            set { dado = value; }
        }
        Nodo proximo;

        public Nodo Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        Nodo anterior;

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        
        /// <summary>
        /// Construtor parametrizado
        /// </summary>
        /// <param name="dado"></param>
        /// <param name="proximo"></param>
        public Nodo(string dado, Nodo proximo)
        {
            this.dado = dado;
            this.proximo = proximo;
        }

        /// <summary>
        /// construtor sem parâmetros
        /// </summary>
        public Nodo()
        {
            dado = string.Empty;
            proximo = null;
            anterior = null;
        }
    }
}
