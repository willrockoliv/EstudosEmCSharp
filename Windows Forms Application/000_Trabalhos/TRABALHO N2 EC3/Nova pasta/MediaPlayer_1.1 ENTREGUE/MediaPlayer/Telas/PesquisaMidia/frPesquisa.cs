using MediaPlayer.EstruturaDeDados;
using MediaPlayer.EstruturaDeDados.Fila;
using MediaPlayer.EstruturaDeDados.Ordenacao;
using System;
using System.Collections;
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
    public partial class frPesquisa : Form
    {
        #region Variáveis
        string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        string[] cadastro = Midia.CarregaCadastroTXT();
        FilaDinamica FilaMidiaPorDescricao = new FilaDinamica();
        Midia retorno;
        #endregion

        /// <summary>
        /// Guarda a mídia que foi selecionado pelo usuário em uma listbox
        /// </summary>
        public Midia Retorno { get { return retorno; } set { retorno = value; } }

        public frPesquisa()
        {
            InitializeComponent();
        }

        private void frPesquisa_Load(object sender, EventArgs e)
        {
            FilaMidiaPorDescricao = Ordenacao.OrdenaFilaPorDescricao(cadastro);
            while (FilaMidiaPorDescricao.Tamanho() != 0)
            {
                Midia Midia = FilaMidiaPorDescricao.Desenfileira();
                if (Midia is Foto)
                    ltbFoto.Items.Add(Midia.Descricao);
                else if (Midia is Video)
                    ltbVideo.Items.Add(Midia.Descricao);
                else if (Midia is Musica)
                    ltbMusica.Items.Add(Midia.Descricao);
            }
        }

        #region Eventos
        #region Valida cliques
        private void ltbFoto_Click(object sender, EventArgs e)
        {
            ltbVideo.SelectedIndex = -1;
            ltbMusica.SelectedIndex = -1;
        }

        private void ltbVideo_Click(object sender, EventArgs e)
        {
            ltbFoto.SelectedIndex = -1;
            ltbMusica.SelectedIndex = -1;
        }

        private void ltbMusica_Click(object sender, EventArgs e)
        {
            ltbFoto.SelectedIndex = -1;
            ltbVideo.SelectedIndex = -1;
        }
        #endregion

        /// <summary>
        /// Seleciona a Midia refente à selecionada em uma listbox e grava em Retorno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            FilaMidiaPorDescricao = Ordenacao.OrdenaFilaPorDescricao(cadastro);
            int tamanho = FilaMidiaPorDescricao.Tamanho();
            int cont = 0;
            if (ltbFoto.SelectedIndex != -1)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Midia Midia = FilaMidiaPorDescricao.Desenfileira();
                    if (Midia is Foto)
                    {
                        if (cont == ltbFoto.SelectedIndex)
                        {
                            retorno = Midia;
                            Close();
                        }
                        cont++;
                    }
                }
            }
            else if (ltbMusica.SelectedIndex != -1)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Midia Midia = FilaMidiaPorDescricao.Desenfileira();
                    if (Midia is Musica)
                    {
                        if (cont == ltbMusica.SelectedIndex)
                        {
                            retorno = Midia;
                            Close();
                        }
                        cont++;
                    }
                }
            }
            else if (ltbVideo.SelectedIndex != -1)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Midia Midia = FilaMidiaPorDescricao.Desenfileira();
                    if (Midia is Video)
                    {
                        if (cont == ltbVideo.SelectedIndex)
                        {
                            retorno = Midia;
                            Close();
                        }
                        cont++;
                    }
                }
            }
            else
                return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
