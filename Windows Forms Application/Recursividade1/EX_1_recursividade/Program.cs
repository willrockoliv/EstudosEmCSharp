using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1_recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 1:
        Faça um programa para calcular a potencia de um número. O método recursivo deve receber como parâmetro a base e
        o expoente, e devolver o valor da potência.
        EX: double CalculaPotencia (int p_base, int p_expoente)
        CalculaPotencia (2,3) = 8
    */

            Console.WriteLine(CalculaPotencia(2, 3000));
            Console.WriteLine(CalculaPotencia(3, 3));
            Console.ReadLine();

        }


        static double CalculaPotencia(int p_base, int p_expoente)
        {
            if (p_expoente == 0)
                return 1;
            else if (p_expoente == 1)
                return p_base;
            else
                return p_base * CalculaPotencia(p_base, p_expoente - 1);
        }

    }
}
