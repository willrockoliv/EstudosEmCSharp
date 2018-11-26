using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static int PA(int x, int r, int n, int cont)
        {
            if(cont == n)
            {
                return x;
            }
            else
            {
                Console.WriteLine(x);
                return PA(x + r, r, n, ++cont);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Informe o número inicial: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a razão: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o número de sequenciais: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Convert.ToString(PA(x, r, n, 0)));

            Console.ReadLine();
        }
    }
}
