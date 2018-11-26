using Biblioteca.DAO;
using Biblioteca.VOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAlunosDB_1
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
                AlunoVO a = new AlunoVO();
                a.Id = 4;
                a.Nome = "Ronaldo";
                a.CidadeId = 5;
                a.DataNascimento = DateTime.Now.AddYears(-43);
                a.Mensalidade = 601.32;

                AlunoDAO.Inserir(a);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
