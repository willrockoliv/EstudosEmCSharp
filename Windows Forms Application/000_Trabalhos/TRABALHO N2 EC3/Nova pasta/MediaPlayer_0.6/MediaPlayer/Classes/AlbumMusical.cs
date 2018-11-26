using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class AlbumMusical : Midia, ICatalogo
    {
        public int AnoLancamento { get; set; }

        string Artista { get; set; }

        // Implementar Lista de músicas: Lista com todas as músicas que fazem parte do álbum.



    }
}
