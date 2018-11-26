using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroNome
{
    class Program
    {
        /*
        1.	Primeiro Nome
        Faça um programa que tenha um método que receba um nome completo ou não. 
        Retorne então apenas o primeiro nome. No programa principal vc deverá solicitar 
        o nome de 2 pessoas e executar este método.

        static  string RetornaPrimeiroNome(string Nomecompleto)
        {
             return ???
        }

        */

        static string RetornarPrimeiroNome(string nomecompleto)
        {
            int espaco = nomecompleto.IndexOf(' ');

            if (espaco == -1)
                return nomecompleto;
            else
                return nomecompleto.Substring(0, espaco);
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o 1° nome completo: ");
            string nome1 = Console.ReadLine();

            Console.Write("Digite o 2° nome completo: ");
            string nome2 = Console.ReadLine();

            Console.WriteLine("1° nome: {0}", RetornarPrimeiroNome(nome1));
            Console.WriteLine("1° nome: {0}", RetornarPrimeiroNome(nome2));

            Console.ReadLine();
        }
    }
}
