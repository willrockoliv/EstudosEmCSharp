using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_Ref_Out
{
    class Program
    {
        static void ValidaInteiro(string num, out int inteiro, out bool ok)
        {
            if (int.TryParse(num, out inteiro))
            {
                ok = true;
            }
            else
                ok = false;
        }

        static void Main(string[] args)
        {
            /*
            26.	Faça seu próprio Int.TryParse. 
            O seu método deverá receber um número no formato string e uma variável de saída.
            Retorne true se o valor informado for um inteiro válido e false caso contrário, 
            além de devolver por referência o resultado da conversão.
            */

            string num = "";
            int inteiro;
            bool ok;

            Console.Write("Digite o número: ");
            num = Console.ReadLine();
            ValidaInteiro(num, out inteiro, out ok);
            Console.Write(ok);
            Console.ReadLine();
        }
    }
}
