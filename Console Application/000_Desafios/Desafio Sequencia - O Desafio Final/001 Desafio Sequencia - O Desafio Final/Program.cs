using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Desafio_Sequencia___O_Desafio_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            string num, resposta="";

            do
            {
                Console.Write("Informe o número de 0 a 9: ");
                num = Console.ReadLine();
            }
            while (num.Length != 1);

            Console.Write("Digite o número de sequências: ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(num);
            num = "1" + num;
            Console.WriteLine(num);

            for(int cont=2; cont < n; cont++)
            {
                int verific_1 = 0, verific_2 = 0, cont_num = 0;

                for(verific_2 = 0; verific_2 <= num.Length; verific_2++)
                {
                    if (verific_2 == num.Length)
                    {
                        resposta = resposta + cont_num + num[verific_1];
                        continue;
                    }

                    if (num[verific_1] == num[verific_2])
                        cont_num++;
                    else
                    {
                        resposta = resposta + cont_num.ToString() + num[verific_1];
                        verific_1 = verific_2; //para o verific_1 ir para o próximo número diferente do primeiro
                        verific_2--; //  "  " verific_2 "   "   "   "       "       "      "     "
                        cont_num = 0; //zerar o contador
                    }


                }

                Console.WriteLine(resposta);
                num = resposta;
                resposta = "";
            }



            Console.ReadLine();
        }
    }
}
