using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CustomExceptions
{
    public class NumeroNegativoException : Exception
    {

        public NumeroNegativoException(string mensagem)
            : base(mensagem)
        {
        }

        public NumeroNegativoException(string mensagem, int numero)
            : base(mensagem + " Número: " + numero)
        {
            File.AppendAllText("LogErro.TXT", mensagem + " Número: " + numero + Environment.NewLine);
        }
    }
}
