using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Aluno
    {
        int ra;

        public int Ra
        {
            get { return ra; }
            set { ra = value; }
        }


        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }



        public Aluno(int ra, string nome)
        {
            Ra = ra;
            Nome = nome;
        }
    }
}
