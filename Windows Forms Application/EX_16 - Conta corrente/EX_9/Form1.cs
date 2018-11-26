using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<ContaBancaria> listaContas = new List<ContaBancaria>();


        private void PreencheAtributosBasicos(ContaBancaria cc)
        {
            cc.Nome = txtNome.Text;
            cc.NumeroConta = txtNumeroConta.Text;
        }


        private void btnCriaCCorrente_Click(object sender, EventArgs e)
        {
         try
            {
                ContaCorrente cc = new ContaCorrente();
                PreencheAtributosBasicos(cc);
                cc.LimitedeCredito = Convert.ToDouble(txtLimite.Text);
                cc.UtilizaTalaoCheque = ckCheque.Checked;                               

                listaContas.Add(cc);
            }
            catch (Exception ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
        }

        private void btnCriaCPoupanca_Click(object sender, EventArgs e)
        {
            try
            {
                ContaPoupanca cc = new ContaPoupanca();
                PreencheAtributosBasicos(cc);
                cc.DiaDeAniversario = Convert.ToInt16(txtDiaAniversario.Text);
                cc.NumeroContaAtrelada = txtNumeroConta.Text;
                listaContas.Add(cc);
            }
            catch (NegocioException ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            catch(FormatException erro)
            {
                MessageBox.Show("Digite apenas números!");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro desconhecido! " + erro.Message);
            }
        }

        private ContaBancaria PesquisaConta(string numero)
        {
            //return listaContas.Find(cc => cc.NumeroConta == numero);

            foreach (ContaBancaria cc in listaContas)
            {
                if (cc.NumeroConta == numero)
                    return cc;
            }
            return null;
        }


        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                ContaBancaria conta = PesquisaConta(txtCCParaMov.Text);
                if (conta == null)
                    MessageBox.Show("Conta não existe!");
                else
                {
                    conta.Saque(Convert.ToDouble(txtValor.Text));
                }
            }
            catch (NegocioException ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            catch (FormatException erro)
            {
                MessageBox.Show("Digite apenas números!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro desconhecido! " + erro.Message);
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                ContaBancaria conta = PesquisaConta(txtCCParaMov.Text);
                if (conta == null)
                    MessageBox.Show("Conta não existe!");
                else
                {
                    conta.Deposito(Convert.ToDouble(txtValor.Text));
                }
            }
            catch (NegocioException ERRO)
            {
                MessageBox.Show(ERRO.Message);
            }
            catch (FormatException erro)
            {
                MessageBox.Show("Digite apenas números!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro desconhecido! " + erro.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (ContaBancaria cc in listaContas)
            {
                listBox1.Items.Add(cc.ToString());
            }
        }
    }
}
