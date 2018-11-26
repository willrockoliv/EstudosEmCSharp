using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressionamentoTeclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true; // sem isso o form não capta as teclas caso o foco esteja em outro controle
        }

        private void Form1_KeyUp(object sender, 
            KeyEventArgs e)
        {   
            listBox1.Items.Add(e.KeyCode.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 &&
               e.Alt)
            {
                MessageBox.Show("Não pode fechar a tela!");
                e.SuppressKeyPress = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int numKey = (int)e.KeyChar;


            if (numKey < 65 || numKey > 122)
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Windows\Media\ir_begin.wav";
            player.PlayLooping();
        }
    }
}
