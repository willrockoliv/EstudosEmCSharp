using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    class Nodo
    {
        private string valor;
        private Nodo proximo;
        //private Nodo endereco;

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
        public Nodo Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

       /* public Nodo Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }*/
    }
}
