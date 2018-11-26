using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_21
{
    class Program
    {

        /*
         21.	Funcionários
                Faça um programa que armazene até 30 funcionários, 
                guardando o nome  e o salário. 
                Ao final, exiba:  O maior salário, o menor salário, 
                a soma dos salários e a média salarial.
         */

        struct Funcionario
        {
            public string nome;
            public double salario;
        }

        static int qtde = 0;
        

        static double LeSalario()
        {
            double salario = 0;
            do
            {
                try
                {
                    Console.WriteLine("Digite o salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.Write("\nDigite apenas números.");
                }
            }
            while (salario <= 0);

            return salario;
        }

        static string LeNome()
        {
            Console.WriteLine("\nDigite o nome: ");
            return Console.ReadLine();
        }

        static bool TestaSaida()
        {
            Console.Write("\n\nDeseja sair? <s/n> ");
            char resp = char.ToUpper(Console.ReadKey().KeyChar);

            /*if (resp == 'S')
                return true;
            else return false; */
            return resp == 'S';
        }


        static double MenorSalario(Funcionario[] funcionarios)
        {
            double menor = funcionarios[0].salario;
            for (int n = 1; n < qtde; n++)
            {
                if (funcionarios[n].salario < menor)
                    menor = funcionarios[n].salario;
            }

            return menor;
        }

        static double MaiorSalario(Funcionario[] funcionarios)
        {
            double maior = funcionarios[0].salario;
            for (int n = 1; n < qtde; n++)
            {
                if (funcionarios[n].salario > maior)
                    maior = funcionarios[n].salario;
            }
            return maior;
        }

        static double Soma(Funcionario[] funcionarios)
        {
            double soma = 0;
            for (int n = 0; n < qtde; n++)                            
                    soma += funcionarios[n].salario;            
            return soma;
        }


        static Funcionario[] PreencheFuncionarios()
        {
            Funcionario[] vetor = new Funcionario[30];            
            for (int n = 0; n < vetor.Length; n++)
            {
                qtde++;
                vetor[n] = new Funcionario();
                vetor[n].nome = LeNome();
                vetor[n].salario = LeSalario();
                if (TestaSaida() == true)
                    break;
            }
            return vetor;
        }


        static void Main(string[] args)
        {
            Funcionario[] vetor = PreencheFuncionarios();

            Console.WriteLine("\n\nEstatísticas\n\n\n");
            Console.WriteLine("Menor salário: {0}", MenorSalario(vetor));
            Console.WriteLine("Maior salário: {0}", MaiorSalario(vetor));
            Console.WriteLine("Soma dos salários: {0}", Soma(vetor));
            Console.WriteLine("Média dos salários: {0}", Soma(vetor) / qtde);

            Console.ReadLine();
        }
    }
}
