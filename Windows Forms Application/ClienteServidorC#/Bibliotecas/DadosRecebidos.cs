using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class DadosRecebidos : EventArgs
    {
        public string Dados { get; set; }

        public DadosRecebidos(string dados)
        {
            Dados = dados;
        }
    }
}
