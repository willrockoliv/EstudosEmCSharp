namespace teste2
{
    partial class FrInsereRecorde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrInsereRecorde));
            this.txbNomeJog = new System.Windows.Forms.TextBox();
            this.txbPontosFinal = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblMsgPontos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNomeJog
            // 
            this.txbNomeJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeJog.Location = new System.Drawing.Point(206, 150);
            this.txbNomeJog.Name = "txbNomeJog";
            this.txbNomeJog.Size = new System.Drawing.Size(179, 35);
            this.txbNomeJog.TabIndex = 0;
            // 
            // txbPontosFinal
            // 
            this.txbPontosFinal.Enabled = false;
            this.txbPontosFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPontosFinal.Location = new System.Drawing.Point(261, 62);
            this.txbPontosFinal.Name = "txbPontosFinal";
            this.txbPontosFinal.ReadOnly = true;
            this.txbPontosFinal.Size = new System.Drawing.Size(80, 35);
            this.txbPontosFinal.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Image = global::teste2.Properties.Resources._1495087867_floppy_disk_save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(157, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 44);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblMsgPontos
            // 
            this.lblMsgPontos.AutoSize = true;
            this.lblMsgPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPontos.ForeColor = System.Drawing.Color.White;
            this.lblMsgPontos.Location = new System.Drawing.Point(21, 65);
            this.lblMsgPontos.Name = "lblMsgPontos";
            this.lblMsgPontos.Size = new System.Drawing.Size(222, 29);
            this.lblMsgPontos.TabIndex = 4;
            this.lblMsgPontos.Text = "Sua Pontuação Foi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insira Seu Nome.";
            // 
            // FrInsereRecorde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.super_trunfo_opaco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsgPontos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbPontosFinal);
            this.Controls.Add(this.txbNomeJog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(480, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrInsereRecorde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insira seu Nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNomeJog;
        private System.Windows.Forms.TextBox txbPontosFinal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblMsgPontos;
        private System.Windows.Forms.Label label1;
    }
}