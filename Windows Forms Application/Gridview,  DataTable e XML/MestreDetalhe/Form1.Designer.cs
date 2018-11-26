namespace MestreDetalhe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProduto = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 138);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(123, 18);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(61, 20);
            this.txtProduto.TabIndex = 2;
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remover Registro Selecionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(602, 17);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(19, 22);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(98, 13);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Código do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(533, 18);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(61, 20);
            this.txtQtde.TabIndex = 6;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(190, 18);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(298, 20);
            this.txtDescricaoProduto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Você pode alterar a quantidade diretamente no grid";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 208);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar em XML";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(108, 208);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(110, 23);
            this.btnCarregar.TabIndex = 11;
            this.btnCarregar.Text = "Carregar de XML";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.Location = new System.Drawing.Point(224, 208);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(110, 23);
            this.btnApagarTudo.TabIndex = 12;
            this.btnApagarTudo.Text = "Apaga tudo!";
            this.btnApagarTudo.UseVisualStyleBackColor = true;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(12, 297);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(665, 95);
            this.lbProdutos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Listagem de produtos disponíveis:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Preencher produtos disponíveis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProdutos);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Exemplo de Grid e DataTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txtProduto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtQtde;
        private System.Windows.Forms.MaskedTextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

