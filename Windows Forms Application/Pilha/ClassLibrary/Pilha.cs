using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Pilha
    {
        private const int capacidade = 5;
        private Funcionario[] vetor = new Funcionario[capacidade];
        private int topo = -1;

        public void Empillhar(Funcionario p_funcionario)
        {
            if (Tamanho() != 5)
                vetor[++topo] = p_funcionario;
            else
                throw new Exception("Tamanho máximo atingido!");
        }

        public Funcionario Desempilhar()
        {
            if (Tamanho() != 0)
            {
                Funcionario valor_topo = vetor[topo];
                topo--;
                return valor_topo;
            }
            else
                throw new Exception("A Pilha está vazia!");
        }

        public Funcionario RetornaTopo()
        {
            if (Tamanho() != 0)
                return vetor[topo];
            else
                throw new Exception("A Pilha está vazia!");
        }

        public int Tamanho()
        {
            return topo + 1;
        }
    }
}
