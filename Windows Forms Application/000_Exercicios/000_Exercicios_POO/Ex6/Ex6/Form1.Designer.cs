namespace Ex6
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
            this.ltbAlunos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btnSalvarMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbAlunos
            // 
            this.ltbAlunos.FormattingEnabled = true;
            this.ltbAlunos.Location = new System.Drawing.Point(15, 103);
            this.ltbAlunos.Name = "ltbAlunos";
            this.ltbAlunos.Size = new System.Drawing.Size(312, 147);
            this.ltbAlunos.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nota 2";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(121, 64);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nota 1";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(15, 64);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 11;
            // 
            // btnSalvarMedia
            // 
            this.btnSalvarMedia.Location = new System.Drawing.Point(227, 64);
            this.btnSalvarMedia.Name = "btnSalvarMedia";
            this.btnSalvarMedia.Size = new System.Drawing.Size(100, 23);
            this.btnSalvarMedia.TabIndex = 10;
            this.btnSalvarMedia.Text = "Salvar Média";
            this.btnSalvarMedia.UseVisualStyleBackColor = true;
            this.btnSalvarMedia.Click += new System.EventHandler(this.btnSalvarMedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Location = new System.Drawing.Point(12, 253);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(81, 13);
            this.lblCont.TabIndex = 16;
            this.lblCont.Text = "Alunos: 0 de 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 290);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.ltbAlunos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btnSalvarMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbAlunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Button btnSalvarMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCont;
    }
}

