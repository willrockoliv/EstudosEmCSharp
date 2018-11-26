using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_26
{
    class Program
    {
        /*
         26.	Faça seu próprio Int.TryParse. 
            O seu método deverá receber um número no formato 
            string e uma variável de saída. 
            Retorne true se o valor informado for um inteiro válido 
            e false caso contrário, além de devolver por referência o 
            resultado da conversão.
 
         * */


        static bool MeuTryParse(string numero, out int valor)
        {
            try
            {
                valor = Convert.ToInt32(numero);
                return true;
            }
            catch
            {
                valor = 0;
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            string numero = Console.ReadLine();
            int convertido;
            if (MeuTryParse(numero, out convertido) == true)            
                Console.WriteLine("Consegui converter: {0} ", convertido);            
            else
                Console.WriteLine("Não Consegui converter!");

            Console.ReadLine() ;
        }
    }
}
