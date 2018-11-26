using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1: Form
    {
        int conta1 = 0, conta2 = 0;

        private void Reset()
        {
            lbc1.Text = "0";
            lbc2.Text = "0";
        }
        private void BloqueiaCampos()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void ValidaCampos()
        {
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
               button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
               button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Jogador 'X'", "Vencedor!");
                    conta1++;
                    lbc1.Text = conta1.ToString();
                }
                else
                {
                    MessageBox.Show(textBox1.Text.ToUpper(), "Vencedor!");
                    conta1++;
                    lbc1.Text = conta1.ToString();
                }
                BloqueiaCampos();
                btReiniciar.Visible = true;
            }
            else if
               (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                if(textBox2.Text == "")
                {
                    MessageBox.Show("Jogador 'O'", "Vencedor!");
                    conta2++;
                    lbc2.Text = conta2.ToString();
                }
                else
                {
                    MessageBox.Show(textBox2.Text.ToUpper(), "Vencedor!");
                    conta2++;
                    lbc2.Text = conta2.ToString();
                }
                BloqueiaCampos();
                btReiniciar.Visible = true;
            }
            else if            
               (!(button1.Text == "" || button2.Text == "" || button3.Text == "" ||
                button4.Text == "" || button5.Text == "" || button6.Text == "" ||
                button7.Text == "" || button8.Text == "" || button9.Text == ""))
            {
                MessageBox.Show("velha !");
                BloqueiaCampos();
                btReiniciar.Visible = true;
            }
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickBotao(object sender)
        {
            if (rb1.Checked)
            {
                (sender as Button).Text = "X";
                rb2.Checked = true;
            }
            if (rb2.Checked && (sender as Button).Text == "")
            {
                (sender as Button).Text = "O";
                rb1.Checked = true;
            }
            (sender as Button).Enabled = false;
            ValidaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClickBotao(sender);
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        

        private void Form1_Load(object sender, EventArgs e)
        {
            btReiniciar.Visible = false;
        }

        private void btNovoJogo_Click(object sender, EventArgs e)
        {
           
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            rb1.Checked = true;
            btReiniciar.Visible = false;
        }

        private void novoJogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         Reset();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
     }
}
