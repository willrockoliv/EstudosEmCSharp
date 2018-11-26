namespace EX_5
{
    partial class frMovimentacao
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
            this.lbMovimentacao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMovimentacao
            // 
            this.lbMovimentacao.FormattingEnabled = true;
            this.lbMovimentacao.Location = new System.Drawing.Point(12, 12);
            this.lbMovimentacao.Name = "lbMovimentacao";
            this.lbMovimentacao.Size = new System.Drawing.Size(207, 238);
            this.lbMovimentacao.TabIndex = 17;
            // 
            // frMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 262);
            this.Controls.Add(this.lbMovimentacao);
            this.Name = "frMovimentacao";
            this.Text = "frMovimentacao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMovimentacao_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMovimentacao_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMovimentacao;
    }
}