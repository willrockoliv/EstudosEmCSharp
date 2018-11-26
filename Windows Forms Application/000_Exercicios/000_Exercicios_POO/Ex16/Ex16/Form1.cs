using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16
{
    public partial class Form1 : Form
    {
        List<Funcionario> piao = new List<Funcionario>();
        List<Funcionario> gerente = new List<Funcionario>();
        List<Funcionario> vendedor = new List<Funcionario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravarFuncPiao_Click(object sender, EventArgs e)
        {
            FuncionarioPiao a = new FuncionarioPiao();
            
            a.Codigo = Convert.ToInt32(txtCodFuncPiao.Text);
            a.Nome = txtNomeFuncPiao.Text;
            a.Salario = Convert.ToDouble(txtSalarioFuncPiao.Text);
            a.HoraExtra = Convert.ToDouble(txtHoraExtraFuncPiao.Text);
            a.Salario = a.CalculaSalario();
            piao.Add(a);
        }

        private void btnGravarFuncGerente_Click(object sender, EventArgs e)
        {
            FuncionarioGerente a = new FuncionarioGerente();

            a.Codigo = Convert.ToInt32(txtCodFuncGerente.Text);
            a.Nome = txtNomeFuncGerente.Text;
            a.Salario = Convert.ToDouble(txtSalarioFuncGerente.Text);
            a.QtdFuncionariosSubordinados = Convert.ToInt32(txtQtdFuncSubordinados.Text);
            a.Salario = a.CalculaSalario();
            gerente.Add(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioVendedor a = new FuncionarioVendedor();

            a.Codigo = Convert.ToInt32(txtCodFuncVendedor.Text);
            a.Nome = txtNomeFuncVendedor.Text;
            a.Salario = Convert.ToDouble(txtSalarioFuncVendedor.Text);
            a.MetaDeVendaMes = Convert.ToDouble(txtMetaDeVendas.Text);
            a.VendasDoMes = Convert.ToDouble(txtVendasDoMes.Text);
            a.PorcentagemSobreVendas = Convert.ToDouble(txtProcSobreVendas.Text);
            a.Salario = a.CalculaSalario();
            vendedor.Add(a);
        }

        private void btnExibirFuncPiao_Click(object sender, EventArgs e)
        {
            txtExibicao.Text = null;
            string conteudo = "Fundionários Pião: ";
            foreach(Funcionario item in piao)
            {
                conteudo = conteudo + "\r\n\r\n Código: " + item.Codigo +
                                      "\r\n Nome: " + item.Nome +
                                      "\r\n Salário: " + item.Salario;
            }
            txtExibicao.Text = conteudo;
        }

        private void btnExibirFuncGerente_Click(object sender, EventArgs e)
        {
            txtExibicao.Text = null;
            string conteudo = "Fundionários Gerente: ";
            foreach (Funcionario item in gerente)
            {
                conteudo = conteudo + "\r\n\r\n Código: " + item.Codigo +
                                      "\r\n Nome: " + item.Nome +
                                      "\r\n Salário: " + item.Salario;
            }
            txtExibicao.Text = conteudo;
        }

        private void btnExibirFuncVendedor_Click(object sender, EventArgs e)
        {
            txtExibicao.Text = null;
            string conteudo = "Fundionários Vendedor: ";
            foreach (Funcionario item in vendedor)
            {
                conteudo = conteudo + "\r\n\r\n Código: " + item.Codigo +
                                      "\r\n Nome: " + item.Nome +
                                      "\r\n Salário: " + item.Salario;
            }
            txtExibicao.Text = conteudo;
        }
    }
}
