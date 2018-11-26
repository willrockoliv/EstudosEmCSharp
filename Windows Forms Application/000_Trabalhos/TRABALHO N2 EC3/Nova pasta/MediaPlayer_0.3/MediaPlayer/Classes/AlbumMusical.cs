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

        public override void Alterar()
        {
            throw new NotImplementedException();
        }

        

        public override void Excluir()
        {
            throw new NotImplementedException();
        }


        
        // Implementar Lista de músicas: Lista com todas as músicas que fazem parte do álbum.



    }
}
