using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }

        public virtual double CalculaSalario()
        {
            return Salario;
        }
    }
}
