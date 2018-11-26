using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados.Fila
{
    class FilaDinamica
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



        public string Listagem()
        {
            string retorno = "";

            NodoFila aux = inicio;
            while (aux != null)
            {
                retorno = retorno + aux.Midia.ToString() + "\r\n";
                aux = aux.Proximo;
            }
            return retorno;
        }
    }
}
