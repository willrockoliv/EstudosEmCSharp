using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeNumerosAleatorios
{
    class Program
    {
        /*
        Gerador de números aleatórios
        O objetivo do programa a seguir é gerar 6 números aleatórios.
        Os números devem ser entre 1 e 6 e não podem se repetir.
        O problema é que ele entra em um loop infinito. 
        O que há de errado?
        */
        static void Main(string[] args)
        {
            Random gerador = new Random();

            int[] vetor = new int[6];

            for (int n = 0; n < vetor.Length; n++)
            {
                bool existe;

                do
                {
                    existe = false;

                    vetor[n] = gerador.Next(1, 7);

                    for (int p = 0; p < n; p++)
                    {
                        if (vetor[p] == vetor[n])
                        {
                            existe = true;
                            break;
                        }
                    }
                }
                while (existe == true);
            }

            for (int n = 0; n < vetor.Length; n++)
            {
                Console.WriteLine(vetor[n]);
            }

            Console.ReadLine();
        }

    }
}

