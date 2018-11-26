namespace HerancaAluno
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtN2_EM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN3_EM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtN2_FTT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHorasEstagio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGraduacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtListagem = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Criar!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RA";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(12, 27);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 20);
            this.txtRA.TabIndex = 3;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(133, 27);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(146, 20);
            this.txtNomeAluno.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(285, 27);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(100, 20);
            this.txtFreq.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frequencia";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(391, 27);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota N1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResponsavel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtN3_EM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtN2_EM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 195);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ensino Médio";
            // 
            // txtN2_EM
            // 
            this.txtN2_EM.Location = new System.Drawing.Point(6, 36);
            this.txtN2_EM.Name = "txtN2_EM";
            this.txtN2_EM.Size = new System.Drawing.Size(100, 20);
            this.txtN2_EM.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota N2";
            // 
            // txtN3_EM
            // 
            this.txtN3_EM.Location = new System.Drawing.Point(6, 80);
            this.txtN3_EM.Name = "txtN3_EM";
            this.txtN3_EM.Size = new System.Drawing.Size(100, 20);
            this.txtN3_EM.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nota N3";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(6, 123);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(146, 20);
            this.txtResponsavel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome Responsável";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHorasEstagio);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtN2_FTT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(232, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 195);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTT";
            // 
            // txtN2_FTT
            // 
            this.txtN2_FTT.Location = new System.Drawing.Point(6, 36);
            this.txtN2_FTT.Name = "txtN2_FTT";
            this.txtN2_FTT.Size = new System.Drawing.Size(100, 20);
            this.txtN2_FTT.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nota N2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Criar!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHorasEstagio
            // 
            this.txtHorasEstagio.Location = new System.Drawing.Point(6, 80);
            this.txtHorasEstagio.Name = "txtHorasEstagio";
            this.txtHorasEstagio.Size = new System.Drawing.Size(100, 20);
            this.txtHorasEstagio.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Horas de Estágio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGraduacao);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(429, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 195);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pós ";
            // 
            // txtGraduacao
            // 
            this.txtGraduacao.Location = new System.Drawing.Point(6, 80);
            this.txtGraduacao.Name = "txtGraduacao";
            this.txtGraduacao.Size = new System.Drawing.Size(163, 20);
            this.txtGraduacao.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Faculade que fez a graduação";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Criar!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Listar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtListagem
            // 
            this.txtListagem.Location = new System.Drawing.Point(15, 326);
            this.txtListagem.Multiline = true;
            this.txtListagem.Name = "txtListagem";
            this.txtListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListagem.Size = new System.Drawing.Size(830, 126);
            this.txtListagem.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Listar com TString()";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtListagem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Herança";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtN3_EM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtN2_EM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHorasEstagio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtN2_FTT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGraduacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtListagem;
        private System.Windows.Forms.Button button5;
    }
}

