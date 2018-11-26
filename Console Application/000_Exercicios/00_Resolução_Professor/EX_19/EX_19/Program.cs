using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_19
{
    class Program
    {

        struct Disciplina
        {
            public string nome;
            public int nota;            
        }

        static void Main(string[] args)
        {
            /*
             19.Faça um programa para gravar os seguintes dados de 
                uma disciplina:
                nome : string;  Não pode estar vazio
                nota de aprovação : int ;  Entre 1 e 10  
             */
            Disciplina d = new Disciplina();
                       

            do
            {
                Console.WriteLine("Digite o nome da disciplina: ");
                d.nome = Console.ReadLine();
            }
            while (d.nome == ""); // (d.nome.Length == 0);

            do
            {
                try
                {
                    Console.WriteLine("Digite a nota da disciplina: ");
                    d.nota = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números inteiros. ");
                }
            }
            while (d.nota <1 || d.nota > 10);


            Console.Clear();
            Console.WriteLine("Dados Cadastrados: ");
            Console.WriteLine("Nome: {0} - Nota: {1}", d.nome, d.nota);
            Console.ReadLine();
        }
    }
}
