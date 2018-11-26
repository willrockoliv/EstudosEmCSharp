using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex62
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0, dividendo=1;

            for(int i=0; i<10;i++)
            {
                if (dividendo % 2 == 0)
                    s = s - (dividendo / (dividendo * dividendo));
                else
                    s = s + (dividendo / (dividendo * dividendo));

                dividendo++;
            }

            Console.WriteLine("S = {0}", s);

            Console.ReadLine();
        }
    }
}
