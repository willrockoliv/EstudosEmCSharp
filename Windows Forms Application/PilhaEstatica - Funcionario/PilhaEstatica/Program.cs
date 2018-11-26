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
            Pilha minhaPilha = new Pilha(); // cria uma instância da classe pilha!
            Funcionario f;

            do
            {
                try
                {
                    Console.Write("\n\n Escolha: 1-> empilha 2->desempilha " +
                    " 3->topo 4-> tamanho 5-> Listar  6-> Soma dos salários  7->Remover a base   9-> sair : ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        f = new Funcionario();
                        Console.Write(">>Digite o nome: ");
                        f.Nome = Console.ReadLine();

                        Console.Write(">>Digite o salário: ");
                        f.Salario = Convert.ToDouble(Console.ReadLine());
                        minhaPilha.Empilha(f);
                    }
                    else if (opcao == 2)
                    {
                        f = minhaPilha.Desempilha();
                        Console.WriteLine(">>Desempilhado: {0} {1} \n\n", f.Nome, f.Salario );                        
                    }
                    else if (opcao == 3)
                    {
                        //valor = minhaPilha.RetornaTopo();
                        Console.WriteLine(">>Topo: {0} {1} \n\n",
                             minhaPilha.RetornaTopo().Nome,
                             minhaPilha.RetornaTopo().Salario);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine(">>Tamanho da pilha: {0}", minhaPilha.Tamanho());
                    }
                    else if (opcao == 5)
                    {
                        Pilha pilhaAux = new Pilha();
                        while (minhaPilha.Tamanho() > 0 )
                        {
                            Console.WriteLine("{0} {1}",
                             minhaPilha.RetornaTopo().Nome,
                             minhaPilha.RetornaTopo().Salario);

                            pilhaAux.Empilha(minhaPilha.Desempilha());
                        }

                        while (pilhaAux.Tamanho() > 0)
                            minhaPilha.Empilha(pilhaAux.Desempilha());
                    }
                    else if (opcao == 6)
                    {
                        double soma = 0;
                        Pilha pilhaAux = new Pilha();
                        while (minhaPilha.Tamanho() > 0)
                        {
                            soma = soma + minhaPilha.RetornaTopo().Salario;
                            pilhaAux.Empilha(minhaPilha.Desempilha());
                        }

                        while (pilhaAux.Tamanho() > 0)
                            minhaPilha.Empilha(pilhaAux.Desempilha());

                        Console.WriteLine("Soma: {0}", soma);
                    }
                    else if (opcao == 7)
                    {                        
                        Pilha pilhaAux = new Pilha();
                        while (minhaPilha.Tamanho() > 1)                                                    
                            pilhaAux.Empilha(minhaPilha.Desempilha());
                        
                        Console.WriteLine(">>Base: {0} {1} \n\n",
                             minhaPilha.RetornaTopo().Nome,
                             minhaPilha.RetornaTopo().Salario);

                        minhaPilha.Desempilha();

                        while (pilhaAux.Tamanho() > 0)
                            minhaPilha.Empilha(pilhaAux.Desempilha());                        
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
