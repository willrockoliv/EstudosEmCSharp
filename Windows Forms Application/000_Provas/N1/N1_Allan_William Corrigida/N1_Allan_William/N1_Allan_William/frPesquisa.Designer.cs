namespace N1_Allan_William
{
    partial class frPesquisa
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
            this.txtNomePesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(66, 17);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(196, 20);
            this.txtNomePesquisa.TabIndex = 0;
            // 
            // btnPesquisar2
            // 
            this.btnPesquisar2.Location = new System.Drawing.Point(99, 54);
            this.btnPesquisar2.Name = "btnPesquisar2";
            this.btnPesquisar2.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar2.TabIndex = 1;
            this.btnPesquisar2.Text = "Pesquisar";
            this.btnPesquisar2.UseVisualStyleBackColor = true;
            this.btnPesquisar2.Click += new System.EventHandler(this.btnPesquisar2_Click);
            // 
            // frPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.btnPesquisar2);
            this.Controls.Add(this.txtNomePesquisa);
            this.Controls.Add(this.label1);
            this.Name = "frPesquisa";
            this.Text = "Tela de pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNomePesquisa;
        private System.Windows.Forms.Button btnPesquisar2;
    }
}