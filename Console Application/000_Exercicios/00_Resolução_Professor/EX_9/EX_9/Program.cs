using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    class Program
    {
        /*
         9.	Tabuada
            Faça um método void que imprima a 
            tabuada de um número. 
            Faça o programa principal para testá-la. 
         */

        static void Tabuada(int numero)
        {
            for (int n = 1; n <= 10; n++)
                Console.WriteLine($"{numero}x{n}={numero * n}");
        }

        static void Main(string[] args)
        {
            Tabuada(7);
            Console.ReadLine();
        }
    }
}
