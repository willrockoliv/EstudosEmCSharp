using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REF_OUT
{
    class Program
    {
        static void RetornaPrimeiroNome(string nomeCompleto, out string primeiroNome)
        {
            int posicaoEspaco = nomeCompleto.IndexOf(' ');
            if (posicaoEspaco == -1)
                primeiroNome = nomeCompleto;
            else
                primeiroNome = nomeCompleto.Substring(0, posicaoEspaco);
        }

        static void RetornaPrimeiroNome2(string nomeCompleto, ref string primeiroNome)
        {
            int posicaoEspaco = nomeCompleto.IndexOf(' ');
            if (posicaoEspaco == -1)
                primeiroNome = nomeCompleto;
            else
                primeiroNome = nomeCompleto.Substring(0, posicaoEspaco);
        }


        static void Main(string[] args)
        {

            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            string primeiroNome;
            RetornaPrimeiroNome(nome, out primeiroNome);

            /* 
            out e ref indicam o endereço da memória onde está a variável, podendo alterar o valor da variável 
            diretamente no método, sem a necessidade de retornar um valor pelo return 
            */

            //Utilizando out

            //contador de tempo de processamento
            Stopwatch cronometro = new Stopwatch();
            //starta o tempo
            cronometro.Start();

            string dado = "xxxbbbb";
            int valorConvertido; // como no if abaixo foi utilizado o comando out, não é necessário preencher a variável com um valor
            for (int n = 1; n <= 1000; n++)
            {
                /*                
                //exemplo para mostrar que essa forma de teste de excessão demora mais do que o algoritmo em seguida
                try
                {
                    Convert.ToInt32(dado);
                    Console.WriteLine("É numero!");
                }
                catch
                { }
                */

                if (int.TryParse(dado, out valorConvertido))
                {
                    Console.WriteLine(valorConvertido);
                    Console.WriteLine("É numero!");
                }
            }

            //exibe o tempo (.Elapsed [decorrido] .TotalMilliseconds [tempo total decorrido em millisegundos] se for apenas .Milliseconds ao bater 1s ele zera
            Console.WriteLine(cronometro.Elapsed.TotalMilliseconds);
            
            Console.ReadLine();

            //-----------------------------------------------------------------------------------------

            //Utilizando ref

            Console.Write("Digite um nome: ");
            string nome2 = Console.ReadLine();

            string primeiroNome2 = "teste";
            RetornaPrimeiroNome2(nome2, ref primeiroNome2);

            //------------------------------------------------------------------------------------------

            /*
            string valorConvertido2 = "";
            for (int n = 1; n <= 1000; n++)
            {
                if (int.TryParse(dado, ref valorConvertido2)) // erro pois .TryParse não aceita ref, apenas out
                {
                    Console.WriteLine(valorConvertido2);
                    Console.WriteLine("É numero!");
                }
            }
            */

            Console.ReadLine();
        }
    }
}
