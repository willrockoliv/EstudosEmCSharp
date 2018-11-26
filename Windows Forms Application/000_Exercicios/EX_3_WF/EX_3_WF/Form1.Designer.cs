namespace EX_3_WF
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
            this.Código = new System.Windows.Forms.Label();
            this.bla = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.ckPossuiCasa = new System.Windows.Forms.CheckBox();
            this.lbEletrodomesticos = new System.Windows.Forms.ListBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(12, 20);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 0;
            this.Código.Text = "Código";
            // 
            // bla
            // 
            this.bla.AutoSize = true;
            this.bla.Location = new System.Drawing.Point(132, 20);
            this.bla.Name = "bla";
            this.bla.Size = new System.Drawing.Size(35, 13);
            this.bla.TabIndex = 1;
            this.bla.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(343, 36);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 4;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(21, 29);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(21, 53);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // ckPossuiCasa
            // 
            this.ckPossuiCasa.AutoSize = true;
            this.ckPossuiCasa.Location = new System.Drawing.Point(186, 82);
            this.ckPossuiCasa.Name = "ckPossuiCasa";
            this.ckPossuiCasa.Size = new System.Drawing.Size(83, 17);
            this.ckPossuiCasa.TabIndex = 7;
            this.ckPossuiCasa.Text = "Possui casa";
            this.ckPossuiCasa.UseVisualStyleBackColor = true;
            // 
            // lbEletrodomesticos
            // 
            this.lbEletrodomesticos.FormattingEnabled = true;
            this.lbEletrodomesticos.Items.AddRange(new object[] {
            "Aspirador de pó",
            "Geladeira",
            "Microondas",
            "Televisão",
            "Videogame"});
            this.lbEletrodomesticos.Location = new System.Drawing.Point(285, 73);
            this.lbEletrodomesticos.Name = "lbEletrodomesticos";
            this.lbEletrodomesticos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEletrodomesticos.Size = new System.Drawing.Size(120, 82);
            this.lbEletrodomesticos.Sorted = true;
            this.lbEletrodomesticos.TabIndex = 8;
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Items.AddRange(new object[] {
            "Araras",
            "Diadema",
            "Jaú",
            "Mauá",
            "Pindamonhangaba",
            "Santa fé do sul",
            "São Bernardo do Campo",
            "São Paulo"});
            this.cbCidade.Location = new System.Drawing.Point(12, 188);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(162, 21);
            this.cbCidade.Sorted = true;
            this.cbCidade.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cidade";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Image = global::EX_3_WF.Properties.Resources._1478235674_folder;
            this.btnCarregar.Location = new System.Drawing.Point(108, 236);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(66, 37);
            this.btnCarregar.TabIndex = 12;
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::EX_3_WF.Properties.Resources._1478235632_floppy;
            this.btnSalvar.Location = new System.Drawing.Point(12, 237);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 37);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 286);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.lbEletrodomesticos);
            this.Controls.Add(this.ckPossuiCasa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.bla);
            this.Controls.Add(this.Código);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Código;
        private System.Windows.Forms.Label bla;
        private System.Windows.Forms.NumericUpDown txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.CheckBox ckPossuiCasa;
        private System.Windows.Forms.ListBox lbEletrodomesticos;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
    }
}

