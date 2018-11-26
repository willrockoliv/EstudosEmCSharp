using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3
{
    class Program
    {
        /*
             3.	Numero Primo
             Faça um programa que tenha uma método 
             que receba um número e devolva um 
             String dizendo se o número é PRIMO.
             */

        static string VerificaNumPrimo(int num)
        {
            if (num == 2 || num == 3)
                return "Primo";
            else if (num == 1 || num % 2 == 0)
                return "Não é primo";

            for (int n=2; n<= num/2; n++)
            {
                if (num % n == 0)
                    return "Não é primo";
            }

            return "Primo";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nº ");
            int numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine(VerificaNumPrimo(numero));

            Console.ReadLine();
        }
    }
}
