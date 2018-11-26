using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AlunoENotas
{
    public partial class Form1 : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        
               

        public Form1()
        {
            InitializeComponent();            
        }
              

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            try
            {                
                Aluno a = new Aluno(txtNome.Text,
                                    Convert.ToDouble(txtN1.Text),
                                    Convert.ToDouble(txtN2.Text)
                                    );

                //add = insere no final da lista
                listaAlunos.Add(a);
                listBox1.Items.Add("Média = " + a.Media.ToString("0.00"));

                RecarregaLista();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("*** Listagem de Alunos Cadastrados ***");
            foreach (Aluno a in listaAlunos)
            {
                listBox1.Items.Add(a.Nome + " - N1: " + a.N1.ToString("0.0") +
                    "  -  N2: " + a.N2.ToString("0.0") +
                    " Média: " + a.Media.ToString("0.0")); 
                    
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aluno a = Pesquisa(txtNomePesquisa.Text);

            if (a != null)
            {
                txtNome.Text = a.Nome;
                txtN1.Text = a.N1.ToString();
                txtN2.Text = a.N2.ToString();
            }
            else
            {
                MessageBox.Show("Não existe.");
            }            
        }



        private Aluno Pesquisa(string nome)
        {
            //query lambda  ou expressões lambda
            return listaAlunos.Find(aluno => aluno.Nome.ToUpper().Contains(nome.ToUpper()));
            /*
            for (int i=0; i<listaAlunos.Count; i++)
            {
                if (listaAlunos[i].Nome.ToUpper().Contains(nome.ToUpper()))
                    return listaAlunos[i];
            }
            return null;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aluno a = Pesquisa(txtNomePesquisa.Text);
            
            if (a != null)
            {
                listaAlunos.Remove(a);
                RecarregaLista();
            }
            else
            {
                MessageBox.Show("Não existe.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Aluno.QtdeAlunosInstanciados.ToString());
        }

       
        
        private void RecarregaLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAlunos;
        }



    }
}
