using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDinamica
{
    class Lista
    {
        Nodo primeiro = null;
        Nodo ultimo = null;
        int qtde = 0;

        private void InserirNaPosicao(Nodo anterior, string valor)
        {
            Nodo novo = new Nodo();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (qtde == 0)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro.Anterior = novo;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
                novo.Anterior = anterior;
                if (novo.Proximo != null)
                {
                    novo.Proximo.Anterior = novo;
                }
            }

            if (novo.Proximo == null)
                ultimo = novo;

            qtde++;
        }

        public void InserirNoInicio(string valor)
        {
            InserirNaPosicao(null, valor);
        }
        public void InserirNoFim(string valor)
        {
            if (qtde == 0)
            {
                InserirNoInicio(valor);
            }
            else
            {
                InserirNaPosicao(ultimo, valor);
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 0</param>
        public void InserirNaPosicao(string valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }


        public string RemoverDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");

            string valor = "";
            qtde--;

            if (qtde == 0)
            {
                valor = primeiro.Dado;
                primeiro = ultimo = null;
                return valor;
            }           
            else
            {
                //nodoApagado irá armazenar o nodo será apagado.
                Nodo nodoApagado = primeiro;
                for (int i = 1; i <= posicao; i++)  // encontra o elemento anterior ao que será apagado
                    nodoApagado = nodoApagado.Proximo;

                valor = nodoApagado.Dado;

                if (nodoApagado.Proximo == null) // ajusta o último
                    ultimo = nodoApagado.Anterior;

                if (nodoApagado.Anterior == null) // ajusta o primeiro
                    primeiro = nodoApagado.Proximo;

                if (nodoApagado.Anterior != null)
                    nodoApagado.Anterior.Proximo = nodoApagado.Proximo;

                if (nodoApagado.Proximo != null)
                    nodoApagado.Proximo.Anterior = nodoApagado.Anterior;

                return valor;
            }           
        }


        public bool Pesquisa(string dado)
        {
            Nodo aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado == dado)
                    return true;
                aux = aux.Proximo;
            }

            return false;
        }




        public string ListarIterativo()
        {
            string r = string.Empty;

            Nodo aux = primeiro;
            while (aux != null)
            {
                r = r + Environment.NewLine + aux.Dado;
                aux = aux.Proximo;
            }

            return r.Trim();
        }


        /// <summary>
        /// Método listar recursivo
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        private string Listar(Nodo e)
        {
            if (e != null)
                return Listar(e.Proximo) + " " + e.Dado;
            else
                return string.Empty;
        }


        public string ListarRecursivo()
        {
            return Listar(RetornaPrimeiro());
        }


        public Nodo RetornaPrimeiro()
        {
            return primeiro;
        }

    }
}
