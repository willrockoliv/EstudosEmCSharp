using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesVisuais_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            data.MinDate = DateTime.Now.Subtract(new TimeSpan(365, 0, 0, 0));
            cbCidade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCidade.SelectedIndex == 0)
                MessageBox.Show("Selecione uma cidade!");
            else
            {
                MessageBox.Show(cbCidade.Text);
                MessageBox.Show(cbCidade.Items[cbCidade.SelectedIndex].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbDiasSemana.Items.Clear();
            cbDiasSemana.Items.Add("Segunda");
            cbDiasSemana.Items.Add("Terça");
            cbDiasSemana.Items.Add("Quarta");
            cbDiasSemana.Items.Add("Quinta");
            cbDiasSemana.Items.Add("Sexta");
            cbDiasSemana.Items.Add("Sábado");
            cbDiasSemana.Items.Add("Domingo");
        }

        private void SelecionarSexta_Click(object sender, EventArgs e)
        {
            //cbDiasSemana.SelectedIndex = 4;
            cbDiasSemana.SelectedIndex = cbDiasSemana.Items.IndexOf("Sexta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "";
            /*for (int n = 0; n < cbDiasSemana.Items.Count; n++)
            {
                x = x + cbDiasSemana.Items[n] + Environment.NewLine;                
            }*/

            foreach(string valor in cbDiasSemana.Items)
            {
                x = x + valor + Environment.NewLine;
            }

            MessageBox.Show(x); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ui!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(
               lbVideogames.Items[lbVideogames.SelectedIndex].ToString());*/


            foreach(string valor in lbVideogames.SelectedItems)
            {
                MessageBox.Show(valor);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int posicaoElemento = lbVideogames.Items.IndexOf(txtDado.Text);
            lbVideogames.SetSelected(posicaoElemento, true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtLocalizar.Text.Length == 0)
            {
                lbVideogames.ClearSelected();
                return;
            }

            for (int n=0; n<lbVideogames.Items.Count; n++)
            {
                if (lbVideogames.Items[n].ToString().Contains(txtLocalizar.Text))
                {
                    lbVideogames.ClearSelected();
                    lbVideogames.SelectedIndex = n;
                    break;
                }
            }

        }
    }
}
