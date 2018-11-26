using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Disparei!");
            lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            Random gerador = new Random();
            int novaPosicalLeft = gerador.Next(0, Width - button2.Width);
            button2.Left = novaPosicalLeft;

            int novaPosicalTop = gerador.Next(0, Height - button2.Height);
            button2.Top = novaPosicalTop;


        }
    }
}
