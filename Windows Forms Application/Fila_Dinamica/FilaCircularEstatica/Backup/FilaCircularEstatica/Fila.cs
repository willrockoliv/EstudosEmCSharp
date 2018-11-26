using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilaCircularEstatica
{
    class Fila
    {

        const int CAPACIDADE = 10; // capacidade máxima da fila
        private int quantidade = 0; // qtde de elementos enfileirados
        private int inicio = 0; // indica qual a primeira posição da fila
        private int fim = 0; // indica a próxima posição
        private string[] dados = new string[CAPACIDADE]; // este vetor irá armazenar os dados da fila
        
        // retorna o tamanho da fila
        public int tamanho()
        {
            return quantidade;
        }

        // enfileira um valor string
        public void enfileirar(string p_valor)
        {
            if (tamanho() == CAPACIDADE)
            {
                throw new Exception("A fila está cheia!!!!");
            }
            else
            {
                dados[fim] = p_valor;
                fim = (fim + 1) % CAPACIDADE;
                quantidade++;
            }
        }
        // remove o primeiro elemento da fila e devolve.
        public string desenfileira()
        {
            if (tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");                
            }
            else
            {
                string valor = dados[inicio];
                inicio = (inicio + 1) % CAPACIDADE;
                quantidade--;
                return valor;
            }
        }
    }
}
