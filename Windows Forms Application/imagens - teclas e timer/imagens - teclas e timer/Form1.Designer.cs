﻿namespace imagens___teclas_e_timer
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlien = new System.Windows.Forms.Button();
            this.btnSerHumano = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::imagens___teclas_e_timer.Properties.Resources.alien_03;
            this.pictureBox1.Location = new System.Drawing.Point(395, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlien
            // 
            this.btnAlien.Image = global::imagens___teclas_e_timer.Properties.Resources._1439872078_sign_error;
            this.btnAlien.Location = new System.Drawing.Point(31, 110);
            this.btnAlien.Name = "btnAlien";
            this.btnAlien.Size = new System.Drawing.Size(145, 41);
            this.btnAlien.TabIndex = 1;
            this.btnAlien.Text = "Sou um alien abestado!";
            this.btnAlien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlien.UseVisualStyleBackColor = true;
            this.btnAlien.Click += new System.EventHandler(this.btnAlien_Click);
            // 
            // btnSerHumano
            // 
            this.btnSerHumano.Image = global::imagens___teclas_e_timer.Properties.Resources._1439871908_floppy;
            this.btnSerHumano.Location = new System.Drawing.Point(31, 63);
            this.btnSerHumano.Name = "btnSerHumano";
            this.btnSerHumano.Size = new System.Drawing.Size(250, 41);
            this.btnSerHumano.TabIndex = 0;
            this.btnSerHumano.Text = "Sou um ser humano lindo e maravilhoso";
            this.btnSerHumano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSerHumano.UseVisualStyleBackColor = true;
            this.btnSerHumano.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSerHumano_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSerHumano);
            this.Controls.Add(this.btnAlien);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerHumano;
        private System.Windows.Forms.Button btnAlien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

