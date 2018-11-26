using MediaPlayer.Telas;
using MediaPlayer.Telas.Sobre;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class frPrincipal : Form
    {
        public frPrincipal()
        {
            InitializeComponent();
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
            frPlaylist Playlist = new frPlaylist();
            Playlist.ShowDialog();
        }

        private void frPrincipal_Load(object sender, EventArgs e)
        {
            string[] arquivo = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\playlist.txt", Encoding.Default);
            for (int n = 0; n < arquivo.Length; n++)
            {
                CbPlaylistPrincipal.Items.Add(arquivo[n]);
            }
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            string[] exibir = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\playlist\\"+CbPlaylistPrincipal.Text+".txt", Encoding.Default);
            for (int n = 0; n < exibir.Length; n++)
            {
               LbPlaylistExibição.Items.Add(exibir[n]);
            }
        }
    }
}
