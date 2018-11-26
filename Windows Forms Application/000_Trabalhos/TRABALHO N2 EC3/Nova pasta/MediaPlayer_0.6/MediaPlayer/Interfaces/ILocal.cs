using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public interface ILocal
    {
        string ArquivoMidia { get; set; } //local e nome do arquivo da mídia
        bool ValidaCaminho(); //valida se o arquivo de mídia realmente existe no local informado.
    }
}
