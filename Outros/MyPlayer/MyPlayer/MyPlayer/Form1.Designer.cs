namespace MyPlayer
{
    partial class frmMyPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyPlayer));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.CmbMidias = new System.Windows.Forms.ComboBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnSalvaSelect = new System.Windows.Forms.Button();
            this.TxbDados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 59);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(418, 237);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(118, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 20);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // CmbMidias
            // 
            this.CmbMidias.FormattingEnabled = true;
            this.CmbMidias.Location = new System.Drawing.Point(12, 32);
            this.CmbMidias.Name = "CmbMidias";
            this.CmbMidias.Size = new System.Drawing.Size(418, 21);
            this.CmbMidias.TabIndex = 12;
            this.CmbMidias.Text = "Select File To Play";
            this.CmbMidias.SelectedIndexChanged += new System.EventHandler(this.CmbMusicas_SelectedIndexChanged);
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(12, 6);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(100, 20);
            this.BtnUpload.TabIndex = 13;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(330, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 20);
            this.BtnSalvar.TabIndex = 14;
            this.BtnSalvar.Text = "Salvar Todos";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnSalvaSelect
            // 
            this.BtnSalvaSelect.Location = new System.Drawing.Point(224, 6);
            this.BtnSalvaSelect.Name = "BtnSalvaSelect";
            this.BtnSalvaSelect.Size = new System.Drawing.Size(100, 20);
            this.BtnSalvaSelect.TabIndex = 15;
            this.BtnSalvaSelect.Text = "Salvar";
            this.BtnSalvaSelect.UseVisualStyleBackColor = true;
            this.BtnSalvaSelect.Click += new System.EventHandler(this.BtnSalvaSelect_Click);
            // 
            // TxbDados
            // 
            this.TxbDados.Location = new System.Drawing.Point(12, 302);
            this.TxbDados.Name = "TxbDados";
            this.TxbDados.ReadOnly = true;
            this.TxbDados.Size = new System.Drawing.Size(418, 20);
            this.TxbDados.TabIndex = 16;
            // 
            // frmMyPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 334);
            this.Controls.Add(this.TxbDados);
            this.Controls.Add(this.BtnSalvaSelect);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.CmbMidias);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMyPlayer";
            this.Text = "My Player";
            this.MaximumSizeChanged += new System.EventHandler(this.frmMyPlayer_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.frmMyPlayer_MinimumSizeChanged);
            this.Resize += new System.EventHandler(this.frmMyPlayer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox CmbMidias;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnSalvaSelect;
        private System.Windows.Forms.TextBox TxbDados;
    }
}

