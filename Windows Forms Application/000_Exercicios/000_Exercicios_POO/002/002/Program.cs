using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo[] a = new Jogo[10];
            int cont = 0;
            char sair;

            do
            {
                a[cont] = new Jogo();

                Console.WriteLine("#" + cont + "\n");

                Console.Write("Informe o código: ");
                a[cont].codigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o nome: ");
                a[cont].nome = Console.ReadLine();

                Console.Write("Informe a categoria: ");
                a[cont].categoria = Console.ReadLine();

                Console.Write("Informe a data de lançamento: ");
                a[cont].data_lanc = Convert.ToDateTime(Console.ReadLine());

                if (cont == 9)
                    break;

                Console.Write("Deseja cadastra mais algum jogo? (S/N): ");
                sair = Console.ReadKey().KeyChar;

                if (Char.ToUpper(sair) == 'S')
                    cont++;

                Console.Clear();
            }
            while (Char.ToUpper(sair) == 'S');

            for (int i = 0; i < 10; i++)
            {
                if (a[i] != null)
                    Console.WriteLine("\nCódigo: " + a[i].codigo + "\nNome: " + a[i].nome + "\nCategoria: " + a[i].categoria +
                                      "\nData de lamçamento: " + a[i].data_lanc.ToString("dd/MM/yyyy") + "\n");
            }

            Console.ReadLine();
        }
    }

    class Jogo
    {
        public int codigo;
        public string nome;
        public string categoria;
        public DateTime data_lanc;
    }
}
