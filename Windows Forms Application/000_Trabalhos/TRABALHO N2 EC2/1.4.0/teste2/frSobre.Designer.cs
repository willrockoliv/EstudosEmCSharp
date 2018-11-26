namespace teste2
{
    partial class frSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSobre));
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCriacaoData = new System.Windows.Forms.Label();
            this.btnSairSobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(391, 446);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(158, 29);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão 1.3.7";
            this.lblVersao.Click += new System.EventHandler(this.lblVersao_Click);
            // 
            // lblCriacaoData
            // 
            this.lblCriacaoData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCriacaoData.AutoSize = true;
            this.lblCriacaoData.BackColor = System.Drawing.Color.Transparent;
            this.lblCriacaoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriacaoData.ForeColor = System.Drawing.Color.White;
            this.lblCriacaoData.Location = new System.Drawing.Point(339, 407);
            this.lblCriacaoData.Name = "lblCriacaoData";
            this.lblCriacaoData.Size = new System.Drawing.Size(269, 29);
            this.lblCriacaoData.TabIndex = 1;
            this.lblCriacaoData.Text = "Criado em 14/05/2017";
            // 
            // btnSairSobre
            // 
            this.btnSairSobre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSairSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairSobre.ForeColor = System.Drawing.Color.Black;
            this.btnSairSobre.Image = global::teste2.Properties.Resources._1495088327_22;
            this.btnSairSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairSobre.Location = new System.Drawing.Point(427, 542);
            this.btnSairSobre.Name = "btnSairSobre";
            this.btnSairSobre.Size = new System.Drawing.Size(105, 55);
            this.btnSairSobre.TabIndex = 1;
            this.btnSairSobre.Text = "Sair   ";
            this.btnSairSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairSobre.UseVisualStyleBackColor = true;
            this.btnSairSobre.Click += new System.EventHandler(this.btnSairSobre_Click);
            // 
            // frSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.SUPER_TRUNFO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnSairSobre);
            this.Controls.Add(this.lblCriacaoData);
            this.Controls.Add(this.lblVersao);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblCriacaoData;
        private System.Windows.Forms.Button btnSairSobre;
    }
}