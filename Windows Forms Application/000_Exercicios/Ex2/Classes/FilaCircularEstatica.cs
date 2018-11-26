using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class FilaCircularEstatica
    {
        const int capacidade = 5;
        private int quantidade = 0;
        private int inicio = 0;
        private int fim = 0;
        private string[] vetor = new string[capacidade];

        public int Tamanho()
        {
            return quantidade;
        }

        public void Enfileirar(string p_valor)
        {
            if (Tamanho() == capacidade)
                throw new Exception("A Fila está cheia!");
            else
            {
                vetor[fim] = p_valor;
                fim = (fim + 1) % capacidade;
                quantidade++;
            }
        }

        public string Desenfileira()
        {
            if (Tamanho() == 0)
                throw new Exception("A Fila esta vazia!");
            else
            {
                string valor = vetor[inicio];
                inicio = (inicio + 1) % capacidade;
                quantidade--;
                return valor;
            }
        }

        public string RetornaInicio()
        {
            if (Tamanho() == 0)
                throw new Exception("A Pilha esta vazia!");
            else
            {
                string valor = vetor[inicio];
                return valor;
            }
        }

        public string Retornafim()
        {
            if (Tamanho() == 0)
                throw new Exception("A Pilha esta vazia!");
            else
            {
                string valor = vetor[fim - 1];
                return valor;
            }
        }
    }
}
