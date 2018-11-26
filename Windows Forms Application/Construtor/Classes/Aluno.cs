using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Aluno
    {
        private string nome;
        private double n1, n2;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value) ||
                    value.Trim().IndexOf(' ') == -1)
                    throw new Exception("Informe o nome com sobrenome!");
                
                nome = value;
            }
        }

        public double N1
        {
            get
            {
                return n1;
            }

            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota n1 inválida!");
                n1 = value;
            }
        }

        public double N2
        {
            get
            {
                return n2;
            }

            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota n2 inválida!");
                n2 = value;
            }
        }

        public double Media
        {
            get
            {
                return (n1 + n2) / 2;
            }
        }


        public Aluno(double n1, double n2, string nome )
        {
            this.N1 = n1; // this significa "Da classe"
            this.N2 = n2; // this significa "Da classe"
            this.Nome = nome; // this significa "Da classe"
        }

    }
}
