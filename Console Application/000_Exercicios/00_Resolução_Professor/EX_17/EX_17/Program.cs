using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             17.	Solicite o código, o salário e a data de nascimento de um aluno. 
             Caso ele digite valores incorretos, solicite-os novamente. 
             Utilize o controle de exceção. 
             Ao final, mostre os valores.
             */

            int codigo = 0;
            double salario = 0;
            DateTime nascimento = DateTime.Now;

            do
            {
                try
                {
                    Console.WriteLine("Digite o código do aluno");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!");
                }
            }
            while (codigo <= 0);


            bool correto = false;
            do
            {
                try
                {
                    Console.WriteLine("Digite o salário do aluno");
                    salario = Convert.ToDouble(Console.ReadLine());
                    correto = true;
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!");
                }
            }
            while (correto == false);



            correto = false;
            do
            {
                try
                {
                    Console.WriteLine("Digite a data de nascimento: ");
                    nascimento = Convert.ToDateTime(Console.ReadLine());
                    correto = true;
                }
                catch
                {
                    Console.WriteLine("Digite uma data válida!");
                }
            }
            while (correto == false);


            Console.WriteLine("\n\n\nRESUMO:\n\n\n");


            Console.WriteLine("Código: {0}", codigo);
            Console.WriteLine("Salário: {0:F2}", salario);
            Console.WriteLine("Data de nascimento: {0}", nascimento.ToString("dd/MM/yyyy"));


            Console.ReadLine();
        }
    }
}
