namespace EX_6_TimeFutebol
{
    partial class frCadTecnicoComHeranca
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
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
      this.SuspendLayout();
      // 
      // txtId
      // 
      this.txtId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // btnPesquisa
      // 
      this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(128, 91);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(457, 20);
      this.txtNome.TabIndex = 56;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(125, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 55;
      this.label2.Text = "Nome";
      // 
      // frCadTecnicoComHeranca
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(667, 132);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label2);
      this.Name = "frCadTecnicoComHeranca";
      this.Text = "frCadTecnicoComHeranca";
      this.Controls.SetChildIndex(this.btnExclui, 0);
      this.Controls.SetChildIndex(this.btnPesquisa, 0);
      this.Controls.SetChildIndex(this.txtId, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.txtNome, 0);
      ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
    }
}