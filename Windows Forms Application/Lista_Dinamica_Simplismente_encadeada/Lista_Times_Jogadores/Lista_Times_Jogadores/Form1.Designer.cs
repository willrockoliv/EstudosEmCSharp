namespace Lista_Times_Jogadores
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTreinador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mkbNumero = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.ltbJogadores = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.ltbTodos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(610, 27);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(379, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 42);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(26, 36);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(288, 20);
            this.txtTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Treinador";
            // 
            // txtTreinador
            // 
            this.txtTreinador.Location = new System.Drawing.Point(26, 75);
            this.txtTreinador.Name = "txtTreinador";
            this.txtTreinador.Size = new System.Drawing.Size(288, 20);
            this.txtTreinador.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // txtJogador
            // 
            this.txtJogador.Location = new System.Drawing.Point(76, 33);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(238, 20);
            this.txtJogador.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número";
            // 
            // mkbNumero
            // 
            this.mkbNumero.Location = new System.Drawing.Point(26, 33);
            this.mkbNumero.Mask = "000";
            this.mkbNumero.Name = "mkbNumero";
            this.mkbNumero.Size = new System.Drawing.Size(28, 20);
            this.mkbNumero.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCont);
            this.groupBox1.Controls.Add(this.ltbJogadores);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.mkbNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtJogador);
            this.groupBox1.Location = new System.Drawing.Point(19, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogadores";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(320, 65);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(30, 13);
            this.lblCont.TabIndex = 16;
            this.lblCont.Text = "0/11";
            // 
            // ltbJogadores
            // 
            this.ltbJogadores.FormattingEnabled = true;
            this.ltbJogadores.Location = new System.Drawing.Point(26, 65);
            this.ltbJogadores.Name = "ltbJogadores";
            this.ltbJogadores.Size = new System.Drawing.Size(288, 303);
            this.ltbJogadores.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Lista_Times_Jogadores.Properties.Resources.stock_plus_13_1_;
            this.btnAdd.Location = new System.Drawing.Point(320, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 21);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTreinador);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Location = new System.Drawing.Point(19, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 105);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // button1
            // 
            this.button1.Image = global::Lista_Times_Jogadores.Properties.Resources._new;
            this.button1.Location = new System.Drawing.Point(379, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Lista_Times_Jogadores.Properties.Resources.lupa1;
            this.btnNovo.Location = new System.Drawing.Point(379, 81);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(25, 20);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = global::Lista_Times_Jogadores.Properties.Resources.linha_16__1_;
            this.btnApagar.Location = new System.Drawing.Point(379, 107);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(25, 20);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // ltbTodos
            // 
            this.ltbTodos.FormattingEnabled = true;
            this.ltbTodos.Location = new System.Drawing.Point(470, 59);
            this.ltbTodos.Name = "ltbTodos";
            this.ltbTodos.Size = new System.Drawing.Size(356, 433);
            this.ltbTodos.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 504);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.ltbTodos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnListar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTreinador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkbNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox ltbJogadores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListBox ltbTodos;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Button button1;
    }
}

