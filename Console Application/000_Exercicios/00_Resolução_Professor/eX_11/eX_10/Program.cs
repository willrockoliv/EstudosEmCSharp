using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eX_10
{
    class Program
    {
        static int Soma(int[] vetor)
        {
            int soma = 0;
            foreach (int valor in vetor)
                soma += valor;
            return soma;
        }


        static void Main(string[] args)
        {
            /*
          11.	Soma
            Faça um método que receba um vetor de inteiros e 
            ele deverá devolver a soma dos elementos do vetor.
            */
            int[] numeros = new int[5];
            for (int n=0; n<numeros.Length; n++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[n] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("O menor valor do vetor é {0} ", Soma(numeros));
            Console.ReadLine();
        }
    }
}
