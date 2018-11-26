using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Ponteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int* p1; // cria uma variável que pode apontar para uma
                         //outra variável inteira
                int numero = 7;
                // &numero = endereço da variável numero
                p1 = &numero; // o ponteiro p1 vai apontar para o mesmo endereço
                              // que a variável numero
                              // *p1 -> valor armazenado no endereço apontado por p1
                Console.WriteLine("Variável número: {0} ponteiro: {1}", numero, *p1);
                Console.Write("\nDigite um valor para o ponteiro:");
                *p1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Variável número: {0} ", numero);
                Console.ReadLine();
            }
        }
    }
}
