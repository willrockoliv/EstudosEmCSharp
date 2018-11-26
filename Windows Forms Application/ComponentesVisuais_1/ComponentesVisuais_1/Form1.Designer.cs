namespace ComponentesVisuais_1
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDiasSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SelecionarSexta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbVideogames = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Maior de 18 anos";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(22, 68);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(108, 20);
            this.data.TabIndex = 1;
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Items.AddRange(new object[] {
            "Selecione uma cidade...",
            "São Bernardo",
            "São Caetano",
            "Diadema",
            "Mauá",
            "Itaquá",
            "Santo André",
            "Riberão Pires"});
            this.cbCidade.Location = new System.Drawing.Point(22, 125);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(216, 21);
            this.cbCidade.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDiasSemana
            // 
            this.cbDiasSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiasSemana.FormattingEnabled = true;
            this.cbDiasSemana.Items.AddRange(new object[] {
            "Selecione uma cidade...",
            "São Bernardo",
            "São Caetano",
            "Diadema",
            "Mauá",
            "Itaquá",
            "Santo André",
            "Riberão Pires"});
            this.cbDiasSemana.Location = new System.Drawing.Point(22, 180);
            this.cbDiasSemana.Name = "cbDiasSemana";
            this.cbDiasSemana.Size = new System.Drawing.Size(216, 21);
            this.cbDiasSemana.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dias da semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cidades";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Preencher dias da semana";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelecionarSexta
            // 
            this.SelecionarSexta.Location = new System.Drawing.Point(255, 207);
            this.SelecionarSexta.Name = "SelecionarSexta";
            this.SelecionarSexta.Size = new System.Drawing.Size(147, 23);
            this.SelecionarSexta.TabIndex = 8;
            this.SelecionarSexta.Text = "Selecionar sexta feira";
            this.SelecionarSexta.UseVisualStyleBackColor = true;
            this.SelecionarSexta.Click += new System.EventHandler(this.SelecionarSexta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Obter todos os valores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComponentesVisuais_1.Properties.Resources.desespero;
            this.pictureBox1.ImageLocation = "C:\\Users\\William.Rocha\\Google Drive\\Computação\\FTT\\EC - Algoritmos\\Windows Forms " +
    "Application\\ComponentesVisuais_1\\ComponentesVisuais_1\\bin\\Debug\\desespero.gif";
            this.pictureBox1.Location = new System.Drawing.Point(436, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbVideogames
            // 
            this.lbVideogames.FormattingEnabled = true;
            this.lbVideogames.Items.AddRange(new object[] {
            "Nintendo Wii",
            "PS3",
            "PS4",
            "XBOX 360",
            "XBOX ONE",
            "Plataforma  PC",
            "SNES"});
            this.lbVideogames.Location = new System.Drawing.Point(22, 286);
            this.lbVideogames.Name = "lbVideogames";
            this.lbVideogames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbVideogames.Size = new System.Drawing.Size(120, 108);
            this.lbVideogames.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ver a seleção";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(148, 324);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(106, 23);
            this.btnSelecionar.TabIndex = 13;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(255, 327);
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(100, 20);
            this.txtDado.TabIndex = 14;
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(22, 260);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(120, 20);
            this.txtLocalizar.TabIndex = 15;
            this.txtLocalizar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Solteiro";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Casado";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(269, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Location = new System.Drawing.Point(443, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 59);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbVideogames);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SelecionarSexta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDiasSemana);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.data);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbDiasSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SelecionarSexta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbVideogames;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

