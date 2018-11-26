using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._57
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                57. FindNum
                Faça um programa que solicite 10 números inteiros.
                Depois o programa deverá entrar em uma repetição, onde ele solicitará um número qualquer e dirá se o número
                existe ou não no vetor previamente digitado.
                Isso se repetirá até que o usuário queira sair.
            */

            Console.WriteLine("Digite 10 numeros: ");

            int[] n = new int[10];

            for(int i=0; i<10; i++)
            {
                Console.Write("{0}° número: ",i+1);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            int n2=0, vereific = 0;
            bool sair = false;

            do
            {
                vereific = 0;

                Console.Clear();

                Console.Write("Informe um número: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 10; i++)
                {
                    if (n[i] == n2)
                        vereific++;
                }

                Console.WriteLine("O número digitado foi encontrado {0} vezes.", vereific);

                char op;

                do
                {
                    Console.Write("\nDeseja continuar (S/N): ");
                    op = Console.ReadKey().KeyChar;
                }
                while (char.ToUpper(op) != 'S' && char.ToUpper(op) != 'N');

                if (char.ToUpper(op) == 'N')
                    sair = true;
            }
            while (sair == false);

            Console.ReadLine();

        }
    }
}
