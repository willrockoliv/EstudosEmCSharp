using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5
{
    class Program
    {
        /* 
        Progressão aritmética é um tipo de sequência numérica que a partir do segundo elemento cada termo (elemento) é a
        soma do seu antecessor por uma constante.
        (5,7,9,11,13,15,17) essa sequência é uma Progressão aritmética, pois os seus elementos são formados pela soma do seu
        antecessor com a constante 2.
        a1 = 5
        a2 = 5 + 2 = 7
        a3 = 7 + 2 = 9
        a4 = 9 + 2 = 11
        a5 = 11 + 2 = 13
        a6 = 13 + 2 = 15
        a7 = 15 + 2 = 17
        Faça um programa que solicite: O elemento inicial da PA, a constante (razão) e o total de sequencias que se deseja
        gerar e então faça 2 algoritmos para resolver este problema: 1 recursivo e um sem recursividade.
    */

        /// <summary>
        /// Método recursivo
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="constante"></param>
        /// <param name="qtde"></param>
        static void ImprimePA(int numero, int constante, int qtde)
        {
            if (qtde > 0)
            {
                Console.Write("{0}", numero);
                if (qtde != 1)
                    Console.Write(",");

                ImprimePA(numero + constante, constante, qtde - 1);
            }
        }


        /// <summary>
        /// Método não recursivo
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="constante"></param>
        /// <param name="qtde"></param>
        static void ImprimePANaoRecursivo(int numero, int constante, int qtde)
        {
            int soma = numero;
            for (int n = 1; n <= qtde; n++)
            {
                Console.Write("{0}", soma);
                if (n != qtde)
                    Console.Write(",");

                soma = soma + constante;
            }
        }


        static void Main(string[] args)
        {
            int inicio = 5;
            int constante = 2;
            int qtde = 20;

            ImprimePA(inicio, constante, qtde);

            Console.WriteLine("\n\n\n");

            ImprimePANaoRecursivo(inicio, constante, qtde);
            Console.ReadLine();
        }
    }
}
