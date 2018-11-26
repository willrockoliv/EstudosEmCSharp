namespace MediaPlayer.Telas
{
    partial class frPlaylist
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPlaylistNomeNovo = new System.Windows.Forms.TextBox();
            this.tbpAlterar = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIDAlterar = new System.Windows.Forms.TextBox();
            this.txtDescricaoAlterar = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivoAlterar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracaoAlterar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxPlaylistNomeAlterar = new System.Windows.Forms.ComboBox();
            this.cbxMidiasPlaylistAlterar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOutrasMidiasAlterar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbpNovo = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtIDNovo = new System.Windows.Forms.TextBox();
            this.txtDescricaoNovo = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivoNovo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuracaoNovo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxMidiaNovo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ltbPlaylist = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDuracaoTotal = new System.Windows.Forms.Label();
            this.btnExluirPlaylist = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAddMidiaNovo = new System.Windows.Forms.Button();
            this.btnAddMidiaAlterar = new System.Windows.Forms.Button();
            this.btnExluirMidiaAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpAlterar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tbpNovo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Midias";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnExluirPlaylist);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.lblDuracaoTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ltbPlaylist);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 442);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist";
            // 
            // txtPlaylistNomeNovo
            // 
            this.txtPlaylistNomeNovo.BackColor = System.Drawing.Color.White;
            this.txtPlaylistNomeNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaylistNomeNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistNomeNovo.Location = new System.Drawing.Point(27, 33);
            this.txtPlaylistNomeNovo.Name = "txtPlaylistNomeNovo";
            this.txtPlaylistNomeNovo.ReadOnly = true;
            this.txtPlaylistNomeNovo.Size = new System.Drawing.Size(219, 22);
            this.txtPlaylistNomeNovo.TabIndex = 26;
            // 
            // tbpAlterar
            // 
            this.tbpAlterar.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpAlterar.Controls.Add(this.groupBox4);
            this.tbpAlterar.Controls.Add(this.groupBox3);
            this.tbpAlterar.Location = new System.Drawing.Point(4, 22);
            this.tbpAlterar.Name = "tbpAlterar";
            this.tbpAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterar.Size = new System.Drawing.Size(964, 206);
            this.tbpAlterar.TabIndex = 1;
            this.tbpAlterar.Text = "Alterar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDuracaoAlterar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCaminhoArquivoAlterar);
            this.groupBox3.Controls.Add(this.txtDescricaoAlterar);
            this.groupBox3.Controls.Add(this.txtIDAlterar);
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(952, 112);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhes";
            // 
            // txtIDAlterar
            // 
            this.txtIDAlterar.BackColor = System.Drawing.Color.White;
            this.txtIDAlterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAlterar.Enabled = false;
            this.txtIDAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAlterar.Location = new System.Drawing.Point(33, 36);
            this.txtIDAlterar.Name = "txtIDAlterar";
            this.txtIDAlterar.ReadOnly = true;
            this.txtIDAlterar.Size = new System.Drawing.Size(75, 22);
            this.txtIDAlterar.TabIndex = 6;
            // 
            // txtDescricaoAlterar
            // 
            this.txtDescricaoAlterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricaoAlterar.Enabled = false;
            this.txtDescricaoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoAlterar.Location = new System.Drawing.Point(114, 36);
            this.txtDescricaoAlterar.Name = "txtDescricaoAlterar";
            this.txtDescricaoAlterar.Size = new System.Drawing.Size(651, 22);
            this.txtDescricaoAlterar.TabIndex = 5;
            // 
            // txtCaminhoArquivoAlterar
            // 
            this.txtCaminhoArquivoAlterar.BackColor = System.Drawing.Color.White;
            this.txtCaminhoArquivoAlterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminhoArquivoAlterar.Enabled = false;
            this.txtCaminhoArquivoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivoAlterar.Location = new System.Drawing.Point(33, 77);
            this.txtCaminhoArquivoAlterar.Name = "txtCaminhoArquivoAlterar";
            this.txtCaminhoArquivoAlterar.ReadOnly = true;
            this.txtCaminhoArquivoAlterar.Size = new System.Drawing.Size(885, 22);
            this.txtCaminhoArquivoAlterar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Caminho do arquivo";
            // 
            // txtDuracaoAlterar
            // 
            this.txtDuracaoAlterar.BackColor = System.Drawing.Color.White;
            this.txtDuracaoAlterar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracaoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracaoAlterar.Location = new System.Drawing.Point(771, 36);
            this.txtDuracaoAlterar.Name = "txtDuracaoAlterar";
            this.txtDuracaoAlterar.ReadOnly = true;
            this.txtDuracaoAlterar.Size = new System.Drawing.Size(147, 22);
            this.txtDuracaoAlterar.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(768, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Duração";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddMidiaAlterar);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cbxOutrasMidiasAlterar);
            this.groupBox4.Controls.Add(this.btnExluirMidiaAlterar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbxMidiasPlaylistAlterar);
            this.groupBox4.Controls.Add(this.cbxPlaylistNomeAlterar);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(952, 64);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parâmetros";
            // 
            // cbxPlaylistNomeAlterar
            // 
            this.cbxPlaylistNomeAlterar.FormattingEnabled = true;
            this.cbxPlaylistNomeAlterar.Location = new System.Drawing.Point(27, 33);
            this.cbxPlaylistNomeAlterar.Name = "cbxPlaylistNomeAlterar";
            this.cbxPlaylistNomeAlterar.Size = new System.Drawing.Size(219, 21);
            this.cbxPlaylistNomeAlterar.TabIndex = 0;
            // 
            // cbxMidiasPlaylistAlterar
            // 
            this.cbxMidiasPlaylistAlterar.FormattingEnabled = true;
            this.cbxMidiasPlaylistAlterar.Location = new System.Drawing.Point(252, 33);
            this.cbxMidiasPlaylistAlterar.Name = "cbxMidiasPlaylistAlterar";
            this.cbxMidiasPlaylistAlterar.Size = new System.Drawing.Size(284, 21);
            this.cbxMidiasPlaylistAlterar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mídias";
            // 
            // cbxOutrasMidiasAlterar
            // 
            this.cbxOutrasMidiasAlterar.FormattingEnabled = true;
            this.cbxOutrasMidiasAlterar.Location = new System.Drawing.Point(576, 33);
            this.cbxOutrasMidiasAlterar.Name = "cbxOutrasMidiasAlterar";
            this.cbxOutrasMidiasAlterar.Size = new System.Drawing.Size(284, 21);
            this.cbxOutrasMidiasAlterar.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(573, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Outras Mídias";
            // 
            // tbpNovo
            // 
            this.tbpNovo.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpNovo.Controls.Add(this.groupBox5);
            this.tbpNovo.Controls.Add(this.groupBox6);
            this.tbpNovo.Location = new System.Drawing.Point(4, 22);
            this.tbpNovo.Name = "tbpNovo";
            this.tbpNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNovo.Size = new System.Drawing.Size(964, 206);
            this.tbpNovo.TabIndex = 0;
            this.tbpNovo.Text = "Novo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtDuracaoNovo);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txtCaminhoArquivoNovo);
            this.groupBox6.Controls.Add(this.txtDescricaoNovo);
            this.groupBox6.Controls.Add(this.txtIDNovo);
            this.groupBox6.Location = new System.Drawing.Point(6, 76);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(952, 112);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detalhes";
            // 
            // txtIDNovo
            // 
            this.txtIDNovo.BackColor = System.Drawing.Color.White;
            this.txtIDNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDNovo.Enabled = false;
            this.txtIDNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNovo.Location = new System.Drawing.Point(33, 36);
            this.txtIDNovo.Name = "txtIDNovo";
            this.txtIDNovo.ReadOnly = true;
            this.txtIDNovo.Size = new System.Drawing.Size(75, 22);
            this.txtIDNovo.TabIndex = 6;
            // 
            // txtDescricaoNovo
            // 
            this.txtDescricaoNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricaoNovo.Enabled = false;
            this.txtDescricaoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoNovo.Location = new System.Drawing.Point(114, 36);
            this.txtDescricaoNovo.Name = "txtDescricaoNovo";
            this.txtDescricaoNovo.Size = new System.Drawing.Size(651, 22);
            this.txtDescricaoNovo.TabIndex = 5;
            // 
            // txtCaminhoArquivoNovo
            // 
            this.txtCaminhoArquivoNovo.BackColor = System.Drawing.Color.White;
            this.txtCaminhoArquivoNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminhoArquivoNovo.Enabled = false;
            this.txtCaminhoArquivoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivoNovo.Location = new System.Drawing.Point(33, 77);
            this.txtCaminhoArquivoNovo.Name = "txtCaminhoArquivoNovo";
            this.txtCaminhoArquivoNovo.ReadOnly = true;
            this.txtCaminhoArquivoNovo.Size = new System.Drawing.Size(885, 22);
            this.txtCaminhoArquivoNovo.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Descrição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Caminho do arquivo";
            // 
            // txtDuracaoNovo
            // 
            this.txtDuracaoNovo.BackColor = System.Drawing.Color.White;
            this.txtDuracaoNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracaoNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracaoNovo.Location = new System.Drawing.Point(771, 36);
            this.txtDuracaoNovo.Name = "txtDuracaoNovo";
            this.txtDuracaoNovo.ReadOnly = true;
            this.txtDuracaoNovo.Size = new System.Drawing.Size(147, 22);
            this.txtDuracaoNovo.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(768, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Duração";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPlaylistNomeNovo);
            this.groupBox5.Controls.Add(this.btnAddMidiaNovo);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbxMidiaNovo);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(952, 64);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // cbxMidiaNovo
            // 
            this.cbxMidiaNovo.FormattingEnabled = true;
            this.cbxMidiaNovo.Location = new System.Drawing.Point(252, 33);
            this.cbxMidiaNovo.Name = "cbxMidiaNovo";
            this.cbxMidiaNovo.Size = new System.Drawing.Size(284, 21);
            this.cbxMidiaNovo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Playlist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mídias";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpNovo);
            this.tabControl1.Controls.Add(this.tbpAlterar);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 232);
            this.tabControl1.TabIndex = 0;
            // 
            // ltbPlaylist
            // 
            this.ltbPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPlaylist.FormattingEnabled = true;
            this.ltbPlaylist.ItemHeight = 25;
            this.ltbPlaylist.Location = new System.Drawing.Point(6, 19);
            this.ltbPlaylist.Name = "ltbPlaylist";
            this.ltbPlaylist.Size = new System.Drawing.Size(871, 404);
            this.ltbPlaylist.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(892, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Duração total:";
            // 
            // lblDuracaoTotal
            // 
            this.lblDuracaoTotal.AutoSize = true;
            this.lblDuracaoTotal.Location = new System.Drawing.Point(915, 252);
            this.lblDuracaoTotal.Name = "lblDuracaoTotal";
            this.lblDuracaoTotal.Size = new System.Drawing.Size(28, 13);
            this.lblDuracaoTotal.TabIndex = 4;
            this.lblDuracaoTotal.Text = "0,00";
            // 
            // btnExluirPlaylist
            // 
            this.btnExluirPlaylist.Image = global::MediaPlayer.Properties.Resources.if_ic_delete_48px_352303__1_;
            this.btnExluirPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExluirPlaylist.Location = new System.Drawing.Point(883, 74);
            this.btnExluirPlaylist.Name = "btnExluirPlaylist";
            this.btnExluirPlaylist.Size = new System.Drawing.Size(94, 49);
            this.btnExluirPlaylist.TabIndex = 12;
            this.btnExluirPlaylist.Text = "Cancelar";
            this.btnExluirPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExluirPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MediaPlayer.Properties.Resources.if_cancel_326554;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(883, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::MediaPlayer.Properties.Resources._1499384406_Select;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(883, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 49);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar    ";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAddMidiaNovo
            // 
            this.btnAddMidiaNovo.Image = global::MediaPlayer.Properties.Resources.stock_plus_13_1_;
            this.btnAddMidiaNovo.Location = new System.Drawing.Point(542, 26);
            this.btnAddMidiaNovo.Name = "btnAddMidiaNovo";
            this.btnAddMidiaNovo.Size = new System.Drawing.Size(28, 28);
            this.btnAddMidiaNovo.TabIndex = 17;
            this.btnAddMidiaNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMidiaNovo.UseVisualStyleBackColor = true;
            // 
            // btnAddMidiaAlterar
            // 
            this.btnAddMidiaAlterar.Image = global::MediaPlayer.Properties.Resources.stock_plus_13_1_;
            this.btnAddMidiaAlterar.Location = new System.Drawing.Point(866, 26);
            this.btnAddMidiaAlterar.Name = "btnAddMidiaAlterar";
            this.btnAddMidiaAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnAddMidiaAlterar.TabIndex = 17;
            this.btnAddMidiaAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMidiaAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExluirMidiaAlterar
            // 
            this.btnExluirMidiaAlterar.Image = global::MediaPlayer.Properties.Resources.linha_16__1__1_;
            this.btnExluirMidiaAlterar.Location = new System.Drawing.Point(542, 26);
            this.btnExluirMidiaAlterar.Name = "btnExluirMidiaAlterar";
            this.btnExluirMidiaAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnExluirMidiaAlterar.TabIndex = 11;
            this.btnExluirMidiaAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExluirMidiaAlterar.UseVisualStyleBackColor = true;
            // 
            // frPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpAlterar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tbpNovo.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPlaylistNomeNovo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpNovo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddMidiaNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMidiaNovo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDuracaoNovo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCaminhoArquivoNovo;
        private System.Windows.Forms.TextBox txtDescricaoNovo;
        private System.Windows.Forms.TextBox txtIDNovo;
        private System.Windows.Forms.TabPage tbpAlterar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddMidiaAlterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxOutrasMidiasAlterar;
        private System.Windows.Forms.Button btnExluirMidiaAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMidiasPlaylistAlterar;
        private System.Windows.Forms.ComboBox cbxPlaylistNomeAlterar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDuracaoAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaminhoArquivoAlterar;
        private System.Windows.Forms.TextBox txtDescricaoAlterar;
        private System.Windows.Forms.TextBox txtIDAlterar;
        private System.Windows.Forms.Label lblDuracaoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ltbPlaylist;
        private System.Windows.Forms.Button btnExluirPlaylist;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}