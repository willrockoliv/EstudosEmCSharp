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
    public partial class frTela2 : Form
    {
        public frTela2()
        {
            InitializeComponent();
        }

        private void frTela2_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
        }
    }
}
