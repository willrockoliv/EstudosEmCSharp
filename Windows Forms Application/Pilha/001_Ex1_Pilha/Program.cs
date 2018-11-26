using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Ex1_Pilha
{
    class Program
    {
        static void Reempilhar(Funcionario[] f2, Pilha p)
        {
            for (int j = 0; j < 5; j++)
            {
                p.Empillhar(f2[j]);
            }
        }

        static double SomaSalarios(Funcionario[] f2, Pilha p)
        {
            double totalSalario = 0;

            for (int i = 0; i < 5; i++)
            {
                f2[i] = p.Desempilhar();

                totalSalario = totalSalario + f2[i].Salario;

                if (i == 4)
                {
                    Reempilhar(f2, p);
                }
            }

            return totalSalario;
        }

        static void Listar(Pilha p)
        {
            Console.Clear();

            Funcionario[] f2 = new Funcionario[5];

            for (int i = 0; i < 5; i++)
            {
                f2[i] = p.Desempilhar();
                if (f2[i] != null)
                {
                    string nome = f2[i].Nome;
                    double salario = f2[i].Salario;

                    Console.WriteLine("\n {0} - R$ {1:F2}", nome, salario);

                    if (i == 4)
                    {
                        Reempilhar(f2, p);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Pilha p = new Pilha();
            double totalSalario = 0;

            do
            {
                try
                {
                    Console.Clear();

                    Funcionario f = new Funcionario();

                    Console.Write("\n #{0} \n\n Nome: ", p.Tamanho());
                    f.Nome = Console.ReadLine();

                    Console.Write("\n\n Salário: ");
                    f.Salario = Convert.ToDouble(Console.ReadLine());

                    p.Empillhar(f);
                }
                catch(Exception erro)
                {
                    Console.WriteLine("Erro: " + erro.Message);
                    Console.ReadLine();
                }
            }
            while (p.Tamanho() != 5);

            Funcionario[] f2 = new Funcionario[5];

            totalSalario = SomaSalarios(f2, p);

            Listar(p);

            Console.WriteLine("\n TOTAL SALÁRIOS: R${0:F2}", totalSalario);

            Console.ReadLine();



            /*
            for (int i = 0; i < 5; i++)
            {
                f2[i] = p.Desempilhar();

                totalSalario = totalSalario + f2[i].Salario;

                if (i == 4)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        p.Empillhar(f2[j]);
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                f2[i] = p.Desempilhar();
                string nome = f2[i].Nome;
                double salario = f2[i].Salario;

                Console.WriteLine("\n {0} - R$ {1:F2}", nome, salario);
            }

            Console.WriteLine("\n TOTAL SALÁRIOS: R${0:F2}", totalSalario);

            Console.ReadLine();
            */
        }
    }
}
