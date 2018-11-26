namespace Cliente
{
    partial class frCliente
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtMsgRecebidas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Endereço Ip ou nome do computador Servidor";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 37);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "18";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Porta";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(12, 79);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(49, 20);
            this.txtPorta.TabIndex = 6;
            this.txtPorta.Text = "5000";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 119);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar!";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(134, 120);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(215, 122);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(233, 20);
            this.txtMsg.TabIndex = 10;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(12, 148);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMsgRecebidas
            // 
            this.txtMsgRecebidas.Location = new System.Drawing.Point(134, 150);
            this.txtMsgRecebidas.Multiline = true;
            this.txtMsgRecebidas.Name = "txtMsgRecebidas";
            this.txtMsgRecebidas.ReadOnly = true;
            this.txtMsgRecebidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsgRecebidas.Size = new System.Drawing.Size(314, 85);
            this.txtMsgRecebidas.TabIndex = 12;
            // 
            // frCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 247);
            this.Controls.Add(this.txtMsgRecebidas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Name = "frCliente";
            this.Text = "Cliente ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frCliente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtMsgRecebidas;
    }
}

