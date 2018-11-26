using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreencherDias_Click(object sender, EventArgs e)
        {
            cbDiasSemana.Items.Add("Segunda");
            cbDiasSemana.Items.Add("Terça");
            cbDiasSemana.Items.Add("Quarta");
            cbDiasSemana.Items.Add("Quinta");
            cbDiasSemana.Items.Add("Sexta");
            cbDiasSemana.Items.Add("Sábado");
            cbDiasSemana.Items.Add("Domingo");
        }

        private void btnPreencherSexta_Click(object sender, EventArgs e)
        {
            // cbDiasSemana.SelectedIndex = 4; pega sempre o item 4
            cbDiasSemana.SelectedIndex = cbDiasSemana.Items.IndexOf("Sexta");
        }

        private void btnExibirItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbDiasSemana);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string x = "";
            for(int i=0; i < cbDiasSemana.Items.Count; i++)
            {
                x = x + cbDiasSemana.SelectedIndex[i]
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string valor in listBox1.SelectedItems)
            {
                MessageBox.Show(valor);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
