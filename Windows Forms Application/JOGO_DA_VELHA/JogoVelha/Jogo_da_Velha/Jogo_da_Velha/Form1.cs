using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Limpa();
        }
        int turn = 1;
        string vez = "x";

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
               
        private void win()
        {
            if ( button1.Text == button2.Text && button3.Text == button1.Text && button2.Text != ""
                || button4.Text == button5.Text && button6.Text == button4.Text && button5.Text != ""
                || button7.Text == button8.Text && button9.Text == button7.Text && button8.Text != ""

                || button1.Text == button4.Text && button7.Text == button1.Text && button4.Text != ""
                || button2.Text == button5.Text && button8.Text == button2.Text && button5.Text != ""
                || button3.Text == button6.Text && button9.Text == button3.Text && button6.Text != ""

                || button1.Text == button5.Text && button9.Text == button1.Text && button5.Text != ""
                || button3.Text == button5.Text && button7.Text == button3.Text && button5.Text != "")
            {
                string ganhador = string.Format("O vencedor é {0}",vez);
                MessageBox.Show(ganhador);

                Limpa();
                turn = 1;
                Enabled();
              
            }

            else if (turn == 9)

            {                
                MessageBox.Show("FIM DE JOGO - EMPATE");
                Limpa();
                turn = 1;
                Enabled();
            }
        }

        private void Enabled()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void Limpa()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void VELHA(Control posicao)
        {
            posicao.Enabled = false;

            posicao.Text = vez;

            win();


            if (vez == "x")
            {
                vez = "o";
            lbkVez.Text="É A vez do 'O'";
            }

            else 
            {
                vez = "x";
                lbkVez.Text = "É A vez do 'X'";
            }

            turn++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VELHA(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VELHA(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VELHA(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VELHA(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VELHA(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VELHA(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VELHA(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VELHA(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VELHA(button9);
        }


        
    }
}
