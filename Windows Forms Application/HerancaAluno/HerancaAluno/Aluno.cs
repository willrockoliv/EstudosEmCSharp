using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAluno
{
    public class Aluno
    {
        protected double MediaDeAprovacao { get; set; } = 5;

        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Preencha o nome!");
                nome = value;
            }
        }

        public string RA { get; set; }
        public double N1 { get; set; }
        public int Frequencia { get; set; }

        public virtual double CalculaMedia()
        {
            return N1;
        }

        public virtual Boolean VerificaAprovacao()
        {
            return CalculaMedia() >= MediaDeAprovacao &&
                   Frequencia >= 75;
        }



        public override string ToString()
        {
            return 
                   "\t RA:  " + RA +
                   "\t Nome: " + Nome +
                   "\t Frequência: " + Frequencia +
                   "\t N1: " + N1.ToString("0.0") +
                   "\t Média: " + CalculaMedia().ToString("0.0") +
                   "\t Aprovado: " + VerificaAprovacao();
        }

    }
}
