using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        List<CCorrente>  listaContas = new List<CCorrente>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CCorrente conta = new CCorrente(Convert.ToInt32(txtAgencia.Text), txtCC.Text, txtTitular.Text);                                
                listaContas.Add(conta);

                txtAgencia.Clear();
                txtCC.Clear();
                txtTitular.Clear();
                txtSaldo.Clear();
                
                cbContas.DataSource = null;
                cbContas.DataSource = listaContas;
                cbContas.DisplayMember = "Nometitular";
                cbContas.ValueMember = "CC";
            }
            catch
            {
                MessageBox.Show("Preencha a agência direito.");                
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (cbContas.SelectedItem  == null)
                MessageBox.Show("Crie a conta primeiro");

            try
            {
                (cbContas.SelectedItem as CCorrente).Saque(Convert.ToDouble(txtValor.Text));
                txtSaldo.Text = (cbContas.SelectedItem as CCorrente).Saldo.ToString("0.00");

                /*
                foreach(CCorrente conta in listaContas)
                    if (conta.CC == cbContas.SelectedValue.ToString())
                    {
                        conta.Saque(Convert.ToDouble(txtValor.Text));
                        txtSaldo.Text = conta.Saldo.ToString("0.00");
                        break;
                    }

                CCorrente cAux = listaContas.Find(conta => conta.CC == cbContas.SelectedValue.ToString());
                cAux.Saque(Convert.ToDouble(txtValor.Text));
                txtSaldo.Text = cAux.Saldo.ToString("0.00"); */

                /*
                List<int> listaInteiros = new List<int>();
                listaInteiros.Add(1);
                listaInteiros.Add(2);
                listaInteiros.Add(7);

                int numero = listaInteiros.Find(n => n == 7);  */


            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbContas.SelectedItem == null)
                MessageBox.Show("Crie a conta primeiro");

            try
            {
                (cbContas.SelectedItem as CCorrente).Deposito(Convert.ToDouble(txtValor.Text));
                txtSaldo.Text = (cbContas.SelectedItem as CCorrente).Saldo.ToString("0.00");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbContas.Items.Clear();
            foreach (var conta in listaContas)
            {
                lbContas.Items.Add($"Ag: {conta.Agencia}  Conta: {conta.CC} Titular: {conta.Nometitular}  Saldo: {conta.Saldo}   ");

            }
        }
    }
}
