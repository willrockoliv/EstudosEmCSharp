using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Fila
    {
        Lista lista;

        public Fila()
        {
            lista = new Lista();
        }


        public void Enfileira(string valor)
        {
            try
            {
                lista.insereNoFim(valor);
            }
            catch
            {
                throw new Exception("A fila está cheia!");
            }
        }


        public string Desenfileira()
        {
            try
            {
                return lista.removeDaPosicao(0);
            }
            catch
            {
                throw new Exception("A fila está vazia!");
            }
        }

        public int Tamanho()
        {
            return lista.tamanho();
        }
    }
}
