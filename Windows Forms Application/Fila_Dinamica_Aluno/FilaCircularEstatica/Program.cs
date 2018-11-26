using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilaCircularEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Fila minhafila = new Fila();
            Console.WriteLine("Sistema em C# para testar a execução de uma fila circular\n");
            do
            {
                try
                {
                    Console.WriteLine("\n\nDigite: 1->Enfileirar 2->Desenfileirar " +

                    "3-> Tamanho   4-> Listar Fila 9->Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":                            
                            Console.Write("Digite o ra do aluno: ");
                            int ra = int.Parse(Console.ReadLine());

                            Console.Write("Digite o nome do aluno: ");
                            string nome = Console.ReadLine();

                            Aluno a = new Aluno(ra, nome);                            
                            
                            minhafila.enfileirar(a);
                            break;
                        case "2":
                            Aluno meuAluno = minhafila.desenfileira();
                            Console.WriteLine("Desenfileirado: {0} - {1}",  meuAluno.Ra, meuAluno.Nome);
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila:{0}", minhafila.tamanho());
                            break;
                        case "4":
                            Console.WriteLine(minhafila.Listagem());
                            break;
                        case "9":
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!!!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != "9");
        }
    }
}
