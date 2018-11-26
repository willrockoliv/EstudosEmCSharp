using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeInvertido
{
    class Program
    {

        /*
        5.	Nome Invertido
        Faça um programa que solicite um texto qualquer e então um método  chamado irá devolver o texto 
        recebido como parâmetro invertido. ex: nariz   r= ziran
         */

        static void NomeInvertido(string nome)
        {
            for (int i = nome.Length-1; i >= 0; i--)
            {
                Console.Write(nome[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            NomeInvertido(nome);
            Console.ReadLine();

        }
    }
}
