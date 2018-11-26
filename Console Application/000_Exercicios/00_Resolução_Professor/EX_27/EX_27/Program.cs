using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_27
{
    class Program
    {

        static bool ValidaCPF(string CPF, out string cpfFormatado)
        {
            cpfFormatado = string.Empty; 
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)            
                return false;            

            int soma = 0;
            int num = 10;

            for (int pos = 0; pos <= 8; pos++)
            {
                soma += Convert.ToInt32(CPF[pos].ToString()) * num;
                num--;
            }

            int resultado = soma % 11;
            int digito1;

            if (resultado == 0 || resultado == 1)
                digito1 = 0;
            else
                digito1 = 11 - resultado;
            
            soma = 0;
            num = 11;

            for (int pos = 0; pos <= 8; pos++)
                soma += Convert.ToInt32(CPF[pos].ToString()) * num--;

            soma += digito1 * 2;

            resultado = soma % 11;
            int digito2;

            if (resultado == 0 || resultado == 1)
                digito2 = 0;
            else
                digito2 = 11 - resultado;

            if (CPF[9].ToString() == digito1.ToString() &&
                CPF[10].ToString() == digito2.ToString())
            {
                cpfFormatado = CPF.Substring(0, 3) + "." +
                               CPF.Substring(3, 3) + "." +
                               CPF.Substring(6, 3) + "-" +
                               CPF.Substring(9, 2);

                return true;
            }
            else
                return false;
        }


        static void Main(string[] args)
        {

            string cpf = Console.ReadLine();
            string cpfformatado;
            if (ValidaCPF(cpf, out cpfformatado))
                Console.WriteLine("CPF válido: " + cpfformatado);
            else
                Console.WriteLine("inválido");

            Console.ReadLine();

        }
    }
}
