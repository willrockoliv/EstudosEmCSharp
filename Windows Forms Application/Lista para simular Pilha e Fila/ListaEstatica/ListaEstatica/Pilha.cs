using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Pilha
    {
        Lista lista;

        public Pilha()
        {
            lista = new Lista();
            /*File.AppendAllText("c:\\teste.txt", 
                "Objeto construido em : " + DateTime.Now + Environment.NewLine);*/
        }

        public void Empilha(string valor)
        {
            try
            {
                lista.insereNoFim(valor);
            }
            catch
            {
                throw new Exception("A pilha está cheia!!!");
            }
        }


        public string Desempilha()
        {
            try
            {
                return lista.removeDaPosicao(lista.tamanho() - 1);
            }
            catch
            {
                throw new Exception("A Pilha está vazia!!|");
            }
        }

        public int Tamanho()
        {
            return lista.tamanho();
        }
    }
}
