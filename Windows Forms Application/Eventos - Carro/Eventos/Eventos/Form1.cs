using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {

        Carro kart = new Carro();
        int pistaAtual = 1;
        const int VELOX = 300;

        public Form1()
        {
            InitializeComponent();
            kart.onCarroAcelerou += gol_onCarroAcelerou;
        }

       

        void gol_onCarroAcelerou(object sender, EventArgs e)
        {
            if (VELOX - kart.VelocidadeAtual * 2 >= 1)
                timer1.Interval = VELOX - kart.VelocidadeAtual * 2;
            if (timer1.Enabled == false)
                timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kart.Acelerar();
            label1.Text = kart.VelocidadeAtual.ToString();           
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pistaAtual == 1)
            {
                this.BackgroundImage = Properties.Resources.Pista2;
                pistaAtual = 2;
            }
            else if (pistaAtual == 2)
            {
                this.BackgroundImage = Properties.Resources.Pista3;
                pistaAtual = 3;
            }
            else if (pistaAtual == 3)
            {
                this.BackgroundImage = Properties.Resources.Pista4;
                pistaAtual = 4;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Pista1;
                pistaAtual = 1;
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 10;
            MessageBox.Show("Táca-lhe pau! Não tem freio!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top - 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top + 10;

        }
    }
}
