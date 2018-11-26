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

namespace EX_5_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Imagens|*.jpg;*.bmp;*.gif";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //copiar imagem
                string pastaEXE = Path.GetDirectoryName(Application.ExecutablePath);
                string pastaImagens = pastaEXE + "\\imagens\\";
                if (Directory.Exists(pastaImagens) == false)
                    Directory.CreateDirectory(pastaImagens);

                string nomeDestino = pastaImagens + Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName, nomeDestino, true);

                listBox1.Items.Add(nomeDestino);
                pictureBox1.ImageLocation = nomeDestino;

                //carrega os arquivos de uma pasta
                foreach ( string arquivo in Directory.GetFiles(pastaImagens))
                {
                    MessageBox.Show(arquivo);
                }


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox1.Text;
            //pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
        }
    }
}
