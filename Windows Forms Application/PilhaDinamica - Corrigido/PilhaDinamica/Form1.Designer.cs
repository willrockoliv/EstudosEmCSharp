namespace PilhaDinamica
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
            this.btnEmpilhar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnDesempilhar = new System.Windows.Forms.Button();
            this.btnRetornaTopo = new System.Windows.Forms.Button();
            this.btnTamanho = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpilhar
            // 
            this.btnEmpilhar.Location = new System.Drawing.Point(5, 73);
            this.btnEmpilhar.Name = "btnEmpilhar";
            this.btnEmpilhar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpilhar.TabIndex = 0;
            this.btnEmpilhar.Text = "Empilha";
            this.btnEmpilhar.UseVisualStyleBackColor = true;
            this.btnEmpilhar.Click += new System.EventHandler(this.btnEmpilhar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(5, 27);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(5, 11);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // btnDesempilhar
            // 
            this.btnDesempilhar.Location = new System.Drawing.Point(86, 73);
            this.btnDesempilhar.Name = "btnDesempilhar";
            this.btnDesempilhar.Size = new System.Drawing.Size(75, 23);
            this.btnDesempilhar.TabIndex = 3;
            this.btnDesempilhar.Text = "Desempilha";
            this.btnDesempilhar.UseVisualStyleBackColor = true;
            this.btnDesempilhar.Click += new System.EventHandler(this.btnDesempilhar_Click);
            // 
            // btnRetornaTopo
            // 
            this.btnRetornaTopo.Location = new System.Drawing.Point(167, 73);
            this.btnRetornaTopo.Name = "btnRetornaTopo";
            this.btnRetornaTopo.Size = new System.Drawing.Size(90, 23);
            this.btnRetornaTopo.TabIndex = 4;
            this.btnRetornaTopo.Text = "Retorna topo";
            this.btnRetornaTopo.UseVisualStyleBackColor = true;
            this.btnRetornaTopo.Click += new System.EventHandler(this.btnRetornaTopo_Click);
            // 
            // btnTamanho
            // 
            this.btnTamanho.Location = new System.Drawing.Point(263, 73);
            this.btnTamanho.Name = "btnTamanho";
            this.btnTamanho.Size = new System.Drawing.Size(75, 23);
            this.btnTamanho.TabIndex = 5;
            this.btnTamanho.Text = "Tamanho";
            this.btnTamanho.UseVisualStyleBackColor = true;
            this.btnTamanho.Click += new System.EventHandler(this.btnTamanho_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(126, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 102);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTamanho);
            this.Controls.Add(this.btnRetornaTopo);
            this.Controls.Add(this.btnDesempilhar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnEmpilhar);
            this.Name = "Form1";
            this.Text = "Programa para testar a pilha dinâmica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpilhar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnDesempilhar;
        private System.Windows.Forms.Button btnRetornaTopo;
        private System.Windows.Forms.Button btnTamanho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
    }
}

