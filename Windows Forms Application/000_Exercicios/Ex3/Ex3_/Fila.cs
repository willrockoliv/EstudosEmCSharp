using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Fila
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
                string valor = vetor[quantidade - 1];
                return valor;
            }
        }

        public string Listar()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha esta vazia!");
            else
            {
                string[] vetor2 = new string[capacidade];
                string lista = "";
                int tamanho = Tamanho();

                lista = Desenfileira();
                vetor2[0] = lista;

                for (int i = 1; i < tamanho; i++)
                {
                    vetor2[i] = Desenfileira();
                    lista = lista + " - " + vetor2[i];

                    if (i == tamanho - 1)
                    {
                        foreach (string valor in vetor2)
                        {
                            Enfileirar(valor);
                        }
                    }
                }

                return lista;
            }
        }
    }
}
