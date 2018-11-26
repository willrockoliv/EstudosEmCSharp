namespace Mestre_Detalhe
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
            this.components = new System.ComponentModel.Container();
            this.grpMestre = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtPedidoID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetalhe = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGravaPedido = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpMestre.SuspendLayout();
            this.grpDetalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMestre
            // 
            this.grpMestre.BackColor = System.Drawing.Color.SteelBlue;
            this.grpMestre.Controls.Add(this.cbCliente);
            this.grpMestre.Controls.Add(this.label3);
            this.grpMestre.Controls.Add(this.label2);
            this.grpMestre.Controls.Add(this.txtData);
            this.grpMestre.Controls.Add(this.txtPedidoID);
            this.grpMestre.Controls.Add(this.label1);
            this.grpMestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMestre.Location = new System.Drawing.Point(12, 12);
            this.grpMestre.Name = "grpMestre";
            this.grpMestre.Size = new System.Drawing.Size(656, 76);
            this.grpMestre.TabIndex = 0;
            this.grpMestre.TabStop = false;
            this.grpMestre.Text = "Mestre";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(89, 41);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(286, 21);
            this.cbCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data do pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(400, 41);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(111, 20);
            this.txtData.TabIndex = 2;
            // 
            // txtPedidoID
            // 
            this.txtPedidoID.Location = new System.Drawing.Point(9, 41);
            this.txtPedidoID.Name = "txtPedidoID";
            this.txtPedidoID.Size = new System.Drawing.Size(52, 20);
            this.txtPedidoID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // grpDetalhe
            // 
            this.grpDetalhe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpDetalhe.Controls.Add(this.pictureBox1);
            this.grpDetalhe.Controls.Add(this.label4);
            this.grpDetalhe.Controls.Add(this.btnAddProd);
            this.grpDetalhe.Controls.Add(this.cbProduto);
            this.grpDetalhe.Controls.Add(this.dataGridView1);
            this.grpDetalhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalhe.Location = new System.Drawing.Point(12, 98);
            this.grpDetalhe.Name = "grpDetalhe";
            this.grpDetalhe.Size = new System.Drawing.Size(656, 231);
            this.grpDetalhe.TabIndex = 1;
            this.grpDetalhe.TabStop = false;
            this.grpDetalhe.Text = "Detalhe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mestre_Detalhe.Properties.Resources._1415687148_Basket;
            this.pictureBox1.Location = new System.Drawing.Point(180, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Produto";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Image = global::Mestre_Detalhe.Properties.Resources._1415687315_down_left_16;
            this.btnAddProd.Location = new System.Drawing.Point(467, 39);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(176, 23);
            this.btnAddProd.TabIndex = 3;
            this.btnAddProd.Text = "Adicionar produto ao pedido";
            this.btnAddProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnAddProd, "Adicionar um produto ao carrinho ");
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(239, 39);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(222, 21);
            this.cbProduto.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(636, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // btnGravaPedido
            // 
            this.btnGravaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravaPedido.Image = global::Mestre_Detalhe.Properties.Resources._1415687018_sc_save;
            this.btnGravaPedido.Location = new System.Drawing.Point(263, 335);
            this.btnGravaPedido.Name = "btnGravaPedido";
            this.btnGravaPedido.Size = new System.Drawing.Size(140, 26);
            this.btnGravaPedido.TabIndex = 2;
            this.btnGravaPedido.Text = "   Gravar Pedido";
            this.btnGravaPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravaPedido.UseVisualStyleBackColor = true;
            this.btnGravaPedido.Click += new System.EventHandler(this.btnGravaPedido_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.btnGravaPedido);
            this.Controls.Add(this.grpDetalhe);
            this.Controls.Add(this.grpMestre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo de cadastro mestre-detalhe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMestre.ResumeLayout(false);
            this.grpMestre.PerformLayout();
            this.grpDetalhe.ResumeLayout(false);
            this.grpDetalhe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtPedidoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDetalhe;
        private System.Windows.Forms.Button btnGravaPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbCliente;
    }
}

