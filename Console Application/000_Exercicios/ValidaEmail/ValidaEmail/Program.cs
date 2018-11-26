using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaEmail
{
    class Program
    {
        /*
        8.	Valida E-mail
        Faça um método cujo objetivo é validar um e-mail informado via parâmetro. 
        Ela deverá retornar TRUE se o e-mail for válido ou FALSE caso contrário. 
        Um e-mail válido é aquele que possui um @ (arroba) e um . (ponto) em seu conteúdo, 
        mas não inicia ou termina com eles.
        */

        static bool ValidaEmail(string email)
        {
            int arroba, ponto;

            arroba = email.IndexOf('@');
            ponto = email.IndexOf('.');

            if (arroba == 0 || arroba == -1 || ponto == -1 || ponto == 0)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o E-mail: ");
            string email = Console.ReadLine();

            if (ValidaEmail(email) == true)
                Console.WriteLine("Email Válido!");
            else
                Console.WriteLine("Email Inválido!");

            Console.ReadLine();
        }
    }
}
