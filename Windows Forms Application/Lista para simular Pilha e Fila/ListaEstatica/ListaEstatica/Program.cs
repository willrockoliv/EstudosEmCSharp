using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            Console.WriteLine("Digite : 1-> Lista  2-> Pilha  3-> Fila");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                TestaLista();
            }
            else if (opcao == "2")
            {
                TestaPilha();
            }
            else if (opcao == "3")
            {
                TestaFila();
            }
        }



        #region lista

        public static void TestaLista()
        {
            string opcao = "", valor;
            int posicao;
            Lista minhaLista = new Lista();
            Console.WriteLine("Sistema em C# para testar a execução de uma lista estática\n");
            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Inserir no início \n 2-> Inserir no fim \n" +
                    "3-> Inserir em uma posição \n 4-> Tamanho \n 5-> Listar \n " +
                    "6-> Remover elemento de uma posição \n 9-> Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para inserir no início:");
                            valor = Console.ReadLine();
                            minhaLista.insereNoInicio(valor);
                            break;
                        case "2":
                            Console.WriteLine("Digite um valor para inserir no fim:");
                            valor = Console.ReadLine();
                            minhaLista.insereNoFim(valor);
                            break;
                        case "3":
                            Console.WriteLine("Digite um valor para inserir:");
                            valor = Console.ReadLine();
                            Console.WriteLine("Digite a posição:");
                            posicao = Convert.ToInt32(Console.ReadLine());
                            minhaLista.insereNaPosicao(posicao, valor);
                            break;
                        case "4":
                            Console.WriteLine("Tamanho da lista:{0}", minhaLista.tamanho());
                            break;
                        case "5":
                            minhaLista.imprimeLista();
                            break;
                        case "6":
                            Console.WriteLine("Digite a posição que deseja remover:");
                            posicao = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Removido: {0} ", minhaLista.removeDaPosicao(posicao));
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
        
        #endregion




        public static void TestaPilha()
        {
            string opcao = "", valor;            
            Pilha pilha = new Pilha();
            Console.WriteLine("Sistema em C# para testar a execução de uma pilha estática\n");
            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Empilhar  \n 2-> Desempilhar \n" +
                    "3-> Tamanho \n 9-> Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para empilhar:");
                            valor = Console.ReadLine();
                            pilha.Empilha(valor);
                            break;
                        case "2":
                            valor = pilha.Desempilha();
                            Console.WriteLine("Desempilhado: " + valor);
                            break;                        
                        case "3":
                            Console.WriteLine("Tamanho da pilha:{0}", pilha.Tamanho());
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






        public static void TestaFila()
        {
            string opcao = "", valor;
            Fila fila = new Fila();
            Console.WriteLine("Sistema em C# para testar a execução de uma fila estática\n");
            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Enfileirar  \n 2-> Desenfileirar \n" +
                    "3-> Tamanho \n 9-> Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar:");
                            valor = Console.ReadLine();
                            fila.Enfileira(valor);
                            break;
                        case "2":
                            valor = fila.Desenfileira();
                            Console.WriteLine("Desenfileirado: " + valor);
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila:{0}", fila.Tamanho());
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
