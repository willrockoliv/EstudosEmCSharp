using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadFerramentas
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tela = new frCadFerramenta())
            {
                tela.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var tela = new frCadFabricante())
            {
                tela.ShowDialog();
            }
        }
    }
}
