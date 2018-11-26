using EX_4._3_WF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_4._3_WF
{
    public partial class frResumo : Form
    {

        public string resumo;

        public frResumo()
        {
            InitializeComponent();
        }

        private void frResumo_Load(object sender, EventArgs e)
        {
            txtResumo.Text = resumo;            
        }
    }
}
