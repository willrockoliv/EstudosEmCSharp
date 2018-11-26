namespace Ex1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnQtdeNosInternos = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnArvoreTeste = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnQtdeNosExternos = new System.Windows.Forms.Button();
            this.btnPreFixado = new System.Windows.Forms.Button();
            this.btnPosFixado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(52, 12);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(15, 37);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(157, 23);
            this.btnInsere.TabIndex = 2;
            this.btnInsere.Text = "Insere número na árvore";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(178, 37);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(115, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar dados";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnQtdeNosInternos
            // 
            this.btnQtdeNosInternos.Location = new System.Drawing.Point(299, 37);
            this.btnQtdeNosInternos.Name = "btnQtdeNosInternos";
            this.btnQtdeNosInternos.Size = new System.Drawing.Size(129, 23);
            this.btnQtdeNosInternos.TabIndex = 4;
            this.btnQtdeNosInternos.Text = "Qtde de nós internos";
            this.btnQtdeNosInternos.UseVisualStyleBackColor = true;
            this.btnQtdeNosInternos.Click += new System.EventHandler(this.btnQtdeNosInternos_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(434, 37);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(115, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Excluir Nodo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnArvoreTeste
            // 
            this.btnArvoreTeste.Location = new System.Drawing.Point(555, 37);
            this.btnArvoreTeste.Name = "btnArvoreTeste";
            this.btnArvoreTeste.Size = new System.Drawing.Size(151, 23);
            this.btnArvoreTeste.TabIndex = 6;
            this.btnArvoreTeste.Text = "Cria uma árvore para teste";
            this.btnArvoreTeste.UseVisualStyleBackColor = true;
            this.btnArvoreTeste.Click += new System.EventHandler(this.btnArvoreTeste_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 147);
            this.listBox1.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(15, 66);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(157, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar um valor";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(178, 66);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(115, 23);
            this.btnAltura.TabIndex = 9;
            this.btnAltura.Text = "Altura da árvore";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnQtdeNosExternos
            // 
            this.btnQtdeNosExternos.Location = new System.Drawing.Point(299, 66);
            this.btnQtdeNosExternos.Name = "btnQtdeNosExternos";
            this.btnQtdeNosExternos.Size = new System.Drawing.Size(129, 23);
            this.btnQtdeNosExternos.TabIndex = 10;
            this.btnQtdeNosExternos.Text = "Qtde de nós externos";
            this.btnQtdeNosExternos.UseVisualStyleBackColor = true;
            this.btnQtdeNosExternos.Click += new System.EventHandler(this.btnQtdeNosExternos_Click);
            // 
            // btnPreFixado
            // 
            this.btnPreFixado.Location = new System.Drawing.Point(434, 66);
            this.btnPreFixado.Name = "btnPreFixado";
            this.btnPreFixado.Size = new System.Drawing.Size(115, 23);
            this.btnPreFixado.TabIndex = 11;
            this.btnPreFixado.Text = "Perc. Pré-fixado";
            this.btnPreFixado.UseVisualStyleBackColor = true;
            // 
            // btnPosFixado
            // 
            this.btnPosFixado.Location = new System.Drawing.Point(555, 66);
            this.btnPosFixado.Name = "btnPosFixado";
            this.btnPosFixado.Size = new System.Drawing.Size(151, 23);
            this.btnPosFixado.TabIndex = 12;
            this.btnPosFixado.Text = "Perc. Pós-fixado";
            this.btnPosFixado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 261);
            this.Controls.Add(this.btnPosFixado);
            this.Controls.Add(this.btnPreFixado);
            this.Controls.Add(this.btnQtdeNosExternos);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnArvoreTeste);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnQtdeNosInternos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnQtdeNosInternos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnArvoreTeste;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnQtdeNosExternos;
        private System.Windows.Forms.Button btnPreFixado;
        private System.Windows.Forms.Button btnPosFixado;
    }
}

