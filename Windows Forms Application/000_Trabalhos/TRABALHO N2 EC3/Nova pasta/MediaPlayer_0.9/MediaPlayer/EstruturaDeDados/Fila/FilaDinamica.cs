using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados.Fila
{
    public class FilaDinamica
    {
        private int quantidade = 0; // qtde de elementos enfileirados
        private NodoFila inicio = null; // indica qual a primeira posição da fila
        private NodoFila fim = null; // indica a próxima posição

        // retorna o tamanho da fila
        public int Tamanho()
        {
            return quantidade;
        }

        // enfileira um valor string
        public void Enfileirar(Midia Midia)
        {
            NodoFila novo = new NodoFila();
            novo.Midia = Midia;
            novo.Proximo = null;

            if (quantidade == 0)
                inicio = novo;
            else
                fim.Proximo = novo;

            fim = novo;
            quantidade++;
        }
        // remove o primeiro elemento da fila e devolve.
        public Midia Desenfileira()
        {
            if (Tamanho() == 0)
                throw new Exception("A fila está vazia!");
            else
            {
                Midia Dado = inicio.Midia;
                inicio = inicio.Proximo;
                quantidade--;

                if (quantidade == 0)
                    fim = null;

                return Dado;
            }
        }

        /// <summary>
        /// Lista os dados do itens enfileirados
        /// </summary>
        /// <returns>Vetor com os dados dos itens enfileirados</returns>
        public string[] Listagem()
        {
            NodoFila aux = inicio;
            string[] retorno = { aux.Midia.ToString() };
            int cont = 0;

            while (aux.Proximo != null)
            {
                Array.Resize(ref retorno, retorno.Length + 1);
                aux = aux.Proximo;
                retorno[++cont] = aux.Midia.ToString();
            }
            return retorno;
        }
    }
}
