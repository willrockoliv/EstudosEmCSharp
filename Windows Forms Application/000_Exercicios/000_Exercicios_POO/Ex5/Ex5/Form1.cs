using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvarMedia_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno Aluno = new Aluno();
                Aluno.Nome = txtNome.Text;
                Aluno.Nota1 = Convert.ToDouble(txtN1.Text);
                Aluno.Nota2 = Convert.ToDouble(txtN2.Text);
                ltbAlunos.Items.Add(Aluno.Nome + " - " + Aluno.Media.ToString());
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
