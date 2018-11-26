using MediaPlayer.EstruturaDeDados;
using MediaPlayer.EstruturaDeDados.Fila;
using MediaPlayer.EstruturaDeDados.Ordenacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Telas
{
    /// <summary>
    /// Nesta tela, o usuário poderá escolher as mídias que deseja tocar no player.
    /// Deve-se listar as mídias e permitir que o usuário monte um playlist para reproduzir as mídias.
    /// 
    /// Ao exibir as mídias para que o usuário as selecione, deve ser possível lista-las das seguintes maneiras:
    ///•	Ordem Alfabética(não importa a mídia, todas em ordem alfabética)
    ///•	Por tipo de mídia(álbum / música / vídeo / foto) e uma vez escolhido o tipo, exibir em ordem alfabética.
    ///•	Por ano(exibir uma forma da pessoa selecionar o ano e então devem ser exibidas as mídias que constam nesse ano)
    /// </summary>
    public partial class frPlaylist : Form
    {
        static string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        static string caminhoPlaylistTXT = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\playlist.txt";
        static string[] cadastro = Midia.CarregaCadastroTXT();
        static FilaDinamica FilaMidias = Ordenacao.OrdenaFilaPorDescricao(cadastro);
        static string[] playlistTXT = CarregaPlaylistTXT();

        static void ValidaArquivos()
        {
            if (!Directory.Exists(caminhoBD))
                Directory.CreateDirectory(caminhoBD);

            if (!File.Exists(caminhoPlaylistTXT))
                File.WriteAllText(caminhoPlaylistTXT, "");
        }

        static void PreencheComboBox(ComboBox cbxMidiaNovo, ComboBox cbxPlaylistNomeAlterar, ComboBox cbxOutrasMidiasAlterar)
        {
            cbxMidiaNovo.Items.Clear();
            cbxPlaylistNomeAlterar.Items.Clear();
            cbxOutrasMidiasAlterar.Items.Clear();

            playlistTXT = CarregaPlaylistTXT();
            foreach (string item in cadastro)
            {
                string[] temp = item.Split('|');
                string descricao = temp[1].Replace("<Descricao>", "");

                cbxMidiaNovo.Items.Add(descricao);

                cbxOutrasMidiasAlterar.Items.Add(descricao);
            }
            foreach (string item in playlistTXT)
            {
                cbxPlaylistNomeAlterar.Items.Add(item);
            }
        }

        /// <summary>
        /// Filtra as mídias que serão exibidas pelo ano de lançamento e/ou tipo de mídia
        /// </summary>
        /// <param name="p_tipoMidia"></param>
        /// <param name="p_anoLancto"></param>
        /// <param name="cbxMidia"></param>
        static void FiltraComboBox(string p_tipoMidia, string p_anoLancto, ComboBox cbxMidia, bool musica)
        {
            string[] midias = new string[cadastro.Length];
            cadastro = Midia.CarregaCadastroTXT();

            if (p_tipoMidia != "")
            {
                int i = 0;
                foreach (string item in cadastro)
                {
                    string[] temp = item.Split('|');
                    string tipoMidia = temp[3].Replace("<Midia>", "");

                    if (tipoMidia == p_tipoMidia)
                        midias[i++] = item;
                }
                Array.Resize(ref midias, i);
            }
            else
                midias = cadastro;

            if (p_anoLancto != "")
            {
                int j = 0;
                foreach (string item in midias)
                {
                    string[] temp = item.Split('|');
                    string anoLancto;
                    if (musica)
                    {
                        string albumCadastro = AlbumMusical.ConsultaAlbumPorID(temp[0].Replace("<Id>", ""));
                        string[] aux = albumCadastro.Split('|');
                        anoLancto = aux[2];
                    }
                    else
                        anoLancto = temp[5].Replace("<AnoLancamento>", "");

                    if (anoLancto == p_anoLancto)
                        midias[j++] = item;
                }
                Array.Resize(ref midias, j);
            }

            foreach (string item in midias)
            {
                string[] temp = item.Split('|');
                cbxMidia.Items.Add(temp[1].Replace("<Descricao>", ""));
            }
        }

        static string[] CarregaPlaylistTXT()
        {
            ValidaArquivos();
            return File.ReadAllLines(caminhoPlaylistTXT, Encoding.Default);
        }



        public frPlaylist()
        {
            InitializeComponent();
        }

        private void frPlaylist_Load(object sender, EventArgs e)
        {
            PreencheComboBox(cbxMidiaNovo, cbxPlaylistNomeAlterar, cbxOutrasMidiasAlterar);

        }

        private void cbxTipoMidiaNovo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMidiaNovo.Text == "Foto" || cbxTipoMidiaNovo.Text == "Video")
            {
                cbxMidiaNovo.Items.Clear();
                FiltraComboBox(cbxTipoMidiaNovo.Text, cbxAnoLancamentoNovo.Text, cbxMidiaNovo, false);
            }
            else if (cbxTipoMidiaNovo.Text == "Musica")
            {
                cbxMidiaNovo.Items.Clear();
                FiltraComboBox(cbxTipoMidiaNovo.Text, cbxAnoLancamentoNovo.Text, cbxMidiaNovo, true);
            }
            else if (cbxTipoMidiaNovo.Text == "")
            {
                cbxMidiaNovo.Items.Clear();
                PreencheComboBox(cbxMidiaNovo, cbxPlaylistNomeAlterar, cbxOutrasMidiasAlterar);
            }
        }

        private void cbxAnoLancamentoNovo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMidiaNovo.Text == "Musica")
            {
                cbxMidiaNovo.Items.Clear();
                FiltraComboBox(cbxTipoMidiaNovo.Text, cbxAnoLancamentoNovo.Text, cbxMidiaNovo, true);
            }
            else
            {
                cbxMidiaNovo.Items.Clear();
                FiltraComboBox(cbxTipoMidiaNovo.Text, cbxAnoLancamentoNovo.Text, cbxMidiaNovo, false);
            }
        }

        private void btnAddMidiaNovo_Click(object sender, EventArgs e)
        {
            if (cbxMidiaNovo.Text == "")
                return;
            else
                ltbPlaylist.Items.Add(cbxMidiaNovo.Text);
        }

        private void btnLimparPlaylist_Click(object sender, EventArgs e)
        {
            ltbPlaylist.Items.Clear();
        }

        private void btnRemoverItemPlaylist_Click(object sender, EventArgs e)
        {
            ltbPlaylist.Items.Remove(ltbPlaylist.SelectedItem.ToString());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ltbPlaylist.Items.Count == 0)
                return;
            else
            {
                playlistTXT = CarregaPlaylistTXT();
                foreach (string item in playlistTXT)
                {
                    if (item == txtPlaylistNomeNovo.Text)
                    {
                        MessageBox.Show("Já Existe uma playlist com esse título", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (txtPlaylistNomeNovo.Text == "" && tbpNovo.Focus() == true)
                    MessageBox.Show("Preencha o nome da playlist", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!Directory.Exists(caminhoBD + "\\playlist"))
                    Directory.CreateDirectory(caminhoBD + "\\playlist");

                if (tbpNovo.Focus())
                    File.AppendAllText(caminhoPlaylistTXT, txtPlaylistNomeNovo.Text + Environment.NewLine, Encoding.Default);
                else if (tbpAlterar.Focus())
                    File.WriteAllText(caminhoBD + "\\playlist\\" + cbxPlaylistNomeAlterar.Text + ".txt", null);


                string[] midias = new string[ltbPlaylist.Items.Count];
                for (int i = 0; i < ltbPlaylist.Items.Count; i++)
                {
                    midias[i] = ltbPlaylist.Items[i].ToString();
                }

                string[] cadastro = Midia.CarregaCadastroTXT();
                for (int i = 0; i < midias.Length; i++)
                {
                    string tempMidias = midias[i];
                    for (int j = 0; j < cadastro.Length; j++)
                    {
                        string[] tempCadastro = cadastro[j].Split('|');
                        if (tempMidias == tempCadastro[1].Replace("<Descricao>", ""))
                        {
                            if (tbpNovo.Focus())
                                File.AppendAllText(caminhoBD + "\\playlist\\" + txtPlaylistNomeNovo.Text + ".txt", cadastro[j] + Environment.NewLine, Encoding.Default);
                            else if (tbpAlterar.Focus())
                                File.AppendAllText(caminhoBD + "\\playlist\\" + cbxPlaylistNomeAlterar.Text + ".txt", cadastro[j] + Environment.NewLine, Encoding.Default);

                            break;
                        }
                    }
                }


                txtPlaylistNomeNovo.Text = null;
                cbxTipoMidiaNovo.Text = null;
                cbxAnoLancamentoNovo.Text = null;
                cbxMidiaNovo.Text = null;
                ltbPlaylist.Items.Clear();
                MessageBox.Show("Salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void cbxPlaylistNomeAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbPlaylist.Items.Clear();
            cbxMidiasPlaylistAlterar.Items.Clear();
            string[] arquivo = File.ReadAllLines(caminhoBD + "\\playlist\\" + cbxPlaylistNomeAlterar.Text + ".txt", Encoding.Default);
            foreach (string linha in arquivo)
            {
                string[] temp = linha.Split('|');
                cbxMidiasPlaylistAlterar.Items.Add(temp[1].Replace("<Descricao>", ""));
                ltbPlaylist.Items.Add(temp[1].Replace("<Descricao>", ""));
            }
        }

        private void cbxtipoMidiaAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxtipoMidiaAlterar.Text == "Foto" || cbxtipoMidiaAlterar.Text == "Video")
            {
                cbxOutrasMidiasAlterar.Items.Clear();
                FiltraComboBox(cbxtipoMidiaAlterar.Text, cbxAnoLancamentoAlterar.Text, cbxOutrasMidiasAlterar, false);
            }
            else if (cbxtipoMidiaAlterar.Text == "Musica")
            {
                cbxOutrasMidiasAlterar.Items.Clear();
                FiltraComboBox(cbxtipoMidiaAlterar.Text, cbxAnoLancamentoAlterar.Text, cbxOutrasMidiasAlterar, true);
            }
            else if (cbxtipoMidiaAlterar.Text == "")
            {
                cbxOutrasMidiasAlterar.Items.Clear();
                PreencheComboBox(cbxMidiaNovo, cbxPlaylistNomeAlterar, cbxOutrasMidiasAlterar);
            }
        }

        private void cbxAnoLancamentoAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxtipoMidiaAlterar.Text == "Musica")
            {
                cbxOutrasMidiasAlterar.Items.Clear();
                FiltraComboBox(cbxtipoMidiaAlterar.Text, cbxAnoLancamentoAlterar.Text, cbxOutrasMidiasAlterar, true);
            }
            else
            {
                cbxOutrasMidiasAlterar.Items.Clear();
                FiltraComboBox(cbxtipoMidiaAlterar.Text, cbxAnoLancamentoAlterar.Text, cbxOutrasMidiasAlterar, false);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbPlaylist.Items.Clear();
        }

        private void btnAddMidiaAlterar_Click(object sender, EventArgs e)
        {
            ltbPlaylist.Items.Add(cbxOutrasMidiasAlterar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}