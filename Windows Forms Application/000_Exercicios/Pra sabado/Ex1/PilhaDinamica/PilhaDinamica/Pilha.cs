using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    /// <summary>
    /// Classe Pilha Dinâmica
    /// </summary>
    class Pilha
    {
        //Representa o topo da pilha
        private Nodo topo = null;
        // quantidade de elementos na pilha
        int quantidade = 0;

         public int Quantidade
        {
            get { return quantidade; }
        }

        /// <summary>
        /// Método para empilhar strings
        /// </summary>
        /// <param name="valor"></param>
        public void Empilhar(string valor)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = valor;
            novoNodo.Anterior = topo;
            topo = novoNodo;
            quantidade++;
        }

        /// <summary>
        /// Desempilhar elementos da pilha
        /// </summary>
        /// <returns></returns>
        public string Desempilhar()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                string retorno = topo.Valor;
                topo = topo.Anterior;
                quantidade--;
                return retorno;
            }
        }

        /// <summary>
        /// Método para retornar o topo da pilha
        /// </summary>
        /// <returns></returns>
        public string RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                return topo.Valor;
            }
        }

        public string RetornaTodos()
        {
            try
            {
                string[] temp = new string[0];
                string todos = "";
                int i = 0;

                do
                {
                    Array.Resize(ref temp, ++i);
                    temp[i - 1] = Desempilhar();
                }
                while (Quantidade > 0);

                foreach (string valor in temp)
                {
                    Empilhar(valor);
                    todos = todos + valor + " - ";
                }

                return todos;
            }
            catch
            {
                throw new Exception("A pilha está vazia!");
            }
        }
    }
}
