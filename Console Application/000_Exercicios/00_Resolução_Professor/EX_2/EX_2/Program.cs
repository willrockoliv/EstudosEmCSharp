using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2
{
    class Program
    {

        static string ParImpar(int numero)
        {
            if (numero % 2 == 0)
                return "Par";
            else
                return "Impar";
        }

        static void Main(string[] args)
        {
            /*
             2.	Par Impar
            Faça um programa que tenha uma método 
            que receba um número e devolva um 
            String dizendo se o número é Par ou Impar. 
             */
            Console.WriteLine("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string resposta = ParImpar(n);
            Console.WriteLine(resposta);
            //Console.WriteLine(ParImpar(n));
            Console.ReadLine();
        }
    }
}
