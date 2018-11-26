namespace CadastroProdutosHeranca
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.txtId = new System.Windows.Forms.NumericUpDown();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnGravar = new System.Windows.Forms.Button();
      this.btnUltimo = new System.Windows.Forms.Button();
      this.btnProximo = new System.Windows.Forms.Button();
      this.btnAnterior = new System.Windows.Forms.Button();
      this.btnPrimeiro = new System.Windows.Forms.Button();
      this.btnExclui = new System.Windows.Forms.Button();
      this.btnAltera = new System.Windows.Forms.Button();
      this.btnInclui = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtValor = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.txtImagem = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(16, 13);
      this.label1.TabIndex = 71;
      this.label1.Text = "Id";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(119, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 13);
      this.label2.TabIndex = 70;
      this.label2.Text = "Nome do técnico";
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(122, 92);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(173, 20);
      this.txtNome.TabIndex = 69;
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(13, 92);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(90, 20);
      this.txtId.TabIndex = 68;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Image = global::CadastroProdutosHeranca.Properties.Resources.if_cancel_46786;
      this.btnCancelar.Location = new System.Drawing.Point(282, 12);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(51, 43);
      this.btnCancelar.TabIndex = 66;
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnGravar
      // 
      this.btnGravar.Image = global::CadastroProdutosHeranca.Properties.Resources.if_floppy_285657;
      this.btnGravar.Location = new System.Drawing.Point(225, 12);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(51, 43);
      this.btnGravar.TabIndex = 65;
      this.btnGravar.UseVisualStyleBackColor = true;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // btnUltimo
      // 
      this.btnUltimo.Image = global::CadastroProdutosHeranca.Properties.Resources.if_go_last_118772;
      this.btnUltimo.Location = new System.Drawing.Point(535, 12);
      this.btnUltimo.Name = "btnUltimo";
      this.btnUltimo.Size = new System.Drawing.Size(51, 43);
      this.btnUltimo.TabIndex = 64;
      this.btnUltimo.Text = " ";
      this.btnUltimo.UseVisualStyleBackColor = true;
      this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
      // 
      // btnProximo
      // 
      this.btnProximo.Image = global::CadastroProdutosHeranca.Properties.Resources.if_go_next_118773;
      this.btnProximo.Location = new System.Drawing.Point(478, 12);
      this.btnProximo.Name = "btnProximo";
      this.btnProximo.Size = new System.Drawing.Size(51, 43);
      this.btnProximo.TabIndex = 63;
      this.btnProximo.Text = " ";
      this.btnProximo.UseVisualStyleBackColor = true;
      this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
      // 
      // btnAnterior
      // 
      this.btnAnterior.Image = global::CadastroProdutosHeranca.Properties.Resources.if_go_previous_118774;
      this.btnAnterior.Location = new System.Drawing.Point(418, 12);
      this.btnAnterior.Name = "btnAnterior";
      this.btnAnterior.Size = new System.Drawing.Size(51, 43);
      this.btnAnterior.TabIndex = 62;
      this.btnAnterior.Text = " ";
      this.btnAnterior.UseVisualStyleBackColor = true;
      this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
      // 
      // btnPrimeiro
      // 
      this.btnPrimeiro.Image = global::CadastroProdutosHeranca.Properties.Resources.if_go_first_118769;
      this.btnPrimeiro.Location = new System.Drawing.Point(361, 12);
      this.btnPrimeiro.Name = "btnPrimeiro";
      this.btnPrimeiro.Size = new System.Drawing.Size(51, 43);
      this.btnPrimeiro.TabIndex = 61;
      this.btnPrimeiro.Text = " ";
      this.btnPrimeiro.UseVisualStyleBackColor = true;
      this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
      // 
      // btnExclui
      // 
      this.btnExclui.Image = global::CadastroProdutosHeranca.Properties.Resources.if_f_cross_256_282471;
      this.btnExclui.Location = new System.Drawing.Point(138, 12);
      this.btnExclui.Name = "btnExclui";
      this.btnExclui.Size = new System.Drawing.Size(51, 43);
      this.btnExclui.TabIndex = 60;
      this.btnExclui.UseVisualStyleBackColor = true;
      this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
      // 
      // btnAltera
      // 
      this.btnAltera.Image = global::CadastroProdutosHeranca.Properties.Resources.if_edit_173002;
      this.btnAltera.Location = new System.Drawing.Point(76, 12);
      this.btnAltera.Name = "btnAltera";
      this.btnAltera.Size = new System.Drawing.Size(51, 43);
      this.btnAltera.TabIndex = 59;
      this.btnAltera.UseVisualStyleBackColor = true;
      this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
      // 
      // btnInclui
      // 
      this.btnInclui.Image = global::CadastroProdutosHeranca.Properties.Resources.if_Add_728898;
      this.btnInclui.Location = new System.Drawing.Point(12, 12);
      this.btnInclui.Name = "btnInclui";
      this.btnInclui.Size = new System.Drawing.Size(51, 43);
      this.btnInclui.TabIndex = 58;
      this.btnInclui.UseVisualStyleBackColor = true;
      this.btnInclui.Click += new System.EventHandler(this.btnInclui_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(319, 73);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 73;
      this.label3.Text = "Valor unitário";
      // 
      // txtValor
      // 
      this.txtValor.DecimalPlaces = 2;
      this.txtValor.Location = new System.Drawing.Point(322, 89);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(90, 20);
      this.txtValor.TabIndex = 72;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(427, 68);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 13);
      this.label4.TabIndex = 75;
      this.label4.Text = "Imagem";
      // 
      // txtImagem
      // 
      this.txtImagem.Location = new System.Drawing.Point(430, 88);
      this.txtImagem.Name = "txtImagem";
      this.txtImagem.Size = new System.Drawing.Size(173, 20);
      this.txtImagem.TabIndex = 74;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 148);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtImagem);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtValor);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.btnUltimo);
      this.Controls.Add(this.btnProximo);
      this.Controls.Add(this.btnAnterior);
      this.Controls.Add(this.btnPrimeiro);
      this.Controls.Add(this.btnExclui);
      this.Controls.Add(this.btnAltera);
      this.Controls.Add(this.btnInclui);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNome;
    protected System.Windows.Forms.NumericUpDown txtId;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.Button btnUltimo;
    private System.Windows.Forms.Button btnProximo;
    private System.Windows.Forms.Button btnAnterior;
    private System.Windows.Forms.Button btnPrimeiro;
    protected System.Windows.Forms.Button btnExclui;
    private System.Windows.Forms.Button btnAltera;
    private System.Windows.Forms.Button btnInclui;
    private System.Windows.Forms.Label label3;
    protected System.Windows.Forms.NumericUpDown txtValor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtImagem;
  }
}

