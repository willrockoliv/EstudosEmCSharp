namespace EX_6_TimeFutebol
{
    partial class frCadJogador
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroCamisa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdTime = new System.Windows.Forms.NumericUpDown();
            this.btnBuscaTime = new System.Windows.Forms.Button();
            this.txtNomeTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCamisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 97);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(11, 113);
            this.txtId.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtId.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(122, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº camisa";
            // 
            // txtNumeroCamisa
            // 
            this.txtNumeroCamisa.Location = new System.Drawing.Point(265, 114);
            this.txtNumeroCamisa.Name = "txtNumeroCamisa";
            this.txtNumeroCamisa.Size = new System.Drawing.Size(90, 20);
            this.txtNumeroCamisa.TabIndex = 5;
            this.txtNumeroCamisa.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNumeroCamisa.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id do Time";
            // 
            // txtIdTime
            // 
            this.txtIdTime.Location = new System.Drawing.Point(391, 115);
            this.txtIdTime.Name = "txtIdTime";
            this.txtIdTime.Size = new System.Drawing.Size(90, 20);
            this.txtIdTime.TabIndex = 7;
            this.txtIdTime.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtIdTime.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnBuscaTime
            // 
            this.btnBuscaTime.Image = global::EX_6_TimeFutebol.Properties.Resources.if_system_search_118797;
            this.btnBuscaTime.Location = new System.Drawing.Point(626, 99);
            this.btnBuscaTime.Name = "btnBuscaTime";
            this.btnBuscaTime.Size = new System.Drawing.Size(41, 36);
            this.btnBuscaTime.TabIndex = 31;
            this.btnBuscaTime.UseVisualStyleBackColor = true;
            this.btnBuscaTime.Click += new System.EventHandler(this.btnBuscaTime_Click);
            // 
            // txtNomeTime
            // 
            this.txtNomeTime.Location = new System.Drawing.Point(487, 115);
            this.txtNomeTime.Name = "txtNomeTime";
            this.txtNomeTime.ReadOnly = true;
            this.txtNomeTime.Size = new System.Drawing.Size(122, 20);
            this.txtNomeTime.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 154);
            this.Controls.Add(this.txtNomeTime);
            this.Controls.Add(this.btnBuscaTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroCamisa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.SugereProximoId = true;
            this.Text = "Cadastro de Jogadores de Futebol";
            this.Controls.SetChildIndex(this.btnExclui, 0);
            this.Controls.SetChildIndex(this.btnPesquisa, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtNumeroCamisa, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdTime, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnBuscaTime, 0);
            this.Controls.SetChildIndex(this.txtNomeTime, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCamisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtNumeroCamisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtIdTime;
        private System.Windows.Forms.Button btnBuscaTime;
        private System.Windows.Forms.TextBox txtNomeTime;
    }
}

