
namespace Aplicação
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gp_Pesquisa = new System.Windows.Forms.GroupBox();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.ts_Generos = new System.Windows.Forms.ToolStrip();
            this.tstb_Maculino = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_Feminino = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_Infantil = new System.Windows.Forms.ToolStripTextBox();
            this.ts_TipoITem = new System.Windows.Forms.ToolStrip();
            this.tstb_Chinelos = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_Tenis = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_Sapatilhas = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_Botas = new System.Windows.Forms.ToolStripTextBox();
            this.nud_NumItem = new System.Windows.Forms.NumericUpDown();
            this.ts_ColorItem = new System.Windows.Forms.ToolStrip();
            this.tstb_cWhite = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_cBlack = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_cRed = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_cBlue = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_cYellow = new System.Windows.Forms.ToolStripTextBox();
            this.tstb_cPink = new System.Windows.Forms.ToolStripTextBox();
            this.lbl_colorItem = new System.Windows.Forms.Label();
            this.lbl_NumberItem = new System.Windows.Forms.Label();
            this.lbl_TPItem = new System.Windows.Forms.Label();
            this.lbl_GeneroItem = new System.Windows.Forms.Label();
            this.tb_ProcurarNome = new System.Windows.Forms.TextBox();
            this.tb_ProcurarCodigo = new System.Windows.Forms.TextBox();
            this.lbl_NomeItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cdgItem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_InformativoItem = new System.Windows.Forms.GroupBox();
            this.lbl_NumberItem2 = new System.Windows.Forms.Label();
            this.lbl_GeneroItem2 = new System.Windows.Forms.Label();
            this.lbl_colorItem2 = new System.Windows.Forms.Label();
            this.lbl_TPItem2 = new System.Windows.Forms.Label();
            this.lbl_NomeItem2 = new System.Windows.Forms.Label();
            this.lbl_cdgItem2 = new System.Windows.Forms.Label();
            this.ms_Options = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.gp_Pesquisa.SuspendLayout();
            this.ts_Generos.SuspendLayout();
            this.ts_TipoITem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NumItem)).BeginInit();
            this.ts_ColorItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_InformativoItem.SuspendLayout();
            this.ms_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_Pesquisa
            // 
            this.gp_Pesquisa.Controls.Add(this.btn_Pesquisa);
            this.gp_Pesquisa.Controls.Add(this.ts_Generos);
            this.gp_Pesquisa.Controls.Add(this.ts_TipoITem);
            this.gp_Pesquisa.Controls.Add(this.nud_NumItem);
            this.gp_Pesquisa.Controls.Add(this.ts_ColorItem);
            this.gp_Pesquisa.Controls.Add(this.lbl_colorItem);
            this.gp_Pesquisa.Controls.Add(this.lbl_NumberItem);
            this.gp_Pesquisa.Controls.Add(this.lbl_TPItem);
            this.gp_Pesquisa.Controls.Add(this.lbl_GeneroItem);
            this.gp_Pesquisa.Controls.Add(this.tb_ProcurarNome);
            this.gp_Pesquisa.Controls.Add(this.tb_ProcurarCodigo);
            this.gp_Pesquisa.Controls.Add(this.lbl_NomeItem);
            this.gp_Pesquisa.Controls.Add(this.label2);
            this.gp_Pesquisa.Controls.Add(this.lbl_cdgItem);
            this.gp_Pesquisa.Location = new System.Drawing.Point(12, 44);
            this.gp_Pesquisa.Name = "gp_Pesquisa";
            this.gp_Pesquisa.Size = new System.Drawing.Size(470, 176);
            this.gp_Pesquisa.TabIndex = 0;
            this.gp_Pesquisa.TabStop = false;
            this.gp_Pesquisa.Text = "Pesquisa";
            this.gp_Pesquisa.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Location = new System.Drawing.Point(6, 133);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(450, 32);
            this.btn_Pesquisa.TabIndex = 19;
            this.btn_Pesquisa.Text = "Pesquisar";
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            // 
            // ts_Generos
            // 
            this.ts_Generos.AutoSize = false;
            this.ts_Generos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ts_Generos.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_Generos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Generos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_Maculino,
            this.tstb_Feminino,
            this.tstb_Infantil});
            this.ts_Generos.Location = new System.Drawing.Point(387, 42);
            this.ts_Generos.Name = "ts_Generos";
            this.ts_Generos.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_Generos.Size = new System.Drawing.Size(69, 23);
            this.ts_Generos.TabIndex = 18;
            this.ts_Generos.Text = "toolStrip1";
            // 
            // tstb_Maculino
            // 
            this.tstb_Maculino.Name = "tstb_Maculino";
            this.tstb_Maculino.Size = new System.Drawing.Size(100, 23);
            this.tstb_Maculino.Text = "Masculino";
            // 
            // tstb_Feminino
            // 
            this.tstb_Feminino.Name = "tstb_Feminino";
            this.tstb_Feminino.Size = new System.Drawing.Size(100, 23);
            this.tstb_Feminino.Text = "Feminino";
            // 
            // tstb_Infantil
            // 
            this.tstb_Infantil.Name = "tstb_Infantil";
            this.tstb_Infantil.Size = new System.Drawing.Size(100, 23);
            this.tstb_Infantil.Text = "Infantil";
            // 
            // ts_TipoITem
            // 
            this.ts_TipoITem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts_TipoITem.AutoSize = false;
            this.ts_TipoITem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ts_TipoITem.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_TipoITem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_TipoITem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_Chinelos,
            this.tstb_Tenis,
            this.tstb_Sapatilhas,
            this.tstb_Botas});
            this.ts_TipoITem.Location = new System.Drawing.Point(262, 40);
            this.ts_TipoITem.Name = "ts_TipoITem";
            this.ts_TipoITem.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_TipoITem.Size = new System.Drawing.Size(74, 25);
            this.ts_TipoITem.TabIndex = 17;
            this.ts_TipoITem.Text = "ts_TipoITem";
            this.ts_TipoITem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ts_TipoITem_ItemClicked);
            // 
            // tstb_Chinelos
            // 
            this.tstb_Chinelos.Name = "tstb_Chinelos";
            this.tstb_Chinelos.Size = new System.Drawing.Size(100, 23);
            this.tstb_Chinelos.Text = "Chinelos";
            // 
            // tstb_Tenis
            // 
            this.tstb_Tenis.Name = "tstb_Tenis";
            this.tstb_Tenis.Size = new System.Drawing.Size(100, 23);
            this.tstb_Tenis.Text = "Tênis";
            // 
            // tstb_Sapatilhas
            // 
            this.tstb_Sapatilhas.Name = "tstb_Sapatilhas";
            this.tstb_Sapatilhas.Size = new System.Drawing.Size(100, 23);
            this.tstb_Sapatilhas.Text = "Sapatilhas";
            // 
            // tstb_Botas
            // 
            this.tstb_Botas.Name = "tstb_Botas";
            this.tstb_Botas.Size = new System.Drawing.Size(100, 23);
            this.tstb_Botas.Text = "Botas";
            // 
            // nud_NumItem
            // 
            this.nud_NumItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nud_NumItem.Location = new System.Drawing.Point(387, 91);
            this.nud_NumItem.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_NumItem.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_NumItem.Name = "nud_NumItem";
            this.nud_NumItem.Size = new System.Drawing.Size(69, 23);
            this.nud_NumItem.TabIndex = 16;
            this.nud_NumItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_NumItem.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_NumItem.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ts_ColorItem
            // 
            this.ts_ColorItem.AutoSize = false;
            this.ts_ColorItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ts_ColorItem.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_ColorItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_ColorItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_cWhite,
            this.tstb_cBlack,
            this.tstb_cRed,
            this.tstb_cBlue,
            this.tstb_cYellow,
            this.tstb_cPink});
            this.ts_ColorItem.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ts_ColorItem.Location = new System.Drawing.Point(261, 87);
            this.ts_ColorItem.Name = "ts_ColorItem";
            this.ts_ColorItem.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ts_ColorItem.Size = new System.Drawing.Size(74, 25);
            this.ts_ColorItem.TabIndex = 15;
            this.ts_ColorItem.Text = "Escolha a cor";
            this.ts_ColorItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tstb_cWhite
            // 
            this.tstb_cWhite.Name = "tstb_cWhite";
            this.tstb_cWhite.ReadOnly = true;
            this.tstb_cWhite.Size = new System.Drawing.Size(100, 23);
            this.tstb_cWhite.Text = "Branco";
            // 
            // tstb_cBlack
            // 
            this.tstb_cBlack.Name = "tstb_cBlack";
            this.tstb_cBlack.ReadOnly = true;
            this.tstb_cBlack.Size = new System.Drawing.Size(100, 23);
            this.tstb_cBlack.Text = "Preto";
            // 
            // tstb_cRed
            // 
            this.tstb_cRed.Name = "tstb_cRed";
            this.tstb_cRed.ReadOnly = true;
            this.tstb_cRed.Size = new System.Drawing.Size(100, 23);
            this.tstb_cRed.Text = "Vermelho";
            // 
            // tstb_cBlue
            // 
            this.tstb_cBlue.Name = "tstb_cBlue";
            this.tstb_cBlue.ReadOnly = true;
            this.tstb_cBlue.Size = new System.Drawing.Size(100, 23);
            this.tstb_cBlue.Text = "Azul";
            // 
            // tstb_cYellow
            // 
            this.tstb_cYellow.Name = "tstb_cYellow";
            this.tstb_cYellow.ReadOnly = true;
            this.tstb_cYellow.Size = new System.Drawing.Size(100, 23);
            this.tstb_cYellow.Text = "Amarelo";
            // 
            // tstb_cPink
            // 
            this.tstb_cPink.Name = "tstb_cPink";
            this.tstb_cPink.ReadOnly = true;
            this.tstb_cPink.Size = new System.Drawing.Size(100, 23);
            this.tstb_cPink.Text = "Rosa";
            // 
            // lbl_colorItem
            // 
            this.lbl_colorItem.AutoSize = true;
            this.lbl_colorItem.Location = new System.Drawing.Point(282, 71);
            this.lbl_colorItem.Name = "lbl_colorItem";
            this.lbl_colorItem.Size = new System.Drawing.Size(26, 15);
            this.lbl_colorItem.TabIndex = 14;
            this.lbl_colorItem.Text = "Cor";
            // 
            // lbl_NumberItem
            // 
            this.lbl_NumberItem.AutoSize = true;
            this.lbl_NumberItem.Location = new System.Drawing.Point(387, 71);
            this.lbl_NumberItem.Name = "lbl_NumberItem";
            this.lbl_NumberItem.Size = new System.Drawing.Size(69, 15);
            this.lbl_NumberItem.TabIndex = 13;
            this.lbl_NumberItem.Text = "Numeração";
            // 
            // lbl_TPItem
            // 
            this.lbl_TPItem.AutoSize = true;
            this.lbl_TPItem.Location = new System.Drawing.Point(261, 25);
            this.lbl_TPItem.Name = "lbl_TPItem";
            this.lbl_TPItem.Size = new System.Drawing.Size(74, 15);
            this.lbl_TPItem.TabIndex = 12;
            this.lbl_TPItem.Text = "Tipo do item";
            // 
            // lbl_GeneroItem
            // 
            this.lbl_GeneroItem.AutoSize = true;
            this.lbl_GeneroItem.Location = new System.Drawing.Point(397, 25);
            this.lbl_GeneroItem.Name = "lbl_GeneroItem";
            this.lbl_GeneroItem.Size = new System.Drawing.Size(45, 15);
            this.lbl_GeneroItem.TabIndex = 11;
            this.lbl_GeneroItem.Text = "Genero";
            this.lbl_GeneroItem.Click += new System.EventHandler(this.lbl_GeneroItem_Click);
            // 
            // tb_ProcurarNome
            // 
            this.tb_ProcurarNome.Location = new System.Drawing.Point(6, 89);
            this.tb_ProcurarNome.Name = "tb_ProcurarNome";
            this.tb_ProcurarNome.Size = new System.Drawing.Size(199, 23);
            this.tb_ProcurarNome.TabIndex = 8;
            // 
            // tb_ProcurarCodigo
            // 
            this.tb_ProcurarCodigo.Location = new System.Drawing.Point(6, 43);
            this.tb_ProcurarCodigo.Name = "tb_ProcurarCodigo";
            this.tb_ProcurarCodigo.Size = new System.Drawing.Size(199, 23);
            this.tb_ProcurarCodigo.TabIndex = 7;
            // 
            // lbl_NomeItem
            // 
            this.lbl_NomeItem.AutoSize = true;
            this.lbl_NomeItem.Location = new System.Drawing.Point(90, 71);
            this.lbl_NomeItem.Name = "lbl_NomeItem";
            this.lbl_NomeItem.Size = new System.Drawing.Size(40, 15);
            this.lbl_NomeItem.TabIndex = 2;
            this.lbl_NomeItem.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // lbl_cdgItem
            // 
            this.lbl_cdgItem.AutoSize = true;
            this.lbl_cdgItem.Location = new System.Drawing.Point(69, 25);
            this.lbl_cdgItem.Name = "lbl_cdgItem";
            this.lbl_cdgItem.Size = new System.Drawing.Size(90, 15);
            this.lbl_cdgItem.TabIndex = 0;
            this.lbl_cdgItem.Text = "Codigo do Item";
            this.lbl_cdgItem.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 289);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gb_InformativoItem
            // 
            this.gb_InformativoItem.Controls.Add(this.lbl_NumberItem2);
            this.gb_InformativoItem.Controls.Add(this.lbl_GeneroItem2);
            this.gb_InformativoItem.Controls.Add(this.lbl_colorItem2);
            this.gb_InformativoItem.Controls.Add(this.lbl_TPItem2);
            this.gb_InformativoItem.Controls.Add(this.lbl_NomeItem2);
            this.gb_InformativoItem.Controls.Add(this.lbl_cdgItem2);
            this.gb_InformativoItem.Location = new System.Drawing.Point(12, 518);
            this.gb_InformativoItem.Name = "gb_InformativoItem";
            this.gb_InformativoItem.Size = new System.Drawing.Size(470, 73);
            this.gb_InformativoItem.TabIndex = 2;
            this.gb_InformativoItem.TabStop = false;
            this.gb_InformativoItem.Text = "Informativo Item";
            this.gb_InformativoItem.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lbl_NumberItem2
            // 
            this.lbl_NumberItem2.AutoSize = true;
            this.lbl_NumberItem2.Location = new System.Drawing.Point(381, 38);
            this.lbl_NumberItem2.Name = "lbl_NumberItem2";
            this.lbl_NumberItem2.Size = new System.Drawing.Size(54, 15);
            this.lbl_NumberItem2.TabIndex = 5;
            this.lbl_NumberItem2.Text = "Numero:";
            // 
            // lbl_GeneroItem2
            // 
            this.lbl_GeneroItem2.AutoSize = true;
            this.lbl_GeneroItem2.Location = new System.Drawing.Point(381, 23);
            this.lbl_GeneroItem2.Name = "lbl_GeneroItem2";
            this.lbl_GeneroItem2.Size = new System.Drawing.Size(48, 15);
            this.lbl_GeneroItem2.TabIndex = 4;
            this.lbl_GeneroItem2.Text = "Genero:";
            // 
            // lbl_colorItem2
            // 
            this.lbl_colorItem2.AutoSize = true;
            this.lbl_colorItem2.Location = new System.Drawing.Point(179, 42);
            this.lbl_colorItem2.Name = "lbl_colorItem2";
            this.lbl_colorItem2.Size = new System.Drawing.Size(29, 15);
            this.lbl_colorItem2.TabIndex = 3;
            this.lbl_colorItem2.Text = "Cor:";
            this.lbl_colorItem2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_TPItem2
            // 
            this.lbl_TPItem2.AutoSize = true;
            this.lbl_TPItem2.Location = new System.Drawing.Point(175, 23);
            this.lbl_TPItem2.Name = "lbl_TPItem2";
            this.lbl_TPItem2.Size = new System.Drawing.Size(33, 15);
            this.lbl_TPItem2.TabIndex = 2;
            this.lbl_TPItem2.Text = "Tipo:";
            // 
            // lbl_NomeItem2
            // 
            this.lbl_NomeItem2.AutoSize = true;
            this.lbl_NomeItem2.Location = new System.Drawing.Point(6, 42);
            this.lbl_NomeItem2.Name = "lbl_NomeItem2";
            this.lbl_NomeItem2.Size = new System.Drawing.Size(43, 15);
            this.lbl_NomeItem2.TabIndex = 1;
            this.lbl_NomeItem2.Text = "Nome:";
            // 
            // lbl_cdgItem2
            // 
            this.lbl_cdgItem2.AutoSize = true;
            this.lbl_cdgItem2.Location = new System.Drawing.Point(6, 23);
            this.lbl_cdgItem2.Name = "lbl_cdgItem2";
            this.lbl_cdgItem2.Size = new System.Drawing.Size(49, 15);
            this.lbl_cdgItem2.TabIndex = 0;
            this.lbl_cdgItem2.Text = "Código:";
            this.lbl_cdgItem2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ms_Options
            // 
            this.ms_Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.ms_Options.Location = new System.Drawing.Point(0, 0);
            this.ms_Options.Name = "ms_Options";
            this.ms_Options.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ms_Options.Size = new System.Drawing.Size(1322, 24);
            this.ms_Options.TabIndex = 3;
            this.ms_Options.Text = "Options";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.toolsToolStripMenuItem.Text = "&Ferramentas";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Analisar Sites",
            "Postagens no Facebook",
            "Postagens no Instagram",
            "Organizador de Rifas"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 593);
            this.Controls.Add(this.gb_InformativoItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gp_Pesquisa);
            this.Controls.Add(this.ms_Options);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp_Pesquisa.ResumeLayout(false);
            this.gp_Pesquisa.PerformLayout();
            this.ts_Generos.ResumeLayout(false);
            this.ts_Generos.PerformLayout();
            this.ts_TipoITem.ResumeLayout(false);
            this.ts_TipoITem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NumItem)).EndInit();
            this.ts_ColorItem.ResumeLayout(false);
            this.ts_ColorItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_InformativoItem.ResumeLayout(false);
            this.gb_InformativoItem.PerformLayout();
            this.ms_Options.ResumeLayout(false);
            this.ms_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_Pesquisa;
        private System.Windows.Forms.Label lbl_cdgItem;
        private System.Windows.Forms.TextBox tb_ProcurarNome;
        private System.Windows.Forms.TextBox tb_ProcurarCodigo;
        private System.Windows.Forms.Label lbl_NomeItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_GeneroItem;
        private System.Windows.Forms.Label lbl_colorItem;
        private System.Windows.Forms.Label lbl_NumberItem;
        private System.Windows.Forms.Label lbl_TPItem;
        private System.Windows.Forms.ToolStrip ts_ColorItem;
        private System.Windows.Forms.NumericUpDown nud_NumItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox tstb_cWhite;
        private System.Windows.Forms.ToolStripTextBox tstb_cBlack;
        private System.Windows.Forms.ToolStripTextBox tstb_cRed;
        private System.Windows.Forms.ToolStripTextBox tstb_cBlue;
        private System.Windows.Forms.ToolStripTextBox tstb_cYellow;
        private System.Windows.Forms.ToolStripTextBox tstb_cPink;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.ToolStrip ts_Generos;
        private System.Windows.Forms.ToolStrip ts_TipoITem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox tstb_Sapatilhas;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_InformativoItem;
        private System.Windows.Forms.Label lbl_NumberItem2;
        private System.Windows.Forms.Label lbl_GeneroItem2;
        private System.Windows.Forms.Label lbl_colorItem2;
        private System.Windows.Forms.Label lbl_TPItem2;
        private System.Windows.Forms.Label lbl_NomeItem2;
        private System.Windows.Forms.Label lbl_cdgItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripTextBox tstb_Feminino;
        private System.Windows.Forms.ToolStripTextBox tstb_Infantil;
        private System.Windows.Forms.ToolStripTextBox tstb_Chinelos;
        private System.Windows.Forms.ToolStripTextBox tstb_Tenis;
        private System.Windows.Forms.ToolStripTextBox tstb_Botas;
        private System.Windows.Forms.ToolStripTextBox tstb_Maculino;
        private System.Windows.Forms.MenuStrip ms_Options;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

