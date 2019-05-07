namespace Apresentacao_Usuario
{
    partial class frmInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsumos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pictureInsumo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvInsumo = new System.Windows.Forms.DataGridView();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdMaxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblInsumos = new System.Windows.Forms.Label();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd_Minima = new System.Windows.Forms.Label();
            this.txtQtdMinima = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtAdm = new System.Windows.Forms.TextBox();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblQtdNaxima = new System.Windows.Forms.Label();
            this.txtQtdMaxima = new System.Windows.Forms.TextBox();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.lblAtencao2 = new System.Windows.Forms.Label();
            this.btnAlerta2 = new System.Windows.Forms.Button();
            this.lblAtencao1 = new System.Windows.Forms.Label();
            this.btnAlerta1 = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.gpbManipulacao = new System.Windows.Forms.GroupBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).BeginInit();
            this.panelAviso.SuspendLayout();
            this.gpbManipulacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.pictureInsumo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(14, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(723, 74);
            this.panelTitulo.TabIndex = 103;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(578, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(91, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Insumos";
            // 
            // pictureInsumo
            // 
            this.pictureInsumo.Image = ((System.Drawing.Image)(resources.GetObject("pictureInsumo.Image")));
            this.pictureInsumo.Location = new System.Drawing.Point(13, 4);
            this.pictureInsumo.Name = "pictureInsumo";
            this.pictureInsumo.Size = new System.Drawing.Size(99, 66);
            this.pictureInsumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInsumo.TabIndex = 4;
            this.pictureInsumo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(169, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvInsumo
            // 
            this.dgvInsumo.AllowUserToAddRows = false;
            this.dgvInsumo.AllowUserToDeleteRows = false;
            this.dgvInsumo.AllowUserToOrderColumns = true;
            this.dgvInsumo.BackgroundColor = System.Drawing.Color.White;
            this.dgvInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInsumo,
            this.NomeInsumo,
            this.Quantidade,
            this.QtdMinima,
            this.QtdMaxima});
            this.dgvInsumo.Location = new System.Drawing.Point(14, 76);
            this.dgvInsumo.Name = "dgvInsumo";
            this.dgvInsumo.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInsumo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumo.Size = new System.Drawing.Size(723, 245);
            this.dgvInsumo.TabIndex = 100;
            this.dgvInsumo.TabStop = false;
            this.dgvInsumo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumo_CellEnter);
            // 
            // IdInsumo
            // 
            this.IdInsumo.DataPropertyName = "IdInsumo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.IdInsumo.DefaultCellStyle = dataGridViewCellStyle7;
            this.IdInsumo.HeaderText = "Código";
            this.IdInsumo.Name = "IdInsumo";
            this.IdInsumo.ReadOnly = true;
            this.IdInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NomeInsumo
            // 
            this.NomeInsumo.DataPropertyName = "NomeInsumo";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInsumo.DefaultCellStyle = dataGridViewCellStyle8;
            this.NomeInsumo.HeaderText = "Insumo";
            this.NomeInsumo.Name = "NomeInsumo";
            this.NomeInsumo.ReadOnly = true;
            this.NomeInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeInsumo.Width = 279;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle9;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QtdMinima
            // 
            this.QtdMinima.DataPropertyName = "QtdMinima";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdMinima.DefaultCellStyle = dataGridViewCellStyle10;
            this.QtdMinima.HeaderText = "Qtd.Minima";
            this.QtdMinima.Name = "QtdMinima";
            this.QtdMinima.ReadOnly = true;
            this.QtdMinima.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QtdMaxima
            // 
            this.QtdMaxima.DataPropertyName = "QtdMaxima";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdMaxima.DefaultCellStyle = dataGridViewCellStyle11;
            this.QtdMaxima.HeaderText = "QtdMáxima";
            this.QtdMaxima.Name = "QtdMaxima";
            this.QtdMaxima.ReadOnly = true;
            this.QtdMaxima.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(423, 18);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 68);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "&Cadastrar Insumo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(520, 18);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 68);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "&Alterar Insumo /Estoque";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(617, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 69);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir Insumo";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(326, 125);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(279, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(617, 154);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 69);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Location = new System.Drawing.Point(323, 109);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(128, 13);
            this.lblBuscarNome.TabIndex = 4;
            this.lblBuscarNome.Text = "Consultar pelo Nome:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(326, 177);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaId.TabIndex = 1;
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(323, 161);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(130, 13);
            this.lblBuscarId.TabIndex = 6;
            this.lblBuscarId.Text = "Consultar Por Código:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 36);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(103, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCodigo_MouseClick);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblInsumos
            // 
            this.lblInsumos.AutoSize = true;
            this.lblInsumos.Location = new System.Drawing.Point(7, 62);
            this.lblInsumos.Name = "lblInsumos";
            this.lblInsumos.Size = new System.Drawing.Size(51, 13);
            this.lblInsumos.TabIndex = 9;
            this.lblInsumos.Text = "Insumo:";
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(10, 78);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.ReadOnly = true;
            this.txtInsumo.Size = new System.Drawing.Size(223, 20);
            this.txtInsumo.TabIndex = 10;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(7, 103);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(72, 13);
            this.lblQtd.TabIndex = 11;
            this.lblQtd.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(10, 120);
            this.txtQtd.MaxLength = 8;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.ReadOnly = true;
            this.txtQtd.Size = new System.Drawing.Size(91, 20);
            this.txtQtd.TabIndex = 11;
            // 
            // lblQtd_Minima
            // 
            this.lblQtd_Minima.AutoSize = true;
            this.lblQtd_Minima.Location = new System.Drawing.Point(7, 146);
            this.lblQtd_Minima.Name = "lblQtd_Minima";
            this.lblQtd_Minima.Size = new System.Drawing.Size(94, 13);
            this.lblQtd_Minima.TabIndex = 13;
            this.lblQtd_Minima.Text = "Quant. Mínima:";
            // 
            // txtQtdMinima
            // 
            this.txtQtdMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdMinima.Location = new System.Drawing.Point(10, 161);
            this.txtQtdMinima.MaxLength = 8;
            this.txtQtdMinima.Name = "txtQtdMinima";
            this.txtQtdMinima.ReadOnly = true;
            this.txtQtdMinima.Size = new System.Drawing.Size(91, 20);
            this.txtQtdMinima.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(326, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 67);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo Insumo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtAdm
            // 
            this.txtAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdm.Enabled = false;
            this.txtAdm.Location = new System.Drawing.Point(162, 186);
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.ReadOnly = true;
            this.txtAdm.Size = new System.Drawing.Size(39, 13);
            this.txtAdm.TabIndex = 14;
            this.txtAdm.TabStop = false;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(432, 175);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Location = new System.Drawing.Point(475, 174);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(74, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblQtdNaxima
            // 
            this.lblQtdNaxima.AutoSize = true;
            this.lblQtdNaxima.Location = new System.Drawing.Point(7, 188);
            this.lblQtdNaxima.Name = "lblQtdNaxima";
            this.lblQtdNaxima.Size = new System.Drawing.Size(95, 13);
            this.lblQtdNaxima.TabIndex = 16;
            this.lblQtdNaxima.Text = "Quant. Máxima:";
            // 
            // txtQtdMaxima
            // 
            this.txtQtdMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdMaxima.Location = new System.Drawing.Point(10, 203);
            this.txtQtdMaxima.MaxLength = 8;
            this.txtQtdMaxima.Name = "txtQtdMaxima";
            this.txtQtdMaxima.ReadOnly = true;
            this.txtQtdMaxima.Size = new System.Drawing.Size(91, 20);
            this.txtQtdMaxima.TabIndex = 15;
            // 
            // panelAviso
            // 
            this.panelAviso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAviso.Controls.Add(this.lblAtencao2);
            this.panelAviso.Controls.Add(this.btnAlerta2);
            this.panelAviso.Controls.Add(this.lblAtencao1);
            this.panelAviso.Controls.Add(this.btnAlerta1);
            this.panelAviso.Location = new System.Drawing.Point(124, 143);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(181, 54);
            this.panelAviso.TabIndex = 17;
            // 
            // lblAtencao2
            // 
            this.lblAtencao2.AutoSize = true;
            this.lblAtencao2.Location = new System.Drawing.Point(30, 32);
            this.lblAtencao2.Name = "lblAtencao2";
            this.lblAtencao2.Size = new System.Drawing.Size(116, 13);
            this.lblAtencao2.TabIndex = 3;
            this.lblAtencao2.Text = "= Acima do Maximo";
            // 
            // btnAlerta2
            // 
            this.btnAlerta2.BackColor = System.Drawing.Color.Yellow;
            this.btnAlerta2.Enabled = false;
            this.btnAlerta2.FlatAppearance.BorderSize = 0;
            this.btnAlerta2.Location = new System.Drawing.Point(5, 29);
            this.btnAlerta2.Name = "btnAlerta2";
            this.btnAlerta2.Size = new System.Drawing.Size(17, 19);
            this.btnAlerta2.TabIndex = 2000;
            this.btnAlerta2.TabStop = false;
            this.btnAlerta2.UseVisualStyleBackColor = false;
            // 
            // lblAtencao1
            // 
            this.lblAtencao1.AutoSize = true;
            this.lblAtencao1.Location = new System.Drawing.Point(30, 7);
            this.lblAtencao1.Name = "lblAtencao1";
            this.lblAtencao1.Size = new System.Drawing.Size(119, 13);
            this.lblAtencao1.TabIndex = 1;
            this.lblAtencao1.Text = "= Abaixo do Mínimo";
            // 
            // btnAlerta1
            // 
            this.btnAlerta1.BackColor = System.Drawing.Color.Red;
            this.btnAlerta1.Enabled = false;
            this.btnAlerta1.FlatAppearance.BorderSize = 0;
            this.btnAlerta1.Location = new System.Drawing.Point(5, 4);
            this.btnAlerta1.Name = "btnAlerta1";
            this.btnAlerta1.Size = new System.Drawing.Size(17, 19);
            this.btnAlerta1.TabIndex = 1000;
            this.btnAlerta1.TabStop = false;
            this.btnAlerta1.UseVisualStyleBackColor = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(124, 127);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(112, 13);
            this.lblEstoque.TabIndex = 18;
            this.lblEstoque.Text = "Alérta de Estoque:";
            // 
            // gpbManipulacao
            // 
            this.gpbManipulacao.Controls.Add(this.lblEstoque);
            this.gpbManipulacao.Controls.Add(this.panelAviso);
            this.gpbManipulacao.Controls.Add(this.txtQtdMaxima);
            this.gpbManipulacao.Controls.Add(this.lblQtdNaxima);
            this.gpbManipulacao.Controls.Add(this.btnAtualizar);
            this.gpbManipulacao.Controls.Add(this.btnBuscaId);
            this.gpbManipulacao.Controls.Add(this.txtAdm);
            this.gpbManipulacao.Controls.Add(this.btnNovo);
            this.gpbManipulacao.Controls.Add(this.txtQtdMinima);
            this.gpbManipulacao.Controls.Add(this.lblQtd_Minima);
            this.gpbManipulacao.Controls.Add(this.txtQtd);
            this.gpbManipulacao.Controls.Add(this.lblQtd);
            this.gpbManipulacao.Controls.Add(this.txtInsumo);
            this.gpbManipulacao.Controls.Add(this.lblInsumos);
            this.gpbManipulacao.Controls.Add(this.txtCodigo);
            this.gpbManipulacao.Controls.Add(this.lblId);
            this.gpbManipulacao.Controls.Add(this.lblBuscarId);
            this.gpbManipulacao.Controls.Add(this.txtBuscaId);
            this.gpbManipulacao.Controls.Add(this.lblBuscarNome);
            this.gpbManipulacao.Controls.Add(this.btnSair);
            this.gpbManipulacao.Controls.Add(this.txtBuscaNome);
            this.gpbManipulacao.Controls.Add(this.btnExcluir);
            this.gpbManipulacao.Controls.Add(this.btnAlterar);
            this.gpbManipulacao.Controls.Add(this.btnInserir);
            this.gpbManipulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbManipulacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.gpbManipulacao.Location = new System.Drawing.Point(14, 328);
            this.gpbManipulacao.Name = "gpbManipulacao";
            this.gpbManipulacao.Size = new System.Drawing.Size(722, 228);
            this.gpbManipulacao.TabIndex = 105;
            this.gpbManipulacao.TabStop = false;
            this.gpbManipulacao.Text = "Manipulação";
            // 
            // frmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 565);
            this.Controls.Add(this.gpbManipulacao);
            this.Controls.Add(this.dgvInsumo);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmInsumos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsumos";
            this.Load += new System.EventHandler(this.frmInsumos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInsumos_KeyDown);
            this.MouseLeave += new System.EventHandler(this.frmInsumos_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmInsumos_MouseMove);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).EndInit();
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
            this.gpbManipulacao.ResumeLayout(false);
            this.gpbManipulacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureInsumo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvInsumo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblInsumos;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd_Minima;
        private System.Windows.Forms.TextBox txtQtdMinima;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtAdm;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblQtdNaxima;
        private System.Windows.Forms.TextBox txtQtdMaxima;
        private System.Windows.Forms.Panel panelAviso;
        private System.Windows.Forms.Label lblAtencao2;
        private System.Windows.Forms.Button btnAlerta2;
        private System.Windows.Forms.Label lblAtencao1;
        private System.Windows.Forms.Button btnAlerta1;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.GroupBox gpbManipulacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdMaxima;
    }
}