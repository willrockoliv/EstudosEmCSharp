using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            try
            {
                int v1 = Convert.ToInt32(txtValor1.Text);
                int v2 = Convert.ToInt32(txtValor2.Text);
                txtResultado.Text = (v1 + v2).ToString();
            }
            catch
            {
                txtResultado.Text = "";
                // ou txtResultado.Clear();
                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
