using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptions
{
    class Funcionario
    {
        private int codigo;
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (value < 0)
                    //throw new NumeroNegativoException("Digite apenas números positivos.");
                    throw new NumeroNegativoException("");
                else
                    codigo = value;
            }
        }


        string nome;
        public string Nome
        {
            get { return nome;}
            set
            {
              if (value.Trim().IndexOf(" ")    == -1)
                  throw new NomeSemSobrenomeException("Informe um nome com sobrenome.");
              else
                  nome = value;
            }
        }


    }
}
