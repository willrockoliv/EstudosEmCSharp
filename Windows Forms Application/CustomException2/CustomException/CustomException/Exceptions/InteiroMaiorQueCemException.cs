using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    class InteiroMaiorQueCemException : Exception
    {
        public InteiroMaiorQueCemException()
            : base("Não pode ser maior que cem.")
        {

        }

    }
}
