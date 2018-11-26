using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                try
                {
                    salario = value;
                }
                catch
                {
                    throw new Exception("Apenas números!");
                }
            }
        }
    }
}
