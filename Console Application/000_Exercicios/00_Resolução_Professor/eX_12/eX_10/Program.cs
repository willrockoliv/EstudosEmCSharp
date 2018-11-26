using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eX_10
{
    class Program
    {
        static double Media(int[] vetor)
        {
            double soma = 0;
            for (int n = 1; n < vetor.Length; n++)
                soma += vetor[n];

            return soma / vetor.Length;
        }


        static void Main(string[] args)
        {
            /*
             10.	Menor valor
            Faça um método que receba um vetor de inteiros e 
            ele deverá devolver qual o menor valor no vetor.
            */
            int[] numeros = new int[5];
            for (int n=0; n<numeros.Length; n++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[n] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("O menor valor do vetor é {0} ",
                Media(numeros));

            Console.ReadLine();
        }
    }
}
