using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_12POO
{
    class Funcionario
    {
        private string nome;
        public int idade;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome inválido! Favor preencher o campo!");
                if (Metodos.validanome(value) == false)
                    throw new Exception("Nome inválido! Favor preencher nome e sobrenome!");
                else
                    nome = value;
            }
        }

        public string Nasc
        {
			set
			{
                if(Metodos.validaData(value, out idade) == false)
                    throw new Exception("Data invalida");
            }
        }

    }
}
