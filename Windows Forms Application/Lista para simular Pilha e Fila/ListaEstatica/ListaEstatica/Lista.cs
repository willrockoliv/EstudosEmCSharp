using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Lista
    {
        private const int CAPACIDADE = 10;
        private string[] dados = new string[CAPACIDADE];
        private int quantidade = 0;

        public int tamanho()
        {
            return quantidade;
        }

        public void insereNaPosicao(int p_posicao, string p_valor)
        {
            if (tamanho() == CAPACIDADE)
            {
                throw new Exception("A lista está cheia!!!\n\n");
            }
            else
            {
                quantidade++;
                for (int i = tamanho() - 1; i > p_posicao; i--)
                {
                    dados[i] = dados[i - 1];
                }
                dados[p_posicao] = p_valor;
            }
        }


        public string removeDaPosicao(int posicao)
        {
            if (tamanho() == 0)
            {
                throw new Exception("A lista está vazia!!!!");
            }
            else
            {
                string aux = dados[posicao];
                for (int i = posicao; i < tamanho() - 1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                quantidade--;
                return aux;
            }
        }


        public void insereNoInicio(string p_valor)
        {
            insereNaPosicao(0, p_valor);
        }


        public void insereNoFim(string p_valor)
        {
            insereNaPosicao(tamanho(), p_valor);
        }

        public void imprimeLista()
        {
            Console.WriteLine("\n\nImpressão dos dados da lista:\n");
            for (int i = 0; i < tamanho(); i++)
            {
                Console.WriteLine(dados[i]);
            }
        }
    } // fim da classe lista
}
