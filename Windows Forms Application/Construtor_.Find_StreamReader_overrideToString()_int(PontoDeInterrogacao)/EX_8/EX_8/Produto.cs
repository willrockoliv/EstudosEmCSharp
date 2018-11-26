using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_8
{
    public class Produto
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private Categoria categoria;

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }


    }
}
