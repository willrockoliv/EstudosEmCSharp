using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    public class Nodo
    {
        private string valor;
        private Nodo proximo;

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
            get { return proximo; }
            set { proximo = value; }
        }
    }
}
