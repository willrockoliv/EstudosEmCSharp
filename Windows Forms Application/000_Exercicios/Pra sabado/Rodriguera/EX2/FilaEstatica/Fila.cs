using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    class Fila
    {
        private int quantidade = 0; // qtde de elementos enfileirados
        //     private int inicio = 0; // indica qual a primeira posição da fila
        //  private int fim = 0; // indica a próxima posição
        public int Tamanho()
        {
            return quantidade;
        }
        // enfileira um valor string
        //private Nodo fim = null;
        private Nodo inicio = null;
        private Nodo fim = null;

        public void Enfileirar(string p_valor)
        {
            /*if (Tamanho() == CAPACIDADE)
            {
                throw new Exception("A fila está cheia!!!!");
            }
            else*/
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = p_valor;
            novoNodo.Proximo = null;

            if (inicio == null)
            {
                inicio = novoNodo;
            }
            else
            {
                fim.Proximo = novoNodo;
            }

            fim = novoNodo;
            quantidade++;

        }
        // remove o primeiro elemento da fila e devolve.
        public string Desenfileira()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                string valor = inicio.Valor;
                inicio = inicio.Proximo;
                quantidade--;
                return valor;
            }
        }
    }
}
