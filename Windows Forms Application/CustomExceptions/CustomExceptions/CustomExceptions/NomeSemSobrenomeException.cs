using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptions
{
    class NomeSemSobrenomeException : Exception
    {
        public NomeSemSobrenomeException(string mensagem):base(mensagem)
        {

        }
    }
}
