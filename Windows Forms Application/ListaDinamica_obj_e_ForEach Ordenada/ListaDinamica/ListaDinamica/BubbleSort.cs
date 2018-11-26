using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ListaDinamica
{
    static class BubbleSort
    {
        /// <summary>
        /// Ordena uma Lista de Inteiros
        /// </summary>
        /// <param name="lista">lista de inteiros</param>
        /// <returns>a lista ordenada</returns>
        public static Lista Ordena_BubbleSort(Lista lista, 
            IComparer comparador)
        {
            object aux;
            bool houvetroca;
            do
            {
                houvetroca = false;
                Nodo no = lista.RetornaPrimeiro();
                while (no.Proximo != null)
                {                    
                    if (comparador.Compare(no.Dado, no.Proximo.Dado) > 0)
                    {
                        //efetua a troca dos valores
                        aux = no.Dado;
                        no.Dado = no.Proximo.Dado;
                        no.Proximo.Dado = aux;
                        houvetroca = true;
                    }
                    no = no.Proximo;
                }
            }
            while (houvetroca == true);
            return lista;
        }

    }
}
