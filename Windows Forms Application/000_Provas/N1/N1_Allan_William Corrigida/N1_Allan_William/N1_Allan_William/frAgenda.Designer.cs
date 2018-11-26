namespace N1_Allan_William
{
    partial class frAgenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelCad = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCad = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // txtTelCad
            // 
            this.txtTelCad.Location = new System.Drawing.Point(66, 48);
            this.txtTelCad.Mask = "9999-9999";
            this.txtTelCad.Name = "txtTelCad";
            this.txtTelCad.Size = new System.Drawing.Size(179, 20);
            this.txtTelCad.TabIndex = 1;
            // 
            // txtNomeCad
            // 
            this.txtNomeCad.Location = new System.Drawing.Point(62, 16);
            this.txtNomeCad.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(183, 20);
            this.txtNomeCad.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(104, 89);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeCad);
            this.Controls.Add(this.txtTelCad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frAgenda";
            this.Text = "Tela de Cadastro ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelCad;
        private System.Windows.Forms.MaskedTextBox txtNomeCad;
        private System.Windows.Forms.Button btnSalvar;
    }
}