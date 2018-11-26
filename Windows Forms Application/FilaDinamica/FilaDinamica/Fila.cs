using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    public class Fila
    {
        //Representa o inicio da fila
        private Nodo inicio = new Nodo();
        private Nodo fim = new Nodo();
        // quantidade de elementos na fila
        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
        }

        /// <summary>
        /// Método para enfileirar strings
        /// </summary>
        /// <param name="valor"></param>
        public void Enfileirar(string valor)
        {
            Nodo novoNodo = new Nodo();


            /*
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = valor;
            novoNodo.Proximo = inicio;
            inicio = novoNodo;
            quantidade++;
            */
        }

        /// <summary>
        /// Desenfileirar elementos da fila
        /// </summary>
        /// <returns></returns>
        public string Desenfileirar()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                string retorno = inicio.Valor;
                inicio = 

                /*
                string retorno = inicio.Valor;
                inicio = inicio.Proximo;
                quantidade--;
                return retorno;
                */
            }
        }

        /// <summary>
        /// Método para retornar o topo da fila
        /// </summary>
        /// <returns></returns>
        public string RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                return inicio.Valor;
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
                    temp[i - 1] = Desenfileirar();
                }
                while (Quantidade > 0);

                foreach (string valor in temp)
                {
                    Enfileirar(valor);
                    todos = todos + valor + " - ";
                }

                return todos;
            }
            catch
            {
                throw new Exception("A fila está vazia!");
            }
        }
    }
}
