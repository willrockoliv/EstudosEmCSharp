namespace MediaPlayer
{
    partial class frPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            this.PrePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.BtnPlayFila = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnPlayPilha = new System.Windows.Forms.Button();
            this.BtnPlayLista = new System.Windows.Forms.Button();
            this.LbPlaylistExibição = new System.Windows.Forms.ListBox();
            this.CbPlaylistPrincipal = new System.Windows.Forms.ComboBox();
            this.LblPlaylistsPrincipal = new System.Windows.Forms.Label();
            this.BtnAleatorio = new System.Windows.Forms.Button();
            this.CkbAleatorioOn = new System.Windows.Forms.CheckBox();
            this.CkbAleatorioOff = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrePlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrePlayer
            // 
            this.PrePlayer.Enabled = true;
            this.PrePlayer.Location = new System.Drawing.Point(235, 27);
            this.PrePlayer.Name = "PrePlayer";
            this.PrePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PrePlayer.OcxState")));
            this.PrePlayer.Size = new System.Drawing.Size(573, 406);
            this.PrePlayer.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.playlistsToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.versãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            this.playlistsToolStripMenuItem.Click += new System.EventHandler(this.playlistsToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.versãoToolStripMenuItem.Text = "Versão";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "1.0.4";
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Location = new System.Drawing.Point(12, 84);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(75, 23);
            this.BtnCarregar.TabIndex = 10;
            this.BtnCarregar.Text = "Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = true;
            // 
            // BtnPlayFila
            // 
            this.BtnPlayFila.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayFila.Image")));
            this.BtnPlayFila.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayFila.Location = new System.Drawing.Point(559, 439);
            this.BtnPlayFila.Name = "BtnPlayFila";
            this.BtnPlayFila.Size = new System.Drawing.Size(75, 40);
            this.BtnPlayFila.TabIndex = 11;
            this.BtnPlayFila.Text = "Fila";
            this.BtnPlayFila.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayFila.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Image = ((System.Drawing.Image)(resources.GetObject("BtnPause.Image")));
            this.BtnPause.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPause.Location = new System.Drawing.Point(478, 439);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 40);
            this.BtnPause.TabIndex = 12;
            this.BtnPause.Text = "Pause";
            this.BtnPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnStop.Location = new System.Drawing.Point(397, 439);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 40);
            this.BtnStop.TabIndex = 13;
            this.BtnStop.Text = "Stop";
            this.BtnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnProximo
            // 
            this.BtnProximo.Image = ((System.Drawing.Image)(resources.GetObject("BtnProximo.Image")));
            this.BtnProximo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProximo.Location = new System.Drawing.Point(316, 439);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(75, 40);
            this.BtnProximo.TabIndex = 14;
            this.BtnProximo.Text = "Próximo";
            this.BtnProximo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProximo.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.Image")));
            this.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAnterior.Location = new System.Drawing.Point(235, 439);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 40);
            this.BtnAnterior.TabIndex = 15;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPlayPilha
            // 
            this.BtnPlayPilha.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayPilha.Image")));
            this.BtnPlayPilha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayPilha.Location = new System.Drawing.Point(640, 439);
            this.BtnPlayPilha.Name = "BtnPlayPilha";
            this.BtnPlayPilha.Size = new System.Drawing.Size(75, 40);
            this.BtnPlayPilha.TabIndex = 16;
            this.BtnPlayPilha.Text = "Pilha";
            this.BtnPlayPilha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayPilha.UseVisualStyleBackColor = true;
            // 
            // BtnPlayLista
            // 
            this.BtnPlayLista.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayLista.Image")));
            this.BtnPlayLista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayLista.Location = new System.Drawing.Point(721, 439);
            this.BtnPlayLista.Name = "BtnPlayLista";
            this.BtnPlayLista.Size = new System.Drawing.Size(75, 40);
            this.BtnPlayLista.TabIndex = 17;
            this.BtnPlayLista.Text = "Lista";
            this.BtnPlayLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayLista.UseVisualStyleBackColor = true;
            // 
            // LbPlaylistExibição
            // 
            this.LbPlaylistExibição.FormattingEnabled = true;
            this.LbPlaylistExibição.Location = new System.Drawing.Point(12, 192);
            this.LbPlaylistExibição.Name = "LbPlaylistExibição";
            this.LbPlaylistExibição.Size = new System.Drawing.Size(203, 212);
            this.LbPlaylistExibição.TabIndex = 18;
            // 
            // CbPlaylistPrincipal
            // 
            this.CbPlaylistPrincipal.FormattingEnabled = true;
            this.CbPlaylistPrincipal.Location = new System.Drawing.Point(12, 57);
            this.CbPlaylistPrincipal.Name = "CbPlaylistPrincipal";
            this.CbPlaylistPrincipal.Size = new System.Drawing.Size(203, 21);
            this.CbPlaylistPrincipal.TabIndex = 19;
            // 
            // LblPlaylistsPrincipal
            // 
            this.LblPlaylistsPrincipal.AutoSize = true;
            this.LblPlaylistsPrincipal.Location = new System.Drawing.Point(13, 38);
            this.LblPlaylistsPrincipal.Name = "LblPlaylistsPrincipal";
            this.LblPlaylistsPrincipal.Size = new System.Drawing.Size(44, 13);
            this.LblPlaylistsPrincipal.TabIndex = 20;
            this.LblPlaylistsPrincipal.Text = "Playlists";
            // 
            // BtnAleatorio
            // 
            this.BtnAleatorio.Image = ((System.Drawing.Image)(resources.GetObject("BtnAleatorio.Image")));
            this.BtnAleatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAleatorio.Location = new System.Drawing.Point(12, 410);
            this.BtnAleatorio.Name = "BtnAleatorio";
            this.BtnAleatorio.Size = new System.Drawing.Size(75, 40);
            this.BtnAleatorio.TabIndex = 21;
            this.BtnAleatorio.Text = "Aleatório";
            this.BtnAleatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAleatorio.UseVisualStyleBackColor = true;
            this.BtnAleatorio.Click += new System.EventHandler(this.BtnAleatorio_Click);
            // 
            // CkbAleatorioOn
            // 
            this.CkbAleatorioOn.AutoSize = true;
            this.CkbAleatorioOn.Enabled = false;
            this.CkbAleatorioOn.Location = new System.Drawing.Point(93, 410);
            this.CkbAleatorioOn.Name = "CkbAleatorioOn";
            this.CkbAleatorioOn.Size = new System.Drawing.Size(58, 17);
            this.CkbAleatorioOn.TabIndex = 22;
            this.CkbAleatorioOn.Text = "Ligado";
            this.CkbAleatorioOn.UseVisualStyleBackColor = true;
            // 
            // CkbAleatorioOff
            // 
            this.CkbAleatorioOff.AutoSize = true;
            this.CkbAleatorioOff.Checked = true;
            this.CkbAleatorioOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAleatorioOff.Enabled = false;
            this.CkbAleatorioOff.Location = new System.Drawing.Point(93, 433);
            this.CkbAleatorioOff.Name = "CkbAleatorioOff";
            this.CkbAleatorioOff.Size = new System.Drawing.Size(73, 17);
            this.CkbAleatorioOff.TabIndex = 23;
            this.CkbAleatorioOff.Text = "Desligado";
            this.CkbAleatorioOff.UseVisualStyleBackColor = true;
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.CkbAleatorioOff);
            this.Controls.Add(this.CkbAleatorioOn);
            this.Controls.Add(this.BtnAleatorio);
            this.Controls.Add(this.LblPlaylistsPrincipal);
            this.Controls.Add(this.CbPlaylistPrincipal);
            this.Controls.Add(this.LbPlaylistExibição);
            this.Controls.Add(this.BtnPlayLista);
            this.Controls.Add(this.BtnPlayPilha);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnPlayFila);
            this.Controls.Add(this.BtnCarregar);
            this.Controls.Add(this.PrePlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.PrePlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer PrePlayer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Button BtnPlayFila;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnPlayPilha;
        private System.Windows.Forms.Button BtnPlayLista;
        private System.Windows.Forms.ListBox LbPlaylistExibição;
        private System.Windows.Forms.ComboBox CbPlaylistPrincipal;
        private System.Windows.Forms.Label LblPlaylistsPrincipal;
        private System.Windows.Forms.Button BtnAleatorio;
        private System.Windows.Forms.CheckBox CkbAleatorioOn;
        private System.Windows.Forms.CheckBox CkbAleatorioOff;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

