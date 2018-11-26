using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutandoProcsBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool retorno = SPs.ValidaCPF(maskedTextBox1.Text);
            if (retorno)
                MessageBox.Show("Válido");
            else
                MessageBox.Show("Inválido");
        }
    }
}
