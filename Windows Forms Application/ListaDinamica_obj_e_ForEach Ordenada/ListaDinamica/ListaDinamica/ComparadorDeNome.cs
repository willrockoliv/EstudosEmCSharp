using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ListaDinamica
{
    class ComparadorDeNome : IComparer
    {        

        public int Compare(object x, object y)
        {
            Aluno aX = x as Aluno;
            Aluno aY = (Aluno)y;  // outra forma de fazer cast

            return aX.Nome.CompareTo(aY.Nome);
        }        
    }
}
