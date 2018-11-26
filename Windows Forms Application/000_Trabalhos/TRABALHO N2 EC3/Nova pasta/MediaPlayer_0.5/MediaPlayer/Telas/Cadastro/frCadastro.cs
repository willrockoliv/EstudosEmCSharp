using MediaPlayer.EstruturaDeDados;
using MediaPlayer.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class frCadastro : Form
    {
        #region Variáveis Globais
        double duracaoMusica = 0;
        bool duracaoObtida = true;
        string caminhoArquivo;
        string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        string[] cadastro = Midia.CarregaCadastroTXT();
        #endregion

        #region Métodos
        /// <summary>
        /// Retorna o tipo de Mídia que foi importado
        /// </summary>
        /// <param name="caminhoArquivo">caminho da mídia</param>
        /// <returns>"vídeo", "musica", "foto" ou ""</returns>
        static string TipoCadastro(string caminhoArquivo)
        {
            if (Path.GetExtension(caminhoArquivo).ToUpper() == ".AVI" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".WMV" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".MKV" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".MP4" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".MPEG")
            {
                return "video";
            }
            else if (Path.GetExtension(caminhoArquivo).ToUpper() == ".MP3" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".WAV" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".WMA")
            {
                return "musica";
            }
            else if (Path.GetExtension(caminhoArquivo).ToUpper() == ".JPG" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".JPEG" ||
                    Path.GetExtension(caminhoArquivo).ToUpper() == ".PNG")
            {
                return "foto";
            }
            else
                return "";
        }

        /// <summary>
        /// Seleciona a page respectiva ao tipo de mídia importado para o devido cadastro
        /// </summary>
        /// <param name="tbcMidia"></param>
        /// <param name="caminhoArquivo"></param>
        static void ConfiguraTipoDeCadastro(TabControl tbcMidia, string caminhoArquivo)
        {
            if (TipoCadastro(caminhoArquivo) == "video")
            {
                tbcMidia.Enabled = true;
                tbcMidia.SelectTab("tbpVideo");
            }
            else if (TipoCadastro(caminhoArquivo) == "foto")
            {
                tbcMidia.Enabled = true;
                tbcMidia.SelectTab("tbpFoto");
            }
            else if (TipoCadastro(caminhoArquivo) == "musica")
            {
                tbcMidia.Enabled = true;
                tbcMidia.SelectTab("tbpMusica");
            }
            else
                tbcMidia.Enabled = false;
        }

        /// <summary>
        /// Quando uma mídia e importada este método preenche alguns campos com as informações da mídia
        /// </summary>
        /// <param name="tbcMidia"></param>
        /// <param name="txtCaminhoArquivoImportado"></param>
        /// <param name="txtDescricao"></param>
        /// <param name="txtDimensoesFoto"></param>
        /// <param name="txtFormatoVideo"></param>
        /// <param name="txtFormatoMusica"></param>
        /// <param name="PrePlayer"></param>
        /// <param name="caminhoArquivo"></param>
        /// <param name="descricao"></param>
        /// <param name="duracaoObtida"></param>
        static void PreencheCamposDoCadastro(TabControl tbcMidia, Button btnSalvar,
                                             TextBox txtCaminhoArquivoImportado, TextBox txtDescricao,
                                             TextBox txtMegapixelFoto, TextBox txtFormatoVideo, TextBox txtFormatoMusica,
                                             AxWMPLib.AxWindowsMediaPlayer PrePlayer, string caminhoArquivo, string descricao,
                                             ref bool duracaoObtida)
        {
            tbcMidia.Enabled = true;
            btnSalvar.Enabled = true;
            txtCaminhoArquivoImportado.Text = caminhoArquivo;
            txtDescricao.Text = descricao;
            ConfiguraTipoDeCadastro(tbcMidia, caminhoArquivo);

            if (TipoCadastro(caminhoArquivo) == "foto")
            {
                Image imagem = new Bitmap(caminhoArquivo);
                txtMegapixelFoto.Text = ((imagem.Height * imagem.Width) / 1000000).ToString(".0");
                PrePlayer.URL = caminhoArquivo;
            }
            else if (TipoCadastro(caminhoArquivo) == "video")
            {
                txtFormatoVideo.Text = Path.GetExtension(caminhoArquivo);
                PrePlayer.URL = caminhoArquivo;
                PrePlayer.Ctlcontrols.stop();
            }
            else if (TipoCadastro(caminhoArquivo) == "musica")
            {
                PrePlayer.URL = caminhoArquivo;
                duracaoObtida = false;
                PrePlayer.Ctlcontrols.play();
                txtFormatoMusica.Text = Path.GetExtension(caminhoArquivo);
            }
        }

        /// <summary>
        /// Quando uma mídia já cadastrada é selecionada este método preenche alguns campos com as informações da mídia
        /// </summary>
        /// <param name="tbcMidia"></param>
        /// <param name="btnSalvar"></param>
        /// <param name="txtCaminhoArquivoImportado"></param>
        /// <param name="txtDescricao"></param>
        /// <param name="cbxAnoLancamentoFoto"></param>
        /// <param name="txtMegapixelFoto"></param>
        /// <param name="mtbTempoExibicaoFoto"></param>
        /// <param name="txtLocalFoto"></param>
        /// <param name="cbxAnoLancamentoVideo"></param>
        /// <param name="txtFormatoVideo"></param>
        /// <param name="ckbPossuiLegendaVideo"></param>
        /// <param name="cbxIdiomaVideo"></param>
        /// <param name="txtDuracaoMusica"></param>
        /// <param name="txtFormatoMusica"></param>
        /// <param name="PrePlayer"></param>
        /// <param name="caminhoArquivo"></param>
        /// <param name="Midia"></param>
        /// <param name="duracaoObtida"></param>
        static void PreencheCamposDoCadastro(TabControl tbcMidia, Button btnSalvar,
                                             TextBox txtId, TextBox txtCaminhoArquivoImportado, TextBox txtDescricao,
                                             ComboBox cbxAnoLancamentoFoto, TextBox txtMegapixelFoto, MaskedTextBox mtbTempoExibicaoFoto, TextBox txtLocalFoto,
                                             ComboBox cbxAnoLancamentoVideo, TextBox txtFormatoVideo, CheckBox ckbPossuiLegendaVideo, ComboBox cbxIdiomaVideo,
                                             TextBox txtDuracaoMusica, TextBox txtFormatoMusica,
                                             AxWMPLib.AxWindowsMediaPlayer PrePlayer,
                                             string caminhoArquivo, Midia Midia, ref bool duracaoObtida)
        {
            tbcMidia.Enabled = true;
            btnSalvar.Enabled = true;
            txtId.Text = Midia.Id.ToString();
            txtCaminhoArquivoImportado.Text = caminhoArquivo;
            txtDescricao.Text = Midia.Descricao;
            ConfiguraTipoDeCadastro(tbcMidia, caminhoArquivo);

            if (TipoCadastro(caminhoArquivo) == "foto")
            {
                cbxAnoLancamentoFoto.Text = (Midia as Foto).AnoLancamento.ToString();
                Image imagem = new Bitmap(caminhoArquivo);
                txtMegapixelFoto.Text = ((imagem.Height * imagem.Width) / 1000000).ToString(".0");
                mtbTempoExibicaoFoto.Text = (Midia as Foto).TempoEmSegundosParaExibir.ToString();
                txtLocalFoto.Text = (Midia as Foto).Local;
                PrePlayer.URL = caminhoArquivo;
            }
            else if (TipoCadastro(caminhoArquivo) == "video")
            {
                cbxAnoLancamentoVideo.Text = (Midia as Video).AnoLancamento.ToString();
                ckbPossuiLegendaVideo.Checked = (Midia as Video).PossuiLegenda == true;
                cbxIdiomaVideo.Text = (Midia as Video).Idioma.ToString();
                txtFormatoVideo.Text = Path.GetExtension(caminhoArquivo);
                PrePlayer.URL = caminhoArquivo;
                PrePlayer.Ctlcontrols.stop();
            }
            else if (TipoCadastro(caminhoArquivo) == "musica")
            {
                PrePlayer.URL = caminhoArquivo;
                duracaoObtida = false;
                PrePlayer.Ctlcontrols.play();
                txtFormatoMusica.Text = Path.GetExtension(caminhoArquivo);
            }
        }

        /// <summary>
        /// Limpa cada objeto da tela
        /// </summary>
        /// <param name="txtCaminhoArquivoImportado"></param>
        /// <param name="txtID"></param>
        /// <param name="txtDescricao"></param>
        /// <param name="cbxAnoLancamentoFoto"></param>
        /// <param name="txtDimensoesFoto"></param>
        /// <param name="mtbTempoExibicaoFoto"></param>
        /// <param name="txtLocalFoto"></param>
        /// <param name="cbxAnoLancamentoVideo"></param>
        /// <param name="txtFormatoVideo"></param>
        /// <param name="cbxPossuiLegendaVideo"></param>
        /// <param name="cbxIdiomaVideo"></param>
        /// <param name="txtDuracaoMusica"></param>
        /// <param name="cbVolumeMusica"></param>
        /// <param name="txtFormatoMusica"></param>
        /// <param name="PrePlayer"></param>
        /// <param name="caminhoArquivo"></param>
        static void LimpaTela(TextBox txtCaminhoArquivoImportado, TextBox txtID, TextBox txtDescricao,
                              ComboBox cbxAnoLancamentoFoto, TextBox txtDimensoesFoto, MaskedTextBox mtbTempoExibicaoFoto, TextBox txtLocalFoto,
                              ComboBox cbxAnoLancamentoVideo, TextBox txtFormatoVideo, CheckBox ckbPossuiLegendaVideo, ComboBox cbxIdiomaVideo,
                              TextBox txtDuracaoMusica, TextBox txtFormatoMusica,
                              AxWMPLib.AxWindowsMediaPlayer PrePlayer, string[] cadastro)
        {
            txtCaminhoArquivoImportado.Text = null;
            txtID.Text = DefineProximoID(ref cadastro).ToString();
            txtDescricao.Text = null;
            PrePlayer.URL = null;

            cbxAnoLancamentoFoto.Text = null;
            txtDimensoesFoto.Text = null;
            mtbTempoExibicaoFoto.Text = null;
            txtLocalFoto.Text = null;

            cbxAnoLancamentoVideo.Text = null;
            txtFormatoVideo.Text = null;
            ckbPossuiLegendaVideo.Checked = false; ;
            cbxIdiomaVideo.Text = null;

            txtDuracaoMusica.Text = null;
            txtFormatoMusica.Text = null;
        }

        /// <summary>
        /// Preenche os atributos da classe Video
        /// </summary>
        /// <param name="caminhoArquivo"></param>
        /// <param name="p_id"></param>
        /// <param name="descricao"></param>
        /// <param name="caminhoBD"></param>
        /// <param name="p_anoLancamentoVideo"></param>
        /// <param name="formatoVideo"></param>
        /// <param name="possuiLegendaVideo"></param>
        /// <param name="idiomaVideo"></param>
        /// <returns>Retorna um objeto do tipo Video com seus atributos preenchidos</returns>
        static Video PreencheVideo(string caminhoArquivo, string p_id, string descricao, string caminhoBD,
                                   string p_anoLancamentoVideo, string formatoVideo, bool possuiLegendaVideo, string idiomaVideo)
        {
            Video Video = new Video();
            if (Video.ValidaCaminho(caminhoArquivo))
            {
                if (Int32.TryParse(p_id, out int id))
                    Video.Id = id;
                else
                    throw new Exception("ID inválido");

                if (descricao.Trim() != "")
                    Video.Descricao = descricao;
                else
                    throw new Exception("Descrição não informada");

                Video.ArquivoDeDados = "\\BD\\video";

                Video.ArquivoMidia = "\\BD\\video\\" + Path.GetFileName(caminhoArquivo);

                if (Int32.TryParse(p_anoLancamentoVideo, out int anoLancamentoVideo))
                    Video.AnoLancamento = anoLancamentoVideo;
                else
                    throw new Exception("Ano de Lançamento inválido");

                Video.Formato = Video.EFormatoVideo(formatoVideo.ToUpper().Replace(".", ""));

                Video.PossuiLegenda = (possuiLegendaVideo);

                Video.Idioma = Video.EIdioma(idiomaVideo.ToLower());


                return Video;
            }
            else
                throw new Exception("Arquivo não encontrado no caminho informado: \r\n " + caminhoArquivo +
                                    "\r\n impossível copiá-lo para: \r\n" + caminhoBD + "\\video");
        }

        /// <summary>
        /// Preenche os atributos da classe Foto
        /// </summary>
        /// <param name="caminhoArquivo"></param>
        /// <param name="p_id"></param>
        /// <param name="descricao"></param>
        /// <param name="p_anoLancamentoVideo"></param>
        /// <param name="local"></param>
        /// <param name="p_megapixel"></param>
        /// <param name="p_tempoEmSegundosParaExibir"></param>
        /// <param name="caminhoBD"></param>
        /// <returns>Retorna um objeto do tipo Foto com seus atributos preenchidos</returns>
        static Foto PreencheFoto(string caminhoArquivo, string p_id, string descricao, string p_anoLancamentoVideo,
                                 string local, string p_megapixel, string p_tempoEmSegundosParaExibir, string caminhoBD)
        {
            Foto Foto = new Foto();
            if (Foto.ValidaCaminho(caminhoArquivo))
            {
                if (Int32.TryParse(p_id, out int id))
                    Foto.Id = id;
                else
                    throw new Exception("ID inválido");

                if (descricao.Trim() != "")
                    Foto.Descricao = descricao;
                else
                    throw new Exception("Descrição não informada");

                Foto.ArquivoDeDados = "\\BD\\foto";

                Foto.ArquivoMidia = "\\BD\\foto\\" + Path.GetFileName(caminhoArquivo);

                if (Int32.TryParse(p_anoLancamentoVideo, out int anoLancamentoVideo))
                    Foto.AnoLancamento = anoLancamentoVideo;
                else
                    throw new Exception("Ano de Lançamento inválido");

                Foto.Local = local;

                if (Double.TryParse(p_megapixel, out double megapixel))
                    Foto.MegaPixels = megapixel;
                else
                    throw new Exception("Valor Megapixel inválido");

                if (Int32.TryParse(p_tempoEmSegundosParaExibir, out int tempoEmSegundosParaExibir))
                    Foto.TempoEmSegundosParaExibir = tempoEmSegundosParaExibir;
                else
                    throw new Exception("Tempo para exibir inválido");

                return Foto;
            }
            else
                throw new Exception("Arquivo não encontrado no caminho informado: \r\n " + caminhoArquivo +
                                    "\r\n impossível copiá-lo para: \r\n" + caminhoBD + "\\foto");
        }

        /// <summary>
        /// Preenche os atributos da classe Musica
        /// </summary>
        /// <param name="caminhoArquivo"></param>
        /// <param name="p_id"></param>
        /// <param name="descricao"></param>
        /// <param name="p_duracaoMusica"></param>
        /// <param name="formatoMusica"></param>
        /// <param name="caminhoBD"></param>
        /// <returns>Retorna um objeto do tipo Musica com seus atributos preenchidos</returns>
        static Musica PreencheMusica(string caminhoArquivo, string p_id, string descricao, string p_duracaoMusica,
                                   string formatoMusica, string caminhoBD)
        {
            Musica Musica = new Musica();
            if (Musica.ValidaCaminho(caminhoArquivo))
            {
                if (Int32.TryParse(p_id, out int id))
                    Musica.Id = id;
                else
                    throw new Exception("ID inválido");

                if (descricao.Trim() != "")
                    Musica.Descricao = descricao;
                else
                    throw new Exception("Descrição não informada");

                Musica.ArquivoDeDados = "\\BD\\musica";

                Musica.ArquivoMidia = "\\BD\\musica\\" + Path.GetFileName(caminhoArquivo);

                if (double.TryParse(p_duracaoMusica, out double duracaoMusica))
                    Musica.Duracao = duracaoMusica;
                else
                    throw new Exception("Duração Inválida");

                Musica.Formato = Musica.EFormatoMusica(formatoMusica.ToUpper().Replace(".", ""));

                return Musica;
            }
            else
                throw new Exception("Arquivo não encontrado no caminho informado: \r\n " + caminhoArquivo +
                                    "\r\n impossível copiá-lo para: \r\n" + caminhoBD + "\\musica");
        }

        /// <summary>
        /// Valida se a mídia existe e copia para uma pasta de uso do sistema
        /// </summary>
        /// <param name="caminhoArquivo"></param>
        /// <param name="arquivoDeDados"></param>
        static void CopiaArquivo(string caminhoArquivo, string arquivoDeDados, string descricao)
        {
            if (File.Exists(caminhoArquivo))
                if (Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + arquivoDeDados))
                    try
                    { File.Copy(caminhoArquivo, Path.GetDirectoryName(Application.ExecutablePath) + arquivoDeDados + "\\" + descricao); }
                    catch
                    { throw new Exception(string.Format("Não foi possível copiar a mídia. O arquivo {0} já existe.", descricao)); }
                else
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + arquivoDeDados);
                    try
                    { File.Copy(caminhoArquivo, Path.GetDirectoryName(Application.ExecutablePath) + arquivoDeDados + "\\" + descricao); }
                    catch
                    { throw new Exception(string.Format("Não foi possível copiar a mídia. O arquivo {0} já existe.", descricao)); }
                }
            else
                throw new Exception("Midia não encontrada");
        }

        /// <summary>
        /// Chama o método Incluir() da classe correspondente ao tipo de mídia importado
        /// </summary>
        /// <param name="midia"></param>
        static void Salvar(Midia midia)
        {
            if (midia is Video)
            {
                if (Midia.Existe((midia as Video).Id))
                    midia.Alterar((midia as Video).ToString(), (midia as Video).Id);
                else
                    midia.Inclui((midia as Video).ToString());
            }
            else if (midia is Foto)
            {
                if (Midia.Existe((midia as Foto).Id))
                    midia.Alterar((midia as Foto).ToString(), (midia as Foto).Id);
                else
                    midia.Inclui((midia as Foto).ToString());
            }
            else if (midia is Musica)
            {
                if (Midia.Existe((midia as Musica).Id))
                    midia.Alterar((midia as Musica).ToString(), (midia as Musica).Id);
                else
                    midia.Inclui((midia as Musica).ToString());
            }
        }

        /// <summary>
        /// Define o número do proximo ID a partir do último ID cadastrado
        /// </summary>
        /// <param name="cadastro"></param>
        /// <returns>Retorna o ultimo ID + 1</returns>
        static int DefineProximoID(ref string[] cadastro)
        {
            cadastro = Midia.CarregaCadastroTXT();
            if (cadastro.Length == 0)
                return 0;
            else
            {
                string[] temp = cadastro[cadastro.Length - 1].Split('|');
                string newID = temp[0].Replace("<Id>", "");
                return Convert.ToInt32(newID) + 1;
            }
        }
        #endregion

        private void frCadastro_Load(object sender, EventArgs e)
        {
            txtID.Text = DefineProximoID(ref cadastro).ToString();
        }

        public frCadastro()
        {
            InitializeComponent();
        }

        #region Eventos
        /// <summary>
        /// Processo de importação de mídia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog importArquivo = new OpenFileDialog();
            importArquivo.Filter = "Vídeo:|*.AVI; *.WMV; *.MKV ; *.MP4; *.MPEG" +
                                   "|Áudio:|*.MP3; *.WAV; *.WMA" +
                                   "|Imagem:|*.JPG; *.JPEG; *.PNG";
            if (importArquivo.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = importArquivo.FileName;

                string descricao = Path.GetFileName(importArquivo.FileName);

                LimpaTela(txtCaminhoArquivoImportado, txtID, txtDescricao,
                          cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                          cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                          txtDuracaoMusica, txtFormatoMusica,
                          PrePlayer, cadastro);

                PreencheCamposDoCadastro(tbcMidia, btnSalvar, txtCaminhoArquivoImportado, txtDescricao, txtMegapixelFoto, txtFormatoVideo,
                                         txtFormatoMusica, PrePlayer, caminhoArquivo, descricao, ref duracaoObtida);
            }
        }

        /// <summary>
        /// Impede o usuário de trocar o tipo de cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbcMidia_Selected(object sender, TabControlEventArgs e)
        {
            ConfiguraTipoDeCadastro(tbcMidia, txtCaminhoArquivoImportado.Text);
        }

        /// <summary>
        /// Este evento é chamado no momento em que é importado o arquivo de música para pegar o a duração dela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrePlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (duracaoObtida == false)
                if (PrePlayer.currentMedia != null)
                {
                    duracaoObtida = true;
                    duracaoMusica = PrePlayer.currentMedia.duration;
                    txtDuracaoMusica.Text = duracaoMusica.ToString(".0");
                    PrePlayer.Ctlcontrols.stop();
                }
        }

        /// <summary>
        /// Processo de salvar o cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (TipoCadastro(caminhoArquivo) == "video")
            {
                try
                {
                    Video Video = PreencheVideo(caminhoArquivo, txtID.Text, txtDescricao.Text, caminhoBD,
                                                cbxAnoLancamentoVideo.Text, txtFormatoVideo.Text,
                                                ckbPossuiLegendaVideo.Checked, cbxIdiomaVideo.Text);
                    if (!Midia.Existe(Video.Id))
                        CopiaArquivo(caminhoArquivo, Video.ArquivoDeDados, Video.Descricao);
                    Salvar(Video);
                    LimpaTela(txtCaminhoArquivoImportado, txtID, txtDescricao,
                              cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                              cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                              txtDuracaoMusica, txtFormatoMusica,
                              PrePlayer, cadastro);
                    MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (TipoCadastro(caminhoArquivo) == "foto")
            {
                try
                {
                    Foto Foto = PreencheFoto(caminhoArquivo, txtID.Text, txtDescricao.Text, cbxAnoLancamentoFoto.Text,
                                             txtLocalFoto.Text, txtMegapixelFoto.Text, mtbTempoExibicaoFoto.Text, caminhoBD);
                    if (!Midia.Existe(Foto.Id))
                        CopiaArquivo(caminhoArquivo, Foto.ArquivoDeDados, Foto.Descricao);
                    Salvar(Foto);
                    LimpaTela(txtCaminhoArquivoImportado, txtID, txtDescricao,
                              cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                              cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                              txtDuracaoMusica, txtFormatoMusica,
                              PrePlayer, cadastro);
                    MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (TipoCadastro(caminhoArquivo) == "musica")
            {
                try
                {
                    Musica Musica = PreencheMusica(caminhoArquivo, txtID.Text, txtDescricao.Text, txtDuracaoMusica.Text,
                                                   txtFormatoMusica.Text, caminhoBD);
                    if (!Midia.Existe(Musica.Id))
                        CopiaArquivo(caminhoArquivo, Musica.ArquivoDeDados, Musica.Descricao);
                    Salvar(Musica);
                    LimpaTela(txtCaminhoArquivoImportado, txtID, txtDescricao,
                              cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                              cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                              txtDuracaoMusica, txtFormatoMusica,
                              PrePlayer, cadastro);
                    MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Fecha a tela de cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abre uma tela de pesquisa onde será possível abrir o cadastro de uma mídia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frPesquisa frPesquisa = new frPesquisa();
            frPesquisa.ShowDialog();
            if (frPesquisa.Retorno != null)
            {
                Midia Midia = frPesquisa.Retorno;
                if (Midia is Foto)
                    caminhoArquivo = Path.GetDirectoryName(Application.ExecutablePath) + (Midia as Foto).ArquivoMidia;
                else if (Midia is Video)
                    caminhoArquivo = Path.GetDirectoryName(Application.ExecutablePath) + (Midia as Video).ArquivoMidia;
                else if (Midia is Musica)
                    caminhoArquivo = Path.GetDirectoryName(Application.ExecutablePath) + (Midia as Musica).ArquivoMidia;

                PreencheCamposDoCadastro(tbcMidia, btnSalvar,
                                         txtID, txtCaminhoArquivoImportado, txtDescricao,
                                         cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                                         cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                                         txtDuracaoMusica, txtFormatoMusica,
                                         PrePlayer, caminhoArquivo, Midia, ref duracaoObtida);
            }

        }

        /// <summary>
        /// Limpa os campos para iniciar um novo cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaTela(txtCaminhoArquivoImportado, txtID, txtDescricao,
                              cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                              cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                              txtDuracaoMusica, txtFormatoMusica,
                              PrePlayer, cadastro);
        }

        /// <summary>
        /// Esses eventos controlam o botões de Minimizar, Maximizar e Fechar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Minimize, Maximize, Fecha
        private void panFechar_MouseHover(object sender, EventArgs e)
        {
            panFechar.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void panFechar_MouseLeave(object sender, EventArgs e)
        {
            panFechar.BackColor = Color.MidnightBlue;
        }

        private void panMaximixar_MouseHover(object sender, EventArgs e)
        {
            panMaximixar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panMaximixar_MouseLeave(object sender, EventArgs e)
        {
            panMaximixar.BackColor = Color.MidnightBlue;
        }

        private void panMinimizar_MouseHover(object sender, EventArgs e)
        {
            panMinimizar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panMinimizar_MouseLeave(object sender, EventArgs e)
        {
            panMinimizar.BackColor = Color.MidnightBlue;
        }

        private void panFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panMaximixar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void panMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        /// <summary>
        /// Exclui o cadastro do arquivo cadastro.txt e a midia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            PrePlayer.Ctlcontrols.stop();
            Midia.Excluir(id);
            LimpaTela(txtCaminhoArquivoImportado, txtID, txtDescricao,
                          cbxAnoLancamentoFoto, txtMegapixelFoto, mtbTempoExibicaoFoto, txtLocalFoto,
                          cbxAnoLancamentoVideo, txtFormatoVideo, ckbPossuiLegendaVideo, cbxIdiomaVideo,
                          txtDuracaoMusica, txtFormatoMusica,
                          PrePlayer, cadastro);
        }
        #endregion
    }
}
