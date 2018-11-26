using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    class Nodo<T>
    {
        #region Atributos
        Nodo<T> _anterior;
        T _dado;
        Nodo<T> _proximo;
        #endregion

        public Nodo()
        {
            Anterior = null;
            Dado = default(T);
            Proximo = null;
        }

        public Nodo(T dado)
        {
            Anterior = null;
            Dado = dado;
            Proximo = null;
        }

        public Nodo(Nodo<T> anterior, T dado)
        {
            Anterior = anterior;
            Dado = dado;
            Proximo = null;
        }

        public Nodo(T dado, Nodo<T> proximo)
        {
            Anterior = null;
            Dado = dado;
            Proximo = proximo;
        }

        public Nodo(Nodo<T> anterior, T dado, Nodo<T> proximo)
        {
            Anterior = anterior;
            Dado = dado;
            Proximo = proximo;
        }

        #region Propriedades
        public Nodo<T> Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public T Dado
        {
            get { return _dado; }
            set { _dado = value; }
        }

        public Nodo<T> Proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }
        #endregion


    }
}
