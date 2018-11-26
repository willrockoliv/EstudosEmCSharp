using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
        struct Funcionario
        {
            public string nome;
            public double salario;            
        }

        static bool ok = true;

        static string LeNome()
        {
            string nome;

            do
            {
                Console.Write("\n Nome: ");
                nome = Console.ReadLine();
            }
            while (nome == "");

            return nome;
        }

        static double LeSalario()
        {
            double salario=0;

            ok = false;
            do
            {
                try
                {
                    Console.Write("\n Salário: R$ ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("\n Dado Inválido!");
                }
            }
            while (ok == false);

            return salario;
        }

        static double MaiorMenorSoma(double salario)
        {
            double maior=0, menor=0, soma=0;
            if (salario > maior)
                maior = salario;
            else if (salario < menor)
                menor = salario;
            soma = soma + salario;

            return maior;
            return menor;
            return soma;
        }

        static void Main(string[] args)
        {
            /*
            21.Funcionários
            Faça um programa que armazene até 30 funcionários, guardando o nome e o salário. 
            Ao final, exiba:  O maior salário, o menor salário, a soma dos salários e a média salarial.
            */
            Funcionario[] funcionario = new Funcionario[30];
            
            Console.WriteLine(" << Dados Funcionários >>");

            char sair;
            double maior=0, menor=0;

            for(int i=0; i <= funcionario.Length; i++)
            {
                funcionario[i].nome = LeNome();
                funcionario[i].salario = LeSalario();

                MaiorMenorSoma(funcionario[i].salario);

                Console.WriteLine("\n Deseja Continuar? (S/N) > ");
                sair = Console.ReadKey().KeyChar;

                if (Char.ToUpper(sair) == 'S')
                    break;
            }



        }
    }
}
