namespace Apresentacao_Usuario
{
    partial class frmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAmarraAcomodacao = new System.Windows.Forms.DataGridView();
            this.dgvAcomodacaoAnterior = new System.Windows.Forms.DataGridView();
            this.dgvAmarraProntuario = new System.Windows.Forms.DataGridView();
            this.dgvAmarraCustos = new System.Windows.Forms.DataGridView();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAmarra = new System.Windows.Forms.DataGridView();
            this.IdPaciente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedico2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAlta = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Internacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBuscaNomeVer = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscaIdVer = new System.Windows.Forms.TextBox();
            this.txtBuscaProntuario = new System.Windows.Forms.TextBox();
            this.txtBuscaIdProntuario = new System.Windows.Forms.TextBox();
            this.txtBuscaCustos = new System.Windows.Forms.TextBox();
            this.txtBuscaIdCustos = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBuscaAcomodacao = new System.Windows.Forms.TextBox();
            this.txtBuscaIdAcomodacao = new System.Windows.Forms.TextBox();
            this.txtBuscaNomeAcomodAnterior = new System.Windows.Forms.TextBox();
            this.txtBuscaAcoAnteriorId = new System.Windows.Forms.TextBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarraAcomodacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodacaoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarraProntuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarraCustos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.dgvAmarraAcomodacao);
            this.panelTitulo.Controls.Add(this.dgvAcomodacaoAnterior);
            this.panelTitulo.Controls.Add(this.dgvAmarraProntuario);
            this.panelTitulo.Controls.Add(this.dgvAmarraCustos);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.dgvAmarra);
            this.panelTitulo.Location = new System.Drawing.Point(1, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(583, 74);
            this.panelTitulo.TabIndex = 104;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAmarraAcomodacao
            // 
            this.dgvAmarraAcomodacao.AllowUserToAddRows = false;
            this.dgvAmarraAcomodacao.AllowUserToDeleteRows = false;
            this.dgvAmarraAcomodacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvAmarraAcomodacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmarraAcomodacao.Location = new System.Drawing.Point(68, 31);
            this.dgvAmarraAcomodacao.Name = "dgvAmarraAcomodacao";
            this.dgvAmarraAcomodacao.ReadOnly = true;
            this.dgvAmarraAcomodacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmarraAcomodacao.Size = new System.Drawing.Size(10, 15);
            this.dgvAmarraAcomodacao.TabIndex = 125;
            // 
            // dgvAcomodacaoAnterior
            // 
            this.dgvAcomodacaoAnterior.AllowUserToAddRows = false;
            this.dgvAcomodacaoAnterior.AllowUserToDeleteRows = false;
            this.dgvAcomodacaoAnterior.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgvAcomodacaoAnterior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcomodacaoAnterior.Location = new System.Drawing.Point(22, 33);
            this.dgvAcomodacaoAnterior.Name = "dgvAcomodacaoAnterior";
            this.dgvAcomodacaoAnterior.ReadOnly = true;
            this.dgvAcomodacaoAnterior.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcomodacaoAnterior.Size = new System.Drawing.Size(15, 13);
            this.dgvAcomodacaoAnterior.TabIndex = 127;
            // 
            // dgvAmarraProntuario
            // 
            this.dgvAmarraProntuario.AllowUserToAddRows = false;
            this.dgvAmarraProntuario.AllowUserToDeleteRows = false;
            this.dgvAmarraProntuario.BackgroundColor = System.Drawing.Color.Red;
            this.dgvAmarraProntuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmarraProntuario.Location = new System.Drawing.Point(26, 10);
            this.dgvAmarraProntuario.Name = "dgvAmarraProntuario";
            this.dgvAmarraProntuario.ReadOnly = true;
            this.dgvAmarraProntuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmarraProntuario.Size = new System.Drawing.Size(11, 10);
            this.dgvAmarraProntuario.TabIndex = 118;
            // 
            // dgvAmarraCustos
            // 
            this.dgvAmarraCustos.AllowUserToAddRows = false;
            this.dgvAmarraCustos.AllowUserToDeleteRows = false;
            this.dgvAmarraCustos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmarraCustos.Location = new System.Drawing.Point(43, 31);
            this.dgvAmarraCustos.Name = "dgvAmarraCustos";
            this.dgvAmarraCustos.ReadOnly = true;
            this.dgvAmarraCustos.Size = new System.Drawing.Size(12, 12);
            this.dgvAmarraCustos.TabIndex = 120;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(385, 44);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(189, 18);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Paciente Alta (Fechamento)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(119, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvAmarra
            // 
            this.dgvAmarra.AllowUserToAddRows = false;
            this.dgvAmarra.AllowUserToDeleteRows = false;
            this.dgvAmarra.BackgroundColor = System.Drawing.Color.Red;
            this.dgvAmarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmarra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente2,
            this.Nome2,
            this.IdMedico2});
            this.dgvAmarra.Location = new System.Drawing.Point(68, 10);
            this.dgvAmarra.Name = "dgvAmarra";
            this.dgvAmarra.ReadOnly = true;
            this.dgvAmarra.Size = new System.Drawing.Size(12, 15);
            this.dgvAmarra.TabIndex = 113;
            // 
            // IdPaciente2
            // 
            this.IdPaciente2.DataPropertyName = "IdPaciente";
            this.IdPaciente2.HeaderText = "Cógigo";
            this.IdPaciente2.Name = "IdPaciente2";
            this.IdPaciente2.ReadOnly = true;
            // 
            // Nome2
            // 
            this.Nome2.DataPropertyName = "Nome";
            this.Nome2.HeaderText = "Nome";
            this.Nome2.Name = "Nome2";
            this.Nome2.ReadOnly = true;
            // 
            // IdMedico2
            // 
            this.IdMedico2.DataPropertyName = "IdMedico";
            this.IdMedico2.HeaderText = "Cod.Medico";
            this.IdMedico2.Name = "IdMedico2";
            this.IdMedico2.ReadOnly = true;
            // 
            // dgvAlta
            // 
            this.dgvAlta.AllowUserToAddRows = false;
            this.dgvAlta.AllowUserToDeleteRows = false;
            this.dgvAlta.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.Nome,
            this.Internacao});
            this.dgvAlta.Location = new System.Drawing.Point(1, 77);
            this.dgvAlta.Name = "dgvAlta";
            this.dgvAlta.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlta.Size = new System.Drawing.Size(583, 217);
            this.dgvAlta.TabIndex = 105;
            this.dgvAlta.TabStop = false;
            this.dgvAlta.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlta_CellEnter);
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.IdPaciente.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdPaciente.HeaderText = "Código";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nome.HeaderText = "Paciente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 340;
            // 
            // Internacao
            // 
            this.Internacao.DataPropertyName = "Internacao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Internacao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Internacao.HeaderText = "Internação";
            this.Internacao.Name = "Internacao";
            this.Internacao.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(265, 362);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 64);
            this.btnExcluir.TabIndex = 107;
            this.btnExcluir.Text = "   &Excluir Paciente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(119, 401);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblBuscarId.Location = new System.Drawing.Point(13, 384);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(118, 13);
            this.lblBuscarId.TabIndex = 112;
            this.lblBuscarId.Text = "Busca Pelo Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(16, 403);
            this.txtBuscaId.MaxLength = 13;
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaId.TabIndex = 1;
            this.txtBuscaId.TextChanged += new System.EventHandler(this.txtBuscaId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Busca Pelo Nome:(Min. 8 Caracteres)";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(15, 358);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(223, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizar.Location = new System.Drawing.Point(163, 401);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(74, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtBuscaNomeVer
            // 
            this.txtBuscaNomeVer.Location = new System.Drawing.Point(104, 321);
            this.txtBuscaNomeVer.Name = "txtBuscaNomeVer";
            this.txtBuscaNomeVer.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaNomeVer.TabIndex = 114;
            this.txtBuscaNomeVer.Visible = false;
            this.txtBuscaNomeVer.TextChanged += new System.EventHandler(this.txtBuscaNomeVer_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCodigo.Location = new System.Drawing.Point(1, 297);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 115;
            this.txtCodigo.Visible = false;
            // 
            // txtBuscaIdVer
            // 
            this.txtBuscaIdVer.Location = new System.Drawing.Point(106, 297);
            this.txtBuscaIdVer.MaxLength = 13;
            this.txtBuscaIdVer.Name = "txtBuscaIdVer";
            this.txtBuscaIdVer.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaIdVer.TabIndex = 116;
            this.txtBuscaIdVer.Visible = false;
            // 
            // txtBuscaProntuario
            // 
            this.txtBuscaProntuario.Location = new System.Drawing.Point(200, 321);
            this.txtBuscaProntuario.Name = "txtBuscaProntuario";
            this.txtBuscaProntuario.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaProntuario.TabIndex = 117;
            this.txtBuscaProntuario.Visible = false;
            // 
            // txtBuscaIdProntuario
            // 
            this.txtBuscaIdProntuario.Location = new System.Drawing.Point(202, 297);
            this.txtBuscaIdProntuario.MaxLength = 13;
            this.txtBuscaIdProntuario.Name = "txtBuscaIdProntuario";
            this.txtBuscaIdProntuario.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaIdProntuario.TabIndex = 119;
            this.txtBuscaIdProntuario.Visible = false;
            // 
            // txtBuscaCustos
            // 
            this.txtBuscaCustos.Location = new System.Drawing.Point(298, 321);
            this.txtBuscaCustos.Name = "txtBuscaCustos";
            this.txtBuscaCustos.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaCustos.TabIndex = 121;
            this.txtBuscaCustos.Visible = false;
            // 
            // txtBuscaIdCustos
            // 
            this.txtBuscaIdCustos.Location = new System.Drawing.Point(300, 297);
            this.txtBuscaIdCustos.MaxLength = 13;
            this.txtBuscaIdCustos.Name = "txtBuscaIdCustos";
            this.txtBuscaIdCustos.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaIdCustos.TabIndex = 122;
            this.txtBuscaIdCustos.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(459, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 64);
            this.btnSair.TabIndex = 123;
            this.btnSair.Text = "  &Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBuscaAcomodacao
            // 
            this.txtBuscaAcomodacao.Location = new System.Drawing.Point(397, 297);
            this.txtBuscaAcomodacao.Name = "txtBuscaAcomodacao";
            this.txtBuscaAcomodacao.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaAcomodacao.TabIndex = 124;
            this.txtBuscaAcomodacao.Visible = false;
            // 
            // txtBuscaIdAcomodacao
            // 
            this.txtBuscaIdAcomodacao.Location = new System.Drawing.Point(395, 321);
            this.txtBuscaIdAcomodacao.MaxLength = 13;
            this.txtBuscaIdAcomodacao.Name = "txtBuscaIdAcomodacao";
            this.txtBuscaIdAcomodacao.Size = new System.Drawing.Size(91, 20);
            this.txtBuscaIdAcomodacao.TabIndex = 126;
            this.txtBuscaIdAcomodacao.Visible = false;
            // 
            // txtBuscaNomeAcomodAnterior
            // 
            this.txtBuscaNomeAcomodAnterior.Location = new System.Drawing.Point(492, 297);
            this.txtBuscaNomeAcomodAnterior.Name = "txtBuscaNomeAcomodAnterior";
            this.txtBuscaNomeAcomodAnterior.Size = new System.Drawing.Size(90, 20);
            this.txtBuscaNomeAcomodAnterior.TabIndex = 128;
            this.txtBuscaNomeAcomodAnterior.Visible = false;
            // 
            // txtBuscaAcoAnteriorId
            // 
            this.txtBuscaAcoAnteriorId.Location = new System.Drawing.Point(492, 321);
            this.txtBuscaAcoAnteriorId.Name = "txtBuscaAcoAnteriorId";
            this.txtBuscaAcoAnteriorId.Size = new System.Drawing.Size(90, 20);
            this.txtBuscaAcoAnteriorId.TabIndex = 129;
            this.txtBuscaAcoAnteriorId.Visible = false;
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 436);
            this.Controls.Add(this.txtBuscaAcoAnteriorId);
            this.Controls.Add(this.txtBuscaNomeAcomodAnterior);
            this.Controls.Add(this.txtBuscaIdAcomodacao);
            this.Controls.Add(this.txtBuscaAcomodacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtBuscaIdCustos);
            this.Controls.Add(this.txtBuscaCustos);
            this.Controls.Add(this.txtBuscaIdProntuario);
            this.Controls.Add(this.txtBuscaProntuario);
            this.Controls.Add(this.txtBuscaIdVer);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtBuscaNomeVer);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvAlta);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAlta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta (Fechamento)";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAlta_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarraAcomodacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodacaoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarraProntuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarraCustos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAlta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Internacao;
        private System.Windows.Forms.DataGridView dgvAmarra;
        private System.Windows.Forms.TextBox txtBuscaNomeVer;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtBuscaIdVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedico2;
        private System.Windows.Forms.TextBox txtBuscaProntuario;
        private System.Windows.Forms.DataGridView dgvAmarraProntuario;
        private System.Windows.Forms.TextBox txtBuscaIdProntuario;
        private System.Windows.Forms.DataGridView dgvAmarraCustos;
        private System.Windows.Forms.TextBox txtBuscaCustos;
        private System.Windows.Forms.TextBox txtBuscaIdCustos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtBuscaAcomodacao;
        private System.Windows.Forms.DataGridView dgvAmarraAcomodacao;
        private System.Windows.Forms.TextBox txtBuscaIdAcomodacao;
        private System.Windows.Forms.DataGridView dgvAcomodacaoAnterior;
        private System.Windows.Forms.TextBox txtBuscaNomeAcomodAnterior;
        private System.Windows.Forms.TextBox txtBuscaAcoAnteriorId;
    }
}