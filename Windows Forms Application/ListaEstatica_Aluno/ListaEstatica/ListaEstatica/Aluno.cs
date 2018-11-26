using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstatica
{
    class Aluno
    {
        private int ra;
        private string nome;

        public int GetRa()
        {
            return ra;
        }

        public void SetRA(int value)
        {
            if (value <= 0)
                throw new Exception("RA não pode ser <= zero");
            ra = value;
        }


        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Exception erro = new Exception("Informe o nome!");
                    throw erro;
                    //throw new Exception("Informe o nome!");
                }
                nome = value;
            }
        }


        /// <summary>
        /// construtor parametrizado
        /// </summary>
        /// <param name="ra"></param>
        /// <param name="nome"></param>
        public Aluno(int ra, string nome)
        {
            SetRA(ra);
            this.Nome = nome;
        }

        /// <summary>
        /// construtor padrão
        /// </summary>
        public Aluno()
        {

        }
    }
}
