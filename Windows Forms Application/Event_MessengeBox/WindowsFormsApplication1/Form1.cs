using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtValor1.Text);
                int b = Convert.ToInt32(txtValor2.Text);

                txtResultado.Text = (a + b).ToString();
            }
            catch
            {
                txtResultado.Text = "";
                // ou txtResultado.Clear();
                txtValor1.Clear();
                txtValor2.Clear();
                MessageBox.Show("Digite apenas números!");
            }
        }
    }
}
