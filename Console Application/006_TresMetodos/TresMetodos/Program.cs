using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresMetodos
{
    class Program
    {
        /*
        6.	Três Métodos
        Faça um programa que tenha 3 métodos : 
        UltimaLetra -> recebe um texto e exibe a última letra dele.
        TrocaCaracter -> recebe um texto, o caractere  original e o novo caractere.
            Ele substituirá todo os caracteres originais pelo novo caractere e deverá devolver o novo texto.
        Iniciais -> recebe um texto e retorna suas iniciais.
        Faça o programa principal de forma que se possa testar todos estes métodos
        */

        static void UltimaLetra(string texto)
        {
            Console.WriteLine(texto[texto.Length - 1]);
        }

        static void TrocaCaracter(string texto)
        {
            char original, novo;

            Console.Write("Digite o caracter original: ");
            original = Console.ReadKey().KeyChar;

            Console.Write("\nDigite o novo caracter: ");
            novo = Console.ReadKey().KeyChar;

            Console.WriteLine(texto.Replace(original, novo));
        }

        static void Iniciais(string texto)
        {
            Console.Write(texto[0]);

            for(int i=0; i < (texto.Length-1); i++)
            {
                if(texto[i] == ' ')
                    Console.Write("-{0}",texto[(i+1)]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool sair = false;
            char original, novo;
            string texto, opcao;

            do
            {
                Console.Write("Digite um texto: ");
                texto = Console.ReadLine();

                do
                {
                    Console.Write("<1> Mostrar útima letra;" +
                                  "\n<2> Trocar um caracter;" +
                                  "\n<3> Mostrar todas a iniciais do texto."+
                                  "\nInforme a opção desejada: ");
                    opcao = Console.ReadLine();

                    if (opcao != "1" && opcao != "2" && opcao != "3")
                        Console.WriteLine("Opção inválida!");
                }
                while (opcao != "1" && opcao != "2" && opcao != "3");

                if (opcao == "1")
                    UltimaLetra(texto);
                else if (opcao == "2")
                    TrocaCaracter(texto);
                else
                    Iniciais(texto);

                Console.Write("Deseja continuar? (S/N): ");
                opcao = Console.ReadLine();

                if (opcao.ToUpper() == "N")
                    sair = true;

                Console.Clear();
            }
            while (sair == false);

            Console.ReadLine();
        }
    }
}
