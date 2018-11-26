using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-) Implemente na classe da pilha dinâmica um método para retornar um string com todos os elementos empilhados.
               Você pode separar os elementos com um “-“.
            */      

            Pilha pilha = new Pilha();
            int op;

            do
            {
                Console.WriteLine(" 1) Empilhar \n 2) Desempilhar \n 3) Tamanho \n 4) Retorna Topo \n 5) Retorna Todos \n 6) Sair");
                op = Convert.ToInt16(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Valor: ");
                    pilha.Empilhar(Console.ReadLine());
                }
                else if (op == 2)
                {
                    try
                    {
                        Console.WriteLine(pilha.Desempilhar());
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Quantidade: " + pilha.Quantidade.ToString());
                }
                else if (op == 4)
                {
                    try
                    {
                        Console.WriteLine("Topo: " + pilha.RetornaTopo());
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
                else if (op == 5)
                {
                    try
                    {
                        Console.WriteLine(pilha.RetornaTodos());
                    }
                    catch(Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
            }
            while (op != 6);
        }
    }
}
