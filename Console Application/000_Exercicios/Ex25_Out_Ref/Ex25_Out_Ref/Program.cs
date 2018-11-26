using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_Out_Ref
{
    class Program
    {
        static void TrabalhaNome(string nome, out string primeiro_nome, ref string nova_versao, out int cont)
        {
            cont = 0;
            foreach (char vogal in nome)
            {
                if (char.ToUpper(vogal) == 'A' ||
                    char.ToUpper(vogal) == 'E' ||
                    char.ToUpper(vogal) == 'I' ||
                    char.ToUpper(vogal) == 'O' ||
                    char.ToUpper(vogal) == 'U')
                    cont++;
            }
            int i=1;

            nova_versao = nome[0].ToString().ToUpper();
            foreach (char letra in nome)
            {
                if (nome[i] == ' ')
                {
                    nova_versao = nova_versao + " " + char.ToUpper(nome[i + 1]);
                    i++;
                }
                else
                    nova_versao = nova_versao + nome[i];
                i++;
                if (i > nome.Length - 1)
                    break;
            }

            primeiro_nome = nome.Substring(0, nome.IndexOf(" "));
        }

        static void Main(string[] args)
        {
            /*
            25.	Crie um método que devolva 3 informações sobre um nome:
            • A quantidade de vogais do nome
            • O primeiro nome do nome informado
            • Uma versão do nome com apenas a primeira letra de cada palavra em maiúsculo
            */

            string nome, primeiro_nome, nova_versao="";
            int cont;

            do
            {
                Console.Write(" Nome Completo: ");
                nome = Console.ReadLine().Trim();
            }
            while (nome == "" || nome.IndexOf(" ") == -1);

            TrabalhaNome(nome, out primeiro_nome, ref nova_versao, out cont);

            Console.WriteLine(" n° de vogais: " + cont + "\n Primeiro Nome: " + primeiro_nome + "\n Nova Versão do nome: " + nova_versao);

            Console.ReadLine();
        }
    }
}
