using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais
{
    interface IOviparo
    {
        string Botar();
        string Chocar();
        bool PossuiPenas { get; set; }
    }
}
