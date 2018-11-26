using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17_
{
    public partial class Form1 : Form
    {
        List<VeiculoAutomotor> v = new List<VeiculoAutomotor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                Carro c = (v.Find(carro => carro.Descricao.Contains(txtDescricaoCarro.Text)) as Carro);
                if (c != null)
                    throw new Exception("Carro já cadastrado");

                c = new Carro();
                if (txtDescricaoCarro.Text != "")
                    c.Descricao = txtDescricaoCarro.Text;
                else
                    throw new Exception("Descrição não pode ser nula");
                if (Double.TryParse(txtCapacidadeMaxKgCarro.Text, out double capacidadeMaxKg))
                    c.CapacidadeMaximaEmKg = capacidadeMaxKg;
                else
                    throw new Exception("Capacidade Máxima inválida");
                if (Int32.TryParse(txtQtdPortasCarro.Text, out int qtdPortas))
                    c.QuantidadeDePortas = qtdPortas;
                else
                    throw new Exception("Quantidade de portas inválida");
                if (ckbUtilizandoReboqueCarro.Checked)
                    c.UtilizandoReboque = true;
                else
                    c.UtilizandoReboque = false;

                v.Add(c);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbUtilizandoReboqueCarro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPagarPedagioCarro_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c = (v.Find(carro => carro.Descricao.Contains(txtDescricaoCarro.Text))) as Carro;
            txtPedagioCarro.Text = "R$ " + c.PagarPedagio().ToString("0.00");
        }

        private void btnPesquisarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                Carro c = (v.Find(carro => carro.Descricao.Contains(txtDescricaoCarro.Text)) as Carro);
                if (c == null)
                    throw new Exception("Carro não encontrado");
                else
                {
                    txtDescricaoCarro.Text = c.Descricao;
                    txtCapacidadeMaxKgCarro.Text = c.CapacidadeMaximaEmKg.ToString();
                    txtQtdPortasCarro.Text = c.QuantidadeDePortas.ToString();
                    ckbUtilizandoReboqueCarro.Checked = c.UtilizandoReboque;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
