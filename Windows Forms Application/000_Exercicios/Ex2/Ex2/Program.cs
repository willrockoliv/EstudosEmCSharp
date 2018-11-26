using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor;
            FilaCircularEstatica minhafila = new FilaCircularEstatica();
            Console.WriteLine("Sistema em C# para testar a execução de uma fila circular\n");
            do
            {
                try
                {
                    Console.WriteLine("\n\nDigite: 1->Enfileirar 2->Desenfileirar " +
                    "3-> Tamanho 4->Retorna Inicio 5->Retorna Fim 9->Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar:");
                            valor = Console.ReadLine();
                            minhafila.Enfileirar(valor);
                            break;
                        case "2":
                            Console.WriteLine("Desenfileirado: {0}", minhafila.Desenfileira());
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila:{0}", minhafila.Tamanho());
                            break;
                        case "4":
                            Console.WriteLine("Inicio: " + minhafila.RetornaInicio());
                            break;
                        case "5":
                            Console.WriteLine("Fim: " + minhafila.Retornafim());
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
