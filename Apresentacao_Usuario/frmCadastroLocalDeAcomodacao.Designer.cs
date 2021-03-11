namespace Apresentacao_Usuario
{
    partial class frmCadastroLocalDeAcomodacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroLocalDeAcomodacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLocalAcomodacao = new System.Windows.Forms.DataGridView();
            this.dgvAcomodGeral = new System.Windows.Forms.DataGridView();
            this.LocalAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GrpLocalAcomodacao = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtAcomodacao = new System.Windows.Forms.TextBox();
            this.lblAcomodacao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpManipulacao = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.txtBuscaVer = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalAcomodacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodGeral)).BeginInit();
            this.GrpLocalAcomodacao.SuspendLayout();
            this.grpManipulacao.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.dgvLocalAcomodacao);
            this.panelTitulo.Controls.Add(this.dgvAcomodGeral);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(564, 74);
            this.panelTitulo.TabIndex = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLocalAcomodacao
            // 
            this.dgvLocalAcomodacao.AllowUserToAddRows = false;
            this.dgvLocalAcomodacao.AllowUserToDeleteRows = false;
            this.dgvLocalAcomodacao.BackgroundColor = System.Drawing.Color.Red;
            this.dgvLocalAcomodacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalAcomodacao.Location = new System.Drawing.Point(14, 10);
            this.dgvLocalAcomodacao.Name = "dgvLocalAcomodacao";
            this.dgvLocalAcomodacao.ReadOnly = true;
            this.dgvLocalAcomodacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalAcomodacao.Size = new System.Drawing.Size(15, 14);
            this.dgvLocalAcomodacao.TabIndex = 109;
            this.dgvLocalAcomodacao.TabStop = false;
            this.dgvLocalAcomodacao.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalAcomodacao_CellEnter);
            // 
            // dgvAcomodGeral
            // 
            this.dgvAcomodGeral.AllowUserToAddRows = false;
            this.dgvAcomodGeral.AllowUserToDeleteRows = false;
            this.dgvAcomodGeral.BackgroundColor = System.Drawing.Color.Blue;
            this.dgvAcomodGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcomodGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalAcomodado,
            this.IdPaciente,
            this.NomePaciente,
            this.Leito,
            this.Quarto});
            this.dgvAcomodGeral.Location = new System.Drawing.Point(57, 10);
            this.dgvAcomodGeral.Name = "dgvAcomodGeral";
            this.dgvAcomodGeral.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAcomodGeral.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAcomodGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcomodGeral.Size = new System.Drawing.Size(14, 14);
            this.dgvAcomodGeral.TabIndex = 2356;
            // 
            // LocalAcomodado
            // 
            this.LocalAcomodado.DataPropertyName = "LocalAcomodado";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.LocalAcomodado.DefaultCellStyle = dataGridViewCellStyle1;
            this.LocalAcomodado.HeaderText = "Acomodação";
            this.LocalAcomodado.Name = "LocalAcomodado";
            this.LocalAcomodado.ReadOnly = true;
            this.LocalAcomodado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalAcomodado.Width = 115;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdPaciente.HeaderText = "Código";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdPaciente.Width = 110;
            // 
            // NomePaciente
            // 
            this.NomePaciente.DataPropertyName = "NomePaciente";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomePaciente.HeaderText = "Nome Paciênte";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            this.NomePaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomePaciente.Width = 194;
            // 
            // Leito
            // 
            this.Leito.DataPropertyName = "Leito";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leito.DefaultCellStyle = dataGridViewCellStyle4;
            this.Leito.HeaderText = "Leito";
            this.Leito.Name = "Leito";
            this.Leito.ReadOnly = true;
            this.Leito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Leito.Width = 50;
            // 
            // Quarto
            // 
            this.Quarto.DataPropertyName = "Quarto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quarto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Quarto.HeaderText = "Quarto";
            this.Quarto.Name = "Quarto";
            this.Quarto.ReadOnly = true;
            this.Quarto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quarto.Width = 50;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(354, 43);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(196, 16);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Cadastro Locais de Acomodação";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(95, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // GrpLocalAcomodacao
            // 
            this.GrpLocalAcomodacao.Controls.Add(this.txtDias);
            this.GrpLocalAcomodacao.Controls.Add(this.lblInformacao);
            this.GrpLocalAcomodacao.Controls.Add(this.txtCast);
            this.GrpLocalAcomodacao.Controls.Add(this.txtValor);
            this.GrpLocalAcomodacao.Controls.Add(this.lblValor);
            this.GrpLocalAcomodacao.Controls.Add(this.txtAcomodacao);
            this.GrpLocalAcomodacao.Controls.Add(this.lblAcomodacao);
            this.GrpLocalAcomodacao.Controls.Add(this.txtCodigo);
            this.GrpLocalAcomodacao.Controls.Add(this.lblCodigo);
            this.GrpLocalAcomodacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLocalAcomodacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GrpLocalAcomodacao.Location = new System.Drawing.Point(3, 82);
            this.GrpLocalAcomodacao.Name = "GrpLocalAcomodacao";
            this.GrpLocalAcomodacao.Size = new System.Drawing.Size(564, 100);
            this.GrpLocalAcomodacao.TabIndex = 111;
            this.GrpLocalAcomodacao.TabStop = false;
            this.GrpLocalAcomodacao.Text = "Cadastro Medicamentos:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(492, 57);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(19, 20);
            this.txtDias.TabIndex = 15;
            this.txtDias.TabStop = false;
            this.txtDias.Text = "0";
            this.txtDias.Visible = false;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Location = new System.Drawing.Point(411, 16);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(147, 13);
            this.lblInformacao.TabIndex = 14;
            this.lblInformacao.Text = "Caixa para Cast Invisivel";
            this.lblInformacao.Visible = false;
            // 
            // txtCast
            // 
            this.txtCast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCast.Location = new System.Drawing.Point(411, 31);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(100, 20);
            this.txtCast.TabIndex = 13;
            this.txtCast.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(103, 70);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(104, 20);
            this.txtValor.TabIndex = 12;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(11, 73);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor:";
            // 
            // txtAcomodacao
            // 
            this.txtAcomodacao.Location = new System.Drawing.Point(103, 44);
            this.txtAcomodacao.Name = "txtAcomodacao";
            this.txtAcomodacao.ReadOnly = true;
            this.txtAcomodacao.Size = new System.Drawing.Size(266, 20);
            this.txtAcomodacao.TabIndex = 11;
            // 
            // lblAcomodacao
            // 
            this.lblAcomodacao.AutoSize = true;
            this.lblAcomodacao.Location = new System.Drawing.Point(11, 47);
            this.lblAcomodacao.Name = "lblAcomodacao";
            this.lblAcomodacao.Size = new System.Drawing.Size(84, 13);
            this.lblAcomodacao.TabIndex = 8;
            this.lblAcomodacao.Text = "Acomodação:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // grpManipulacao
            // 
            this.grpManipulacao.Controls.Add(this.btnNovo);
            this.grpManipulacao.Controls.Add(this.btnExcluir);
            this.grpManipulacao.Controls.Add(this.btnAlterar);
            this.grpManipulacao.Controls.Add(this.btnInserir);
            this.grpManipulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManipulacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpManipulacao.Location = new System.Drawing.Point(3, 188);
            this.grpManipulacao.Name = "grpManipulacao";
            this.grpManipulacao.Size = new System.Drawing.Size(564, 100);
            this.grpManipulacao.TabIndex = 112;
            this.grpManipulacao.TabStop = false;
            this.grpManipulacao.Text = "Manipulação:";
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(8, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(132, 68);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Nova Acomodação";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(425, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(132, 68);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "&Excluir Acomodação";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(286, 18);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(132, 68);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "&Alterar Acomodação";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(147, 18);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(132, 68);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "&Inserir Acomodação";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.txtBuscaVer);
            this.grpConsulta.Controls.Add(this.btnAtualizar);
            this.grpConsulta.Controls.Add(this.btnBuscaId);
            this.grpConsulta.Controls.Add(this.lblBuscarId);
            this.grpConsulta.Controls.Add(this.txtBuscaId);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Controls.Add(this.txtBuscaNome);
            this.grpConsulta.Controls.Add(this.btnSair);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpConsulta.Location = new System.Drawing.Point(3, 295);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(564, 100);
            this.grpConsulta.TabIndex = 0;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta:";
            // 
            // txtBuscaVer
            // 
            this.txtBuscaVer.Location = new System.Drawing.Point(12, 67);
            this.txtBuscaVer.Name = "txtBuscaVer";
            this.txtBuscaVer.Size = new System.Drawing.Size(223, 20);
            this.txtBuscaVer.TabIndex = 16;
            this.txtBuscaVer.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(372, 43);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(80, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "  &Limpar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(329, 43);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 3;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(243, 27);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(79, 13);
            this.lblBuscarId.TabIndex = 28;
            this.lblBuscarId.Text = "Pelo Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(246, 46);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(76, 20);
            this.txtBuscaId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pelo Nome:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(12, 46);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(223, 20);
            this.txtBuscaNome.TabIndex = 1;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(458, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 68);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastroLocalDeAcomodacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 402);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpManipulacao);
            this.Controls.Add(this.GrpLocalAcomodacao);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroLocalDeAcomodacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Local De Acomodacao";
            this.Load += new System.EventHandler(this.frmCadastroLocalDeAcomodacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroLocalDeAcomodacao_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalAcomodacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodGeral)).EndInit();
            this.GrpLocalAcomodacao.ResumeLayout(false);
            this.GrpLocalAcomodacao.PerformLayout();
            this.grpManipulacao.ResumeLayout(false);
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.DataGridView dgvLocalAcomodacao;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GrpLocalAcomodacao;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.TextBox txtCast;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtAcomodacao;
        private System.Windows.Forms.Label lblAcomodacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.GroupBox grpManipulacao;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvAcomodGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quarto;
        private System.Windows.Forms.TextBox txtBuscaVer;
    }
}