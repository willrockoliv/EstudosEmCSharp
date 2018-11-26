using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static int TabuadaRecursiva(int multiplicando, int multiplicador)
        {
            if (multiplicador == 10)
                return multiplicador * multiplicando;
            else
            {
                Console.WriteLine(" {0} x {1} = {2}", multiplicador, multiplicando, multiplicador * multiplicando);
                return TabuadaRecursiva(multiplicando, multiplicador + 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o número que deseja a tabuada: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" {0} x {1} = {2}", 10, x, TabuadaRecursiva(x, 0));
            Console.ReadLine();
        }
    }
}
