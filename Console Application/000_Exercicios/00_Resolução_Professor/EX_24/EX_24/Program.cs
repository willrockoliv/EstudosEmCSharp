using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_24
{
    class Program
    {
        struct Retorno
        {
            public double media, soma, maior, menor;
        }

        static Retorno Estatisticas(int[] vetor)
        {
            Retorno r = new Retorno();

            r.menor =  r.maior = vetor[0];
            r.soma = 0;
            foreach (int valor in vetor)
            {
                r.soma += valor;
                if (valor > r.maior)
                    r.maior = valor;
                if (valor < r.menor)
                    r.menor = valor;
            }
            r.media = r.soma / vetor.Length;                      

            return r;
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

            Retorno resultado =  Estatisticas(vetor);

            Console.WriteLine("Maior: {0}, Menor: {1}, Média: {2}, Soma: {3}",
                resultado.maior, resultado.menor, resultado.media,
                resultado.soma);

            Console.ReadLine();
        }
    }
}
