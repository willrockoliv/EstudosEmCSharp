namespace teste2
{
    partial class frManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frManual));
            this.lblManual = new System.Windows.Forms.Label();
            this.btnSairManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblManual
            // 
            this.lblManual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblManual.BackColor = System.Drawing.Color.Transparent;
            this.lblManual.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.Color.Transparent;
            this.lblManual.Location = new System.Drawing.Point(39, 35);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(837, 496);
            this.lblManual.TabIndex = 0;
            this.lblManual.Text = resources.GetString("lblManual.Text");
            // 
            // btnSairManual
            // 
            this.btnSairManual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSairManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairManual.ForeColor = System.Drawing.Color.Black;
            this.btnSairManual.Image = global::teste2.Properties.Resources._1495088327_22;
            this.btnSairManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairManual.Location = new System.Drawing.Point(403, 542);
            this.btnSairManual.Name = "btnSairManual";
            this.btnSairManual.Size = new System.Drawing.Size(105, 55);
            this.btnSairManual.TabIndex = 1;
            this.btnSairManual.Text = "Sair   ";
            this.btnSairManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairManual.UseVisualStyleBackColor = true;
            this.btnSairManual.Click += new System.EventHandler(this.btnSairManual_Click);
            // 
            // frManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.super_trunfo_opaco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnSairManual);
            this.Controls.Add(this.lblManual);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Button btnSairManual;
    }
}