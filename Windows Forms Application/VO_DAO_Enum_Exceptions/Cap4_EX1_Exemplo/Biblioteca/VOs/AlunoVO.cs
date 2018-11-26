using Biblioteca.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VOs
{
    public class AlunoVO
    {
        private int id;
        private string nome;
        private double mensalidade;
        private int cidadeId;
        private DateTime dataNascimento;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                    throw new ValidacaoException("Id não pode ser negativo!");
                else
                    id = value;
            }
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
                    throw new ValidacaoException("Informe o nome!");
                else
                    nome = value;
            }
        }
        public double Mensalidade
        {
            get
            {
                return mensalidade;
            }
            set
            {
                if (value < 0)
                    throw new ValidacaoException("Mensalidade não pode ser negativa!");
                else
                    mensalidade = value;
            }
        }
        public int CidadeId
        {
            get
            {
                return cidadeId;
            }
            set
            {
                if (value < 0)
                    throw new ValidacaoException("Código da cidade não ser negativo!");
                else
                    cidadeId = value;
            }
        }
        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ValidacaoException("Mas a pessoa nem nasceu ainda!");
                else
                    dataNascimento = value;
            }
        }
    }
}
