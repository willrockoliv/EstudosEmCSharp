using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_20
{
    class Program
    {

        /*
         20.	Sistema Acadêmico
        Faça um programa que solicite os seguintes dados de um aluno:
        nome, telefone, idade, valor da mensalidade. 
        Ao final do programa, exiba os dados cadastrados. 
        Validações: 
        Nome deve ser preenchido, 
        telefone deve ter exatamente 9 dígitos (contando o “-“)
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

        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            do
            {
                Console.WriteLine("Digite o nome: ");
                aluno.nome = Console.ReadLine();
            }
            while (aluno.nome.Length == 0);


            do
            {
                Console.WriteLine("Digite o telefone: ");
                aluno.telefone = Console.ReadLine();
            }
            while (aluno.telefone.Length != 9 ||
                   aluno.telefone[0] == '7' ||
                   aluno.telefone[0] == '8' ||
                   aluno.telefone[0] == '9' ||
                   aluno.telefone[0] == '0' ||
                   aluno.telefone[4] != '-');


            bool correto = false;
            do
            {
                try
                {
                    Console.WriteLine("Digite a idade: ");
                    aluno.idade = Convert.ToInt32(Console.ReadLine());
                    correto = (aluno.idade >= 0 && aluno.idade <= 150);                       
                }
                catch
                {
                    Console.WriteLine("Digite a idade válida");
                }
            }
            while (!correto);



            correto = false;
            do
            {
                try
                {
                    Console.WriteLine("Digite a mensalidade: ");
                    aluno.mensalidade = Convert.ToDouble (Console.ReadLine());
                    correto = aluno.mensalidade >= 0;
                }
                catch
                {
                    Console.WriteLine("Digite a mensalidade válida");
                }
            }
            while (!correto);


            Console.WriteLine("\n\nDados gravados: \n\n");
            Console.WriteLine("Nome: {0} ", aluno.nome);
            Console.WriteLine("Telefone: {0} ", aluno.telefone);
            Console.WriteLine("Idade: {0} ", aluno.idade);
            Console.WriteLine("Mensalidade: {0} ", aluno.mensalidade);

            Console.ReadLine();
        }
    }
}
