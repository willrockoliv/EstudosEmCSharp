using MediaPlayer.EstruturaDeDados;
using MediaPlayer.EstruturaDeDados.Fila;
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
    public partial class frPesquisa : Form
    {
        string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";
        string[] cadastro = Midia.CarregaCadastroTXT();
        FilaDinamica FilaMidias = new FilaDinamica();
        FilaDinamica FilaMidiasPorDescricao = new FilaDinamica();
        FilaDinamica FilaMidiasPorID = new FilaDinamica();

        /// <summary>
        /// Preenche a FilaDeMidiasa a partir do vetor de cadastros carregado do cadastro.txt 
        /// </summary>
        /// <param name="FilaMidias">Objeto que sera preenchido</param>
        /// <param name="cadastro">vetor com os cadastroscarregados do arquivo cadastro.txt</param>
        static void PreencheFila(FilaDinamica FilaMidias, string[] cadastro)
        {
            foreach (string linha in cadastro)
            {
                string[] temp = linha.Split('|');
                int id = Convert.ToInt32(temp[0].Replace("<Id>", ""));
                FilaMidias.Enfileirar(Midia.Consultar(id));
            }
        }

        static void OrdenaFilaPorDescricao(FilaDinamica FilaMidiaPorDescricao, string[] cadastro)
        {
            ListaDinamica ListaOrdenadacao = new ListaDinamica();
            foreach (string linha in cadastro)
            {
                string[] temp = linha.Split('|');
                int id = Convert.ToInt32(temp[0].Replace("<Id>", ""));
                Midia Midia = Midia.Consultar(id);

                for (int i = 0; i < ListaOrdenadacao.Tamanho; i++)
                {
                    //if(Midia.Descricao.CompareTo(ListaOrdenadacao.Listar)
                }
            }
        }


        public frPesquisa()
        {
            InitializeComponent();
        }

        private void frPesquisa_Load(object sender, EventArgs e)
        {
            PreencheFila(FilaMidias, cadastro);

            //for (int i = 0; i < FilaMidias.Tamanho(); i++)
            //{
            //    Midia Midia = FilaMidias.Desenfileira();
            //    if(Midia is Foto)
            //}
        }



        /// <summary>
        /// Esses eventos controlam o botões de Minimizar, Maximizar e Fechar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Minimize, Maximize, Fecha
        private void panMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panMinimizar_MouseHover(object sender, EventArgs e)
        {
            panMinimizar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panMinimizar_MouseLeave(object sender, EventArgs e)
        {
            panMinimizar.BackColor = Color.MidnightBlue;
        }

        private void panMaximixar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void panMaximixar_MouseHover(object sender, EventArgs e)
        {
            panMaximixar.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void panMaximixar_MouseLeave(object sender, EventArgs e)
        {
            panMaximixar.BackColor = Color.MidnightBlue;
        }

        private void panFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panFechar_MouseHover(object sender, EventArgs e)
        {
            panFechar.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void panFechar_MouseLeave(object sender, EventArgs e)
        {
            panFechar.BackColor = Color.MidnightBlue;
        }
        #endregion

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            frPrincipal Principal = new frPrincipal();
            Principal.ShowDialog();
        }
    }
}
