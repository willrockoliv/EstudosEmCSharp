using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Aluno
    {
        private string nome;
        private double n1, n2, media;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value == null || value.IndexOf(" ") == -1)
                    throw new Exception("Favor preencher Nome e Sobrenome");
                else
                    nome = value;
            }
        }
        public double Nota1
        {
            get
            {
                return n1;
            }
            set
            {
                n1 = value;
            }
        }
        public double Nota2
        {
            get
            {
                return n2;
            }
            set
            {
                n2 = value;
            }
        }
        public double Media
        {
            get
            {
                media = (n1 + n2) / 2;

                if (media < 0 || media > 10)
                    throw new Exception("Média inválida. Deve estar entre 0 e 10");
                else
                    return media;
            }
        }
    }
}
