using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace teste2
{
    public partial class frPrincipal : Form
    {
        SoundPlayer Music = new SoundPlayer(@"Summer_Song.wav");
        string[] configuracaoVetor;
        public frPrincipal()
        {
            InitializeComponent();

            string configuracaoTexto = File.ReadAllText("Cfg.txt");
            configuracaoVetor = configuracaoTexto.Split('|');
            if (configuracaoVetor[0] == "True")
                Music.PlayLooping();
            else
                Music.Stop();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            frJogo jogo = new frJogo();
            jogo.ShowDialog();
            string[] arquivo = File.ReadAllLines("PontuacaoFinal.txt", Encoding.Default);
            File.AppendAllLines("recordes.txt", arquivo, Encoding.Default);
            File.WriteAllText("PontuacaoFinal.txt", null);
        }

        private void jogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                Close();
        }

        private void recordesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frRecordes recordes = new frRecordes();
            recordes.ShowDialog();
        }

        private void programadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProgramadores programadores = new frProgramadores();
            programadores.ShowDialog();
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frSobre sobre = new frSobre();
            sobre.ShowDialog();
        }

        private void oQueÉSuperTrunfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frInfo info = new frInfo();
            info.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frManual manual = new frManual();
            manual.ShowDialog();
        }

        private void CadastroCartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCadastro cadastro = new frCadastro();
            cadastro.ShowDialog();
        }

        private void configuraçõesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frConfiguracao configuracao = new frConfiguracao();
            configuracao.ShowDialog();
            if (configuracao.som == false)
                Music.Stop();
            else
                Music.PlayLooping();
        }
    }
}
