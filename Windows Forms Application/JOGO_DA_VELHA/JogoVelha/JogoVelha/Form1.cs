using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetBotao();
        }

        string XO = "X";
        int quantida = 1;

        private void ResetBotao()
        {
            #region Limpa Texto

            #region Linha 1
            
            bnt11.Text = "";
            bnt12.Text = "";
            bnt13.Text = "";

            #endregion

            #region Linha 2

            bnt21.Text = "";
            bnt22.Text = "";
            bnt23.Text = "";

            #endregion

            #region Linha 3

            bnt31.Text = "";
            bnt32.Text = "";
            bnt33.Text = "";

            #endregion

            #endregion

            #region Enable Botoes

            #region Linha 1

            bnt11.Enabled = true;
            bnt12.Enabled = true;
            bnt13.Enabled = true;

            #endregion

            #region Linha 2

            bnt21.Enabled = true;
            bnt22.Enabled = true;
            bnt23.Enabled = true;

            #endregion

            #region Linha 3

            bnt31.Enabled = true;
            bnt32.Enabled = true;
            bnt33.Enabled = true;

            #endregion

            #endregion

            quantida = 1;
        }

        private void Jogo(Control posicao)
        {
            posicao.Text = XO;
            posicao.Enabled = false;

            if (Ganhador())
                ResetBotao();
            
            if (XO == "X")
            {
                lblVez.Text = "É a vez do O";
                XO = "O";
            }
            else
            {
                lblVez.Text = "É a vez do X";
                XO = "X";
            }
            quantida++;
        }

        private bool Ganhador()
        {

            if (bnt11.Text == bnt12.Text && bnt12.Text == bnt13.Text && bnt13.Text != "" || // Linha 1
               bnt21.Text == bnt22.Text && bnt22.Text == bnt23.Text && bnt23.Text != "" || // Linha 2
               bnt31.Text == bnt32.Text && bnt32.Text == bnt33.Text && bnt33.Text != "" || // Linha 3

               bnt11.Text == bnt21.Text && bnt21.Text == bnt31.Text && bnt31.Text != "" || // Coluna 1
               bnt12.Text == bnt22.Text && bnt22.Text == bnt32.Text && bnt32.Text != "" || // Coluna 2
               bnt13.Text == bnt23.Text && bnt23.Text == bnt33.Text && bnt33.Text != "" || // Coluna 3

               bnt11.Text == bnt22.Text && bnt22.Text == bnt33.Text && bnt33.Text != "" || // Diagonal 1
               bnt13.Text == bnt22.Text && bnt22.Text == bnt31.Text && bnt31.Text != ""   // Diagonal 2
               )
            {
                string vencerdor = string.Format("O vencedor é {0}", XO);
                MessageBox.Show(vencerdor);
                return true;
            }
            else if (quantida == 9)
            {
                MessageBox.Show("Deu Velha!!");
                return true;
            }
            else
                return false;
        }

        #region Botões

        private void button2_Click(object sender, EventArgs e)
        {
            Jogo(bnt12);
        }

        private void bnt11_Click(object sender, EventArgs e)
        {
            Jogo(bnt11);
        }

        private void bnt13_Click(object sender, EventArgs e)
        {
            Jogo(bnt13);
        }

        private void bnt21_Click(object sender, EventArgs e)
        {
            Jogo(bnt21);
        }

        private void bnt22_Click(object sender, EventArgs e)
        {
            Jogo(bnt22);
        }

        private void bnt23_Click(object sender, EventArgs e)
        {
            Jogo(bnt23);
        }

        private void bnt31_Click(object sender, EventArgs e)
        {
            Jogo(bnt31);
        }

        private void bnt32_Click(object sender, EventArgs e)
        {
            Jogo(bnt32);
        }

        private void bnt33_Click(object sender, EventArgs e)
        {
            Jogo(bnt33);
        }

        #endregion
    }
}
