namespace teste2
{
    partial class frConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfiguracao));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSom = new System.Windows.Forms.GroupBox();
            this.rbsomdesligado = new System.Windows.Forms.RadioButton();
            this.rbsomligado = new System.Windows.Forms.RadioButton();
            this.gbDificuldade = new System.Windows.Forms.GroupBox();
            this.rbdificil = new System.Windows.Forms.RadioButton();
            this.rbmedio = new System.Windows.Forms.RadioButton();
            this.rbfacil = new System.Windows.Forms.RadioButton();
            this.btnSairSobre = new System.Windows.Forms.Button();
            this.gbSom.SuspendLayout();
            this.gbDificuldade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // gbSom
            // 
            this.gbSom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbSom.BackColor = System.Drawing.Color.Transparent;
            this.gbSom.Controls.Add(this.rbsomdesligado);
            this.gbSom.Controls.Add(this.rbsomligado);
            this.gbSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSom.ForeColor = System.Drawing.Color.White;
            this.gbSom.Location = new System.Drawing.Point(158, 79);
            this.gbSom.Name = "gbSom";
            this.gbSom.Size = new System.Drawing.Size(236, 156);
            this.gbSom.TabIndex = 1;
            this.gbSom.TabStop = false;
            this.gbSom.Text = "Som";
            // 
            // rbsomdesligado
            // 
            this.rbsomdesligado.AutoSize = true;
            this.rbsomdesligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsomdesligado.Location = new System.Drawing.Point(64, 85);
            this.rbsomdesligado.Name = "rbsomdesligado";
            this.rbsomdesligado.Size = new System.Drawing.Size(126, 29);
            this.rbsomdesligado.TabIndex = 1;
            this.rbsomdesligado.Text = "Desligado";
            this.rbsomdesligado.UseVisualStyleBackColor = true;
            this.rbsomdesligado.CheckedChanged += new System.EventHandler(this.rbsomdesligado_CheckedChanged);
            // 
            // rbsomligado
            // 
            this.rbsomligado.AutoSize = true;
            this.rbsomligado.Checked = true;
            this.rbsomligado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsomligado.Location = new System.Drawing.Point(64, 50);
            this.rbsomligado.Name = "rbsomligado";
            this.rbsomligado.Size = new System.Drawing.Size(95, 29);
            this.rbsomligado.TabIndex = 0;
            this.rbsomligado.TabStop = true;
            this.rbsomligado.Text = "Ligado";
            this.rbsomligado.UseVisualStyleBackColor = true;
            this.rbsomligado.CheckedChanged += new System.EventHandler(this.rbsomligado_CheckedChanged);
            // 
            // gbDificuldade
            // 
            this.gbDificuldade.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbDificuldade.BackColor = System.Drawing.Color.Transparent;
            this.gbDificuldade.Controls.Add(this.rbdificil);
            this.gbDificuldade.Controls.Add(this.rbmedio);
            this.gbDificuldade.Controls.Add(this.rbfacil);
            this.gbDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDificuldade.ForeColor = System.Drawing.Color.White;
            this.gbDificuldade.Location = new System.Drawing.Point(500, 79);
            this.gbDificuldade.Name = "gbDificuldade";
            this.gbDificuldade.Size = new System.Drawing.Size(236, 156);
            this.gbDificuldade.TabIndex = 2;
            this.gbDificuldade.TabStop = false;
            this.gbDificuldade.Text = "Dificuldade";
            // 
            // rbdificil
            // 
            this.rbdificil.AutoSize = true;
            this.rbdificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdificil.Location = new System.Drawing.Point(69, 104);
            this.rbdificil.Name = "rbdificil";
            this.rbdificil.Size = new System.Drawing.Size(82, 29);
            this.rbdificil.TabIndex = 3;
            this.rbdificil.Text = "Dificil";
            this.rbdificil.UseVisualStyleBackColor = true;
            this.rbdificil.CheckedChanged += new System.EventHandler(this.rbdificil_CheckedChanged);
            // 
            // rbmedio
            // 
            this.rbmedio.AutoSize = true;
            this.rbmedio.Checked = true;
            this.rbmedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmedio.Location = new System.Drawing.Point(69, 74);
            this.rbmedio.Name = "rbmedio";
            this.rbmedio.Size = new System.Drawing.Size(89, 29);
            this.rbmedio.TabIndex = 2;
            this.rbmedio.TabStop = true;
            this.rbmedio.Text = "Médio";
            this.rbmedio.UseVisualStyleBackColor = true;
            this.rbmedio.CheckedChanged += new System.EventHandler(this.rbmedio_CheckedChanged);
            // 
            // rbfacil
            // 
            this.rbfacil.AutoSize = true;
            this.rbfacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfacil.Location = new System.Drawing.Point(69, 39);
            this.rbfacil.Name = "rbfacil";
            this.rbfacil.Size = new System.Drawing.Size(76, 29);
            this.rbfacil.TabIndex = 1;
            this.rbfacil.Text = "Fácil";
            this.rbfacil.UseVisualStyleBackColor = true;
            this.rbfacil.CheckedChanged += new System.EventHandler(this.rbfacil_CheckedChanged);
            // 
            // btnSairSobre
            // 
            this.btnSairSobre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSairSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairSobre.ForeColor = System.Drawing.Color.Black;
            this.btnSairSobre.Image = global::teste2.Properties.Resources._1495088327_22;
            this.btnSairSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairSobre.Location = new System.Drawing.Point(397, 416);
            this.btnSairSobre.Name = "btnSairSobre";
            this.btnSairSobre.Size = new System.Drawing.Size(105, 55);
            this.btnSairSobre.TabIndex = 5;
            this.btnSairSobre.Text = "Sair   ";
            this.btnSairSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSairSobre.UseVisualStyleBackColor = true;
            this.btnSairSobre.Click += new System.EventHandler(this.btnSairSobre_Click);
            // 
            // frConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.SUPER_TRUNFO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnSairSobre);
            this.Controls.Add(this.gbDificuldade);
            this.Controls.Add(this.gbSom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frConfiguracao_Load);
            this.gbSom.ResumeLayout(false);
            this.gbSom.PerformLayout();
            this.gbDificuldade.ResumeLayout(false);
            this.gbDificuldade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSom;
        private System.Windows.Forms.GroupBox gbDificuldade;
        private System.Windows.Forms.Button btnSairSobre;
        private System.Windows.Forms.RadioButton rbsomdesligado;
        private System.Windows.Forms.RadioButton rbsomligado;
        private System.Windows.Forms.RadioButton rbdificil;
        private System.Windows.Forms.RadioButton rbmedio;
        private System.Windows.Forms.RadioButton rbfacil;
    }
}