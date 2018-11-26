using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
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
                nome = Console.ReadLine();
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
                    salario = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    throw new Exception("Apenas números!");
                }
            }
        }
    }
}
