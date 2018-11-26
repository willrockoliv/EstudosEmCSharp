using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAluno
{
    class AlunoEM : Aluno
    {

        public AlunoEM()
        {
            MediaDeAprovacao = 6;
        }

        public double N2 { get; set; }
        public double N3 { get; set; }

        public string Responsavel { get; set; }

        public override double CalculaMedia()
        {
            return (N1 + N2 + N3) / 3;
        }


        public override string ToString()
        {
            return base.ToString() +
                 "\t N2: " + N2.ToString("0.0") +
                 "\t N3: " + N3.ToString("0.0") +
                 "\t Resp: " + Responsavel;
        }
    }
}
