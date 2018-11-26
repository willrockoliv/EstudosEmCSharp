using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        /*
        4.	Vogais
        Faça um programa que tenha uma método void que recebe um nome e o objetivo do 
        método é escrever no vídeo apenas as vogais deste nome.
        */

        static void Vogais(string nome)
        {
            for(int cont=0; cont < nome.Length-1; cont++)
            {
                if (Char.ToUpper(nome[cont]) == 'A' || Char.ToUpper(nome[cont]) == 'E' ||
                    Char.ToUpper(nome[cont]) == 'I' || Char.ToUpper(nome[cont]) == 'O' ||
                   Char.ToUpper(nome[cont]) == 'U')
                    Console.Write(nome[cont]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Vogais(nome);
            Console.ReadLine();
        }
    }
}
