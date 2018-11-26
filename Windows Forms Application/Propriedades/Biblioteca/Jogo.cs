using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jogo
    {
        private int codigo;
        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(nome))
                    throw new Exception("Nome inválido!");
                nome = value;
            }
        }
        public string Categoria { get; set; }
        public DateTime DataLancamento { get; set; }


        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Código não pode ser <= 0");

                codigo = value;
            }
        }

    }
}
