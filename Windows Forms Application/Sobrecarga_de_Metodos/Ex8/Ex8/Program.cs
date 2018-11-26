using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        /*
        Faça método sobrecarregado para salvar em um arquivo texto o conteúdo passado por parâmetro.
        Quando não for passado por parâmetro o caminho, salve na pasta da aplicação.
        Crie as seguintes versões do método:
        Salva (string texto)
        Salva (string texto, string caminho)
        Salva(string[] vetor)
        Salva(string vetor, string caminho)
        */

        static void Salva(string texto)
        {
            File.WriteAllText("texto.txt", texto);
        }
        static void Salva(string texto, string caminho)
        {
            File.WriteAllText(caminho + "\\texto.txt", texto);
        }
        static void Salva(string[] vetor)
        {
            File.WriteAllLines("texto.txt", vetor);
        }
        static void Salva(string[] vetor, string caminho)
        {
            File.WriteAllLines(caminho + "\\texto.txt", vetor);
        }

        static void Main(string[] args)
        {
            string[] texto_vetor = new string[1];
            string texto = null;
            string caminho = null;
            int cont = 0;
            string opcao = null;


            do
            {
                Console.WriteLine("Digite abaixo o texto que deseja salvar: ");
                texto = Console.ReadLine();


                Console.Write("Digite o caminho do diretório onde deseja salvar o texto: ");
                caminho = Console.ReadLine();

                do
                {
                    Console.Write("Deseja salvar mais algum texto? (S/N): ");
                    opcao = Console.ReadLine().ToUpper();
                    Console.Clear();
                }
                while (opcao == "" || (opcao.ToUpper() != "N" && opcao.ToUpper() != "S"));

                if (cont == 0)
                {
                    texto_vetor[cont] = texto;
                    if (opcao.ToUpper() == "S")
                        cont++;
                }
                else if (opcao.ToUpper() == "S")
                {
                    cont++;
                    Array.Resize(ref texto_vetor, texto_vetor.Length + 1);
                    texto_vetor[cont] = texto;
                }

            }
            while (opcao.ToUpper() == "S");

            if (Directory.Exists(caminho) != false && cont > 0)
                Salva(texto_vetor, caminho);
            else if (cont > 0)
                Salva(texto_vetor);
            else if (Directory.Exists(caminho) != false)
                Salva(texto, caminho);
            else
                Salva(texto);
        }
    }
}
