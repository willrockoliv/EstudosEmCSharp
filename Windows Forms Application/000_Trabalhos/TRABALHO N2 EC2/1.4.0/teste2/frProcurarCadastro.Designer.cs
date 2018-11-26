namespace teste2
{
    partial class frProcurarCadastro
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = global::teste2.Properties.Resources._1495088193_new_24;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(417, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 38);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::teste2.Properties.Resources._1495088327_22;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(421, 124);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 38);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(12, 16);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(399, 147);
            this.lstCartas.TabIndex = 1;
            // 
            // frProcurarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.SUPER_TRUNFO;
            this.ClientSize = new System.Drawing.Size(511, 182);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbrir);
            this.Name = "frProcurarCadastro";
            this.Text = "frProcurarCadastro";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lstCartas;
    }
}