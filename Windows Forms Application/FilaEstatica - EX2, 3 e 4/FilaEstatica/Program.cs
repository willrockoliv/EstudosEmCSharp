using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {            
            string opcao = "", valor;
            Fila minhafila = new Fila();
            Console.WriteLine("Sistema em C# para testar a execução de uma fila circular\n");
            do
            {
                try
                {
                    Console.WriteLine("\n\nDigite: 1->Enfileirar 2->Desenfileirar " +
                    "3-> Tamanho  4-> Inicio  5-> Fim  6-> Listar  7-> Inverter  9->Sair");
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
                            Console.WriteLine("Início da fila:{0}", minhafila.RetornaInicio());
                            break;
                        case "5":
                            Console.WriteLine("Fim da fila:{0}", minhafila.RetornaFim());
                            break;
                        case "6":
                            Console.WriteLine("Fila: {0}", minhafila.Listar());
                            break;
                        case "9":
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        case "7":
                            Console.WriteLine("De ... " + minhafila.Listar());
                            
                            Pilha pilhaAux = new Pilha();
                            while (minhafila.Tamanho() > 0)
                                pilhaAux.Empilha(minhafila.Desenfileira());

                            while (pilhaAux.Tamanho() > 0)
                                minhafila.Enfileirar(pilhaAux.Desempilha());

                            Console.WriteLine("Para... {0}", minhafila.Listar());
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
