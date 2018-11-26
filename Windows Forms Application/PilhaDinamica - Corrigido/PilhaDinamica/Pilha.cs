using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PilhaDinamica
{
    /// <summary>
    /// Classe Pilha Dinâmica
    /// </summary>
    class Pilha
    {        
        //Representa o topo da pilha
        private Nodo topo = null;
        
        // quantidade de elementos na pilha
        int quantidade = 0;
        public int Quantidade
        {
            get { return quantidade; }            
        }

        /// <summary>
        /// Método para empilhar strings
        /// </summary>
        /// <param name="valor"></param>
        public void Empilhar(string valor)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = valor;
            novoNodo.Anterior = topo;

            topo = novoNodo;
            quantidade++;
        }

        /// <summary>
        /// Desempilhar elementos da pilha
        /// </summary>
        /// <returns></returns>
        public string Desempilhar()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                string retorno = topo.Valor;
                topo = topo.Anterior;
                quantidade--;
                return retorno;
            }
        }

        /// <summary>
        /// Método para retornr o topo da pilha
        /// </summary>
        /// <returns></returns>
        public string RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                return topo.Valor;
            }
        }



        public string Listar()
        {
            string r = "";
            Nodo aux = topo;
            while (aux != null)
            {
                r += aux.Valor + " - ";
                aux = aux.Anterior;
            }
            r = r.Trim();
            r = r.Substring(0, r.Length - 1);
            return r;
        }

       


    }
}
