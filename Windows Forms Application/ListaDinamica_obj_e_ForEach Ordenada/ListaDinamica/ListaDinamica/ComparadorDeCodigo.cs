using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ListaDinamica
{
    class ComparadorDeCodigo : IComparer
    {           

        public int Compare(object x, object y)
        {
            if ((x as Aluno).Codigo > (y as Aluno).Codigo)
                return 1;
            else if ((x as Aluno).Codigo == (y as Aluno).Codigo)
                return 0;
            else
                return -1;            
        }
        
    }
}