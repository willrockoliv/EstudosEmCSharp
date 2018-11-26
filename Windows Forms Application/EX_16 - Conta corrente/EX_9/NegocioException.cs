using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    class NegocioException : Exception
    {

        public NegocioException(string erro) : base(erro)
        {

        }
    }
}
