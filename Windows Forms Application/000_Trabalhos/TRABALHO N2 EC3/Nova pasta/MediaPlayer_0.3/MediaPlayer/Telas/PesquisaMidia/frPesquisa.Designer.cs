namespace MediaPlayer.Telas
{
    partial class frPesquisa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMinimizar = new System.Windows.Forms.Panel();
            this.panMaximixar = new System.Windows.Forms.Panel();
            this.panFechar = new System.Windows.Forms.Panel();
            this.tbcMidia = new System.Windows.Forms.TabControl();
            this.tbpFoto = new System.Windows.Forms.TabPage();
            this.ltbFoto = new System.Windows.Forms.ListBox();
            this.tbpVideo = new System.Windows.Forms.TabPage();
            this.ltbVideo = new System.Windows.Forms.ListBox();
            this.tbpMusica = new System.Windows.Forms.TabPage();
            this.ltbMusica = new System.Windows.Forms.ListBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbAaZ = new System.Windows.Forms.RadioButton();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbcMidia.SuspendLayout();
            this.tbpFoto.SuspendLayout();
            this.tbpVideo.SuspendLayout();
            this.tbpMusica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panMinimizar);
            this.panel1.Controls.Add(this.panMaximixar);
            this.panel1.Controls.Add(this.panFechar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 33);
            this.panel1.TabIndex = 12;
            // 
            // panMinimizar
            // 
            this.panMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panMinimizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panMinimizar.BackgroundImage = global::MediaPlayer.Properties.Resources.if_minimize_82798;
            this.panMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMinimizar.Location = new System.Drawing.Point(913, 0);
            this.panMinimizar.Name = "panMinimizar";
            this.panMinimizar.Size = new System.Drawing.Size(37, 31);
            this.panMinimizar.TabIndex = 14;
            this.panMinimizar.Click += new System.EventHandler(this.panMinimizar_Click);
            this.panMinimizar.MouseLeave += new System.EventHandler(this.panMinimizar_MouseLeave);
            this.panMinimizar.MouseHover += new System.EventHandler(this.panMinimizar_MouseHover);
            // 
            // panMaximixar
            // 
            this.panMaximixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panMaximixar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panMaximixar.BackgroundImage = global::MediaPlayer.Properties.Resources.if_maximize_82791;
            this.panMaximixar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMaximixar.Location = new System.Drawing.Point(950, 0);
            this.panMaximixar.Name = "panMaximixar";
            this.panMaximixar.Size = new System.Drawing.Size(37, 31);
            this.panMaximixar.TabIndex = 13;
            this.panMaximixar.Click += new System.EventHandler(this.panMaximixar_Click);
            this.panMaximixar.MouseLeave += new System.EventHandler(this.panMaximixar_MouseLeave);
            this.panMaximixar.MouseHover += new System.EventHandler(this.panMaximixar_MouseHover);
            // 
            // panFechar
            // 
            this.panFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panFechar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panFechar.BackgroundImage = global::MediaPlayer.Properties.Resources.if_close_82555;
            this.panFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panFechar.Location = new System.Drawing.Point(986, 0);
            this.panFechar.Name = "panFechar";
            this.panFechar.Size = new System.Drawing.Size(37, 31);
            this.panFechar.TabIndex = 12;
            this.panFechar.Click += new System.EventHandler(this.panFechar_Click);
            this.panFechar.MouseLeave += new System.EventHandler(this.panFechar_MouseLeave);
            this.panFechar.MouseHover += new System.EventHandler(this.panFechar_MouseHover);
            // 
            // tbcMidia
            // 
            this.tbcMidia.Controls.Add(this.tbpFoto);
            this.tbcMidia.Controls.Add(this.tbpVideo);
            this.tbcMidia.Controls.Add(this.tbpMusica);
            this.tbcMidia.Location = new System.Drawing.Point(52, 49);
            this.tbcMidia.Name = "tbcMidia";
            this.tbcMidia.SelectedIndex = 0;
            this.tbcMidia.Size = new System.Drawing.Size(944, 407);
            this.tbcMidia.TabIndex = 13;
            // 
            // tbpFoto
            // 
            this.tbpFoto.BackColor = System.Drawing.Color.Honeydew;
            this.tbpFoto.Controls.Add(this.ltbFoto);
            this.tbpFoto.Location = new System.Drawing.Point(4, 22);
            this.tbpFoto.Name = "tbpFoto";
            this.tbpFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFoto.Size = new System.Drawing.Size(936, 381);
            this.tbpFoto.TabIndex = 0;
            this.tbpFoto.Text = "Foto";
            // 
            // ltbFoto
            // 
            this.ltbFoto.FormattingEnabled = true;
            this.ltbFoto.Location = new System.Drawing.Point(6, 6);
            this.ltbFoto.Name = "ltbFoto";
            this.ltbFoto.Size = new System.Drawing.Size(924, 368);
            this.ltbFoto.TabIndex = 0;
            // 
            // tbpVideo
            // 
            this.tbpVideo.BackColor = System.Drawing.Color.Honeydew;
            this.tbpVideo.Controls.Add(this.ltbVideo);
            this.tbpVideo.Location = new System.Drawing.Point(4, 22);
            this.tbpVideo.Name = "tbpVideo";
            this.tbpVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVideo.Size = new System.Drawing.Size(936, 381);
            this.tbpVideo.TabIndex = 1;
            this.tbpVideo.Text = "Vídeo";
            // 
            // ltbVideo
            // 
            this.ltbVideo.FormattingEnabled = true;
            this.ltbVideo.Location = new System.Drawing.Point(6, 6);
            this.ltbVideo.Name = "ltbVideo";
            this.ltbVideo.Size = new System.Drawing.Size(924, 368);
            this.ltbVideo.TabIndex = 1;
            // 
            // tbpMusica
            // 
            this.tbpMusica.BackColor = System.Drawing.Color.Honeydew;
            this.tbpMusica.Controls.Add(this.ltbMusica);
            this.tbpMusica.Location = new System.Drawing.Point(4, 22);
            this.tbpMusica.Name = "tbpMusica";
            this.tbpMusica.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMusica.Size = new System.Drawing.Size(936, 381);
            this.tbpMusica.TabIndex = 2;
            this.tbpMusica.Text = "Música";
            // 
            // ltbMusica
            // 
            this.ltbMusica.FormattingEnabled = true;
            this.ltbMusica.Location = new System.Drawing.Point(6, 6);
            this.ltbMusica.Name = "ltbMusica";
            this.ltbMusica.Size = new System.Drawing.Size(924, 368);
            this.ltbMusica.TabIndex = 1;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::MediaPlayer.Properties.Resources.if_basics_09_296825__2_;
            this.btnPesquisa.Location = new System.Drawing.Point(12, 71);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 28);
            this.btnPesquisa.TabIndex = 11;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdbID.Location = new System.Drawing.Point(14, 103);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(22, 30);
            this.rdbID.TabIndex = 1;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            // 
            // rdbAaZ
            // 
            this.rdbAaZ.AutoSize = true;
            this.rdbAaZ.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdbAaZ.Location = new System.Drawing.Point(7, 133);
            this.rdbAaZ.Name = "rdbAaZ";
            this.rdbAaZ.Size = new System.Drawing.Size(37, 30);
            this.rdbAaZ.TabIndex = 14;
            this.rdbAaZ.TabStop = true;
            this.rdbAaZ.Text = "A a Z";
            this.rdbAaZ.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(413, 462);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(196, 47);
            this.BtnSair.TabIndex = 18;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.rdbAaZ);
            this.Controls.Add(this.rdbID);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.tbcMidia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frPesquisa";
            this.Load += new System.EventHandler(this.frPesquisa_Load);
            this.panel1.ResumeLayout(false);
            this.tbcMidia.ResumeLayout(false);
            this.tbpFoto.ResumeLayout(false);
            this.tbpVideo.ResumeLayout(false);
            this.tbpMusica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panMinimizar;
        private System.Windows.Forms.Panel panMaximixar;
        private System.Windows.Forms.Panel panFechar;
        private System.Windows.Forms.TabControl tbcMidia;
        private System.Windows.Forms.TabPage tbpFoto;
        private System.Windows.Forms.ListBox ltbFoto;
        private System.Windows.Forms.TabPage tbpVideo;
        private System.Windows.Forms.TabPage tbpMusica;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.RadioButton rdbAaZ;
        private System.Windows.Forms.ListBox ltbVideo;
        private System.Windows.Forms.ListBox ltbMusica;
        private System.Windows.Forms.Button BtnSair;
    }
}