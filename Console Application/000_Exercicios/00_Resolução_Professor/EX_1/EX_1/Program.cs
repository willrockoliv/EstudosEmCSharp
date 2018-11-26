using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1
{
    class Program
    {

        static string RetornaPrimeiroNome(string Nomecompleto)
        {
            int posicaoEspaco = Nomecompleto.IndexOf(' ');
            if (posicaoEspaco == -1)
                return Nomecompleto;
            else
                return Nomecompleto.Substring(0, posicaoEspaco);
        }

        static void Main(string[] args)
        {
            /*
            1.	Primeiro Nome
            Faça um programa que tenha um método que receba um nome completo ou não.
            Retorne então apenas o primeiro nome. 
            No programa principal vc deverá solicitar o nome de 2 pessoas e 
            executar este método.           
            */
            Console.WriteLine("Digite o nome do seu pai: ");
            string pai = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua mãe: ");
            string mae = Console.ReadLine();

            string PrimeiroNomePai = RetornaPrimeiroNome(pai);
            string PrimeiroNomeMae = RetornaPrimeiroNome(mae);

            Console.WriteLine("Pai: " + PrimeiroNomePai);
            Console.WriteLine("Mae: {0} ", PrimeiroNomeMae);

            /*
            Console.WriteLine("Pai: " + RetornaPrimeiroNome(pai));
            Console.WriteLine("Mae: {0} ", RetornaPrimeiroNome(mae));
            */

            Console.ReadLine();
        }
    }
}
