using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestadorDeLetrasMaiusculas
{
    class Program
    {
        /*
        Testador de letras maiúsculas
        O programa a seguir deveria solicitar um texto ao usuário e, 
        após analisa-lo, informar se há ao menos uma letra maiúscula ou 
        se não há nenhuma letra em maiúsculo.O problema é que ele está exibindo 
        várias mensagens na tela sem ainda ter terminado de procurar e, em determinado 
        momento, ele dá um erro.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();

            bool teste = false;

            for (int n = 0; n <= texto.Length-1; n++)
            {
                if (texto[n] == ' ')
                    continue;
                else if (texto[n] == texto.ToUpper()[n])
                {
                    Console.WriteLine("Existe letra maiúscula");
                    teste = true;
                    break;
                }
            }

            if(teste == false)
                Console.WriteLine("Não existe letra maiúscula");

            Console.ReadLine();

        }
    }
}
