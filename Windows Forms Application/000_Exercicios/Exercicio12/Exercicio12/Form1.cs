using Exercicio12.Classes;
using Exercicio12.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            comboBox1.DataSource = Enum.GetValues(typeof(SexoEnum));
            comboBox2.DataSource = Enum.GetValues(typeof(ECivilEnum));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            int idade;
            string data = maskedTextBox1.Text;

            if (!Metodos.ValidaNome(nome))
            {
                MessageBox.Show("Nome Invalido, falta sobrenome");
                return;
            }

            
            else if(!Metodos.ValidaData(data, out idade))
            {
                MessageBox.Show("Data Invalida, não seja burro");
                return;
            }

            else
            {
                label3.Visible = true;
                label3.Text = "A idade é: " + idade;
                DateTime novaData = Convert.ToDateTime(maskedTextBox1.Text);

                Funcionario funcionario = new Funcionario(nome, (SexoEnum)comboBox1.SelectedItem, (ECivilEnum)comboBox2.SelectedItem, novaData);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
