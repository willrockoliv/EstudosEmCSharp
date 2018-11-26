using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valor;
            Pilha minhaPilha = new Pilha(); // cria uma instância da classe pilha!
            do
            {
                try
                {
                    Console.Write("\n\n Escolha: 1-> empilha 2->desempilha " +
                    " 3->topo 4-> tamanho 9-> sair : ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.Write(">>Digite o valor que deseja empilhar: ");
                        valor = Console.ReadLine();
                        minhaPilha.Empilha(valor);
                    }
                    else if (opcao == 2)
                    {
                        valor = minhaPilha.Desempilha();
                        Console.WriteLine(">>Desempilhado: {0} \n\n", valor);
                    }
                    else if (opcao == 3)
                    {
                        valor = minhaPilha.RetornaTopo();
                        Console.WriteLine(">>Valor no topo: {0} \n\n", valor);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine(">>Tamanho da pilha: {0}", minhaPilha.Tamanho());
                    }
                    else if (opcao == 9)
                    {
                        // sai do programa
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO: " + erro.Message);
                }
            }
            while (opcao != 9);
        }
    }
}
