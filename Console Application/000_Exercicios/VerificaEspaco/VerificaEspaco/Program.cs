using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaEspaco
{
    class Program
    {
        /*
        7.	Verifica Espaço
        Faça um método cujo objetivo é verificar se existe espaco (' ') em um texto informado via parâmetro. 
        Ela deverá retornar True se houver espaço e False se não houver. Faça o programa principal para testar esta function.
        */

        static bool VerificaEspaco(string texto)
        {
            if (texto.IndexOf(' ') == -1)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o texto desejado: ");
            string texto = Console.ReadLine();

            if (VerificaEspaco(texto) == true)
                Console.WriteLine("Existe espaço.");
            else
                Console.WriteLine("Não existe espaço.");

            Console.ReadLine();
        }
    }
}
