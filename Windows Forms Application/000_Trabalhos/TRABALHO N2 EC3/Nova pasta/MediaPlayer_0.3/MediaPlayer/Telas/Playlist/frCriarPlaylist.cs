using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Telas.Playlist
{
    public partial class frCriarPlaylist : Form
    {
        /// <summary>
        /// Ao exibir as mídias para que o usuário as selecione, deve ser possível lista-las das seguintes maneiras:
        /// •	Ordem Alfabética (não importa a mídia, todas em ordem alfabética)
        /// •	Por tipo de mídia(álbum / música / vídeo / foto) e uma vez escolhido o tipo, exibir em ordem alfabética.
        /// •	Por ano(exibir uma forma da pessoa selecionar o ano e então devem ser exibidas as mídias que constam nesse ano)
        /// </summary>
        public frCriarPlaylist()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            frPrincipal Principal = new frPrincipal();
            Principal.ShowDialog();
        }
    }
}
