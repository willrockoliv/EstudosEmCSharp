using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    class Program
    {
        /*
        20.	Sistema Acadêmico
        Faça um programa que solicite os seguintes dados de um aluno: nome, telefone, idade, valor da mensalidade. 
        Ao final do programa, exiba os dados cadastrados. 
        Validações: 
        Nome deve ser preenchido, telefone deve ter exatamente 9 dígitos (contando o “-“)
        O primeiro dígito do celular não pode iniciar com 7,8 ou 9
        Idade deve estar entre 0 e 150 
        mensalidade deve ser >= 0.
        */

        struct Aluno
        {
            public string nome, telefone;
            public int idade;
            public double mensalidade;
        }

        static bool ok=true;

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

        static string LeTelefone()
        {
            string telefone;
            do
            {
                Console.Write("\n Telefone ou celular: ");
                telefone = Console.ReadLine();
            }
            while (telefone == "");
            return telefone;
        }

        static bool ValidaTelefone(string telefone)
        {
            bool ok = true;
            if (telefone.Replace("-", "").Length != 8)
            {
                Console.WriteLine("\n Número inválido");
                ok = false;
            }
            else if (telefone[0] == '7' ||
                     telefone[0] == '8' ||
                     telefone[0] == '9')
            {
                Console.WriteLine("\n O número não pode iniciar com {0}", telefone[0]);
                ok = false;
            }
            else if (telefone[4] != '-')
            {
                Console.WriteLine("\n Formato Inválido (xxxx-xxxx)");
                ok = false;
            }
            else
            {
                try
                {
                    Convert.ToInt64(telefone.Replace("-", ""));                    
                }
                catch
                {
                    Console.WriteLine("\n Número inválido");
                    ok = false;
                }
            }

            return ok;
        }

        static int LeIdade()
        {
            int idade=0;
            ok = false;
            do
            {
                try
                {
                    Console.Write("\n Idade: ");
                    idade = Convert.ToInt16(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("\n A idade deve ser um número inteiro");
                }
            }
            while (idade <= 0 || idade >= 150 || ok == false);
            return idade;
        }

        static double LeMensalidade()
        {
            double mensalidade=0;
            do
            {
                try
                {
                    Console.Write("\n Mensalidade: R$");
                    mensalidade = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\n Apenas valores positivos");
                }
            }
            while (mensalidade < 0);
            return mensalidade;
        }

        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine(" Dados do aluno ");

            aluno.nome = LeNome();
            do
            {
                aluno.telefone = LeTelefone();
                ok = ValidaTelefone(aluno.telefone);
            }
            while (ok == false);

            aluno.idade = LeIdade();

            aluno.mensalidade = LeMensalidade();



            Console.Clear();
            Console.WriteLine("\n << DADOS DO ALUNO >> \n Nome: {0} \n Telefone: {1} \n Idade: {2} \n Mensalidade: R${3:f2}",
                              aluno.nome,aluno.telefone,aluno.idade,aluno.mensalidade);
            Console.ReadLine();
        }
    }
}
