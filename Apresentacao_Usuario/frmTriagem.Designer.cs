namespace Apresentacao_Usuario
{
    partial class frmTriagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriagem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpTriagem = new System.Windows.Forms.GroupBox();
            this.lblAnotações = new System.Windows.Forms.Label();
            this.textAnotacoes = new System.Windows.Forms.TextBox();
            this.textDiaHora = new System.Windows.Forms.TextBox();
            this.txtCapNome = new System.Windows.Forms.TextBox();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelPrioridade = new System.Windows.Forms.Panel();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.checkBx = new System.Windows.Forms.CheckBox();
            this.checkAl = new System.Windows.Forms.CheckBox();
            this.checkMd = new System.Windows.Forms.CheckBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.textSexo = new System.Windows.Forms.TextBox();
            this.textDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.dgvTriagem = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioridadeBaixa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrioridadeMedia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrioridadeAlta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpTriagem.SuspendLayout();
            this.panelPrioridade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(1, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(883, 74);
            this.panelTitulo.TabIndex = 108;
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
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(696, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(146, 24);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Triagem Paciente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(266, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 41);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // grpTriagem
            // 
            this.grpTriagem.Controls.Add(this.lblAnotações);
            this.grpTriagem.Controls.Add(this.textAnotacoes);
            this.grpTriagem.Controls.Add(this.textDiaHora);
            this.grpTriagem.Controls.Add(this.txtCapNome);
            this.grpTriagem.Controls.Add(this.btnBuscaId);
            this.grpTriagem.Controls.Add(this.lblBuscaId);
            this.grpTriagem.Controls.Add(this.txtBuscaId);
            this.grpTriagem.Controls.Add(this.btnImprimir);
            this.grpTriagem.Controls.Add(this.panelPrioridade);
            this.grpTriagem.Controls.Add(this.btnAtualizar);
            this.grpTriagem.Controls.Add(this.btnSair);
            this.grpTriagem.Controls.Add(this.lblBuscarNome);
            this.grpTriagem.Controls.Add(this.txtBuscaNome);
            this.grpTriagem.Controls.Add(this.btnAtendido);
            this.grpTriagem.Controls.Add(this.btnGravar);
            this.grpTriagem.Controls.Add(this.textSexo);
            this.grpTriagem.Controls.Add(this.textDataNascimento);
            this.grpTriagem.Controls.Add(this.textNome);
            this.grpTriagem.Controls.Add(this.textCodigo);
            this.grpTriagem.Controls.Add(this.dgvTriagem);
            this.grpTriagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTriagem.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpTriagem.Location = new System.Drawing.Point(1, 79);
            this.grpTriagem.Name = "grpTriagem";
            this.grpTriagem.Size = new System.Drawing.Size(883, 425);
            this.grpTriagem.TabIndex = 503;
            this.grpTriagem.TabStop = false;
            this.grpTriagem.Text = "Triagem de Pacientes:";
            // 
            // lblAnotações
            // 
            this.lblAnotações.AutoSize = true;
            this.lblAnotações.BackColor = System.Drawing.Color.White;
            this.lblAnotações.Location = new System.Drawing.Point(17, 75);
            this.lblAnotações.Name = "lblAnotações";
            this.lblAnotações.Size = new System.Drawing.Size(499, 13);
            this.lblAnotações.TabIndex = 521;
            this.lblAnotações.Text = "Anotaçoes Gerais de Características Sintomáticas do(a) Paciente no ato de Entrdad" +
    "a.:";
            this.lblAnotações.Visible = false;
            // 
            // textAnotacoes
            // 
            this.textAnotacoes.AcceptsReturn = true;
            this.textAnotacoes.Location = new System.Drawing.Point(14, 91);
            this.textAnotacoes.Multiline = true;
            this.textAnotacoes.Name = "textAnotacoes";
            this.textAnotacoes.Size = new System.Drawing.Size(563, 201);
            this.textAnotacoes.TabIndex = 520;
            this.textAnotacoes.Visible = false;
            // 
            // textDiaHora
            // 
            this.textDiaHora.Location = new System.Drawing.Point(245, 391);
            this.textDiaHora.MaxLength = 25;
            this.textDiaHora.Name = "textDiaHora";
            this.textDiaHora.ReadOnly = true;
            this.textDiaHora.Size = new System.Drawing.Size(10, 20);
            this.textDiaHora.TabIndex = 519;
            this.textDiaHora.TabStop = false;
            this.textDiaHora.Visible = false;
            // 
            // txtCapNome
            // 
            this.txtCapNome.Location = new System.Drawing.Point(260, 391);
            this.txtCapNome.Name = "txtCapNome";
            this.txtCapNome.Size = new System.Drawing.Size(10, 20);
            this.txtCapNome.TabIndex = 518;
            this.txtCapNome.Visible = false;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(137, 389);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.AutoSize = true;
            this.lblBuscaId.Location = new System.Drawing.Point(4, 375);
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(129, 13);
            this.lblBuscaId.TabIndex = 517;
            this.lblBuscaId.Text = "Consultar por Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(6, 391);
            this.txtBuscaId.MaxLength = 13;
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(125, 20);
            this.txtBuscaId.TabIndex = 1;
            this.txtBuscaId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaId_KeyPress);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.ForeColor = System.Drawing.Color.Blue;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnImprimir.Location = new System.Drawing.Point(779, 320);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 42);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panelPrioridade
            // 
            this.panelPrioridade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrioridade.Controls.Add(this.lblPrioridade);
            this.panelPrioridade.Controls.Add(this.checkBx);
            this.panelPrioridade.Controls.Add(this.checkAl);
            this.panelPrioridade.Controls.Add(this.checkMd);
            this.panelPrioridade.Location = new System.Drawing.Point(291, 320);
            this.panelPrioridade.Name = "panelPrioridade";
            this.panelPrioridade.Size = new System.Drawing.Size(467, 42);
            this.panelPrioridade.TabIndex = 514;
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPrioridade.Location = new System.Drawing.Point(131, 4);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(203, 13);
            this.lblPrioridade.TabIndex = 513;
            this.lblPrioridade.Text = "PRIORIDADE DE ATENDIMENTO:";
            // 
            // checkBx
            // 
            this.checkBx.AutoSize = true;
            this.checkBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBx.Location = new System.Drawing.Point(11, 20);
            this.checkBx.Name = "checkBx";
            this.checkBx.Size = new System.Drawing.Size(118, 17);
            this.checkBx.TabIndex = 510;
            this.checkBx.Text = "Prioridade Baixa";
            this.checkBx.UseVisualStyleBackColor = true;
            this.checkBx.CheckedChanged += new System.EventHandler(this.checkBx_CheckedChanged);
            // 
            // checkAl
            // 
            this.checkAl.AutoSize = true;
            this.checkAl.ForeColor = System.Drawing.Color.Red;
            this.checkAl.Location = new System.Drawing.Point(349, 20);
            this.checkAl.Name = "checkAl";
            this.checkAl.Size = new System.Drawing.Size(109, 17);
            this.checkAl.TabIndex = 512;
            this.checkAl.Text = "Prioridade Alta";
            this.checkAl.UseVisualStyleBackColor = true;
            this.checkAl.CheckedChanged += new System.EventHandler(this.checkAl_CheckedChanged);
            // 
            // checkMd
            // 
            this.checkMd.AutoSize = true;
            this.checkMd.ForeColor = System.Drawing.Color.Gold;
            this.checkMd.Location = new System.Drawing.Point(178, 20);
            this.checkMd.Name = "checkMd";
            this.checkMd.Size = new System.Drawing.Size(121, 17);
            this.checkMd.TabIndex = 511;
            this.checkMd.Text = "Prioridade Média";
            this.checkMd.UseVisualStyleBackColor = true;
            this.checkMd.CheckedChanged += new System.EventHandler(this.checkMd_CheckedChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(631, 373);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(127, 42);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(779, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 42);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Location = new System.Drawing.Point(4, 336);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(128, 13);
            this.lblBuscarNome.TabIndex = 509;
            this.lblBuscarNome.Text = "Consultar pelo Nome:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(7, 352);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(260, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnAtendido
            // 
            this.btnAtendido.Enabled = false;
            this.btnAtendido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendido.ForeColor = System.Drawing.Color.Blue;
            this.btnAtendido.Image = ((System.Drawing.Image)(resources.GetObject("btnAtendido.Image")));
            this.btnAtendido.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtendido.Location = new System.Drawing.Point(462, 373);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(127, 42);
            this.btnAtendido.TabIndex = 4;
            this.btnAtendido.Text = "&Ok/Designar";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGravar.Location = new System.Drawing.Point(291, 373);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(127, 42);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "  &Gravar Registro";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // textSexo
            // 
            this.textSexo.Location = new System.Drawing.Point(231, 391);
            this.textSexo.MaxLength = 25;
            this.textSexo.Name = "textSexo";
            this.textSexo.ReadOnly = true;
            this.textSexo.Size = new System.Drawing.Size(10, 20);
            this.textSexo.TabIndex = 501;
            this.textSexo.TabStop = false;
            this.textSexo.Visible = false;
            // 
            // textDataNascimento
            // 
            this.textDataNascimento.Location = new System.Drawing.Point(217, 391);
            this.textDataNascimento.Mask = "00/00/0000";
            this.textDataNascimento.Name = "textDataNascimento";
            this.textDataNascimento.ReadOnly = true;
            this.textDataNascimento.Size = new System.Drawing.Size(10, 20);
            this.textDataNascimento.TabIndex = 403;
            this.textDataNascimento.TabStop = false;
            this.textDataNascimento.ValidatingType = typeof(System.DateTime);
            this.textDataNascimento.Visible = false;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(203, 391);
            this.textNome.MaxLength = 100;
            this.textNome.Name = "textNome";
            this.textNome.ReadOnly = true;
            this.textNome.Size = new System.Drawing.Size(10, 20);
            this.textNome.TabIndex = 402;
            this.textNome.TabStop = false;
            this.textNome.Visible = false;
            // 
            // textCodigo
            // 
            this.textCodigo.ForeColor = System.Drawing.Color.Blue;
            this.textCodigo.Location = new System.Drawing.Point(189, 391);
            this.textCodigo.MaxLength = 13;
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.ReadOnly = true;
            this.textCodigo.Size = new System.Drawing.Size(10, 20);
            this.textCodigo.TabIndex = 401;
            this.textCodigo.TabStop = false;
            this.textCodigo.Visible = false;
            // 
            // dgvTriagem
            // 
            this.dgvTriagem.AllowUserToAddRows = false;
            this.dgvTriagem.AllowUserToDeleteRows = false;
            this.dgvTriagem.BackgroundColor = System.Drawing.Color.White;
            this.dgvTriagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTriagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Data,
            this.Sexo,
            this.DiaHora,
            this.PrioridadeBaixa,
            this.PrioridadeMedia,
            this.PrioridadeAlta});
            this.dgvTriagem.Location = new System.Drawing.Point(3, 19);
            this.dgvTriagem.Name = "dgvTriagem";
            this.dgvTriagem.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTriagem.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTriagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTriagem.Size = new System.Drawing.Size(877, 295);
            this.dgvTriagem.TabIndex = 200;
            this.dgvTriagem.TabStop = false;
            this.dgvTriagem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTriagem_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nome.HeaderText = "Nome Paciente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 280;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data.HeaderText = "Nascimento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 150;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Sexo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DiaHora
            // 
            this.DiaHora.DataPropertyName = "DiaHora";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "T";
            dataGridViewCellStyle5.NullValue = null;
            this.DiaHora.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiaHora.HeaderText = "Hora/Chegada";
            this.DiaHora.Name = "DiaHora";
            this.DiaHora.ReadOnly = true;
            // 
            // PrioridadeBaixa
            // 
            this.PrioridadeBaixa.DataPropertyName = "Pbaixa";
            this.PrioridadeBaixa.HeaderText = "Bx.";
            this.PrioridadeBaixa.Name = "PrioridadeBaixa";
            this.PrioridadeBaixa.ReadOnly = true;
            this.PrioridadeBaixa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrioridadeBaixa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrioridadeBaixa.Width = 35;
            // 
            // PrioridadeMedia
            // 
            this.PrioridadeMedia.DataPropertyName = "Pmedia";
            this.PrioridadeMedia.HeaderText = "Md.";
            this.PrioridadeMedia.Name = "PrioridadeMedia";
            this.PrioridadeMedia.ReadOnly = true;
            this.PrioridadeMedia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrioridadeMedia.Width = 35;
            // 
            // PrioridadeAlta
            // 
            this.PrioridadeAlta.DataPropertyName = "Palta";
            this.PrioridadeAlta.HeaderText = "Al.";
            this.PrioridadeAlta.Name = "PrioridadeAlta";
            this.PrioridadeAlta.ReadOnly = true;
            this.PrioridadeAlta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrioridadeAlta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrioridadeAlta.Width = 35;
            // 
            // frmTriagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 506);
            this.Controls.Add(this.grpTriagem);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTriagem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triagem";
            this.Load += new System.EventHandler(this.frmTriagem_Load);
            this.MouseLeave += new System.EventHandler(this.frmTriagem_MouseLeave);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpTriagem.ResumeLayout(false);
            this.grpTriagem.PerformLayout();
            this.panelPrioridade.ResumeLayout(false);
            this.panelPrioridade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpTriagem;
        private System.Windows.Forms.DataGridView dgvTriagem;
        private System.Windows.Forms.MaskedTextBox textDataNascimento;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textSexo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.CheckBox checkAl;
        private System.Windows.Forms.CheckBox checkMd;
        private System.Windows.Forms.CheckBox checkBx;
        private System.Windows.Forms.Panel panelPrioridade;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblBuscaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.TextBox txtCapNome;
        private System.Windows.Forms.TextBox textDiaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaHora;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrioridadeBaixa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrioridadeMedia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrioridadeAlta;
        private System.Windows.Forms.Label lblAnotações;
        private System.Windows.Forms.TextBox textAnotacoes;
    }
}