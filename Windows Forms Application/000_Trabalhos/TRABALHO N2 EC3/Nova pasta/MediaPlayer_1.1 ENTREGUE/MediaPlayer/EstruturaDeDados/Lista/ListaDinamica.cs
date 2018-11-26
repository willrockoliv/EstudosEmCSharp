using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados
{
    public class ListaDinamica
    {
        NodoLista primeiro = null;
        int qtde = 0;

        public int Tamanho { get { return qtde; } set { qtde = value; } }

        private void InserirNaPosicao(NodoLista anterior, Midia Midia)
        {
            NodoLista novo = new NodoLista();
            novo.Midia = Midia;

            if (anterior == null)
            {
                if (primeiro == null)
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
            Tamanho++;
        }

        public void InserirNoInicio(Midia Midia)
        {
            InserirNaPosicao(null, Midia);
        }


        public void InserirNoFim(Midia Midia)
        {
            if (Tamanho == 0)
            {
                InserirNoInicio(Midia);
            }
            else
            {
                NodoLista aux = primeiro;
                while (aux.Proximo != null)
                {
                    aux = aux.Proximo;
                }
                InserirNaPosicao(aux, Midia);
            }
        }


        /// <summary>
        /// Insere em uma posição, iniciando do 1
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Midia Midia, int posicao)
        {
            if (posicao > Tamanho || posicao <= 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 1)
                InserirNoInicio(Midia);
            else
            {
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao - 1; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, Midia);
            }
        }


        public Midia RemoverDaPosicao(int posicao)
        {
            if (posicao > Tamanho || posicao <= 0)
                throw new Exception("Não é possível remover.");

            Midia Midia = null;
            if (posicao == 1)
            {
                Midia = primeiro.Midia;
                primeiro = primeiro.Proximo;
            }
            else
            {
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao - 1; i++)
                    aux = aux.Proximo;

                Midia = aux.Proximo.Midia;
                aux.Proximo = aux.Proximo.Proximo;
            }
            Tamanho--;
            return Midia;
        }

        public Midia Pesquisa(Midia p_Midia, IComparer comparador)
        {
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (comparador.Compare(aux.Midia, p_Midia) == 0)
                    return aux.Midia;
                aux = aux.Proximo;
            }
            throw new Exception("Midia não encontrada");
        }

        public Midia Pesquisa(int p_posicao)
        {
            if (p_posicao > Tamanho)
                throw new Exception("Posição não pode ser maior do que o tamanho da lista");
            else
                return Pesquisa(p_posicao, 0, primeiro);
        }

        private Midia Pesquisa(int p_posicao, int cont, NodoLista nodo)
        {
            if (cont != p_posicao)
                return Pesquisa(p_posicao, cont + 1, nodo.Proximo);

            return nodo.Midia;
        }

        public string Listar()
        {
            string r = string.Empty;

            NodoLista aux = primeiro;
            while (aux != null)
            {
                r = r + "\r\n" + aux.Midia.ToString();

                aux = aux.Proximo;
            }

            return r.Trim();
        }

        public Midia Listar(NodoLista e)
        {
            if (e.Proximo != null)
                Listar(e.Proximo);

            return e.Midia;
        }

        public NodoLista RetornaPrimeiro()
        {
            return primeiro;
        }
    }
}
