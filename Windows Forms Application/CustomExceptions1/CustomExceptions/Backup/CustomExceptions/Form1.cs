using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario func = new Funcionario();
                func.Codigo = Convert.ToInt32(txtCodigo.Text);
            }
            catch (NumeroNegativoException erro)
            {
                MessageBox.Show(erro.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números.");
            }
        }
    }
}
