using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5
{
    /*
    5.	Nome Invertido
        Faça um programa que solicite um texto qualquer e 
        então um método  chamado irá devolver o 
        texto recebido como parâmetro 
        invertido.ex: nariz r = ziran*/



    class Program
    {
        static string Inverte(string texto)
        {
            string retorno = "";
            foreach (char letra in texto)
                retorno = letra + retorno;

            return retorno;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();
            string resposta = Inverte(texto);
            Console.WriteLine(resposta);
            Console.ReadLine();
        }
    }
}
