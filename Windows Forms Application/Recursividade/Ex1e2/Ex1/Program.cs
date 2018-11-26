using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        /*
         * Teste de mesa
         * 
         * b = 2, e = 3
         * 
         * R = 2 * CalculaPotencia( 2, [3-1 = 2]) = 8
         *         R = 2 * CalculaPotencia( 2, [2-1 = 1]) = 4
         *             R = 2 * ClculaPotencia( 2, [1-1 = 0]) = 2
         *                 R = 1
        */


        static int CalculaPotencia(int b, int e)
        {
            if (e == 0)
                return 1;
            else
            {
                return b * CalculaPotencia(b, e - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite a base: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Resultado: " + Convert.ToString(CalculaPotencia(b, e)));
            Console.ReadLine();
        }
    }
}
