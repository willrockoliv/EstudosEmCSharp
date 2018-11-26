using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManipulacaoTeclas
{
    public partial class Form1 : Form
    {
        private string textoDigitado = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, 
            KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                textBox1.Clear();
            }

            textoDigitado += e.KeyChar;

            //MessageBox.Show("você pressionou: " +  e.KeyChar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textoDigitado);
        }

        private void textBox2_KeyDown(object sender, 
            KeyEventArgs e)
        {
            if (e.Alt == true)
                MessageBox.Show("Você pressionou ALT");

            if (e.Control == true)
                MessageBox.Show("Você pressionou Control");

            if (e.Shift == true)
                MessageBox.Show("Você pressionou SHIFT");

            MessageBox.Show(e.KeyCode.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random geradorDeNumeros = new Random();

             //sempre coloque 1 a mais
            int numero = geradorDeNumeros.Next(1,100);
           
                
            MessageBox.Show(numero.ToString() );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Text = Text + e.KeyChar;
            e.Handled = true; // não exibe a tecla digitada
        }
    }
}
