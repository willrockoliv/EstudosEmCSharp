using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Classes;
using System.Xml.Linq;
using System.Xml;

using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MyPlayer
{
    public partial class frmMyPlayer : Form
    {
        Lista<Midia> lista = Midia.Listar<Midia>();
        public frmMyPlayer()
        {
            InitializeComponent();
            Atualizar();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (CmbMidias.SelectedItem == null) { MessageBox.Show("Escola uma música para tocar."); return; }

            axWindowsMediaPlayer1.URL = (CmbMidias.SelectedItem as ILocal).ArquivoMidia;
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        private void frmMyPlayer_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Height = ((Form)sender).Size.Height - 145;
            axWindowsMediaPlayer1.Width = ((Form)sender).Size.Width - 40;
        }

        private void frmMyPlayer_MaximumSizeChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Height = ((Form)sender).Size.Height - 145;
            axWindowsMediaPlayer1.Width = ((Form)sender).Size.Width - 40;
        }

        private void frmMyPlayer_MinimumSizeChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Height = ((Form)sender).Size.Height - 145;
            axWindowsMediaPlayer1.Width = ((Form)sender).Size.Width - 40;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            lista.Inserir(Arquivos.PegarArquivo());
            Atualizar();
        }

        private void CmbMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMidias.SelectedItem != null)
            {
                TxbDados.Text = (CmbMidias.SelectedItem as Midia).ToString();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            lista.ForEach(m => m.Incluir());
            Atualizar();
        }

        private void BtnSalvaSelect_Click(object sender, EventArgs e)
        {
            (CmbMidias.SelectedItem as Midia).Incluir();
        }

        void Atualizar()
        {
            CmbMidias.DataSource = null;
            CmbMidias.DataSource = lista.GetList();
            CmbMidias.DisplayMember = "Nome";
        }
    }
}
