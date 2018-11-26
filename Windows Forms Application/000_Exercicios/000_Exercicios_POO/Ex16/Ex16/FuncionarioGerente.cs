using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    public class FuncionarioGerente : Funcionario
    {
        private int qtdFuncionariosSubordinados;
        private double bonus;

        public double Bonus { get => bonus = 15 * QtdFuncionariosSubordinados; set => bonus = value; }
        public int QtdFuncionariosSubordinados { get => qtdFuncionariosSubordinados; set => qtdFuncionariosSubordinados = value; }

        public override double CalculaSalario()
        {
            return Salario + Bonus;
        }
    }
}
