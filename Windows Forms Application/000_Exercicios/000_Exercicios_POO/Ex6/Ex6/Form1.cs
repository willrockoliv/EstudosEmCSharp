using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvarMedia_Click(object sender, EventArgs e)
        {
            int cont;
            if (ltbAlunos.Items.Count == 10)
            {
                MessageBox.Show("Máximo de 10 alunos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Aluno Aluno = new Aluno();
                Aluno.Nome = txtNome.Text;
                Aluno.Nota1 = Convert.ToDouble(txtN1.Text);
                Aluno.Nota2 = Convert.ToDouble(txtN2.Text);
                ltbAlunos.Items.Add(Aluno.Nome + " - " + Aluno.Media.ToString());
                cont = ltbAlunos.Items.Count;
                lblCont.Text = "Alunos: " + cont + " de 10";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
