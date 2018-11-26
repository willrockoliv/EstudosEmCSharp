using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EX_1
{
    class Program
    {
        /*
         2.	Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie até 10 jogos. Após efetuar os cadastros, exiba os dados em vídeo
        */
        static void Main(string[] args)
        {
            Jogo[] vetor = new Jogo[10];
            int qtde = 0;
            
            for (int n=0; n<10; n++)
            {
                qtde++;
                vetor[n] = new Jogo();

                Console.WriteLine("Digite o código do jogo: ");
                vetor[n].Codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do jogo: ");
                vetor[n].Nome = Console.ReadLine();

                Console.WriteLine("Digite a categoria do jogo: ");
                vetor[n].Categoria = Console.ReadLine();

                Console.WriteLine("Digite a data de lançamento do jogo: ");
                vetor[n].DataLancamento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Deseja continuar? <S/N> ");
                if (char.ToUpper(Console.ReadKey().KeyChar) != 'S')
                    break;
            }


            for (int n = 0; n < qtde; n++)
            {
                Jogo j = vetor[n];
                Console.WriteLine("Dados do Jogo: ");
                Console.WriteLine("Código: {0}", j.Codigo);
                Console.WriteLine("Nome: {0}", j.Nome);
                Console.WriteLine("Categoria: {0}", j.Categoria);
                Console.WriteLine("Data: {0}", j.DataLancamento.ToString("dd/MM/yyyy"));
            }

            Console.ReadLine();

        }
    }
}
