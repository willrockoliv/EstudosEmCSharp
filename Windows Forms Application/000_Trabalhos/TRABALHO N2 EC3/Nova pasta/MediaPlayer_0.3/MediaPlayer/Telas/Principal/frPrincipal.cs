using MediaPlayer.Telas.Playlist;
using MediaPlayer.Telas.Sobre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
            frCadastro frCadastro = new frCadastro();
            frCadastro.ShowDialog();
        }

        private void BtnAleatorio_Click(object sender, EventArgs e)
        {
            //if(CkbAleatorioOff.Checked=true)
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCadastro cadastro = new frCadastro();
            cadastro.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frSobre Sobre = new frSobre();
            Sobre.ShowDialog();
        }

        private void playlistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCriarPlaylist CriarPlaylist = new frCriarPlaylist();
            CriarPlaylist.ShowDialog();
        }
    }
}
