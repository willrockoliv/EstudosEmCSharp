namespace EX_4_Velha
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt11 = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.bt13 = new System.Windows.Forms.Button();
            this.bt21 = new System.Windows.Forms.Button();
            this.bt22 = new System.Windows.Forms.Button();
            this.bt23 = new System.Windows.Forms.Button();
            this.bt31 = new System.Windows.Forms.Button();
            this.bt32 = new System.Windows.Forms.Button();
            this.bt33 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sua vez: X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt11
            // 
            this.bt11.Location = new System.Drawing.Point(33, 52);
            this.bt11.Name = "bt11";
            this.bt11.Size = new System.Drawing.Size(108, 54);
            this.bt11.TabIndex = 1;
            this.bt11.UseVisualStyleBackColor = true;
            this.bt11.Click += new System.EventHandler(this.bt11_Click);
            // 
            // bt12
            // 
            this.bt12.Location = new System.Drawing.Point(157, 52);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(108, 54);
            this.bt12.TabIndex = 1;
            this.bt12.UseVisualStyleBackColor = true;
            this.bt12.Click += new System.EventHandler(this.bt12_Click);
            // 
            // bt13
            // 
            this.bt13.Location = new System.Drawing.Point(285, 52);
            this.bt13.Name = "bt13";
            this.bt13.Size = new System.Drawing.Size(108, 54);
            this.bt13.TabIndex = 1;
            this.bt13.UseVisualStyleBackColor = true;
            this.bt13.Click += new System.EventHandler(this.bt13_Click);
            // 
            // bt21
            // 
            this.bt21.Location = new System.Drawing.Point(33, 112);
            this.bt21.Name = "bt21";
            this.bt21.Size = new System.Drawing.Size(108, 54);
            this.bt21.TabIndex = 1;
            this.bt21.UseVisualStyleBackColor = true;
            this.bt21.Click += new System.EventHandler(this.bt21_Click);
            // 
            // bt22
            // 
            this.bt22.Location = new System.Drawing.Point(157, 112);
            this.bt22.Name = "bt22";
            this.bt22.Size = new System.Drawing.Size(108, 54);
            this.bt22.TabIndex = 1;
            this.bt22.UseVisualStyleBackColor = true;
            this.bt22.Click += new System.EventHandler(this.bt22_Click);
            // 
            // bt23
            // 
            this.bt23.Location = new System.Drawing.Point(285, 112);
            this.bt23.Name = "bt23";
            this.bt23.Size = new System.Drawing.Size(108, 54);
            this.bt23.TabIndex = 1;
            this.bt23.UseVisualStyleBackColor = true;
            this.bt23.Click += new System.EventHandler(this.bt23_Click);
            // 
            // bt31
            // 
            this.bt31.Location = new System.Drawing.Point(33, 172);
            this.bt31.Name = "bt31";
            this.bt31.Size = new System.Drawing.Size(108, 54);
            this.bt31.TabIndex = 1;
            this.bt31.UseVisualStyleBackColor = true;
            this.bt31.Click += new System.EventHandler(this.bt31_Click);
            // 
            // bt32
            // 
            this.bt32.Location = new System.Drawing.Point(157, 172);
            this.bt32.Name = "bt32";
            this.bt32.Size = new System.Drawing.Size(108, 54);
            this.bt32.TabIndex = 1;
            this.bt32.UseVisualStyleBackColor = true;
            this.bt32.Click += new System.EventHandler(this.bt32_Click);
            // 
            // bt33
            // 
            this.bt33.Location = new System.Drawing.Point(285, 172);
            this.bt33.Name = "bt33";
            this.bt33.Size = new System.Drawing.Size(108, 54);
            this.bt33.TabIndex = 1;
            this.bt33.UseVisualStyleBackColor = true;
            this.bt33.Click += new System.EventHandler(this.bt33_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 252);
            this.Controls.Add(this.bt33);
            this.Controls.Add(this.bt32);
            this.Controls.Add(this.bt23);
            this.Controls.Add(this.bt22);
            this.Controls.Add(this.bt31);
            this.Controls.Add(this.bt13);
            this.Controls.Add(this.bt21);
            this.Controls.Add(this.bt12);
            this.Controls.Add(this.bt11);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "JOGO DA VELHA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt11;
        private System.Windows.Forms.Button bt12;
        private System.Windows.Forms.Button bt13;
        private System.Windows.Forms.Button bt21;
        private System.Windows.Forms.Button bt22;
        private System.Windows.Forms.Button bt23;
        private System.Windows.Forms.Button bt31;
        private System.Windows.Forms.Button bt32;
        private System.Windows.Forms.Button bt33;
    }
}

