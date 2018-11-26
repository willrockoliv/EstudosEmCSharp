using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    class Program
    {
        /*
         3.	Numero Primo
         Faça um programa que tenha uma método que receba um número e devolva 
         um String dizendo se o número é PRIMO.
        */

        static bool NumeroPrimo(int num)
        {
            int cont=0;

            for(int i=1; i<=num; i++)
            {
                if (num % i == 0)
                    cont++;
            }

            if (cont == 2)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = Convert.ToInt16(Console.ReadLine());

            if (NumeroPrimo(num) == true)
                Console.WriteLine("O número digitado é primo!");
            else
                Console.WriteLine("O número digitado não é primo!");

            Console.ReadLine();
        }
    }
}
