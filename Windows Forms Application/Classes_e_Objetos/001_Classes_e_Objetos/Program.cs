using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes_e_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo a = new Jogo();


            Console.Write("Informe o código: ");
            a.codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome: ");
            a.nome = Console.ReadLine();

            Console.Write("Informe a categoria: ");
            a.categoria = Console.ReadLine();

            Console.Write("Informe a data de lançamento: ");
            a.data_lanc = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("\nCódigo: " + a.codigo + "\nNome: " + a.nome + "\nCategoria: " + a.categoria + 
                              "\nData de lamçamento: " + a.data_lanc.ToString("dd/MM/yyyy"));

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
