using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    class Program
    {
        /*
          19.	Faça um programa para gravar os seguintes dados de uma disciplina:
            nome : string;  Não pode estar vazio
            nota de aprovação : int ;  Entre 1 e 10 
            Ao final exiba os dados no formato nome – nota de aprovação 
        */

        struct Disciplina
        {
            public string nome;
            public int nota;
        }

        static void Main(string[] args)
        {
            Disciplina d = new Disciplina();

            do
            {
                Console.Write("Digite o nome da disciplina: ");
                d.nome = Console.ReadLine();
            }
            while (d.nome == "");

            do
            {
                try
                {
                    Console.Write("Digite a nota: ");
                    d.nota = Convert.ToInt16(Console.ReadLine());   
                }
                catch
                {
                    Console.WriteLine("Apenas números interiros.");
                }
            }
            while (d.nota < 1 || d.nota > 10);

            Console.Clear();
            Console.WriteLine("{0} - {1}", d.nome, d.nota);
            Console.ReadLine();
        }
    }
}
