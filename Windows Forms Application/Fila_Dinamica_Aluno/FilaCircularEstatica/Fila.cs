﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilaCircularEstatica
{
    class Fila
    {


        private int quantidade = 0; // qtde de elementos enfileirados
        private Nodo inicio = null; // indica qual a primeira posição da fila
        private Nodo fim = null; // indica a próxima posição


        // retorna o tamanho da fila
        public int tamanho()
        {
            return quantidade;
        }

        // enfileira um valor string
        public void enfileirar(Aluno p_valor)
        {
            Nodo novo = new Nodo();
            novo.Valor = p_valor;
            novo.Proximo = null;

            if (quantidade == 0)
            {
                inicio = novo;
            }
            else
            {
                fim.Proximo = novo;
            }

            fim = novo;            
            quantidade++;

        }


        // remove o primeiro elemento da fila e devolve.
        public Aluno desenfileira()
        {
            if (tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                Aluno valor = inicio.Valor;
                inicio = inicio.Proximo;
                quantidade--;
                
                if (quantidade == 0)
                    fim = null;

                return valor;
            }
        }



        public string Listagem()
        {
            string retorno = "";

            Nodo aux = inicio;
            while (aux != null)
            {
                retorno = retorno + aux.Valor.Ra + " - " + 
                          aux.Valor.Nome + Environment.NewLine ;
                aux = aux.Proximo;
            }

            return retorno;
        }

    }
}
