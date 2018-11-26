using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex59
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int cont1 = 0; cont1 < 10; cont1++)
            {
                bool ok = true;

                do
                {
                    Console.Write("{0}° Número: ", cont1+1);
                    num[cont1] = Convert.ToInt16(Console.ReadLine());

                    for (int cont2 = 0; cont2 < cont1; cont2++)
                    {
                        if (num[cont1] == num[cont2])
                        {
                            ok = false;
                            Console.WriteLine("Número já digitado!");
                        }
                        else
                            ok = true;
                    }
                }
                while (ok == false);
            }

            Console.WriteLine("Números digitados:");

            for(int cont3=0; cont3 < 10; cont3++)
            {
                Console.WriteLine(num[cont3]);
            }

            Console.ReadLine();
        }
    }
}
