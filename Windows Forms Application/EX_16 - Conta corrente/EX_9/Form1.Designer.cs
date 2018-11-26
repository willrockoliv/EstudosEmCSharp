namespace EX_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCriaCCorrente = new System.Windows.Forms.Button();
            this.ckCheque = new System.Windows.Forms.CheckBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCriaCPoupanca = new System.Windows.Forms.Button();
            this.txtDiaAniversario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumeroCCAtrelada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtCCParaMov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 20);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroConta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados comuns";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(183, 38);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(99, 20);
            this.txtNumeroConta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nmero da conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCriaCCorrente);
            this.groupBox2.Controls.Add(this.ckCheque);
            this.groupBox2.Controls.Add(this.txtLimite);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta corrente";
            // 
            // btnCriaCCorrente
            // 
            this.btnCriaCCorrente.Location = new System.Drawing.Point(38, 112);
            this.btnCriaCCorrente.Name = "btnCriaCCorrente";
            this.btnCriaCCorrente.Size = new System.Drawing.Size(91, 30);
            this.btnCriaCCorrente.TabIndex = 9;
            this.btnCriaCCorrente.Text = "Criar C.Corrente";
            this.btnCriaCCorrente.UseVisualStyleBackColor = true;
            this.btnCriaCCorrente.Click += new System.EventHandler(this.btnCriaCCorrente_Click);
            // 
            // ckCheque
            // 
            this.ckCheque.AutoSize = true;
            this.ckCheque.Location = new System.Drawing.Point(20, 75);
            this.ckCheque.Name = "ckCheque";
            this.ckCheque.Size = new System.Drawing.Size(134, 17);
            this.ckCheque.TabIndex = 8;
            this.ckCheque.Text = "Utiliza talão de cheque";
            this.ckCheque.UseVisualStyleBackColor = true;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(20, 39);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(99, 20);
            this.txtLimite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Limite de crédito";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCriaCPoupanca);
            this.groupBox3.Controls.Add(this.txtDiaAniversario);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.NumeroCCAtrelada);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(262, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 148);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta poupança";
            // 
            // btnCriaCPoupanca
            // 
            this.btnCriaCPoupanca.Location = new System.Drawing.Point(49, 112);
            this.btnCriaCPoupanca.Name = "btnCriaCPoupanca";
            this.btnCriaCPoupanca.Size = new System.Drawing.Size(107, 30);
            this.btnCriaCPoupanca.TabIndex = 10;
            this.btnCriaCPoupanca.Text = "Criar C.Poupança";
            this.btnCriaCPoupanca.UseVisualStyleBackColor = true;
            this.btnCriaCPoupanca.Click += new System.EventHandler(this.btnCriaCPoupanca_Click);
            // 
            // txtDiaAniversario
            // 
            this.txtDiaAniversario.Location = new System.Drawing.Point(20, 75);
            this.txtDiaAniversario.Name = "txtDiaAniversario";
            this.txtDiaAniversario.Size = new System.Drawing.Size(38, 20);
            this.txtDiaAniversario.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dia de aniversário";
            // 
            // NumeroCCAtrelada
            // 
            this.NumeroCCAtrelada.Location = new System.Drawing.Point(20, 39);
            this.NumeroCCAtrelada.Name = "NumeroCCAtrelada";
            this.NumeroCCAtrelada.Size = new System.Drawing.Size(99, 20);
            this.NumeroCCAtrelada.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nº da c.Corrente atrelada";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 279);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(542, 108);
            this.listBox1.TabIndex = 5;
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(521, 222);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(69, 30);
            this.btnSaque.TabIndex = 11;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(596, 222);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(66, 30);
            this.btnDeposito.TabIndex = 12;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(544, 199);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(99, 20);
            this.txtValor.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(556, 279);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(69, 30);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar tudo";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtCCParaMov
            // 
            this.txtCCParaMov.Location = new System.Drawing.Point(544, 160);
            this.txtCCParaMov.Name = "txtCCParaMov";
            this.txtCCParaMov.Size = new System.Drawing.Size(99, 20);
            this.txtCCParaMov.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nmero da conta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 401);
            this.Controls.Add(this.txtCCParaMov);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.listBox1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckCheque;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NumeroCCAtrelada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaAniversario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCriaCCorrente;
        private System.Windows.Forms.Button btnCriaCPoupanca;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtCCParaMov;
        private System.Windows.Forms.Label label8;
    }
}

