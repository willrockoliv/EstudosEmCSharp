using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    public class FuncionarioVendedor : Funcionario
    {
        private double metaDeVendaMes;
        private double vendasDoMes;
        private double porcentagemSobreVendas;

        public double MetaDeVendaMes { get => metaDeVendaMes; set => metaDeVendaMes = value; }
        public double VendasDoMes { get => vendasDoMes; set => vendasDoMes = value; }
        public double PorcentagemSobreVendas { get => porcentagemSobreVendas; set => porcentagemSobreVendas = value; }

        public override double CalculaSalario()
        {
            if (VendasDoMes >= MetaDeVendaMes)
                return Salario + (VendasDoMes * (PorcentagemSobreVendas / 100));
            else
                return Salario;
        }
    }
}
