using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDinamica
{
    class Aluno 
    {
        private int codigo = 0;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome = string.Empty;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }



        public override string ToString()
        {
            return codigo + " - " + nome;
        }
    }
}
