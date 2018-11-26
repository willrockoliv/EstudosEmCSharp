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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
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
            this.tbcMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMidia.Controls.Add(this.tbpFoto);
            this.tbcMidia.Controls.Add(this.tbpVideo);
            this.tbcMidia.Controls.Add(this.tbpMusica);
            this.tbcMidia.Location = new System.Drawing.Point(12, 40);
            this.tbcMidia.Name = "tbcMidia";
            this.tbcMidia.SelectedIndex = 0;
            this.tbcMidia.Size = new System.Drawing.Size(898, 716);
            this.tbcMidia.TabIndex = 13;
            // 
            // tbpFoto
            // 
            this.tbpFoto.BackColor = System.Drawing.Color.Honeydew;
            this.tbpFoto.Controls.Add(this.ltbFoto);
            this.tbpFoto.Location = new System.Drawing.Point(4, 22);
            this.tbpFoto.Name = "tbpFoto";
            this.tbpFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFoto.Size = new System.Drawing.Size(890, 690);
            this.tbpFoto.TabIndex = 0;
            this.tbpFoto.Text = "Foto";
            // 
            // ltbFoto
            // 
            this.ltbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbFoto.FormattingEnabled = true;
            this.ltbFoto.Location = new System.Drawing.Point(6, 6);
            this.ltbFoto.Name = "ltbFoto";
            this.ltbFoto.Size = new System.Drawing.Size(878, 680);
            this.ltbFoto.TabIndex = 0;
            this.ltbFoto.Click += new System.EventHandler(this.ltbFoto_Click);
            // 
            // tbpVideo
            // 
            this.tbpVideo.BackColor = System.Drawing.Color.Honeydew;
            this.tbpVideo.Controls.Add(this.ltbVideo);
            this.tbpVideo.Location = new System.Drawing.Point(4, 22);
            this.tbpVideo.Name = "tbpVideo";
            this.tbpVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVideo.Size = new System.Drawing.Size(890, 690);
            this.tbpVideo.TabIndex = 1;
            this.tbpVideo.Text = "Vídeo";
            // 
            // ltbVideo
            // 
            this.ltbVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbVideo.FormattingEnabled = true;
            this.ltbVideo.Location = new System.Drawing.Point(6, 6);
            this.ltbVideo.Name = "ltbVideo";
            this.ltbVideo.Size = new System.Drawing.Size(878, 680);
            this.ltbVideo.TabIndex = 1;
            this.ltbVideo.Click += new System.EventHandler(this.ltbVideo_Click);
            // 
            // tbpMusica
            // 
            this.tbpMusica.BackColor = System.Drawing.Color.Honeydew;
            this.tbpMusica.Controls.Add(this.ltbMusica);
            this.tbpMusica.Location = new System.Drawing.Point(4, 22);
            this.tbpMusica.Name = "tbpMusica";
            this.tbpMusica.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMusica.Size = new System.Drawing.Size(890, 690);
            this.tbpMusica.TabIndex = 2;
            this.tbpMusica.Text = "Música";
            // 
            // ltbMusica
            // 
            this.ltbMusica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltbMusica.FormattingEnabled = true;
            this.ltbMusica.Location = new System.Drawing.Point(6, 6);
            this.ltbMusica.Name = "ltbMusica";
            this.ltbMusica.Size = new System.Drawing.Size(878, 680);
            this.ltbMusica.TabIndex = 1;
            this.ltbMusica.Click += new System.EventHandler(this.ltbMusica_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::MediaPlayer.Properties.Resources.if_cancel_326554;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(916, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 49);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.Image = global::MediaPlayer.Properties.Resources._1499384406_Select;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(916, 71);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(94, 49);
            this.btnAbrir.TabIndex = 15;
            this.btnAbrir.Text = "Abrir       ";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAbrir);
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
        private System.Windows.Forms.ListBox ltbVideo;
        private System.Windows.Forms.ListBox ltbMusica;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAbrir;
    }
}