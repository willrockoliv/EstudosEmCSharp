using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagens___teclas_e_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerHumano_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int lado =  r.Next(0, Width - btnSerHumano.Width);
            int topo = r.Next(0, Height - btnSerHumano.Height);

            btnSerHumano.Left = lado;
            btnSerHumano.Top  = topo;
        }

        private void btnAlien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JA SABIAAAA");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString("HH:mm:ss");
            btnAlien.Left = btnAlien.Left + 1;
 
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Você apertou enter");
            }

            if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("Você apertou a");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
