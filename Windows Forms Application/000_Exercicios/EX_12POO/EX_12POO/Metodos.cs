using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_12POO
{
    class Metodos
    {
        enum Sexo
        {
            MASCULINO,
            FEMININO
        }
        enum Estadocivil
        {
            CASADO,
            SOLTEIRO
        }

        public Metodos()
        {

        }

        public Metodos(string sexo, string ec)
        {
            if (sexo.ToUpper() != Sexo.MASCULINO.ToString() && sexo.ToUpper() != Sexo.FEMININO.ToString())
                throw new Exception("Sexo invalido");
            if (ec.ToUpper() != Estadocivil.CASADO.ToString() && ec.ToUpper() != Estadocivil.SOLTEIRO.ToString())
                throw new Exception("Estado civil invalido");
        }


        public static bool validanome(string nome)
        {
            if (nome.Trim().Replace(" ", "").Length != nome.Trim().Length)
                return true;
            else
                return false;
        }

        public static bool validaData(string data, out int idade)
        {
            try
            {
                idade = Convert.ToInt32(DateTime.Now.Year - Convert.ToDateTime(data).Year);
                return true;
            }
            catch
            {
                idade = 0;
                return false;
            }
        }

    }
}
