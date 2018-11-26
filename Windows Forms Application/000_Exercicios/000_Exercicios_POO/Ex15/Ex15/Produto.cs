using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private string categoria;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao
        {
            get => descricao;
            set
            {
                if (value != "")
                    descricao = value;
                else
                    throw new Exception("Descrição Obrigatória!");
            }
        }
        public string Categoria
        {
            get => categoria;
            set
            {
                if (value != null)
                    categoria = value;
                else
                    throw new Exception("Categoria obrigatória");
            }
        }
    }
}
