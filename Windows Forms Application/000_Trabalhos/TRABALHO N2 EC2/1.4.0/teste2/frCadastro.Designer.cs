namespace teste2
{
    partial class frCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastro));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodInterno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblHumanasForca = new System.Windows.Forms.Label();
            this.lblMalandragemForca = new System.Windows.Forms.Label();
            this.lblRaivaForca = new System.Windows.Forms.Label();
            this.lblFomeForca = new System.Windows.Forms.Label();
            this.lblSonoForca = new System.Windows.Forms.Label();
            this.btnRemoverImgem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMaisHumanas = new System.Windows.Forms.Button();
            this.progressBarHumanas = new System.Windows.Forms.ProgressBar();
            this.btnMenosHumanas = new System.Windows.Forms.Button();
            this.btnMaisMalandragem = new System.Windows.Forms.Button();
            this.progressBarMalandragem = new System.Windows.Forms.ProgressBar();
            this.btnMenosMalandragem = new System.Windows.Forms.Button();
            this.btnMaisRaiva = new System.Windows.Forms.Button();
            this.progressBarRaiva = new System.Windows.Forms.ProgressBar();
            this.btnMenosRaiva = new System.Windows.Forms.Button();
            this.btnMaisFome = new System.Windows.Forms.Button();
            this.progressBarFome = new System.Windows.Forms.ProgressBar();
            this.btnMenosFome = new System.Windows.Forms.Button();
            this.btnMaisSono = new System.Windows.Forms.Button();
            this.progressBarSono = new System.Windows.Forms.ProgressBar();
            this.btnMenosSono = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbImagemCarta = new System.Windows.Forms.PictureBox();
            this.openFileDiologCadastro = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::teste2.Properties.Resources._1495088193_new_24;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(652, 122);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 55);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcurar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Image = global::teste2.Properties.Resources._1495088216_search;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(652, 183);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(105, 55);
            this.btnProcurar.TabIndex = 7;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::teste2.Properties.Resources._1495088231_delete;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(652, 244);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 55);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProximo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProximo.Image = global::teste2.Properties.Resources._1495087548_double_arrow_right;
            this.btnProximo.Location = new System.Drawing.Point(652, 335);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 50);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnterior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnterior.Image = global::teste2.Properties.Resources._1495087525_double_arrow_left;
            this.btnAnterior.Location = new System.Drawing.Point(207, 335);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 50);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Image = global::teste2.Properties.Resources._1495088327_22;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(652, 541);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 55);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair   ";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::teste2.Properties.Resources._1495087867_floppy_disk_save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(652, 61);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 55);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::teste2.Properties.Resources.cartaFrente;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCodInterno);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblHumanasForca);
            this.panel1.Controls.Add(this.lblMalandragemForca);
            this.panel1.Controls.Add(this.lblRaivaForca);
            this.panel1.Controls.Add(this.lblFomeForca);
            this.panel1.Controls.Add(this.lblSonoForca);
            this.panel1.Controls.Add(this.btnRemoverImgem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCarregarImagem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnMaisHumanas);
            this.panel1.Controls.Add(this.progressBarHumanas);
            this.panel1.Controls.Add(this.btnMenosHumanas);
            this.panel1.Controls.Add(this.btnMaisMalandragem);
            this.panel1.Controls.Add(this.progressBarMalandragem);
            this.panel1.Controls.Add(this.btnMenosMalandragem);
            this.panel1.Controls.Add(this.btnMaisRaiva);
            this.panel1.Controls.Add(this.progressBarRaiva);
            this.panel1.Controls.Add(this.btnMenosRaiva);
            this.panel1.Controls.Add(this.btnMaisFome);
            this.panel1.Controls.Add(this.progressBarFome);
            this.panel1.Controls.Add(this.btnMenosFome);
            this.panel1.Controls.Add(this.btnMaisSono);
            this.panel1.Controls.Add(this.progressBarSono);
            this.panel1.Controls.Add(this.btnMenosSono);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ptbImagemCarta);
            this.panel1.Location = new System.Drawing.Point(288, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 535);
            this.panel1.TabIndex = 1;
            // 
            // lblCodInterno
            // 
            this.lblCodInterno.AutoSize = true;
            this.lblCodInterno.BackColor = System.Drawing.Color.Transparent;
            this.lblCodInterno.Location = new System.Drawing.Point(336, 3);
            this.lblCodInterno.Name = "lblCodInterno";
            this.lblCodInterno.Size = new System.Drawing.Size(13, 13);
            this.lblCodInterno.TabIndex = 39;
            this.lblCodInterno.Text = "0";
            this.lblCodInterno.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.SkyBlue;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(17, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(2, 21);
            this.lblCodigo.TabIndex = 38;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 37;
            this.txtNome.Text = "NOME";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHumanasForca
            // 
            this.lblHumanasForca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHumanasForca.AutoSize = true;
            this.lblHumanasForca.BackColor = System.Drawing.Color.Transparent;
            this.lblHumanasForca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumanasForca.ForeColor = System.Drawing.Color.Black;
            this.lblHumanasForca.Location = new System.Drawing.Point(8, 501);
            this.lblHumanasForca.Name = "lblHumanasForca";
            this.lblHumanasForca.Size = new System.Drawing.Size(36, 19);
            this.lblHumanasForca.TabIndex = 36;
            this.lblHumanasForca.Tag = "";
            this.lblHumanasForca.Text = "0 %";
            // 
            // lblMalandragemForca
            // 
            this.lblMalandragemForca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMalandragemForca.AutoSize = true;
            this.lblMalandragemForca.BackColor = System.Drawing.Color.Transparent;
            this.lblMalandragemForca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalandragemForca.ForeColor = System.Drawing.Color.Black;
            this.lblMalandragemForca.Location = new System.Drawing.Point(8, 451);
            this.lblMalandragemForca.Name = "lblMalandragemForca";
            this.lblMalandragemForca.Size = new System.Drawing.Size(36, 19);
            this.lblMalandragemForca.TabIndex = 35;
            this.lblMalandragemForca.Tag = "";
            this.lblMalandragemForca.Text = "0 %";
            // 
            // lblRaivaForca
            // 
            this.lblRaivaForca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaivaForca.AutoSize = true;
            this.lblRaivaForca.BackColor = System.Drawing.Color.Transparent;
            this.lblRaivaForca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaivaForca.ForeColor = System.Drawing.Color.Black;
            this.lblRaivaForca.Location = new System.Drawing.Point(8, 403);
            this.lblRaivaForca.Name = "lblRaivaForca";
            this.lblRaivaForca.Size = new System.Drawing.Size(36, 19);
            this.lblRaivaForca.TabIndex = 34;
            this.lblRaivaForca.Tag = "";
            this.lblRaivaForca.Text = "0 %";
            // 
            // lblFomeForca
            // 
            this.lblFomeForca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFomeForca.AutoSize = true;
            this.lblFomeForca.BackColor = System.Drawing.Color.Transparent;
            this.lblFomeForca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFomeForca.ForeColor = System.Drawing.Color.Black;
            this.lblFomeForca.Location = new System.Drawing.Point(8, 355);
            this.lblFomeForca.Name = "lblFomeForca";
            this.lblFomeForca.Size = new System.Drawing.Size(36, 19);
            this.lblFomeForca.TabIndex = 33;
            this.lblFomeForca.Tag = "";
            this.lblFomeForca.Text = "0 %";
            // 
            // lblSonoForca
            // 
            this.lblSonoForca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSonoForca.AutoSize = true;
            this.lblSonoForca.BackColor = System.Drawing.Color.Transparent;
            this.lblSonoForca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonoForca.ForeColor = System.Drawing.Color.Black;
            this.lblSonoForca.Location = new System.Drawing.Point(8, 307);
            this.lblSonoForca.Name = "lblSonoForca";
            this.lblSonoForca.Size = new System.Drawing.Size(36, 19);
            this.lblSonoForca.TabIndex = 32;
            this.lblSonoForca.Tag = "";
            this.lblSonoForca.Text = "0 %";
            // 
            // btnRemoverImgem
            // 
            this.btnRemoverImgem.Enabled = false;
            this.btnRemoverImgem.Image = global::teste2.Properties.Resources.linha_16;
            this.btnRemoverImgem.Location = new System.Drawing.Point(292, 83);
            this.btnRemoverImgem.Name = "btnRemoverImgem";
            this.btnRemoverImgem.Size = new System.Drawing.Size(25, 25);
            this.btnRemoverImgem.TabIndex = 31;
            this.btnRemoverImgem.UseVisualStyleBackColor = true;
            this.btnRemoverImgem.Click += new System.EventHandler(this.btnRemoverImgem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fúria/Explosividade";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Image = global::teste2.Properties.Resources.stock_plus_13;
            this.btnCarregarImagem.Location = new System.Drawing.Point(292, 54);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(25, 25);
            this.btnCarregarImagem.TabIndex = 11;
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sagacidade";
            // 
            // btnMaisHumanas
            // 
            this.btnMaisHumanas.Location = new System.Drawing.Point(292, 495);
            this.btnMaisHumanas.Name = "btnMaisHumanas";
            this.btnMaisHumanas.Size = new System.Drawing.Size(22, 23);
            this.btnMaisHumanas.TabIndex = 26;
            this.btnMaisHumanas.Text = "+";
            this.btnMaisHumanas.UseVisualStyleBackColor = true;
            this.btnMaisHumanas.Click += new System.EventHandler(this.btnMaisHumanas_Click);
            // 
            // progressBarHumanas
            // 
            this.progressBarHumanas.Location = new System.Drawing.Point(65, 495);
            this.progressBarHumanas.Name = "progressBarHumanas";
            this.progressBarHumanas.Size = new System.Drawing.Size(221, 23);
            this.progressBarHumanas.TabIndex = 25;
            // 
            // btnMenosHumanas
            // 
            this.btnMenosHumanas.Enabled = false;
            this.btnMenosHumanas.Location = new System.Drawing.Point(320, 495);
            this.btnMenosHumanas.Name = "btnMenosHumanas";
            this.btnMenosHumanas.Size = new System.Drawing.Size(22, 23);
            this.btnMenosHumanas.TabIndex = 24;
            this.btnMenosHumanas.Text = "-";
            this.btnMenosHumanas.UseVisualStyleBackColor = true;
            this.btnMenosHumanas.Click += new System.EventHandler(this.btnMenosHumanas_Click);
            // 
            // btnMaisMalandragem
            // 
            this.btnMaisMalandragem.Location = new System.Drawing.Point(292, 445);
            this.btnMaisMalandragem.Name = "btnMaisMalandragem";
            this.btnMaisMalandragem.Size = new System.Drawing.Size(22, 23);
            this.btnMaisMalandragem.TabIndex = 23;
            this.btnMaisMalandragem.Text = "+";
            this.btnMaisMalandragem.UseVisualStyleBackColor = true;
            this.btnMaisMalandragem.Click += new System.EventHandler(this.btnMaisMalandragem_Click);
            // 
            // progressBarMalandragem
            // 
            this.progressBarMalandragem.Location = new System.Drawing.Point(65, 445);
            this.progressBarMalandragem.Name = "progressBarMalandragem";
            this.progressBarMalandragem.Size = new System.Drawing.Size(221, 23);
            this.progressBarMalandragem.TabIndex = 22;
            // 
            // btnMenosMalandragem
            // 
            this.btnMenosMalandragem.Enabled = false;
            this.btnMenosMalandragem.Location = new System.Drawing.Point(320, 445);
            this.btnMenosMalandragem.Name = "btnMenosMalandragem";
            this.btnMenosMalandragem.Size = new System.Drawing.Size(22, 23);
            this.btnMenosMalandragem.TabIndex = 21;
            this.btnMenosMalandragem.Text = "-";
            this.btnMenosMalandragem.UseVisualStyleBackColor = true;
            this.btnMenosMalandragem.Click += new System.EventHandler(this.btnMenosMalandragem_Click);
            // 
            // btnMaisRaiva
            // 
            this.btnMaisRaiva.Location = new System.Drawing.Point(292, 397);
            this.btnMaisRaiva.Name = "btnMaisRaiva";
            this.btnMaisRaiva.Size = new System.Drawing.Size(22, 23);
            this.btnMaisRaiva.TabIndex = 20;
            this.btnMaisRaiva.Text = "+";
            this.btnMaisRaiva.UseVisualStyleBackColor = true;
            this.btnMaisRaiva.Click += new System.EventHandler(this.btnMaisRaiva_Click);
            // 
            // progressBarRaiva
            // 
            this.progressBarRaiva.Location = new System.Drawing.Point(65, 397);
            this.progressBarRaiva.Name = "progressBarRaiva";
            this.progressBarRaiva.Size = new System.Drawing.Size(221, 23);
            this.progressBarRaiva.TabIndex = 19;
            // 
            // btnMenosRaiva
            // 
            this.btnMenosRaiva.Enabled = false;
            this.btnMenosRaiva.Location = new System.Drawing.Point(320, 397);
            this.btnMenosRaiva.Name = "btnMenosRaiva";
            this.btnMenosRaiva.Size = new System.Drawing.Size(22, 23);
            this.btnMenosRaiva.TabIndex = 18;
            this.btnMenosRaiva.Text = "-";
            this.btnMenosRaiva.UseVisualStyleBackColor = true;
            this.btnMenosRaiva.Click += new System.EventHandler(this.btnMenosRaiva_Click);
            // 
            // btnMaisFome
            // 
            this.btnMaisFome.Location = new System.Drawing.Point(292, 349);
            this.btnMaisFome.Name = "btnMaisFome";
            this.btnMaisFome.Size = new System.Drawing.Size(22, 23);
            this.btnMaisFome.TabIndex = 17;
            this.btnMaisFome.Text = "+";
            this.btnMaisFome.UseVisualStyleBackColor = true;
            this.btnMaisFome.Click += new System.EventHandler(this.btnMaisFome_Click);
            // 
            // progressBarFome
            // 
            this.progressBarFome.Location = new System.Drawing.Point(65, 349);
            this.progressBarFome.Name = "progressBarFome";
            this.progressBarFome.Size = new System.Drawing.Size(221, 23);
            this.progressBarFome.TabIndex = 16;
            // 
            // btnMenosFome
            // 
            this.btnMenosFome.Enabled = false;
            this.btnMenosFome.Location = new System.Drawing.Point(320, 349);
            this.btnMenosFome.Name = "btnMenosFome";
            this.btnMenosFome.Size = new System.Drawing.Size(22, 23);
            this.btnMenosFome.TabIndex = 15;
            this.btnMenosFome.Text = "-";
            this.btnMenosFome.UseVisualStyleBackColor = true;
            this.btnMenosFome.Click += new System.EventHandler(this.btnMenosFome_Click);
            // 
            // btnMaisSono
            // 
            this.btnMaisSono.Location = new System.Drawing.Point(292, 301);
            this.btnMaisSono.Name = "btnMaisSono";
            this.btnMaisSono.Size = new System.Drawing.Size(22, 23);
            this.btnMaisSono.TabIndex = 14;
            this.btnMaisSono.Text = "+";
            this.btnMaisSono.UseVisualStyleBackColor = true;
            this.btnMaisSono.Click += new System.EventHandler(this.btnMaisSono_Click);
            // 
            // progressBarSono
            // 
            this.progressBarSono.Location = new System.Drawing.Point(65, 301);
            this.progressBarSono.Name = "progressBarSono";
            this.progressBarSono.Size = new System.Drawing.Size(221, 23);
            this.progressBarSono.TabIndex = 13;
            // 
            // btnMenosSono
            // 
            this.btnMenosSono.Enabled = false;
            this.btnMenosSono.Location = new System.Drawing.Point(320, 301);
            this.btnMenosSono.Name = "btnMenosSono";
            this.btnMenosSono.Size = new System.Drawing.Size(22, 23);
            this.btnMenosSono.TabIndex = 12;
            this.btnMenosSono.Text = "-";
            this.btnMenosSono.UseVisualStyleBackColor = true;
            this.btnMenosSono.Click += new System.EventHandler(this.btnMenosSono_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "de Humanas";
            // 
            // ptbImagemCarta
            // 
            this.ptbImagemCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImagemCarta.ImageLocation = "";
            this.ptbImagemCarta.Location = new System.Drawing.Point(65, 34);
            this.ptbImagemCarta.Name = "ptbImagemCarta";
            this.ptbImagemCarta.Size = new System.Drawing.Size(221, 243);
            this.ptbImagemCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagemCarta.TabIndex = 0;
            this.ptbImagemCarta.TabStop = false;
            // 
            // frCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::teste2.Properties.Resources.super_trunfo_opaco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagemCarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImagemCarta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMaisHumanas;
        private System.Windows.Forms.ProgressBar progressBarHumanas;
        private System.Windows.Forms.Button btnMenosHumanas;
        private System.Windows.Forms.Button btnMaisMalandragem;
        private System.Windows.Forms.ProgressBar progressBarMalandragem;
        private System.Windows.Forms.Button btnMenosMalandragem;
        private System.Windows.Forms.Button btnMaisRaiva;
        private System.Windows.Forms.ProgressBar progressBarRaiva;
        private System.Windows.Forms.Button btnMenosRaiva;
        private System.Windows.Forms.Button btnMaisFome;
        private System.Windows.Forms.ProgressBar progressBarFome;
        private System.Windows.Forms.Button btnMenosFome;
        private System.Windows.Forms.Button btnMaisSono;
        private System.Windows.Forms.ProgressBar progressBarSono;
        private System.Windows.Forms.Button btnMenosSono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoverImgem;
        private System.Windows.Forms.Label lblSonoForca;
        private System.Windows.Forms.Label lblHumanasForca;
        private System.Windows.Forms.Label lblMalandragemForca;
        private System.Windows.Forms.Label lblRaivaForca;
        private System.Windows.Forms.Label lblFomeForca;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.OpenFileDialog openFileDiologCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodInterno;
    }
}