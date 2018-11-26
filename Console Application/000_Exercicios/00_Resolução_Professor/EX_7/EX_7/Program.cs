using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_7
{
    /*
        7.	Verifica Espaço
        Faça um método cujo objetivo é verificar 
        se existe espaco (' ') em um texto 
        informado via parâmetro. 
        Ela deverá retornar True se houver espaço e 
        False se não houver. 
        Faça o programa principal para testar esta 
        function.      
     */
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        static Boolean TemEspaco(string texto)
        {
            foreach (char letra in texto)
                if (letra == ' ')
                    return true;

            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um texto: ");
            //string a = Console.ReadLine();
            //if (TemEspaco(a))
            if (TemEspaco(Console.ReadLine()) == true)
                Console.WriteLine("Tem espaço!");
            else
                Console.WriteLine("NÃO Tem espaço!");
            Console.ReadLine();
        }
    }
}
