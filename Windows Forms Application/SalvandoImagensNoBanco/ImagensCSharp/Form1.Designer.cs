namespace ImagensCSharp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarregarIMG = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregaImg = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarregarIMG
            // 
            this.btnCarregarIMG.Location = new System.Drawing.Point(36, 12);
            this.btnCarregarIMG.Name = "btnCarregarIMG";
            this.btnCarregarIMG.Size = new System.Drawing.Size(220, 43);
            this.btnCarregarIMG.TabIndex = 1;
            this.btnCarregarIMG.Text = "Carregar Imagem do arquivo";
            this.btnCarregarIMG.UseVisualStyleBackColor = true;
            this.btnCarregarIMG.Click += new System.EventHandler(this.btnCarregarIMG_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(36, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 43);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar Imagem no BD";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregaImg
            // 
            this.btnCarregaImg.Location = new System.Drawing.Point(159, 312);
            this.btnCarregaImg.Name = "btnCarregaImg";
            this.btnCarregaImg.Size = new System.Drawing.Size(111, 43);
            this.btnCarregaImg.TabIndex = 3;
            this.btnCarregaImg.Text = "Carregar Imagem do BD";
            this.btnCarregaImg.UseVisualStyleBackColor = true;
            this.btnCarregaImg.Click += new System.EventHandler(this.btnCarregaImg_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(145, 279);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(43, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(104, 282);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 367);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCarregaImg);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarregarIMG);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Salvar/Carregar imagem do BD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarregarIMG;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregaImg;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label lblid;
    }
}

