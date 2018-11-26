using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Lista<T> : IListSource, IEnumerable
    {
        #region Atributos       
        Nodo<T> Primeiro = null;
        Nodo<T> Ultimo = null;
        int _quantidade = 0;
        #endregion

        #region Propriedades
        public int Quantidade { get { return _quantidade; } }
        #endregion

        #region Metodos

        #region Inserir
        private void InserirNaPosicao(Nodo<T> anterior, T dado)
        {
            Nodo<T> novo = new Nodo<T>(dado);

            if (anterior == null)
            {
                if (_quantidade == 0)
                    Primeiro = novo;
                else
                {
                    novo.Proximo = Primeiro;
                    Primeiro.Anterior = novo;
                    Primeiro = novo;
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
                Ultimo = novo;

            _quantidade++;
        }

        public void InserirNoInicio(T dado)
        {
            InserirNaPosicao(null, dado);
        }

        public void InserirNoFim(T valor)
        {
            if (_quantidade == 0)
                InserirNoInicio(valor);
            else
                InserirNaPosicao(Ultimo, valor);
        }

        public void InserirNaPosicao(T dado, int posicao)
        {
            if (posicao > _quantidade || posicao < 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 0)
                InserirNoInicio(dado);
            else
            {
                Nodo<T> aux = Primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, dado);
            }
        }

        public void Inserir(T valor)
        {
            InserirNoFim(valor);
        }
        #endregion

        #region Remover
        public T RemoverDaPosicao(int posicao)
        {
            if (posicao >= _quantidade || posicao < 0 || _quantidade == 0)
                throw new Exception("Não é possível remover.");

            T dado = default(T);
            _quantidade--;

            if (_quantidade == 0)
            {
                dado = Primeiro.Dado;
                Primeiro = Ultimo = null;
                return dado;
            }
            else
            {
                //nodoApagado irá armazenar o nodo será apagado.
                Nodo<T> nodoApagado = Primeiro;
                for (int i = 1; i <= posicao; i++)  // encontra o elemento anterior ao que será apagado
                    nodoApagado = nodoApagado.Proximo;

                dado = nodoApagado.Dado;

                if (nodoApagado.Proximo == null) // ajusta o último
                    Ultimo = nodoApagado.Anterior;

                if (nodoApagado.Anterior == null) // ajusta o primeiro
                    Primeiro = nodoApagado.Proximo;

                if (nodoApagado.Anterior != null)
                    nodoApagado.Anterior.Proximo = nodoApagado.Proximo;

                if (nodoApagado.Proximo != null)
                    nodoApagado.Proximo.Anterior = nodoApagado.Anterior;

                return dado;
            }
        }
        #endregion

        public void ForEach(Action<T> action)
        {
            Nodo<T> aux = Primeiro;
            while (aux != null)
            {
                action.Invoke(aux.Dado);
                aux = aux.Proximo;
            }
            
        }

        public T[] ToArray()
        {
            T[] retorno = new T[Quantidade];
            int i = 0;
            foreach(T dado in this)
                retorno[i++] = dado;
            return retorno;
        }


        #endregion

        #region IListSource Members
        public bool ContainsListCollection { get { return true; } }
        public IList GetList()
        {
            BindingList<T> bindingList = new BindingList<T>();
            Nodo<T> aux = Primeiro;
            while (aux != null)
            {
                bindingList.Add(aux.Dado);
                aux = aux.Proximo;
            }
            return bindingList;
        }
        #endregion

        #region IEnumerable Members
        public IEnumerator GetEnumerator()
        {
            Nodo<T> aux = Primeiro;
            while (aux != null)
            {
                yield return aux.Dado;
                aux = aux.Proximo;
            }
        }
        #endregion

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Quantidade)
                    throw new IndexOutOfRangeException();
                var aux = Primeiro;
                for(int i = 0;i<index;i++)
                    aux = aux.Proximo;
                return aux.Dado;
            }
            set
            {
                if (index < 0 || index >= Quantidade)
                    throw new IndexOutOfRangeException();
                var aux = Primeiro;
                for (int i = 0; i < index; i++)
                    aux = aux.Proximo;
                aux.Dado = value;
            }
        }
    }
}
