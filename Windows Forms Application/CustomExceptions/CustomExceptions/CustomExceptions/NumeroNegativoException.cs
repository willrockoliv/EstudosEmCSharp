using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptions
{
    public class NumeroNegativoException : Exception 
    {
        /// <summary>
        /// Informe a mensagem da exceção.
        /// </summary>
        /// <param name="msg"></param>
        public NumeroNegativoException(string msg)
            : base(msg)
        {

        }



        /// <summary>
        /// Informe a mensagem da exceção.
        /// </summary>
        /// <param name="msg"></param>
        public NumeroNegativoException()
            : base("Informe apenas números positivos.")
        {
        }
    }
}
