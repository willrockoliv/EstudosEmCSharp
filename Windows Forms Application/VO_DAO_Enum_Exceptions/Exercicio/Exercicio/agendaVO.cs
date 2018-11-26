using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class agendaVO
    {
        private int id;
        private string nome;
        private string telefone;

        public int Id
        {
            get => id;
            set
            {
                if (value > 0)
                    id = value;
                else
                    throw new Exception("Id não pode ser menor ou igual a zero");
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome não pode ser nulo");
                else
                    nome = value;
            }
        }

        public string Telefone
        {
            get => telefone;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Telefone não pode ser nulo");
                else
                    telefone = value;
            }
        }
    }
}
