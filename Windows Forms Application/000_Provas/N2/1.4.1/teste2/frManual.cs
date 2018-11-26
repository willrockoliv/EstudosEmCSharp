using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2
{
    public partial class frManual : Form
    {
        public frManual()
        {
            InitializeComponent();
        }

        private void btnSairManual_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
