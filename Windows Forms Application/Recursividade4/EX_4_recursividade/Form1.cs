using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_4_recursividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpezaRecursiva(this);
        }



        private void LimpezaRecursiva(Control container)
        {
            foreach (Control objeto in container.Controls)
            {   
                if (objeto.Controls.Count > 0)
                    LimpezaRecursiva(objeto);
                else if (!(objeto is Button || objeto is Label))
                    objeto.Text = "";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Yellow;
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }
    }
}
