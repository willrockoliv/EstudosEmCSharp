using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcaoValida
{
    class Program
    {
        /*
        Opção Válida
        O programa a seguir deveria solicitar uma opção e apenas os números 1, 2 e 3 deveriam ser aceitos, 
        porém mesmo digitando um desses valores o programa continua sem deixar sair da validação.
        */
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Digite uma das 3 opções: \n1-> Calcular, " +
                                  "\n2-> Listar e \n3-> Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
            }
            while (opcao != 1 && opcao != 2 && opcao != 3);



            Console.WriteLine("Você escolheu a opção: {0}", opcao);

            Console.ReadLine();

        }
    }
}
