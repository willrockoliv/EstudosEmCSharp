using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Jogo_da_Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 60;
            Console.CursorTop = 10;
            Console.ReadLine();
            //char valor = ' ';
            DateTime inicio = DateTime.Now;
            double tempoemSegundos;

            do
            {
                if (Console.KeyAvailable)
                {


                    ConsoleKeyInfo tecla = Console.ReadKey();
                    Console.WriteLine(tecla.KeyChar);
                    Console.WriteLine(tecla.Key.ToString());
                    if (tecla.Key.ToString() == "F2")
                        Console.WriteLine("Apertou F2");


                    Thread.Sleep(1000); // o processamento para. valor em milissegundos
                }
                Console.CursorLeft = 60;
                Console.CursorTop = 10;
                tempoemSegundos = DateTime.Now.Subtract(inicio).TotalSeconds;

                //Console.WriteLine("processando a " + Math.Truncate( tempoemSegundos) + "seg.");
                Console.WriteLine("Ainda restam " + (180 - Math.Truncate(tempoemSegundos)) + "seg.");
            }
            while (tempoemSegundos <= 180); 
       

            

        }
    }
}
