using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace formanimal
{
    public partial class JanelaInfoAnimais : Form
    {

        DataTable tabela;

        public JanelaInfoAnimais()
        {
            InitializeComponent();

            #region DataTable

            //cria uma tabela 
            tabela = new DataTable();

            //coluna Animal
            DataColumn coluna = new DataColumn("Atributo1", typeof(string));
            tabela.Columns.Add(coluna);

            //coluna Nome
            coluna = new DataColumn("Valor1", typeof(string));
            tabela.Columns.Add(coluna);

            //configurações do grid
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;

            //preencha as colunas com os nomes dos campos do datatable.
            //as colunas do grid foram preenchidas pela propriedade columns

            colAtrib.DataPropertyName = "Atributo1";
            colValor.DataPropertyName = "Valor1";

            //associa a tabela ao grid
            dataGridView2.DataSource = tabela;

#endregion
        }

        #region extensaotxt
        private string extension = ".txt"; //determina a extensão do arquivo de texto
        #endregion

        #region Params

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= (0x80000 | 0x20000);  // habilita o minimizar na janela sem borda              
                return cp;
            }
        }

        #endregion       

        #region DeterminaImagem

        public void DeterminaImagemAnimal(string bicho)
        {
            
            if (bicho == "Gato")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\gatoreal.jpg");
            }
            if (bicho == "Cachorro")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\cachorroreal.jpg");
            }
            if (bicho == "Baleia")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\baleiareal.jpg");
            }
            if (bicho == "Morcego")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\morcegoreal.jpg");
            }
            if (bicho == "Ornitorrinco")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\ornitorrincoreal.jpg");
            }
            if (bicho == "Pato")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\patoreal.jpg");
            }
            if (bicho == "Pinguim")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\pinguimreal.jpg");
            }
            if (bicho == "Pombo")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\pomboreal.jpg");
            }
            if (bicho == "Coruja")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\corujareal.jpg");
            }
            if (bicho == "Tartaruga")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\tartarugareal.jpg");
            }
            if (bicho == "Camaleao")
            {
                pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + @"\ImagensReal\camaleaoreal.jpg");
            }

        }

        #endregion

        #region learquivo

        public void learquivo(string arquivo)
        {

            StreamReader leitor = new StreamReader(System.Environment.CurrentDirectory + @"\DescrAnimal\" + arquivo, Encoding.UTF8);
            string x;

            try
            {

                while ((x = leitor.ReadLine()) != null)
                {

                    if (x != "")
                    {

                        string auxiliar1 = x.Remove(x.IndexOf(";"));
                        x = x.Remove(0, x.IndexOf(";") + 1);

                        if (auxiliar1 == "$1")
                        {
                            DataRow novalinha;

                            novalinha = tabela.NewRow();
                            novalinha["Valor1"] = x.Remove(0, x.IndexOf(";") + 1).ToString();
                            novalinha["Atributo1"] = x.Remove(x.IndexOf(";")).ToString();

                            tabela.Rows.Add(novalinha);
                        }


                        if (auxiliar1 == "$2")//título
                        {

                            string divisor = "-------------------";

                            
                            richTextBox1.Text = x + Environment.NewLine + divisor +
                            Environment.NewLine + Environment.NewLine + Environment.NewLine;
                            richTextBox1.Find(x, RichTextBoxFinds.MatchCase);
                            richTextBox1.SelectionFont = new Font("Verdana", 15, FontStyle.Bold);

                        }

                        if (auxiliar1 == "$3") //texto comum
                        {

                            x = x.Replace("$3", "");
                            x = x.Replace(";", " ");

                            richTextBox1.Find(x, RichTextBoxFinds.MatchCase);
                            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
                            richTextBox1.Text = richTextBox1.Text + x;
                            
                            

                        }

                     
                                       

                    }
                }
            }
            finally
            {

                leitor.Close();

            }
        }

        #endregion               

        #region determinaAnimal

        public void DeterminaAnimal(string bicho)
        {            

            if (bicho == "Gato")
            {
                learquivo("gato" + extension);
            }
            if (bicho == "Cachorro")
            {
                learquivo("cachorro" + extension);
            }
            if (bicho == "Baleia")
            {
                learquivo("baleia" + extension);
            }
            if (bicho == "Morcego")
            {
                learquivo("morcego" + extension);
            }
            if (bicho == "Ornitorrinco")
            {
                learquivo("ornitorrinco" + extension);
            }
            if (bicho == "Pato")
            {
                learquivo("pato" + extension);
            }
            if (bicho == "Pinguim")
            {
                learquivo("pinguim" + extension);
            }
            if (bicho == "Pombo")
            {
                learquivo("pombo" + extension);
            }
            if (bicho == "Coruja")
            {
                learquivo("coruja" + extension);
            }
            if (bicho == "Tartaruga")
            {
                learquivo("tartaruga" + extension);
            }
            if (bicho == "Camaleao")
            {
                learquivo("camaleao" + extension);
            }

            DeterminaImagemAnimal(bicho);

        }

        #endregion

        private void label19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label14, label14.Location.X - 10, label14.Location.Y + 15);
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.BackColor = Color.PapayaWhip;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.Tan;
        }     

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.BackColor = Color.PapayaWhip;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.Tan;
        }

        private void JanelaInfoAnimais_Load(object sender, EventArgs e)
        {

        }

        private void label14_MouseEnter_1(object sender, EventArgs e)
        {
            label14.BackColor = Color.PapayaWhip;
        }

        private void label14_MouseLeave_1(object sender, EventArgs e)
        {
            label14.BackColor = Color.Tan;
        }

        private void label15_MouseLeave_1(object sender, EventArgs e)
        {
            label15.BackColor = Color.Tan;
        }

        private void label15_MouseEnter_1(object sender, EventArgs e)
        {
            label15.BackColor = Color.PapayaWhip;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.BackColor = Color.PapayaWhip;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.BackColor = Color.Tan;
        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label15, label15.Location.X, label15.Location.Y + 15);
        }

      


    }
}
