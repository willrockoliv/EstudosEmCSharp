using MediaPlayer.EstruturaDeDados;
using MediaPlayer.EstruturaDeDados.Fila;
using MediaPlayer.EstruturaDeDados.Pilha;
using MediaPlayer.Telas;
using MediaPlayer.Telas.Sobre;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer
{
   
    struct Exibir
    {
        public int id;
        public string descricao;
        public string caminho;
        public string tipo;
        public string caminhoCompleto;
    }
    
    public partial class frPrincipal : Form
    {
        static string TocarPilha(PilhaDinamica pilha)
        {
            
            string caminho = pilha.RetornaTopo().ArquivoDeDados + "\\" + pilha.RetornaTopo().Descricao;
            
            pilha.Desempilhar();
            return caminho;
        }
        Musica Musica = new Musica();
        Video Video = new Video();
        Foto Foto = new Foto();
        PilhaDinamica pilha = new PilhaDinamica();
        ListaDinamica lista = new ListaDinamica();
        FilaDinamica fila = new FilaDinamica();
        public frPrincipal()
        {
            InitializeComponent();
            
        }

        private void BtnAleatorio_Click(object sender, EventArgs e)
        {
            int qntd = LbPlaylistExibição.Items.Count;
            LbPlaylistExibição.Items.Clear();
            if (CkbAleatorioOff.Checked==true)
            {
                CkbAleatorioOff.Checked = false;
                CkbAleatorioOn.Checked = true;
                Random sorteio = new Random();
                String [] tamanholista = fila.Listagem();
                Exibir[] tamanho = new Exibir[qntd];
                for (int n = 0; n < qntd; n++)
                {
                    string[] temp = tamanholista[n].Split('|');
                    int id = Convert.ToInt32(temp[0].Replace("<Id>", ""));
                    tamanho[n].id = id;
                    string descricao = temp[1].Replace("<Descricao>", "");
                    tamanho[n].descricao = descricao;
                    string caminho = temp[2].Replace("<ArquivoDeDados>", "");
                    tamanho[n].caminho = caminho;
                    string tipo = temp[3].Replace("<Midia>", "");
                    tamanho[n].tipo = tipo;
                    string caminhoCompleto = temp[4].Replace("<ArquivoMidia>", "");
                    tamanho[n].caminhoCompleto = caminhoCompleto;
                    if (tipo == "Foto")
                    {
                        Foto.Id = id;
                        Foto.Descricao = descricao;
                        Foto.ArquivoDeDados = caminho;
                        Foto.ArquivoMidia = caminhoCompleto;
                        pilha.Empilhar(Foto);
                        fila.Enfileirar(Foto);
                        lista.InserirNoFim(Foto);
                    }
                    else if (tipo == "Video")
                    {
                        Video.Id = id;
                        Video.Descricao = descricao;
                        Video.ArquivoDeDados = caminho;
                        Video.ArquivoMidia = caminhoCompleto;
                        pilha.Empilhar(Video);
                        fila.Enfileirar(Video);
                        lista.InserirNoFim(Video);
                    }
                    else
                    {
                        Musica.Id = id;
                        Musica.Descricao = descricao;
                        Musica.ArquivoDeDados = caminho;
                        Musica.ArquivoMidia = caminhoCompleto;
                        pilha.Empilhar(Musica);
                        fila.Enfileirar(Musica);
                        lista.InserirNoFim(Musica);
                    }
                    LbPlaylistExibição.Items.Add(tamanho[sorteio.Next(0, qntd)].descricao);
                }
            }
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
            timer1.Start();
            string[] arquivo = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\playlist.txt", Encoding.Default);

            for (int n = 0; n < arquivo.Length; n++)
            {
                CbPlaylistPrincipal.Items.Add(arquivo[n]);
            }
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            
        
            string[] exibir = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\playlist\\" + CbPlaylistPrincipal.Text + ".txt", Encoding.Default);
            Exibir[] separar = new Exibir[exibir.Length];
            for (int n = 0; n < exibir.Length; n++)
            {
                string[] linha = exibir[n].Split('|');
                int id = Convert.ToInt32(linha[0].Replace("<Id>", ""));
                separar[n].id = id;
                string descricao = linha[1].Replace("<Descricao>", "");
                separar[n].descricao = descricao;
                string caminho = linha[2].Replace("<ArquivoDeDados>", "");
                separar[n].caminho = caminho;
                string tipo = linha[3].Replace("<Midia>", "");
                separar[n].tipo = tipo;
                string caminhoCompleto = linha[4].Replace("<ArquivoMidia>", "");
                separar[n].caminhoCompleto = caminhoCompleto;
                if(tipo=="Foto")
                {
                    Foto.Id = id;
                    Foto.Descricao = descricao;
                    Foto.ArquivoDeDados = caminho;
                    Foto.ArquivoMidia = caminhoCompleto;
                    pilha.Empilhar(Foto);
                    fila.Enfileirar(Foto);
                    lista.InserirNoFim(Foto);
                }
                else if (tipo=="Video")
                {
                    Video.Id = id;
                    Video.Descricao = descricao;
                    Video.ArquivoDeDados = caminho;
                    Video.ArquivoMidia = caminhoCompleto;
                    pilha.Empilhar(Video);
                    fila.Enfileirar(Video);
                    lista.InserirNoFim(Video);
                }
                else
                {
                    Musica.Id = id;
                    Musica.Descricao = descricao;
                    Musica.ArquivoDeDados = caminho;
                    Musica.ArquivoMidia = caminhoCompleto;
                    pilha.Empilhar(Musica);
                    fila.Enfileirar(Musica);
                    lista.InserirNoFim(Musica);
                }
                LbPlaylistExibição.Items.Add(separar[n].descricao);
            }

           
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            PlayerPrincipal.Ctlcontrols.stop();
        }

        private void BtnPlayPilha_Click(object sender, EventArgs e)
        {
            int num = pilha.Quantidade;
            PlayerPrincipal.URL = (Path.GetDirectoryName(Application.ExecutablePath) + TocarPilha(pilha));
            
            LbPlaylistExibição.SelectedIndex = num - 1;
            BtnPlayPilha.Enabled = false;
            //pilha.Desempilhar();
        }

        private void BtnStop_MouseClick(object sender, MouseEventArgs e)
        {
            PlayerPrincipal.Ctlcontrols.stop();
            if (BtnPlayPilha.Enabled == false)
                BtnPlayPilha.Enabled = true;
            else if (BtnPlayLista.Enabled == false)
                BtnPlayLista.Enabled = true;
            else
                BtnPlayFila.Enabled = true;
        }

        private void PlayerPrincipal_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
           //if (PlayerPrincipal.playState == WMPPlayState.wmppsStopped && BtnPlayPilha.Enabled == false)
            {
             //   PlayerPrincipal.URL = (Path.GetDirectoryName(Application.ExecutablePath) + TocarPilha(pilha));
               // PlayerPrincipal.Ctlcontrols.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PlayerPrincipal.playState.ToString()=="wmppsStopped"&& BtnPlayPilha.Enabled == false&&pilha.Quantidade>0)
                PlayerPrincipal.URL = (Path.GetDirectoryName(Application.ExecutablePath) + TocarPilha(pilha));
        }
    }
}
