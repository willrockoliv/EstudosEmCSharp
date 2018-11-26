using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_12POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        Funcionario F = new Funcionario();
        

        private void btnVal_Click(object sender, EventArgs e)
        {
            
            try
            {
                F.Nome = txtNome.Text;
                F.Nasc = txtDtan.Text;
                Metodos M = new Metodos(txtSexo.Text, txtEc.Text);
                MessageBox.Show("Nome: "+ F.Nome + "\nIdade: " + F.idade +
                    "\nSexo: "+txtSexo.Text+"\nEstado civil: "+txtEc.Text);
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
