using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados.Pilha
{
    public class PilhaDinamica
    {
        //Representa o topo da pilha
        private NodoPilha topo = null;

        // quantidade de elementos na pilha
        int quantidade = 0;
        public int Quantidade
        {
            get { return quantidade; }
        }

        /// <summary>
        /// Método para empilhar strings
        /// </summary>
        /// <param name="dado"></param>
        public void Empilhar(Midia dado)
        {
            NodoPilha novoNodo = new NodoPilha();
            novoNodo.Dado = dado;
            novoNodo.Anterior = topo;

            topo = novoNodo;
            quantidade++;
        }

        /// <summary>
        /// Desempilhar elementos da pilha
        /// </summary>
        /// <returns></returns>
        public Midia Desempilhar()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                Midia retorno = topo.Dado;
                topo = topo.Anterior;
                quantidade--;
                return retorno;
            }
        }

        /// <summary>
        /// Método para retornr o topo da pilha
        /// </summary>
        /// <returns></returns>
        public Midia RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                return topo.Dado;
            }
        }



        public string Listar()
        {
            string r = "";
            NodoPilha aux = topo;
            while (aux != null)
            {
                r += aux.Dado.ToString() + "\r\n";
                aux = aux.Anterior;
            }
            r = r.Trim();
            r = r.Substring(0, r.Length - 1);
            return r;
        }
    }
}
