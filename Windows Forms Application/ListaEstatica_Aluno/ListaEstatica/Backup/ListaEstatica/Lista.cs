using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Lista
    {
        private const int CAPACIDADE = 32;
        private Aluno[] dados = new Aluno[CAPACIDADE];
        private int quantidade = 0;

        public int tamanho()
        {
            return quantidade;
        }

        public void insereNaPosicao(int p_posicao, Aluno p_valor)
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

        public Aluno removeDaPosicao(int posicao)
        {
            if (tamanho() == 0)
            {
                throw new Exception("A lista está vazia!!!!");
            }
            else
            {
                Aluno aux = dados[posicao];
                for (int i = posicao; i < tamanho() - 1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                quantidade--;
                return aux;
            }
        }

        public void insereNoInicio(Aluno p_valor)
        {
            insereNaPosicao(0, p_valor);
        }

        public void insereNoFim(Aluno p_valor)
        {
            insereNaPosicao(tamanho(), p_valor);
        }

        public string ImprimeLista()
        {
            string r = "\n\nImpressão dos dados da lista:\r\n";
            for (int i = 0; i < tamanho(); i++)
            {
                r = r + dados[i].Ra.ToString() + " - " +
                        dados[i].Nome + Environment.NewLine;    
            }

            return r;
        }           

        public Aluno RetornaPrimeiro()
        {
            if (tamanho() == 0)
                throw new Exception("A lista está vazia!");
            else
                return dados[0];
        }

        public Aluno RetornaUltimo()
        {
            if (tamanho() == 0)
                throw new Exception("A lista está vazia!");
            else
                return dados[tamanho() -1];
        }

        public Aluno Pesquisa(int ra)
        {
            for (int i = 0; i < tamanho(); i++)
            {
                if (dados[i].Ra == ra)
                    return dados[i];
            }
            return null;
        }
    } // fim da classe lista
}
