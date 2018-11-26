using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private string rg;
        private double salario;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Código não pode ser negativo!");

                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome errado!");

                nome = value;
            }
        }

        public string RG
        {
            get
            {
                return rg;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("RG errado!");

                rg = value;
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
                if (salario < 0)
                    throw new Exception("Salário inválido!");

                salario = value;
            }
        }

        public double Inss
        {
            get
            {
                return salario * 0.11;
            }
        }


        public double CalcularSalario
        {
            get
            {
                return salario - Inss;
            }
        }

    }
}
