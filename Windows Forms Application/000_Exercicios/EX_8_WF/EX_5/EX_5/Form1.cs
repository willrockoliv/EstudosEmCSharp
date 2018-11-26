using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_5
{
    public partial class Form1 : Form
    {
        CCorrente conta;
        bool contaCriada = false;
        frMovimentacao telaMovimentacao = null;

        public Form1()
        {
            InitializeComponent();
            lbMovimentacao.Items.Clear();
        }


        /// <summary>
        /// Verifica se o valor para saque/depósito foi informado.
        /// </summary>
        /// <returns></returns>
        private bool ValidaValor()
        {
            try
            {
                /*if (Convert.ToDouble(txtValor.Text) > 0)
                    return true;
                
                return false;*/

                return Convert.ToDouble(txtValor.Text) > 0;
            }
            catch
            {
                return false;
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            if (contaCriada == false)
            {
                MessageBox.Show("Digite primeiro os dados da conta.");
                return;
            }

            if (ValidaValor())
            {
                if (Convert.ToDouble(txtValor.Text) > conta.Saldo)
                {
                    MessageBox.Show("Saldo não pode ficar negativo!.");
                    return;
                }

                conta.Saldo = conta.Saldo - Convert.ToDouble(txtValor.Text);
                txtSaldo.Text = conta.Saldo.ToString("0.00");
                lbMovimentacao.Items.Add("Sacado R$ " + txtValor.Text);
                                
                if (telaMovimentacao.Visible == false)
                    ExibeTela();

                telaMovimentacao.RegistraMovimento("Sacado R$ " + txtValor.Text);
            }
            else
            {
                MessageBox.Show("Valor inválido.");
            }
        }



        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (contaCriada == false)
            {
                MessageBox.Show("Digite primeiro os dados da conta.");
                return;
            }

            if (ValidaValor())
            {
                conta.Saldo = conta.Saldo + Convert.ToDouble(txtValor.Text);
                txtSaldo.Text = conta.Saldo.ToString("0.00");
                lbMovimentacao.Items.Add("Depositado R$ " + txtValor.Text);

                if (telaMovimentacao.Visible == false)
                    ExibeTela();

                telaMovimentacao.RegistraMovimento("Depositado R$ " + txtValor.Text);                
            }
            else
            {
                MessageBox.Show("Valor inválido.");
            }

        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                imgFotoCliente.ImageLocation = openFileDialog1.FileName;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (contaCriada)
            {
                MessageBox.Show("Já criado!");
                return;
            }

            errorProvider1.Clear();
            bool erros = false;


            if (txtCliente.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtCliente, "Informe o cliente.");
                erros = true;
            }

            if (txtConta.Text.Trim().Length < 5)
            {
                errorProvider1.SetError(txtConta, "Informe a conta corrente com pelo menos 5 dígitos.");
                erros = true;
            }

            try
            {
                if (Convert.ToInt32(txtAgencia.Text) <= 0)
                {
                    errorProvider1.SetError(txtAgencia, "Informe a agência.");
                    erros = true;
                }
            }
            catch
            {
                errorProvider1.SetError(txtAgencia, "Digite apenas números na agência.");
                erros = true;
            }
            
            /*
            if (imgFotoCliente.ImageLocation == null ||
                imgFotoCliente.ImageLocation == "") */

            if (string.IsNullOrEmpty(imgFotoCliente.ImageLocation))
            {
                errorProvider1.SetError(imgFotoCliente, "Informe a foto.");
                erros = true;
            }
                       
            
            if (erros)
                return;
            else
            {
                conta = new CCorrente();
                conta.Agencia = txtAgencia.Text;
                conta.CaminhoFoto = imgFotoCliente.ImageLocation;
                conta.Conta = txtConta.Text;
                conta.NomeCliente = txtCliente.Text;
                conta.Saldo = Convert.ToDouble(txtSaldo.Text);
                contaCriada = true;
                btnSaque.Enabled = btnDeposito.Enabled = true;
                MessageBox.Show("Criado!");

                ExibeTela();

            }
        }

        private void ExibeTela()
        {
            telaMovimentacao = new frMovimentacao();
            telaMovimentacao.Show();
            telaMovimentacao.Left = Left + Width + 2;
        }

        private void imgFotoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
