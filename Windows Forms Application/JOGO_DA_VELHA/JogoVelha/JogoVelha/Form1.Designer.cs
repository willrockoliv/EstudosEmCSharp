namespace JogoVelha
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
            this.lblVez = new System.Windows.Forms.Label();
            this.bnt11 = new System.Windows.Forms.Button();
            this.bnt12 = new System.Windows.Forms.Button();
            this.bnt13 = new System.Windows.Forms.Button();
            this.bnt23 = new System.Windows.Forms.Button();
            this.bnt22 = new System.Windows.Forms.Button();
            this.bnt21 = new System.Windows.Forms.Button();
            this.bnt33 = new System.Windows.Forms.Button();
            this.bnt32 = new System.Windows.Forms.Button();
            this.bnt31 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVez
            // 
            this.lblVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.Location = new System.Drawing.Point(12, 9);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(225, 23);
            this.lblVez.TabIndex = 0;
            this.lblVez.Text = "É a vez do X";
            // 
            // bnt11
            // 
            this.bnt11.Location = new System.Drawing.Point(12, 42);
            this.bnt11.Name = "bnt11";
            this.bnt11.Size = new System.Drawing.Size(71, 42);
            this.bnt11.TabIndex = 1;
            this.bnt11.Text = "button1";
            this.bnt11.UseVisualStyleBackColor = true;
            this.bnt11.Click += new System.EventHandler(this.bnt11_Click);
            // 
            // bnt12
            // 
            this.bnt12.Location = new System.Drawing.Point(89, 42);
            this.bnt12.Name = "bnt12";
            this.bnt12.Size = new System.Drawing.Size(71, 42);
            this.bnt12.TabIndex = 2;
            this.bnt12.Text = "button2";
            this.bnt12.UseVisualStyleBackColor = true;
            this.bnt12.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt13
            // 
            this.bnt13.Location = new System.Drawing.Point(166, 42);
            this.bnt13.Name = "bnt13";
            this.bnt13.Size = new System.Drawing.Size(71, 42);
            this.bnt13.TabIndex = 3;
            this.bnt13.Text = "button3";
            this.bnt13.UseVisualStyleBackColor = true;
            this.bnt13.Click += new System.EventHandler(this.bnt13_Click);
            // 
            // bnt23
            // 
            this.bnt23.Location = new System.Drawing.Point(166, 90);
            this.bnt23.Name = "bnt23";
            this.bnt23.Size = new System.Drawing.Size(71, 42);
            this.bnt23.TabIndex = 6;
            this.bnt23.Text = "button4";
            this.bnt23.UseVisualStyleBackColor = true;
            this.bnt23.Click += new System.EventHandler(this.bnt23_Click);
            // 
            // bnt22
            // 
            this.bnt22.Location = new System.Drawing.Point(89, 90);
            this.bnt22.Name = "bnt22";
            this.bnt22.Size = new System.Drawing.Size(71, 42);
            this.bnt22.TabIndex = 5;
            this.bnt22.Text = "button5";
            this.bnt22.UseVisualStyleBackColor = true;
            this.bnt22.Click += new System.EventHandler(this.bnt22_Click);
            // 
            // bnt21
            // 
            this.bnt21.Location = new System.Drawing.Point(12, 90);
            this.bnt21.Name = "bnt21";
            this.bnt21.Size = new System.Drawing.Size(71, 42);
            this.bnt21.TabIndex = 4;
            this.bnt21.Text = "button6";
            this.bnt21.UseVisualStyleBackColor = true;
            this.bnt21.Click += new System.EventHandler(this.bnt21_Click);
            // 
            // bnt33
            // 
            this.bnt33.Location = new System.Drawing.Point(166, 138);
            this.bnt33.Name = "bnt33";
            this.bnt33.Size = new System.Drawing.Size(71, 42);
            this.bnt33.TabIndex = 9;
            this.bnt33.Text = "button7";
            this.bnt33.UseVisualStyleBackColor = true;
            this.bnt33.Click += new System.EventHandler(this.bnt33_Click);
            // 
            // bnt32
            // 
            this.bnt32.Location = new System.Drawing.Point(89, 138);
            this.bnt32.Name = "bnt32";
            this.bnt32.Size = new System.Drawing.Size(71, 42);
            this.bnt32.TabIndex = 8;
            this.bnt32.Text = "button8";
            this.bnt32.UseVisualStyleBackColor = true;
            this.bnt32.Click += new System.EventHandler(this.bnt32_Click);
            // 
            // bnt31
            // 
            this.bnt31.Location = new System.Drawing.Point(12, 138);
            this.bnt31.Name = "bnt31";
            this.bnt31.Size = new System.Drawing.Size(71, 42);
            this.bnt31.TabIndex = 7;
            this.bnt31.Text = "button9";
            this.bnt31.UseVisualStyleBackColor = true;
            this.bnt31.Click += new System.EventHandler(this.bnt31_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 208);
            this.Controls.Add(this.bnt33);
            this.Controls.Add(this.bnt32);
            this.Controls.Add(this.bnt31);
            this.Controls.Add(this.bnt23);
            this.Controls.Add(this.bnt22);
            this.Controls.Add(this.bnt21);
            this.Controls.Add(this.bnt13);
            this.Controls.Add(this.bnt12);
            this.Controls.Add(this.bnt11);
            this.Controls.Add(this.lblVez);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Button bnt11;
        private System.Windows.Forms.Button bnt12;
        private System.Windows.Forms.Button bnt13;
        private System.Windows.Forms.Button bnt23;
        private System.Windows.Forms.Button bnt22;
        private System.Windows.Forms.Button bnt21;
        private System.Windows.Forms.Button bnt33;
        private System.Windows.Forms.Button bnt32;
        private System.Windows.Forms.Button bnt31;
    }
}

