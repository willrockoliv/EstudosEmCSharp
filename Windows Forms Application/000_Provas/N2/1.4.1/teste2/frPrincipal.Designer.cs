namespace teste2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroCartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oQueÉSuperTrunfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJogar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordesToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.CadastroCartasToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.jogarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordesToolStripMenuItem
            // 
            this.recordesToolStripMenuItem.Name = "recordesToolStripMenuItem";
            this.recordesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.recordesToolStripMenuItem.Text = "Recordes";
            this.recordesToolStripMenuItem.Click += new System.EventHandler(this.recordesToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click_1);
            // 
            // CadastroCartasToolStripMenuItem
            // 
            this.CadastroCartasToolStripMenuItem.Name = "CadastroCartasToolStripMenuItem";
            this.CadastroCartasToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.CadastroCartasToolStripMenuItem.Text = "Cadastro de Cartas";
            this.CadastroCartasToolStripMenuItem.Click += new System.EventHandler(this.CadastroCartasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programadoresToolStripMenuItem,
            this.versãoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // programadoresToolStripMenuItem
            // 
            this.programadoresToolStripMenuItem.Name = "programadoresToolStripMenuItem";
            this.programadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.programadoresToolStripMenuItem.Text = "Programadores";
            this.programadoresToolStripMenuItem.Click += new System.EventHandler(this.programadoresToolStripMenuItem_Click);
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.versãoToolStripMenuItem.Text = "Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oQueÉSuperTrunfoToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // oQueÉSuperTrunfoToolStripMenuItem
            // 
            this.oQueÉSuperTrunfoToolStripMenuItem.Name = "oQueÉSuperTrunfoToolStripMenuItem";
            this.oQueÉSuperTrunfoToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.oQueÉSuperTrunfoToolStripMenuItem.Text = "O que é Super Trunfo";
            this.oQueÉSuperTrunfoToolStripMenuItem.Click += new System.EventHandler(this.oQueÉSuperTrunfoToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // jogarToolStripMenuItem
            // 
            this.jogarToolStripMenuItem.Name = "jogarToolStripMenuItem";
            this.jogarToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.jogarToolStripMenuItem.Text = "Sair";
            this.jogarToolStripMenuItem.Click += new System.EventHandler(this.jogarToolStripMenuItem_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJogar.BackColor = System.Drawing.Color.White;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.Black;
            this.btnJogar.Image = global::teste2.Properties.Resources._1495100475_Games_1;
            this.btnJogar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJogar.Location = new System.Drawing.Point(408, 415);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(90, 59);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste2.Properties.Resources.SUPER_TRUNFO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPER TRUNFO EC2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oQueÉSuperTrunfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastroCartasToolStripMenuItem;
    }
}

