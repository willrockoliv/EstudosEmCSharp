using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void PA(int x, int r, int n)
        {
            Console.WriteLine(x);

            for (int i = 0; i < n; i++)
            {
                x += r;
                Console.WriteLine(x);
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

            PA(x, r, n);

            Console.ReadLine();
        }
    }
}
