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
                    throw new NumeroNegativoException("Numero não pode ser negativo.", value);
                else
                    codigo = value;
            }
        }
        private string cpf;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }
}
