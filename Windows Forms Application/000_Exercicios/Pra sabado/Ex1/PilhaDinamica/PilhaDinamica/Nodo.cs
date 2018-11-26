using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    /// <summary>
    /// Classe que irá representar 1 elemento na pilha
    /// </summary>
    class Nodo
    {
        private string valor;
        private Nodo anterior;
        /// <summary>
        /// Valor que será armazenado
        /// </summary>
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        /// <summary>
        /// Endereço do nodo anterior na pilha
        /// </summary>
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
