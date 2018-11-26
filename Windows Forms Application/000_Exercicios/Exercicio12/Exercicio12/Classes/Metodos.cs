using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12.Classes
{
    public class Metodos
    {
        public static bool ValidaNome(string nome)
        {
            int espaco = nome.IndexOf(" ");

            if (nome[espaco + 1].ToString() != null && espaco != -1)
                return true;

            else
                return false;
           
        }

        public static bool ValidaData(string data, out int idade)
        {
            DateTime temp;
            if (DateTime.TryParse(data, out temp))
            {
                idade = DateTime.Now.Year - temp.Year;
                return true;
            }

            else
            {
                idade = 0;
                return false;
            }
        }
    }
}
