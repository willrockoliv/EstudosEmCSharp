using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        /*
         7.	Crie um método para somar 2 valores e devolver o resultado. 
         O método pode receber como parâmetro tanto valores inteiros como string. 
         Crie um programa teste para  testar as 2 chamadas.
         */

        static int Soma(int v1, int v2)
        {
            int soma = v1 + v2;
            return soma; 
        }

        static double Soma(string v1, string v2)
        {
            double soma;
            try
            {
                double valor1 = Convert.ToDouble(v1);
                double valor2 = Convert.ToDouble(v2);

                return soma = valor1 + valor2;
            }
            catch
            {
                Console.WriteLine("Valor inválido!");
                Console.ReadLine();
                return soma = 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("# Lendo string #");
            Console.Write("Digite o valor 1: ");
            string v1 = Console.ReadLine();
            Console.Write("Digite o valor 2: ");
            string v2 = Console.ReadLine();
            Console.WriteLine("Resultado: " + Soma(v1, v2));
            Console.ReadLine();
            Console.Clear();

            try
            {
                Console.WriteLine("# Lendo inteiros #");
            Console.Write("Digite o valor 1: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado: " + Soma(v1, v2));
            Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Valor inválido!");
                Console.ReadLine();
            }
        }
    }
}
