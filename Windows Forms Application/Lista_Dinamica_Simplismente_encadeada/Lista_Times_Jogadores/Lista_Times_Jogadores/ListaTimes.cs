using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Times_Jogadores
{
    public class ListaTimes
    {
        NodoTimes primeiro = null;
        public int qtde = 0;

        private void InserirNaPosicao(NodoTimes anterior, string time, string treinador, ListaJogadores ListaJogadores)
        {
            NodoTimes novo = new NodoTimes();
            novo.Time = time;
            novo.Treinador = treinador;
            novo.ListaJogadores = ListaJogadores;

            if (anterior == null)
            {
                if (qtde == 0)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtde++;
        }

        public void InserirNoInicio(string time, string treinador, ListaJogadores ListaJogadores)
        {
            InserirNaPosicao(null, time, treinador, ListaJogadores);
        }

        public void InserirNoFim(string time, string treinador, ListaJogadores ListaJogadores)
        {
            if (qtde == 0)
                InserirNoInicio(time, treinador, ListaJogadores);
            else
            {
                NodoTimes aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, time, treinador, ListaJogadores);
            }
        }

        public void InserirNaPosicao(string time, string treinador, ListaJogadores LisataJogadores, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir");

            if (posicao == 0)
                InserirNoInicio(time, treinador, LisataJogadores);
            else
            {
                NodoTimes aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, time, treinador, LisataJogadores);
            }
        }

        public void RemoveDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover");

            if (posicao == 0)
                primeiro = primeiro.Proximo;
            else
            {
                NodoTimes aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                aux.Proximo = aux.Proximo.Proximo;
            }
            qtde--;
        }

        public string[] Listar()
        {
            string[] lista = new string[0];
            NodoTimes aux = primeiro;
            string[] lista_aux;
            int i = -1;

            while (aux != null)
            {
                Array.Resize(ref lista, lista.Length + 14);

                lista[++i] = "Time: " + aux.Time;
                lista[++i] = "Treinador: " + aux.Treinador;
                lista[++i] = "Jogadores: ";

                lista_aux = aux.ListaJogadores.ImprimeLista();
                for (int j = 0; j < 11; j++)
                {
                    lista[++i] = lista_aux[j];
                }
                aux = aux.Proximo;
            }
            return lista;
        }
    }
}

