using Biblioteca.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VOs
{
    public class JogosVO
    {
        //CREATE TABLE jogos(
        //    [id] [int] NOT NULL primary key,
        //    [descricao] [varchar] (50) NULL,
        //    [valor_locacao] [decimal](18, 2) NULL,
        //    [data_aquisicao] [datetime] NULL,
        //    [categoriaID] [int] NULL)

        private int id;
        private string descricao;
        private double valor_locacao;
        private DateTime data_aquisicao;
        private int categoriaID;

        public int Id
        {
            get => id;
            set
            {
                if (value < 0)
                    throw new ValidacaoException("Id não pode ser menor que zero");
                else
                    id = value;
            }
        }

        public string Descricao
        {
            get => descricao;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ValidacaoException("Nome não pode ser nulo");
                else
                    descricao = value;
            }
        }

        public double Valor_locacao
        {
            get => valor_locacao;
            set
            {
                if (value < 0)
                    throw new ValidacaoException("Valor da locação não pode ser menor que zero");
                else
                    valor_locacao = value;
            }
        }

        public DateTime Data_aquisicao
        {
            get => data_aquisicao;
            set
            {
                if (value <= DateTime.Now || value == null)
                    throw new ValidacaoException("Data não pode ser menor que a data atual nem nula.");
                else
                    data_aquisicao = value;
            }
        }
        public int CategoriaID
        {
            get => categoriaID;
            set
            {
                if (value < 0)
                    throw new ValidacaoException("ID da categoria não pode ser menor que zero");
                else
                    categoriaID = value;
            }
        }
    }
}
