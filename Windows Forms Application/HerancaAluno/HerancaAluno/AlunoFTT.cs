using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAluno
{
    public class AlunoFTT : Aluno
    {
        public double N2 { get; set; }

        public int Estagio { get; set; }

        public override double CalculaMedia()
        {
            return N1 * 0.4 + N2 * 0.6;
        }

        public override string ToString()
        {
            return base.ToString() +
                        "\t N2: " + N2.ToString("0.0") +
                        "\t Estagio: " + Estagio;
        }
    }



}
