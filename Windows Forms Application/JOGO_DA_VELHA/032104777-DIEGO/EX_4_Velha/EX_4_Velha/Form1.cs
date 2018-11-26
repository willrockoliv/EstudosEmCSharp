using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_4_Velha
{
    public partial class Form1 : Form
    {
        bool verJoga = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void VerGanhador()
        {
            if (bt11.Text != String.Empty && bt11.Text == bt12.Text && bt12.Text == bt13.Text ||
             bt21.Text != String.Empty && bt21.Text == bt22.Text && bt22.Text == bt23.Text ||
             bt31.Text != String.Empty && bt31.Text == bt32.Text && bt32.Text == bt33.Text ||

             bt11.Text != String.Empty && bt11.Text == bt21.Text && bt21.Text == bt23.Text ||
             bt12.Text != String.Empty && bt12.Text == bt22.Text && bt22.Text == bt32.Text ||
             bt13.Text != String.Empty && bt13.Text == bt23.Text && bt23.Text == bt33.Text ||

             bt11.Text != String.Empty && bt11.Text == bt22.Text && bt22.Text == bt33.Text ||
             bt13.Text != String.Empty && bt13.Text == bt22.Text && bt22.Text == bt31.Text)
            {
                if (verJoga)
                {
                    MessageBox.Show(" O ganhador foi: X ");
                    limpar(); 
                }
                else
                {
                    MessageBox.Show(" O ganhador foi: O");
                    limpar(); 
                }
            }
            else
            {
                bool tudoPreenchido = true;

                foreach (Control item in this.Controls)
                {
                    if (item is Button && item.Enabled)
                    {
                        tudoPreenchido = false;
                        break;

                    }
                }
                if (tudoPreenchido)
                {
                    MessageBox.Show(" Deu VEIA!!!!");

                    limpar();
                }

            }
            
        }

        private void limpar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = String.Empty;
                
                }
            
            
            
            
            }




        }


        private void bt11_Click(object sender, EventArgs e)
        {
            bt11.Text = verJoga ? "X" : "O";
            bt11.Enabled = false;
           
            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");


        }

        private void bt12_Click(object sender, EventArgs e)
        {
            bt12.Text = verJoga ? "X" : "O";
            bt12.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            bt13.Text = verJoga ? "X" : "O";
            bt13.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt21_Click(object sender, EventArgs e)
        {
            bt21.Text = verJoga ? "X" : "O";
            bt21.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt22_Click(object sender, EventArgs e)
        {
            bt22.Text = verJoga ? "X" : "O";
            bt22.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt23_Click(object sender, EventArgs e)
        {
            bt23.Text = verJoga ? "X" : "O";
            bt23.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt31_Click(object sender, EventArgs e)
        {
            bt31.Text = verJoga ? "X" : "O";
            bt31.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt32_Click(object sender, EventArgs e)
        {
            bt32.Text = verJoga ? "X" : "O";
            bt32.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        private void bt33_Click(object sender, EventArgs e)
        {
            bt33.Text = verJoga ? "X" : "O";
            bt33.Enabled = false;

            VerGanhador();

            verJoga = !verJoga;

            label1.Text = string.Format(" Sua vez: {0}", this.verJoga ? "X" : "O");
        }

        

     }
}
