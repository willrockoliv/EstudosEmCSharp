using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_exemplo_1
{
    public partial class frTela1 : Form
    {
        public frTela1()
        {
            InitializeComponent();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            frTela2 tela2 = new frTela2();
            tela2.Text = "Mudei o título da tela 2";            
            tela2.ShowDialog();
            MessageBox.Show("teste");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int n = 1; n <= 500; n++)
            {
                frTela2 tela2 = new frTela2();
                tela2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = panel1.Visible;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu que fiz");
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frTela2 tela2 = new frTela2();
            tela2.ShowDialog();
        }
    }
}
