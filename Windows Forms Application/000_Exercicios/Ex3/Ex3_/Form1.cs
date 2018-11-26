using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public bool ok = true;
        public string[] arquivo;
        struct Cadastros
        {
            public int codigo;
            public bool masculino, feminino, possui_casa;
            public string nome, cidade, data_nasc, eletrodomestico;
        }

        public Form1()
        {
            InitializeComponent();
            
            ok = ValidaArquivo(ok);
            if (ok == true)
            {
                arquivo = File.ReadAllLines("cadastro.txt", Encoding.UTF8);
                Cadastros[] cadastros = new Cadastros[arquivo.Length];
                CarregaArquivo(arquivo, ref cadastros);
                txtCod.Text = Convert.ToString(cadastros[arquivo.Length - 1].codigo);
            }
        }

        static void CarregaArquivo(string[] arquivo, ref Cadastros[] cadastro)
        {
            for (int i = 0; i < arquivo.Length; i++)
            {
                string[] temp = arquivo[i].Split('|');
                cadastro[i].codigo = Convert.ToInt16(temp[0].Trim());
                cadastro[i].data_nasc = temp[1].Trim();
                cadastro[i].nome = temp[2].Trim();
                cadastro[i].cidade = temp[3].Trim();
                if (temp[4].Trim() == "t")
                {
                    cadastro[i].possui_casa = true;
                    cadastro[i].eletrodomestico = temp[5].Trim();
                }
                else
                {
                    cadastro[i].possui_casa = false;
                    cadastro[i].eletrodomestico = null;
                }
                if (temp[6].Trim() == "M")
                {
                    cadastro[i].masculino = true;
                    cadastro[i].feminino = false;
                }
                else
                {
                    cadastro[i].masculino = false;
                    cadastro[i].feminino = true;
                }
            }
        }

        static bool ValidaArquivo(bool ok)
        {
            if (File.Exists("cadastro.txt"))
                return ok = true;
            else
                return ok = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastros[] Cadastros = new Cadastros[arquivo.Length];
            #region Valida Código
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
            ok = ValidaCodigo(ok, codigo);
            if (ok == false)
            {
                ok = true;
                return;
            }
            #endregion

            #region Valida Sexo
            if (rbMasculino.Checked == false && rbFeminino.Checked == false)
            {
                MessageBox.Show("Sexo é obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            if (ok == false)
            {
                ok = true;
                return;
            }
            #endregion

            #region Valida Nome
            string nome = txtNome.Text;
            ok = ValidaNome(nome, ok);
            if (ok == false)
            {
                ok = true;
                return;
            }
            #endregion

            #region Valida Cidade
            int cidade = cbCidade.SelectedIndex;
            ok = ValidaCidade(cidade, ok);
            if (ok == false)
            {
                ok = true;
                return;
            }
            #endregion

            #region Valida Data Nasc
            string data_nasc = txtDataNasc.Text;
            ok = ValidaDataNasc(data_nasc, ok);
            if (ok == false)
            {
                ok = true;
                return;
            }
            #endregion

            #region Valida Possui Casa
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
            #endregion

            #region Valida Eletrodomsticos
            if (cbPossuiCasa.Checked == true)
            {
                if (lbEletrodomesticos.SelectedIndex == -1)
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
            #endregion

            #region Salva e Limpa Campos
            if (ok == true)
            {
                Salvar(txtCod, txtDataNasc, txtNome, cbCidade, cbPossuiCasa, rbFeminino, rbMasculino, lbEletrodomesticos);
                MessageBox.Show("Salvo com sucesso!", "Salvo com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCod.Clear();
                txtDataNasc.Clear();
                txtNome.Clear();
                cbCidade.SelectedIndex = -1;
                cbPossuiCasa.Checked = false;
                rbFeminino.Checked = false;
                rbMasculino.Checked = false;
            }
            #endregion
        }

        static bool ValidaCodigo(bool ok, int codigo)
        {
            if (codigo < Cadastros[arquivo.Length - 1].codigo)
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

        static bool ValidaCidade(int cidade, bool ok)
        {
            if (cidade == -1)
            {
                MessageBox.Show("Cidade é um campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ok = false;
            }
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

        static void Salvar(TextBox txtCod, MaskedTextBox txtDataNasc, TextBox txtNome, ComboBox cbCidade,
                           CheckBox cbPossuiCasa, RadioButton rbFeminino, RadioButton rbMasculino,
                           ListBox lbEletrodomesticos)
        {
            string arquivo = txtCod.Text.Trim() + " | " + txtDataNasc.Text.Trim() + " | " +
                             txtNome.Text.Trim() + " | " + cbCidade.SelectedItem.ToString().Trim() + " | ";
            if (cbPossuiCasa.Checked == true)
            {
                arquivo = arquivo + " t | ";
                arquivo = arquivo + lbEletrodomesticos.SelectedItem.ToString().Trim() + " | ";
            }
            if (rbFeminino.Checked == true)
                arquivo = arquivo + "F | ";
            else if (rbMasculino.Checked == true)
                arquivo = arquivo + "M" + Environment.NewLine;

            File.AppendAllText("cadastro.txt", arquivo, Encoding.UTF8);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Form2 funcionarios = new Form2();

        }

        private void cbPossuiCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPossuiCasa.Checked == true)
                lbEletrodomesticos.Enabled = true;
            else
                lbEletrodomesticos.Enabled = false;
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
