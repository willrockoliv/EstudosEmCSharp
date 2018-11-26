using EX_6_TimeFutebol.DAO;
using EX_6_TimeFutebol.Enumeradores;
using EX_6_TimeFutebol.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_6_TimeFutebol
{
    public partial class frCadTecnicoComHeranca : frPadrao
    {
        public frCadTecnicoComHeranca()
        {
            InitializeComponent();
            cadastroDAO = new TecnicoDAO();
            SugereProximoId = true;
        }


        protected override void PreencheTela(PadraoVO o)
        {
            try
            {
                if (o != null)
                {
                    txtId.Text = (o as TecnicoVO).Id.ToString();
                    txtNome.Text = (o as TecnicoVO).Nome;
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

        protected override void ControlaCamposTela(EnumModoOperacao modo)
        {
            txtNome.Enabled = modo != EnumModoOperacao.Navegacao;
        }

        protected override PadraoVO PreencheObj()
        {
            TecnicoVO t = new TecnicoVO();
            t.Id = Convert.ToInt32(txtId.Text);
            t.Nome = txtNome.Text;
            return t;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (frConsultaTecnico tela = new frConsultaTecnico())
            {
                tela.ShowDialog();
                if (tela.IdSelecionado != 0)
                {
                    TecnicoVO t = cadastroDAO.Consulta(tela.IdSelecionado) as TecnicoVO;
                    PreencheTela(t);
                }
            }
        }
    }
}
