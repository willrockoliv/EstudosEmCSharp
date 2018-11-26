using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_5
{
    public partial class frMovimentacao : Form
    {
        public frMovimentacao()
        {
            InitializeComponent();
        }


        public void RegistraMovimento(string movimento)
        {
            lbMovimentacao.Items.Add(movimento);
        }

        private void frMovimentacao_FormClosing(object sender, 
            FormClosingEventArgs e)
        {
            e.Cancel = true;         
        }

        private void frMovimentacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
