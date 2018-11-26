using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_25
{
    class Program
    {
        static void DadosNome(  string nome,
                                out int qtdeVogais,                              
                                out string pNome, 
                                out string nomeM)
        {
            qtdeVogais = 0;
            nomeM = ""; //char.ToUpper(nome[0]).ToString();

            for (int n = 0; n < nome.Length; n++)
            {
                if (char.ToUpper(nome[n]) == 'A' ||
                    char.ToUpper(nome[n]) == 'E' ||
                    char.ToUpper(nome[n]) == 'I' ||
                    char.ToUpper(nome[n]) == 'O' ||
                    char.ToUpper(nome[n]) == 'U')
                    qtdeVogais++;

                if (n == 0 ||  nome[n - 1] == ' ')
                    nomeM = nomeM + char.ToUpper(nome[n]);
                else
                    nomeM = nomeM + nome[n];
            }

            if (nome.IndexOf(' ') != -1)
                pNome = nome.Substring(0, nome.IndexOf(' '));
            else
                pNome = nome;            
        }

        static void Main(string[] args)
        {
            /*
             * 25.	Crie um método que devolva 3 informações sobre um nome:
            •	A quantidade de vogais do nome
            •	O primeiro nome do nome informado
            •	Uma versão do nome com apenas a primeira letra de cada
            palavra em maiúsculo
             * */

            int qtde;
            string pNome, nomeEmMaiusculo;
            DadosNome("ana silva sa", out qtde, out pNome, out nomeEmMaiusculo);

            Console.WriteLine("{0} {1}  {2}", qtde, pNome, nomeEmMaiusculo);

            Console.ReadLine();

        }
    }
}
