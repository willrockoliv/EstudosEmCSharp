using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formanimal
{
    public partial class Agradecimentos : Form
    {
        public Agradecimentos()
        {
            InitializeComponent();
        }

        private void btnInstancia_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label21.BackColor = Color.PapayaWhip;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.BackColor = Color.Tan;
        }
    }
}
