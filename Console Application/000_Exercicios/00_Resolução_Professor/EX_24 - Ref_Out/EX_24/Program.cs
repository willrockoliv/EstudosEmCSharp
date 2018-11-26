using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_24
{
    class Program
    {   
        static void Estatisticas(int[] vetor, 
                                out int maior, out int menor,
                                out double media, out int soma)
        {            
            menor = maior = vetor[0];
            soma = 0;
            foreach (int valor in vetor)
            {
                soma += valor;
                if (valor > maior)
                    maior = valor;
                if (valor < menor)
                    menor = valor;
            }
            media = soma / vetor.Length;            
        }



        static void Main(string[] args)
        {
            /*
             24.	Faça um método que receba um vetor de 
             inteiros e ele deverá devolver:
            •	a média dos elementos do vetor.
            •	a soma
            •	o maior valor
            •	o menor valor
              */

            int[] vetor = { 5, 6, 9, 1, 8, 7, 2, 23, 89, 1250 };
            int maior, menor, soma;
            double media;

            Estatisticas(vetor, out maior, out menor, out media, out soma);

            Console.WriteLine("Maior: {0}, Menor: {1}, Média: {2}, Soma: {3}",
                              maior, menor, media, soma);
            Console.ReadLine();
        }
    }
}
