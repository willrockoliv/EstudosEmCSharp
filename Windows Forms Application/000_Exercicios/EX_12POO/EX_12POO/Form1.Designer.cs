namespace EX_12POO
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEc = new System.Windows.Forms.TextBox();
            this.txtDtan = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(127, 38);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 1;
            // 
            // txtEc
            // 
            this.txtEc.Location = new System.Drawing.Point(127, 64);
            this.txtEc.Name = "txtEc";
            this.txtEc.Size = new System.Drawing.Size(100, 20);
            this.txtEc.TabIndex = 2;
            // 
            // txtDtan
            // 
            this.txtDtan.Location = new System.Drawing.Point(127, 91);
            this.txtDtan.Mask = "00/00/0000";
            this.txtDtan.Name = "txtDtan";
            this.txtDtan.Size = new System.Drawing.Size(100, 20);
            this.txtDtan.TabIndex = 3;
            this.txtDtan.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de nascimento";
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(83, 124);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(75, 23);
            this.btnVal.TabIndex = 8;
            this.btnVal.Text = "validar";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 159);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDtan);
            this.Controls.Add(this.txtEc);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "EX12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEc;
        private System.Windows.Forms.MaskedTextBox txtDtan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVal;
    }
}

