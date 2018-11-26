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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.Codigo = 1;
                f.Nome = "maria";
            }
            catch (NomeSemSobrenomeException erro)
            {
                MessageBox.Show(erro.Message);
            }
            catch (NumeroNegativoException erro)
            {
                MessageBox.Show(erro.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Você não digitou números.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro desconhecido. Erro: " + erro.Message);
            }
        }
    }
}
