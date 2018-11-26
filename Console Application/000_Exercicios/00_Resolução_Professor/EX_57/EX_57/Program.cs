using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_57
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 57. FindNum
                Faça um programa que solicite 10 números inteiros.
                Depois o programa deverá entrar em uma repetição, onde ele solicitará um número qualquer e dirá se o número
                existe ou não no vetor previamente digitado.
                Isso se repetirá até que o usuário queira sair.*/


            int[] numeros = new int[10];

            for (int n = 0; n < numeros.Length; n++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[n] = Convert.ToInt32(Console.ReadLine());
            }

            int pesquisa;
            do
            {
                Console.WriteLine("Digite um número para pesquisar ou -1 para sair: ");
                pesquisa = Convert.ToInt32(Console.ReadLine());
                if (pesquisa != -1)
                {
                    bool existe = false;
                    for (int n = 0; n < numeros.Length; n++)
                    {
                        if (numeros[n] == pesquisa)
                        {
                            existe = true;
                            Console.WriteLine("Encontrei!!!");
                            break;
                        }
                    }

                    if (!existe) //(existe == false)
                    {
                        Console.WriteLine("Não Encontrei!!!");
                    }

                }
            }
            while (pesquisa != -1);


        }
    }
}
