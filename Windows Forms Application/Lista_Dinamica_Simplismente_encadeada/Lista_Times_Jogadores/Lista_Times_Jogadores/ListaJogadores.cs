using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Times_Jogadores
{
    public class ListaJogadores
    {
        private const int CAPACIDADE = 11;
        private string[] jogador = new string[CAPACIDADE];
        private string[] numero = new string[CAPACIDADE];
        private int quantidade = 0;

        public int Tamanho()
        {
            return quantidade;
        }
        public void InsereNaPosicao(int p_posicao, string p_jogador, string p_numero)
        {
            if (Tamanho() == CAPACIDADE)
                throw new Exception("A lista está cheia!!!\n\n");
            else if (p_posicao > Tamanho())
                throw new Exception("Não é possível inserir nesta posição");
            else
            {
                quantidade++;
                for (int i = Tamanho() - 1; i > p_posicao; i--)
                {
                    jogador[i] = jogador[i - 1];
                    numero[i] = numero[i - 1];
                }
                jogador[p_posicao] = p_jogador;
                numero[p_posicao] = p_numero;
            }
        }
        public string RemoveDaPosicao(int posicao)
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!!!");
            else if (posicao > Tamanho() - 1)
                throw new Exception("Posição inválida!!!");
            else
            {
                string aux_jogador = jogador[posicao];
                string aux_numero = numero[posicao];
                for (int i = posicao; i < Tamanho() - 1; i++)
                {
                    jogador[i] = jogador[i + 1];
                    numero[i] = numero[i + 1];
                }
                quantidade--;
                return aux_jogador + aux_numero;
            }
        }
        public void InsereNoInicio(string p_jogador, string p_numero)
        {
            InsereNaPosicao(0, p_jogador, p_numero);
        }
        public void InsereNoFim(string p_jogador, string p_numero)
        {
            InsereNaPosicao(Tamanho(), p_jogador, p_numero);
        }
        public string[] ImprimeLista()
        {
            string[] listaJogadores = new string[11];
            for (int i = 0; i < Tamanho(); i++)
            {
                listaJogadores[i] = numero[i] + "  -  " + jogador[i];
            }
            return listaJogadores;
        }
    }
}

