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
        }
        string XO = "X";
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = XO;
            if (XO == "X")
                XO = "O";
            else if (XO == "O")
                XO = "X";
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            lbkVez.Text = string.Format("é a vez do {0}",XO);
        }
    }
}
