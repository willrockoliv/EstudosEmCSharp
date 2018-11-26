using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public interface ILocal
    {
        string Localizacao { get; }
        string ArquivoMidia { get; set; }
        bool ValidaCaminho();
    }
}
