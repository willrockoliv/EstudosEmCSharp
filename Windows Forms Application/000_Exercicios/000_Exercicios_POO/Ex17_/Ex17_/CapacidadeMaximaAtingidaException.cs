using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_
{
    class CapacidadeMaximaAtingidaException : Exception
    {
        public CapacidadeMaximaAtingidaException():base("Capacidade máxima atingida")
        {
        }

        public CapacidadeMaximaAtingidaException(string msg) : base(msg)
        {
        }
    }
}
