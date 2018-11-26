namespace Ex16
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExibirFuncPiao = new System.Windows.Forms.Button();
            this.btnGravarFuncPiao = new System.Windows.Forms.Button();
            this.txtHoraExtraFuncPiao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioFuncPiao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFuncPiao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodFuncPiao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExibirFuncGerente = new System.Windows.Forms.Button();
            this.btnGravarFuncGerente = new System.Windows.Forms.Button();
            this.txtQtdFuncSubordinados = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioFuncGerente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeFuncGerente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodFuncGerente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExibirFuncVendedor = new System.Windows.Forms.Button();
            this.txtProcSobreVendas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVendasDoMes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMetaDeVendas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalarioFuncVendedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeFuncVendedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodFuncVendedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExibicao = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExibirFuncPiao);
            this.groupBox1.Controls.Add(this.btnGravarFuncPiao);
            this.groupBox1.Controls.Add(this.txtHoraExtraFuncPiao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalarioFuncPiao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeFuncPiao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodFuncPiao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário Pião";
            // 
            // btnExibirFuncPiao
            // 
            this.btnExibirFuncPiao.Location = new System.Drawing.Point(122, 128);
            this.btnExibirFuncPiao.Name = "btnExibirFuncPiao";
            this.btnExibirFuncPiao.Size = new System.Drawing.Size(75, 23);
            this.btnExibirFuncPiao.TabIndex = 9;
            this.btnExibirFuncPiao.Text = "Exibir";
            this.btnExibirFuncPiao.UseVisualStyleBackColor = true;
            this.btnExibirFuncPiao.Click += new System.EventHandler(this.btnExibirFuncPiao_Click);
            // 
            // btnGravarFuncPiao
            // 
            this.btnGravarFuncPiao.Location = new System.Drawing.Point(21, 128);
            this.btnGravarFuncPiao.Name = "btnGravarFuncPiao";
            this.btnGravarFuncPiao.Size = new System.Drawing.Size(75, 23);
            this.btnGravarFuncPiao.TabIndex = 8;
            this.btnGravarFuncPiao.Text = "Gravar";
            this.btnGravarFuncPiao.UseVisualStyleBackColor = true;
            this.btnGravarFuncPiao.Click += new System.EventHandler(this.btnGravarFuncPiao_Click);
            // 
            // txtHoraExtraFuncPiao
            // 
            this.txtHoraExtraFuncPiao.Location = new System.Drawing.Point(107, 100);
            this.txtHoraExtraFuncPiao.Name = "txtHoraExtraFuncPiao";
            this.txtHoraExtraFuncPiao.Size = new System.Drawing.Size(90, 20);
            this.txtHoraExtraFuncPiao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora Extra (R$):";
            // 
            // txtSalarioFuncPiao
            // 
            this.txtSalarioFuncPiao.Location = new System.Drawing.Point(107, 74);
            this.txtSalarioFuncPiao.Name = "txtSalarioFuncPiao";
            this.txtSalarioFuncPiao.Size = new System.Drawing.Size(90, 20);
            this.txtSalarioFuncPiao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salário:";
            // 
            // txtNomeFuncPiao
            // 
            this.txtNomeFuncPiao.Location = new System.Drawing.Point(107, 48);
            this.txtNomeFuncPiao.Name = "txtNomeFuncPiao";
            this.txtNomeFuncPiao.Size = new System.Drawing.Size(90, 20);
            this.txtNomeFuncPiao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtCodFuncPiao
            // 
            this.txtCodFuncPiao.Location = new System.Drawing.Point(107, 22);
            this.txtCodFuncPiao.Name = "txtCodFuncPiao";
            this.txtCodFuncPiao.Size = new System.Drawing.Size(90, 20);
            this.txtCodFuncPiao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExibirFuncGerente);
            this.groupBox2.Controls.Add(this.btnGravarFuncGerente);
            this.groupBox2.Controls.Add(this.txtQtdFuncSubordinados);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSalarioFuncGerente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomeFuncGerente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCodFuncGerente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 174);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionário Gerente";
            // 
            // btnExibirFuncGerente
            // 
            this.btnExibirFuncGerente.Location = new System.Drawing.Point(122, 137);
            this.btnExibirFuncGerente.Name = "btnExibirFuncGerente";
            this.btnExibirFuncGerente.Size = new System.Drawing.Size(75, 23);
            this.btnExibirFuncGerente.TabIndex = 10;
            this.btnExibirFuncGerente.Text = "Exibir";
            this.btnExibirFuncGerente.UseVisualStyleBackColor = true;
            this.btnExibirFuncGerente.Click += new System.EventHandler(this.btnExibirFuncGerente_Click);
            // 
            // btnGravarFuncGerente
            // 
            this.btnGravarFuncGerente.Location = new System.Drawing.Point(21, 137);
            this.btnGravarFuncGerente.Name = "btnGravarFuncGerente";
            this.btnGravarFuncGerente.Size = new System.Drawing.Size(75, 23);
            this.btnGravarFuncGerente.TabIndex = 8;
            this.btnGravarFuncGerente.Text = "Gravar";
            this.btnGravarFuncGerente.UseVisualStyleBackColor = true;
            this.btnGravarFuncGerente.Click += new System.EventHandler(this.btnGravarFuncGerente_Click);
            // 
            // txtQtdFuncSubordinados
            // 
            this.txtQtdFuncSubordinados.Location = new System.Drawing.Point(107, 104);
            this.txtQtdFuncSubordinados.Name = "txtQtdFuncSubordinados";
            this.txtQtdFuncSubordinados.Size = new System.Drawing.Size(90, 20);
            this.txtQtdFuncSubordinados.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Funcionários \r\nSubordinados:";
            // 
            // txtSalarioFuncGerente
            // 
            this.txtSalarioFuncGerente.Location = new System.Drawing.Point(107, 74);
            this.txtSalarioFuncGerente.Name = "txtSalarioFuncGerente";
            this.txtSalarioFuncGerente.Size = new System.Drawing.Size(90, 20);
            this.txtSalarioFuncGerente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Salário:";
            // 
            // txtNomeFuncGerente
            // 
            this.txtNomeFuncGerente.Location = new System.Drawing.Point(107, 48);
            this.txtNomeFuncGerente.Name = "txtNomeFuncGerente";
            this.txtNomeFuncGerente.Size = new System.Drawing.Size(90, 20);
            this.txtNomeFuncGerente.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome:";
            // 
            // txtCodFuncGerente
            // 
            this.txtCodFuncGerente.Location = new System.Drawing.Point(107, 22);
            this.txtCodFuncGerente.Name = "txtCodFuncGerente";
            this.txtCodFuncGerente.Size = new System.Drawing.Size(90, 20);
            this.txtCodFuncGerente.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExibirFuncVendedor);
            this.groupBox3.Controls.Add(this.txtProcSobreVendas);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtVendasDoMes);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtMetaDeVendas);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSalarioFuncVendedor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtNomeFuncVendedor);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCodFuncVendedor);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(252, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 255);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funcionário Vendedor";
            // 
            // btnExibirFuncVendedor
            // 
            this.btnExibirFuncVendedor.Location = new System.Drawing.Point(122, 214);
            this.btnExibirFuncVendedor.Name = "btnExibirFuncVendedor";
            this.btnExibirFuncVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnExibirFuncVendedor.TabIndex = 11;
            this.btnExibirFuncVendedor.Text = "Exibir";
            this.btnExibirFuncVendedor.UseVisualStyleBackColor = true;
            this.btnExibirFuncVendedor.Click += new System.EventHandler(this.btnExibirFuncVendedor_Click);
            // 
            // txtProcSobreVendas
            // 
            this.txtProcSobreVendas.Location = new System.Drawing.Point(107, 173);
            this.txtProcSobreVendas.Name = "txtProcSobreVendas";
            this.txtProcSobreVendas.Size = new System.Drawing.Size(90, 20);
            this.txtProcSobreVendas.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 26);
            this.label14.TabIndex = 11;
            this.label14.Text = "Porcentagem\r\nsobre vendas:";
            // 
            // txtVendasDoMes
            // 
            this.txtVendasDoMes.Location = new System.Drawing.Point(107, 139);
            this.txtVendasDoMes.Name = "txtVendasDoMes";
            this.txtVendasDoMes.Size = new System.Drawing.Size(90, 20);
            this.txtVendasDoMes.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 26);
            this.label13.TabIndex = 9;
            this.label13.Text = "Vendas\r\ndo Mês:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMetaDeVendas
            // 
            this.txtMetaDeVendas.Location = new System.Drawing.Point(107, 104);
            this.txtMetaDeVendas.Name = "txtMetaDeVendas";
            this.txtMetaDeVendas.Size = new System.Drawing.Size(90, 20);
            this.txtMetaDeVendas.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Meta de\r\nVendas:";
            // 
            // txtSalarioFuncVendedor
            // 
            this.txtSalarioFuncVendedor.Location = new System.Drawing.Point(107, 74);
            this.txtSalarioFuncVendedor.Name = "txtSalarioFuncVendedor";
            this.txtSalarioFuncVendedor.Size = new System.Drawing.Size(90, 20);
            this.txtSalarioFuncVendedor.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Salário:";
            // 
            // txtNomeFuncVendedor
            // 
            this.txtNomeFuncVendedor.Location = new System.Drawing.Point(107, 48);
            this.txtNomeFuncVendedor.Name = "txtNomeFuncVendedor";
            this.txtNomeFuncVendedor.Size = new System.Drawing.Size(90, 20);
            this.txtNomeFuncVendedor.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome:";
            // 
            // txtCodFuncVendedor
            // 
            this.txtCodFuncVendedor.Location = new System.Drawing.Point(107, 22);
            this.txtCodFuncVendedor.Name = "txtCodFuncVendedor";
            this.txtCodFuncVendedor.Size = new System.Drawing.Size(90, 20);
            this.txtCodFuncVendedor.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Código:";
            // 
            // txtExibicao
            // 
            this.txtExibicao.Location = new System.Drawing.Point(508, 21);
            this.txtExibicao.Multiline = true;
            this.txtExibicao.Name = "txtExibicao";
            this.txtExibicao.Size = new System.Drawing.Size(238, 356);
            this.txtExibicao.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 404);
            this.Controls.Add(this.txtExibicao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodFuncPiao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravarFuncPiao;
        private System.Windows.Forms.TextBox txtHoraExtraFuncPiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioFuncPiao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFuncPiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExibirFuncPiao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExibirFuncGerente;
        private System.Windows.Forms.Button btnGravarFuncGerente;
        private System.Windows.Forms.TextBox txtQtdFuncSubordinados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioFuncGerente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeFuncGerente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodFuncGerente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExibirFuncVendedor;
        private System.Windows.Forms.TextBox txtProcSobreVendas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtVendasDoMes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMetaDeVendas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalarioFuncVendedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeFuncVendedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodFuncVendedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExibicao;
    }
}

