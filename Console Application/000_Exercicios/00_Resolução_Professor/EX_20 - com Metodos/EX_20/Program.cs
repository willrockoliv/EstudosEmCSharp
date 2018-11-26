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
            public int n1, n2;
            public double mensalidade;
        }

        static string LeString(string mensagem)
        {
            Console.WriteLine(mensagem);
            return Console.ReadLine();
        }

        static string LeTelefoneNaoCelular()
        {
            string telefone;
            do
            {
                telefone = LeString("Digite o telefone: ");
            }
            while (telefone.Length != 9 ||
                  telefone[0] == '7' ||
                  telefone[0] == '8' ||
                  telefone[0] == '9' ||
                  telefone[0] == '0' ||
                  telefone[4] != '-');

            return telefone;
        }

              
        static string LeNome()
        {
            string nome;
            do
            {
                nome = LeString("Digite o nome: ");
            }
            while (nome.Length == 0);
            return nome;
        }
         
        static int LeInteiro(string mensagem)
        {
            int numero = 0;
            bool correto = false;
            do
            {
                try
                {                    
                    numero = Convert.ToInt32( LeString(mensagem) );
                    correto = true;                    
                }
                catch
                {
                    Console.WriteLine("Número inválido!");
                }
            }
            while (!correto);
            return numero;
        }


        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.nome = LeNome();
            aluno.telefone = LeTelefoneNaoCelular();          
                        
            do
            {       
                aluno.idade = LeInteiro("Digite a idade: ");
            }
            while (aluno.idade < 0 || aluno.idade > 150);


            aluno.n1 = LeInteiro("Digite a nota N1");
            aluno.n2 = LeInteiro("Digite a nota N2");

            bool correto = false;
            do
            {
                try
                {
                    Console.WriteLine("Digite a mensalidade: ");
                    aluno.mensalidade = Convert.ToDouble(Console.ReadLine());
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
