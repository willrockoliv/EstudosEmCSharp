using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX_16
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("dados.txt") == true)
            {
                string dadosNoDisco = File.ReadAllText("dados.txt");
                Console.WriteLine(dadosNoDisco);
            }

            string conteudo = string.Empty;
            string palavra;
            do
            {
                palavra = Console.ReadLine();
                if (palavra.ToUpper() != "SAIR")
                    conteudo +=  Environment.NewLine + palavra;
            }
            while (palavra.ToUpper() != "SAIR");

            File.WriteAllText("dados.txt", conteudo);
        }
    }
}
