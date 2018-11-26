using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_8
{
    class Program
    {

        static bool ValidaEmail(string email)
        {
            int posicaoSegundoArroba = -1;

            if (email.IndexOf('@') > 0)
            {
                //posicaoSegundoArroba = email.Substring(email.IndexOf('@') + 1).IndexOf("@");
                posicaoSegundoArroba = email.IndexOf('@', email.IndexOf('@') + 1);
            }
            if (email.Length >= 5 &&
                email.IndexOf('.') > 0 &&
                email.IndexOf('@') > 0 &&
                email.IndexOf('@') != email.Length - 1 &&
                email.IndexOf('.') != email.Length - 1 &&
                posicaoSegundoArroba == -1)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {

            /*
             8.	Valida E-mail
            Faça um método cujo objetivo é validar um 
            e-mail informado via parâmetro. Ela deverá retornar 
            TRUE se o e-mail for válido ou FALSE caso contrário. 
            Um e-mail válido é aquele que possui um @ (arroba) e um . 
            (ponto) em seu conteúdo, mas não inicia ou termina com eles.
            */


            Console.WriteLine("Digite um email: ");
            string email = Console.ReadLine();

            if (ValidaEmail(email))
                Console.WriteLine("Válido!");
            else
                Console.WriteLine("inVálido!");

            Console.ReadLine();
        }
    }
}
