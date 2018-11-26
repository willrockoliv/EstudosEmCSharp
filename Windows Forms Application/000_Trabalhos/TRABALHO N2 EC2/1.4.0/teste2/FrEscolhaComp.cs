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

namespace teste2
{
    public partial class FrEscolhaComp : Form
    {
        public FrEscolhaComp()
        {
            InitializeComponent();
        }

        private void FrEscolhaComp_Load(object sender, EventArgs e)
        {
            string vencedor = File.ReadAllText("escolha.txt", Encoding.Default);
            lblVencedor.Text = vencedor;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
