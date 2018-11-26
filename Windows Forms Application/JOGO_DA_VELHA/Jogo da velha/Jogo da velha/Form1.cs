using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }
        int jogada = 0;
        private void btnPos1_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos1.Text = "X";
            }
            else
            {
                txtPos1.Text = "O";
            }
            jogada++;
            btnPos1.Enabled = false;
        }
        private void btnPos2_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos2.Text = "X";
            }
            else
            {
                txtPos2.Text = "O";
            }
            jogada++;
            btnPos2.Enabled = false;
        }
        private void btnPos3_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos3.Text = "X";
            }
            else
            {
                txtPos3.Text = "O";
            }
            jogada++;
            btnPos3.Enabled = false;
        }
        private void btnPos4_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos4.Text = "X";
            }
            else
            {
                txtPos4.Text = "O";
            }
            jogada++;
            btnPos4.Enabled = false;
        }
        private void btnPos5_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos5.Text = "X";
            }
            else
            {
                txtPos5.Text = "O";
            }
            jogada++;
            btnPos5.Enabled = false;
        }
        private void btnPos6_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos6.Text = "X";
            }
            else
            {
                txtPos6.Text = "O";
            }
            jogada++;
            btnPos6.Enabled = false;
        }
        private void btnPos7_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos7.Text = "X";
            }
            else
            {
                txtPos7.Text = "O";
            }
            jogada++;
            btnPos7.Enabled = false;
        }
        private void btnPos8_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos8.Text = "X";
            }
            else
            {
                txtPos8.Text = "O";
            }
            jogada++;
            btnPos8.Enabled = false;
        }
        private void btnPos9_Click(object sender, EventArgs e)
        {
            if (jogada % 2 == 0)
            {
                txtPos9.Text = "X";
            }
            else
            {
                txtPos9.Text = "O";
            }
            jogada++;
            btnPos9.Enabled = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            jogada = 0;
            btnPos1.Enabled = true;
            btnPos2.Enabled = true;
            btnPos3.Enabled = true;
            btnPos4.Enabled = true;
            btnPos5.Enabled = true;
            btnPos6.Enabled = true;
            btnPos7.Enabled = true;
            btnPos8.Enabled = true;
            btnPos9.Enabled = true;
            txtPos1.Text = "";
            txtPos2.Text = "";
            txtPos3.Text = "";
            txtPos4.Text = "";
            txtPos5.Text = "";
            txtPos6.Text = "";
            txtPos7.Text = "";
            txtPos8.Text = "";
            txtPos9.Text = "";            
        }        
    }
}
