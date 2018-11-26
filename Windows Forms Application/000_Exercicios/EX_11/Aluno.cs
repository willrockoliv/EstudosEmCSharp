using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlunoENotas
{
    class Aluno
    {
        string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrEmpty(value) ||
                    value.Trim().IndexOf(' ') == -1)
                {
                    throw new Exception("Informe um nome com sobrenome");
                }
                else
                    nome = value;
            }
        }
        double n1;

        public double N1
        {
            get { return n1; }
            set
            {

                if (value < 0 || value > 10)
                    throw new Exception("Informe a nota entre 0 e 10");
                n1 = value;
            }
        }
        double n2;

        public double N2
        {
            get { return n2; }
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Informe a nota entre 0 e 10");

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


        public Aluno(string nome, double n1, double n2)
        {
            Nome = nome;
            N1 = n1;
            N2 = n2;
        
            qtdeAlunosInstanciados++;
        }



        #region atributo estático
        private static int qtdeAlunosInstanciados = 0;

        public static int QtdeAlunosInstanciados
        {
            get { return Aluno.qtdeAlunosInstanciados; }            
        }

        #endregion

    }
}
