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

        struct RetornoCadastro
        {
            public Funcionario[] vetor;
            public int qtde;
        }


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


        static double MenorSalario(RetornoCadastro dados)
        {
            double menor = dados.vetor[0].salario;
            for (int n = 1; n < dados.qtde; n++)
            {
                if (dados.vetor[n].salario < menor)
                    menor = dados.vetor[n].salario;
            }
            return menor;
        }

        static double MaiorSalario(Funcionario[] funcionarios, int qtde)
        {
            double maior = funcionarios[0].salario;
            for (int n = 1; n < qtde; n++)
            {
                if (funcionarios[n].salario > maior)
                    maior = funcionarios[n].salario;
            }
            return maior;
        }

        static double Soma(Funcionario[] funcionarios, int qtde)
        {
            double soma = 0;
            for (int n = 0; n < qtde; n++)                            
                    soma += funcionarios[n].salario;            
            return soma;
        }


        static RetornoCadastro PreencheFuncionarios()
        {
            RetornoCadastro retorno = new RetornoCadastro();

            retorno.vetor = new Funcionario[30];
            retorno.qtde = 0;

            for (int n = 0; n < retorno.vetor.Length; n++)
            {
                retorno.qtde++;
                retorno.vetor[n] = new Funcionario();
                retorno.vetor[n].nome = LeNome();
                retorno.vetor[n].salario = LeSalario();
                if (TestaSaida() == true)
                    break;
            }
            return retorno;
        }


        static void Main(string[] args)
        {
            RetornoCadastro retorno = PreencheFuncionarios();            

            Console.WriteLine("\n\nEstatísticas\n\n\n");
            Console.WriteLine("Menor salário: {0}", MenorSalario(retorno));
            Console.WriteLine("Maior salário: {0}", MaiorSalario(retorno.vetor, retorno.qtde));
            Console.WriteLine("Soma dos salários: {0}", Soma(retorno.vetor, retorno.qtde));
            Console.WriteLine("Média dos salários: {0}", Soma(retorno.vetor, retorno.qtde) / retorno.qtde);

            Console.ReadLine();
        }
    }
}
