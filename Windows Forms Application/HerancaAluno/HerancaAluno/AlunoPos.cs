using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAluno
{
    class AlunoPos : Aluno
    {
        public AlunoPos()
        {
            MediaDeAprovacao = 7;
        }
        
        public string Graduacao { get; set; }


        public override string ToString()
        {
            return base.ToString() +
                 "\t Graduação: " + Graduacao;
        }
    }
}
