using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3_Recursividade
{
    class Program
    {
        static void Tabuada(int numero, int contador)
        {
            if (contador <=10)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, contador, numero * contador);
                Tabuada(numero, contador + 1);
            }
        }
        
        static void Main(string[] args)
        {
            /*
            Faça um programa para imprimir a tabuada, usando recursividade
            */
            Tabuada(7, 0);
            Console.ReadLine();

        }
    }
}
