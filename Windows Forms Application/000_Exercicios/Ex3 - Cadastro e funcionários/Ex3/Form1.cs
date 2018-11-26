using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbPossuiCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPossuiCasa.Checked == true)
                lbEletrodomesticos.Enabled = true;
            else
                lbEletrodomesticos.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool ok = true;

            int codigo;
            try
            {
                codigo = Convert.ToInt16(txtCod.Text);
            }
            catch
            {
                MessageBox.Show("Código inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ValidaCodigo(ok, codigo);
            if (ok == false)
            {
                ok = true;
                return;
            }

            string nome = txtNome.Text;
            ValidaNome(nome, ok);
            if (ok == false)
            {
                ok = true;
                return;
            }

            string data_nasc = txtDataNasc.Text;
            ValidaDataNasc(data_nasc, ok);
            if (ok == false)
            {
                ok = true;
                return;
            }

            if (rbMasculino.Checked == false &&  rbFeminino.Checked == false)
            {
                MessageBox.Show("Sexo é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            if (ok == false)
            {
                ok = true;
                return;
            }

            if (cbPossuiCasa.Checked == false)
            {
                MessageBox.Show("Indique se possui casa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            if (ok == false)
            {
                ok = true;
                return;
            }

            if (cbPossuiCasa.Checked == true)
            {
                if(lbEletrodomesticos.SelectedIndex == -1)
                {
                    MessageBox.Show("Indique pelo menos 1 eletrodomestico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ok = false;
                }
            }
            if (ok == false)
            {
                ok = true;
                return;
            }

        }

        static bool ValidaCodigo(bool ok, int codigo)
        {
            if (codigo <= 0)
            {
                MessageBox.Show("Código deve ser maior que 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ok = false;
            }
            else
                return ok = true;
        }

        static bool ValidaNome(string nome, bool ok)
        {
            if (nome.Trim() == "" || nome.Trim().IndexOf(' ') == -1)
            {
                MessageBox.Show("Campo Nome e Sobrenome é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ok = false;
            }
            else
                return ok = true;
        }

        static bool ValidaDataNasc(string data_nasc, bool ok)
        {
            try
            {
                Convert.ToDateTime(data_nasc);
                if (Convert.ToDateTime(data_nasc) >= DateTime.Now.Date)
                {
                    MessageBox.Show("Data de Nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ok = false;
                }
            }
            catch
            {
                return ok = true;
            }
            return ok = true;
        }


        /*
3-) Crie um cadastro de funcionários, com os seguintes campos e validações:

codigo do funcionário: não pode ser menor ou igual a 0
nome : obrigatório nome e sobrenome 
data de nascimento: não pode ser superior a data atual
sexo : obrigatório
possui casa: checkbox
listbox com eletrodomesticos que ele possui na casa(preencha com umas 5 opções).
Multipla escolha. se possuir casa, deve selecionar pelo menos 1 opção.
cidade: utilize um combobox. campo obrigatório.

Crie 2 botoes: 1 botão deverá salvar todos os dados em um arquivo texto.
O outro botão deverá recuperar as informações e preencher os campos na tela.          
*/
    }
}
