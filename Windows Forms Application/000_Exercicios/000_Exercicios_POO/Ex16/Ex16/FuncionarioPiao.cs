using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    public class FuncionarioPiao : Funcionario
    {
        private double horaExtra;

        public double HoraExtra { get => horaExtra; set => horaExtra = value; }

        public override double CalculaSalario()
        {
            return Salario + HoraExtra;
        }
    }
}
