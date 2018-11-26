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
            int n = 0;
            do
            {
                try
                {
                    Console.WriteLine("Digite um numero: ");
                    n = Convert.ToInt16(Console.ReadLine());
                    if (n > 0)
                    {
                        Tabuada(n);
                        Console.ReadLine();
                    }
                    else
                        Console.WriteLine("Digite apenas números positivos.");
                }
                catch
                {
                    Console.WriteLine("Digite apenas números.");
                }
            }
            while (n <= 0);

        }
    }
}
