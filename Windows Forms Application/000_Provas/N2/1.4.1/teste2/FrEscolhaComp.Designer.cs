namespace teste2
{
    partial class FrEscolhaComp
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
            this.lblVencedor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblVencedor
            // 
            this.lblVencedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedor.ForeColor = System.Drawing.Color.White;
            this.lblVencedor.Location = new System.Drawing.Point(5, 9);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(243, 190);
            this.lblVencedor.TabIndex = 6;
            this.lblVencedor.Text = "O Computador venceu!";
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrEscolhaComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.super_trunfo_opaco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(252, 208);
            this.Controls.Add(this.lblVencedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(573, 200);
            this.Name = "FrEscolhaComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha";
            this.Load += new System.EventHandler(this.FrEscolhaComp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.Timer timer1;
    }
}