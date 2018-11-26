using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4
{
    class Program
    {
        /*
         * 4.	Vogais
            Faça um programa que tenha uma 
            método void que recebe um nome e 
            o objetivo do método é escrever no 
            vídeo apenas as vogais deste nome.
         */

        static void ExibeVogais(string frase)
        {
            foreach(char letra in frase)
            {
                if (char.ToUpper(letra) == 'A' ||
                    char.ToUpper(letra) == 'E' ||
                    char.ToUpper(letra) == 'I' ||
                    char.ToUpper(letra) == 'O' ||
                    char.ToUpper(letra) == 'U')
                    Console.Write(letra);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine();

            ExibeVogais(nome);

            Console.ReadLine();
        }
    }
}
