using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();

            string ExisteMaiusculo = "Nao";

            for (int n = 0; n < texto.Length; n++)
            {
                if (texto[n] == texto.ToUpper()[n])
                {
                    ExisteMaiusculo = "Sim";
                    break;
                }
            }

            if (ExisteMaiusculo == "Sim")
                Console.WriteLine("Existe letra maiúscula");
            else             
                Console.WriteLine("Não existe letra maiúscula");            

            Console.ReadLine();

        }
    }
}
