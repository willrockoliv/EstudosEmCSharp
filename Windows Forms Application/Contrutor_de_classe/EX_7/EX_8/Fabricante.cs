using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_8
{
    class Fabricante
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Fabricante(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return Id + " - " + Nome;
        }
    }
}
