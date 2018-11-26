using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_8
{
    public partial class Form1 : Form
    {
        List<Jogo> listaJogos;
        List<Fabricante> listaFabricante;

        public Form1()
        {
            InitializeComponent();

            listaFabricante = new List<Fabricante>();

            listaFabricante.Add(new Fabricante(1, "Konami"));
            listaFabricante.Add(new Fabricante(2, "Capcom"));
            listaFabricante.Add(new Fabricante(3, "Nintendo"));
            listaFabricante.Add(new Fabricante(4, "EA"));
            listaFabricante.Add(new Fabricante(5, "Acclaim"));
            listaFabricante.Add(new Fabricante(6, "IronHide"));
            listaFabricante.Add(new Fabricante(7, "SEGA"));

            cbFabricante.DisplayMember = "Nome";
            cbFabricante.ValueMember = "Id";
            cbFabricante.DataSource = listaFabricante;

            listaJogos = Jogo.Carregar(listaFabricante);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo j = new Jogo();
            try
            {
                j.Codigo = Convert.ToInt32(txtCodigo.Text);
                j.Descricao = txtDescricao.Text;
                j.Valor = Convert.ToDouble(txtValor.Text);
                j.Dificuldade = (DificuldadeEnum)cbDificuldade.SelectedIndex;
                j.Fabricante = cbFabricante.SelectedItem as Fabricante;
                j.Salvar();
                listaJogos.Add(j);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*listBox1.Items.Clear();
            foreach (Jogo j in listaJogos)
            {
                listBox1.Items.Add("");
                listBox1.Items.Add("Jogo: " + j.Codigo.ToString());
                listBox1.Items.Add(j.Descricao);
                listBox1.Items.Add(j.Valor);
                listBox1.Items.Add(j.Dificuldade.ToString());
                listBox1.Items.Add(j.Fabricante.ToString());
            }*/
            Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaJogos = Jogo.Carregar(listaFabricante);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbDificuldadeListagem.SelectedIndex == -1)
                Listar(); // lista tudo!
            else
                Listar((DificuldadeEnum)cbDificuldadeListagem.SelectedIndex); // lista por dificuldade
        }



        /// <summary>
        /// lista tudo
        /// </summary>
        private void Listar()
        {
            Listar(null);
        }


        private void Listar(DificuldadeEnum? dificuldade)
        {
            bool listarTudo = dificuldade == null;
            foreach (Jogo j in listaJogos)
            {               
                if (listarTudo || j.Dificuldade == dificuldade)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Jogo: " + j.Codigo.ToString());
                    listBox1.Items.Add(j.Descricao);
                    listBox1.Items.Add(j.Valor);
                    listBox1.Items.Add(j.Dificuldade.ToString());
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cbDificuldadeListagem.SelectedIndex = -1;
        }




    }
}
