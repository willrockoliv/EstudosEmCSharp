namespace Jogo_da_velha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptbTabuleiro = new System.Windows.Forms.PictureBox();
            this.rbtXis = new System.Windows.Forms.RadioButton();
            this.rbtBola = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbTabuleiro
            // 
            this.ptbTabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("ptbTabuleiro.Image")));
            this.ptbTabuleiro.Location = new System.Drawing.Point(12, 12);
            this.ptbTabuleiro.Name = "ptbTabuleiro";
            this.ptbTabuleiro.Size = new System.Drawing.Size(510, 510);
            this.ptbTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTabuleiro.TabIndex = 0;
            this.ptbTabuleiro.TabStop = false;
            // 
            // rbtXis
            // 
            this.rbtXis.AutoSize = true;
            this.rbtXis.BackColor = System.Drawing.SystemColors.Control;
            this.rbtXis.Checked = true;
            this.rbtXis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtXis.Location = new System.Drawing.Point(538, 66);
            this.rbtXis.Name = "rbtXis";
            this.rbtXis.Size = new System.Drawing.Size(126, 29);
            this.rbtXis.TabIndex = 10;
            this.rbtXis.TabStop = true;
            this.rbtXis.Text = "Jogador 1";
            this.rbtXis.UseVisualStyleBackColor = false;
            // 
            // rbtBola
            // 
            this.rbtBola.AutoSize = true;
            this.rbtBola.BackColor = System.Drawing.SystemColors.Control;
            this.rbtBola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBola.Location = new System.Drawing.Point(538, 101);
            this.rbtBola.Name = "rbtBola";
            this.rbtBola.Size = new System.Drawing.Size(126, 29);
            this.rbtBola.TabIndex = 11;
            this.rbtBola.Text = "Jogador 2";
            this.rbtBola.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Location = new System.Drawing.Point(12, 66);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(147, 124);
            this.btn1.TabIndex = 12;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Location = new System.Drawing.Point(187, 66);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(147, 124);
            this.btn2.TabIndex = 13;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Window;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Location = new System.Drawing.Point(359, 66);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(147, 124);
            this.btn3.TabIndex = 14;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Location = new System.Drawing.Point(12, 217);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(147, 124);
            this.btn4.TabIndex = 15;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Location = new System.Drawing.Point(187, 217);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(147, 124);
            this.btn5.TabIndex = 16;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Location = new System.Drawing.Point(359, 217);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(147, 124);
            this.btn6.TabIndex = 17;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Location = new System.Drawing.Point(12, 365);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(147, 124);
            this.btn7.TabIndex = 18;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Location = new System.Drawing.Point(187, 365);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(147, 124);
            this.btn8.TabIndex = 19;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Location = new System.Drawing.Point(359, 365);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(147, 124);
            this.btn9.TabIndex = 20;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseMove);
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 534);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rbtBola);
            this.Controls.Add(this.rbtXis);
            this.Controls.Add(this.ptbTabuleiro);
            this.Name = "Form1";
            this.Text = "Jogo da velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTabuleiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTabuleiro;
        private System.Windows.Forms.RadioButton rbtXis;
        private System.Windows.Forms.RadioButton rbtBola;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
    }
}

