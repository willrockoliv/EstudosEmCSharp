namespace teste2
{
    partial class FrResultado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrResultado));
            this.btnSair = new System.Windows.Forms.Button();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.TmParaFechar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::teste2.Properties.Resources._1495088327_22;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(63, 137);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair   ";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblVencedor
            // 
            this.lblVencedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedor.ForeColor = System.Drawing.Color.White;
            this.lblVencedor.Location = new System.Drawing.Point(6, 9);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(206, 129);
            this.lblVencedor.TabIndex = 5;
            this.lblVencedor.Text = "O Computador venceu!";
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TmParaFechar
            // 
            this.TmParaFechar.Interval = 2500;
            // 
            // FrResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.super_trunfo_opaco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(219, 185);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(573, 200);
            this.Name = "FrResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.FrResultado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.Timer TmParaFechar;
    }
}