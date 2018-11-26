using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                2-) Implemente a Fila utilizando a mesma técnica utilizada na Fila dinâmica. Observe que não será uma Fila circular,
                pois não há mais o problema de ter que descolar os elementos quando utilizamos esta técnica de elementos
                encadeados.
            */

            Fila Fila = new Fila();
            int op;

            do
            {
                Console.WriteLine(" 1) Enfileirar \n 2) Desenfileirar \n 3) Tamanho \n 4) Retorna Inicio \n 5) Retorna Todos \n 6) Sair");
                op = Convert.ToInt16(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Valor: ");
                    Fila.Enfileirar(Console.ReadLine());
                }
                else if (op == 2)
                {
                    try
                    {
                        Console.WriteLine(Fila.Desenfileirar());
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Quantidade: " + Fila.Quantidade.ToString());
                }
                else if (op == 4)
                {
                    try
                    {
                        Console.WriteLine("Inicio: " + Fila.RetornaTopo());
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
                else if (op == 5)
                {
                    try
                    {
                        Console.WriteLine(Fila.RetornaTodos());
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                }
            }
            while (op != 6);
        }
    }
}
