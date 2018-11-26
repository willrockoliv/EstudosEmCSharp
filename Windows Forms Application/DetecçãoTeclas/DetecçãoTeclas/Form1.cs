using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetecçãoTeclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender,
            KeyEventArgs e)
        {
            MessageBox.Show("Evento do textbox!");


        }


        bool enterPressinado = false;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.Text += e.KeyChar;
            if (e.KeyChar == 13)
                enterPressinado = true;

            if (enterPressinado == false)
                e.Handled = true;
            else
                e.Handled = false; ;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Evento do form!");
            if (e.KeyCode == Keys.F4 &&
               e.Alt == true)
            {
                MessageBox.Show("não pode fechar a tela");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = DateTime.Now.ToString("dd MMMM, dddd -  dd/MMMM/yyyy HH:mm:ss.fff");
            timer1.Start();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random gerador = new Random();
            button2.Top = gerador.Next(0, Height - button2.Height);
            button2.Left = gerador.Next(0, Width - button2.Width);
        }
    }
}
