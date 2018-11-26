namespace jogo_velha
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
            this.tabuleiro = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabuleiro
            // 
            this.tabuleiro.ColumnHeadersHeight = 50;
            this.tabuleiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabuleiro.ColumnHeadersVisible = false;
            this.tabuleiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.tabuleiro.Location = new System.Drawing.Point(12, 12);
            this.tabuleiro.Name = "tabuleiro";
            this.tabuleiro.ReadOnly = true;
            this.tabuleiro.RowHeadersVisible = false;
            this.tabuleiro.RowHeadersWidth = 50;
            this.tabuleiro.Size = new System.Drawing.Size(272, 169);
            this.tabuleiro.TabIndex = 0;
            this.tabuleiro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabuleiro_CellClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "Column1";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 50;
            // 
            // col2
            // 
            this.col2.HeaderText = "Column1";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            this.col2.Width = 50;
            // 
            // col3
            // 
            this.col3.HeaderText = "Column1";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.tabuleiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabuleiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
    }
}

