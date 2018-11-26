using EX_6_TimeFutebol.DAO;
using EX_6_TimeFutebol.Enumeradores;
using EX_6_TimeFutebol.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_6_TimeFutebol
{
    public partial class Form1 : frPadrao
    {
        public Form1()
        {
            InitializeComponent();
            cadastroDAO = new JogadorFutebolDAO();
        }       
        
        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            base.ControlaCamposTela(modo);
            txtNome.Enabled = (modo != EnumModoOperacao.Navegacao);
            txtNumeroCamisa.Enabled = (modo != EnumModoOperacao.Navegacao);
            txtIdTime.Enabled = (modo != EnumModoOperacao.Navegacao);
        }
        
        protected override PadraoVO PreencheObj()
        {
            JogadorFutebolVO j = new JogadorFutebolVO();
            j.Id = Convert.ToInt32(txtId.Text);
            j.Nome = txtNome.Text;
            j.NumeroCamisa = Convert.ToInt32(txtNumeroCamisa.Text);
            j.TimeId = Convert.ToInt32(txtIdTime.Text);
            return j;
        }


        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                JogadorFutebolVO j = o as JogadorFutebolVO;
                if (j != null)
                {
                    txtId.Text = j.Id.ToString();
                    txtNome.Text = j.Nome;
                    txtNumeroCamisa.Value = j.NumeroCamisa;
                    txtIdTime.Value = j.TimeId;
                    TimeVO t = (new TimeDAO()).Consulta((int)txtIdTime.Value) as TimeVO;
                    if (t != null)
                        txtNomeTime.Text = t.Nome;
                    else
                        txtNomeTime.Clear();
                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
               
       
        private void btnBuscaTime_Click(object sender, EventArgs e)
        {
            using (frConsultaTimes form = new frConsultaTimes())
            {
                form.ShowDialog();
                if (form.IdSelecionado != 0)
                    txtIdTime.Value = form.IdSelecionado;
            }
        }
                

        private void txtIdTime_Leave(object sender, EventArgs e)
        {
            TimeVO t = (new TimeDAO()).Consulta((int)txtIdTime.Value) as TimeVO;
            if (t != null)
                txtNomeTime.Text = t.Nome;
            else
                txtNomeTime.Text = "";

        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            using (frConsulta form = new frConsulta())
            {
                form.ShowDialog();
                if (form.IdSelecionado != 0)
                {                    
                    var j = cadastroDAO.Consulta(form.IdSelecionado);
                    PreencheTela(j as JogadorFutebolVO);
                }
            }
        }
    }
}
