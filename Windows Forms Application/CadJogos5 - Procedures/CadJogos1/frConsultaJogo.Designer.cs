namespace CadJogos1
{
    partial class frConsultaJogo
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbPorCategoria = new System.Windows.Forms.RadioButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tbTodas = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.gvJogos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJogos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbPorCategoria);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.tbTodas);
            this.groupBox1.Location = new System.Drawing.Point(372, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // rbPorCategoria
            // 
            this.rbPorCategoria.AutoSize = true;
            this.rbPorCategoria.Location = new System.Drawing.Point(18, 55);
            this.rbPorCategoria.Name = "rbPorCategoria";
            this.rbPorCategoria.Size = new System.Drawing.Size(88, 17);
            this.rbPorCategoria.TabIndex = 2;
            this.rbPorCategoria.Text = "Por categoria";
            this.rbPorCategoria.UseVisualStyleBackColor = true;
            this.rbPorCategoria.CheckedChanged += new System.EventHandler(this.rbPorCategoria_CheckedChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(145, 32);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(169, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // tbTodas
            // 
            this.tbTodas.AutoSize = true;
            this.tbTodas.Checked = true;
            this.tbTodas.Location = new System.Drawing.Point(18, 32);
            this.tbTodas.Name = "tbTodas";
            this.tbTodas.Size = new System.Drawing.Size(55, 17);
            this.tbTodas.TabIndex = 0;
            this.tbTodas.TabStop = true;
            this.tbTodas.Text = "Todas";
            this.tbTodas.UseVisualStyleBackColor = true;
            this.tbTodas.CheckedChanged += new System.EventHandler(this.rbPorCategoria_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(291, 18);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(235, 21);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // gvJogos
            // 
            this.gvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvJogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvJogos.Location = new System.Drawing.Point(0, 106);
            this.gvJogos.Name = "gvJogos";
            this.gvJogos.Size = new System.Drawing.Size(803, 194);
            this.gvJogos.TabIndex = 9;
            this.gvJogos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvJogos_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPreco);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 106);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 51);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(194, 25);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(87, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 75);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 7;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(194, 75);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(87, 20);
            this.txtId.TabIndex = 9;
            // 
            // frConsultaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 351);
            this.Controls.Add(this.gvJogos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frConsultaJogo";
            this.Text = "Consulta de jogos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJogos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPorCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton tbTodas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView gvJogos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
    }
}