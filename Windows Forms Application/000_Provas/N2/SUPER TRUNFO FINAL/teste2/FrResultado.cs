using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace teste2
{
    public partial class FrResultado : Form
    {
        public FrResultado()
        {
            InitializeComponent();

        }

        private void FrResultado_Load(object sender, EventArgs e)
        {

            string vencedor = File.ReadAllText("Vencedor.txt", Encoding.Default);
            lblVencedor.Text = vencedor;
            TmParaFechar.Start();
            TmParaFechar.Tick += new EventHandler(TmParaFechar_Tick);
        }

        private void TmParaFechar_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TmParaFechar.Stop();
            Close();
        }




    }
}
