using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6
{
    class Program
    {
        /*
         * 6.	Três Métodos
            Faça um programa que tenha 3 métodos : 
            UltimaLetra -> recebe um texto e exibe 
                           a última letra   dele.
            TrocaCaracter -> recebe um texto, o caractere  original e
                            o novo caractere. 
                            Ele substituirá todo os caracteres 
                            originais pelo novo caractere e 
                            deverá devolver o novo texto.
            Iniciais -> recebe um texto e retorna suas iniciais.
            Faça o programa principal de forma que 
            se possa testar todos estes métodos
        */


        /// <summary>
        /// Retorna a última letra de um texto
        /// </summary>
        /// <param name="texto">texto a ser tratado</param>
        static void UltimaLetra(string texto)
        {
            Console.WriteLine(texto[texto.Length - 1]);
        }

        /// <summary>
        /// Substitui os caracteres de um texto
        /// </summary>
        /// <param name="texto">texto original</param>
        /// <param name="caractereAnterior">caractere que será substituido</param>
        /// <param name="novoCaractere">novo caractere</param>
        /// <returns>o novo texto</returns>
        static string TrocaCaractere(string texto,
                                     char caractereAnterior,
                                     char novoCaractere)
        {
            string retorno = "";
            foreach (char letra in texto)
            {
                if (letra == caractereAnterior)
                    retorno = retorno + novoCaractere;
                else
                    retorno = retorno + letra;
            }
            return retorno;
        }

        /// <summary>
        /// Obtem as iniciais de um texto
        /// </summary>
        /// <param name="texto">o texto</param>
        /// <returns>apenas as iniciais.</returns>
        static string Iniciais(string texto)
        {
            string r = texto[0].ToString();
            for (int n = 1; n < texto.Length; n++)
            {
                if (texto[n] == ' ')
                    r += texto[n + 1];
            }
            return r;
        }


        static void Main(string[] args)
        {
            UltimaLetra("Genipapito");
            UltimaLetra("Diana");

            Console.WriteLine(TrocaCaractere("Banana", 'a', 'j'));
            Console.WriteLine(TrocaCaractere("alface", 'a', 'u'));

            Console.WriteLine(Iniciais("Joao da Silva"));

            Console.ReadLine();
        }
    }
}
