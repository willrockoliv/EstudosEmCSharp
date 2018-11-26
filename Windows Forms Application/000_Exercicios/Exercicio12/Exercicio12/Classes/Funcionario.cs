using Exercicio12.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12.Classes
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public SexoEnum Sexo { get; set; }
        public ECivilEnum ECivil { get; set; }

        public DateTime DataNasc { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, SexoEnum sexo, ECivilEnum eCivil, DateTime dataNasc)
        {
            Nome = nome;
            Sexo = sexo;
            ECivil = eCivil;
            DataNasc = dataNasc;
        }
    }
}
