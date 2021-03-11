namespace Apresentacao_Usuario
{
    partial class frmFuncionarios_Administrativos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios_Administrativos));
            this.dgvFuncAdm = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbManipulacao = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblobservacoes = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.masktxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.masktxtAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.txtCpts = new System.Windows.Forms.TextBox();
            this.lblCPTS = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.txtAdm = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblAdmissao = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncAdm)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbManipulacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFuncAdm
            // 
            this.dgvFuncAdm.AllowUserToAddRows = false;
            this.dgvFuncAdm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFuncAdm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncAdm.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NomeFuncionario,
            this.Cargo,
            this.Admissao,
            this.CPTS,
            this.CPF,
            this.RG,
            this.Endereco,
            this.Telefone,
            this.Celular,
            this.Email,
            this.Observacoes});
            this.dgvFuncAdm.Location = new System.Drawing.Point(10, 80);
            this.dgvFuncAdm.Name = "dgvFuncAdm";
            this.dgvFuncAdm.ReadOnly = true;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFuncAdm.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFuncAdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncAdm.Size = new System.Drawing.Size(965, 289);
            this.dgvFuncAdm.TabIndex = 100;
            this.dgvFuncAdm.TabStop = false;
            this.dgvFuncAdm.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncAdm_CellEnter);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdFuncionario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 55;
            // 
            // NomeFuncionario
            // 
            this.NomeFuncionario.DataPropertyName = "NomeFuncionario";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeFuncionario.HeaderText = "Nome Completo";
            this.NomeFuncionario.Name = "NomeFuncionario";
            this.NomeFuncionario.ReadOnly = true;
            this.NomeFuncionario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeFuncionario.Width = 220;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cargo.HeaderText = "Cargo Exercido";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cargo.Width = 170;
            // 
            // Admissao
            // 
            this.Admissao.DataPropertyName = "Admissao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admissao.DefaultCellStyle = dataGridViewCellStyle5;
            this.Admissao.HeaderText = "Admissão";
            this.Admissao.Name = "Admissao";
            this.Admissao.ReadOnly = true;
            this.Admissao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Admissao.Width = 80;
            // 
            // CPTS
            // 
            this.CPTS.DataPropertyName = "CPTS";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPTS.DefaultCellStyle = dataGridViewCellStyle6;
            this.CPTS.HeaderText = "Cart. Profissional";
            this.CPTS.Name = "CPTS";
            this.CPTS.ReadOnly = true;
            this.CPTS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CPTS.Width = 130;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.DefaultCellStyle = dataGridViewCellStyle7;
            this.CPF.HeaderText = "C.P.F.";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CPF.Width = 120;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG.DefaultCellStyle = dataGridViewCellStyle8;
            this.RG.HeaderText = "Identidade";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RG.Width = 150;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.DefaultCellStyle = dataGridViewCellStyle9;
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Endereco.Width = 360;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle10;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.DefaultCellStyle = dataGridViewCellStyle11;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Celular.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle12;
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 210;
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observacoes.DefaultCellStyle = dataGridViewCellStyle13;
            this.Observacoes.HeaderText = "Observações sobre o(a) Funcionario(a)";
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            this.Observacoes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observacoes.Width = 500;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(10, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(965, 74);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(609, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(297, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Funcionarios Administrativos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(205, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // gpbManipulacao
            // 
            this.gpbManipulacao.Controls.Add(this.txtObs);
            this.gpbManipulacao.Controls.Add(this.lblobservacoes);
            this.gpbManipulacao.Controls.Add(this.txtEmail);
            this.gpbManipulacao.Controls.Add(this.lblemail);
            this.gpbManipulacao.Controls.Add(this.txtCelular);
            this.gpbManipulacao.Controls.Add(this.lblcelular);
            this.gpbManipulacao.Controls.Add(this.txtTelefone);
            this.gpbManipulacao.Controls.Add(this.lbltelefone);
            this.gpbManipulacao.Controls.Add(this.txtEndereco);
            this.gpbManipulacao.Controls.Add(this.lblendereco);
            this.gpbManipulacao.Controls.Add(this.txtRg);
            this.gpbManipulacao.Controls.Add(this.lblrg);
            this.gpbManipulacao.Controls.Add(this.lblcpf);
            this.gpbManipulacao.Controls.Add(this.masktxtCpf);
            this.gpbManipulacao.Controls.Add(this.masktxtAdmissao);
            this.gpbManipulacao.Controls.Add(this.txtCpts);
            this.gpbManipulacao.Controls.Add(this.lblCPTS);
            this.gpbManipulacao.Controls.Add(this.btnAtualizar);
            this.gpbManipulacao.Controls.Add(this.btnBuscaId);
            this.gpbManipulacao.Controls.Add(this.txtAdm);
            this.gpbManipulacao.Controls.Add(this.btnNovo);
            this.gpbManipulacao.Controls.Add(this.lblAdmissao);
            this.gpbManipulacao.Controls.Add(this.txtCargo);
            this.gpbManipulacao.Controls.Add(this.lblCargo);
            this.gpbManipulacao.Controls.Add(this.txtNome);
            this.gpbManipulacao.Controls.Add(this.lblNome);
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
            this.gpbManipulacao.Location = new System.Drawing.Point(12, 375);
            this.gpbManipulacao.Name = "gpbManipulacao";
            this.gpbManipulacao.Size = new System.Drawing.Size(963, 272);
            this.gpbManipulacao.TabIndex = 3;
            this.gpbManipulacao.TabStop = false;
            this.gpbManipulacao.Text = "Manipulação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(222, 243);
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(391, 20);
            this.txtObs.TabIndex = 20;
            // 
            // lblobservacoes
            // 
            this.lblobservacoes.AutoSize = true;
            this.lblobservacoes.Location = new System.Drawing.Point(219, 227);
            this.lblobservacoes.Name = "lblobservacoes";
            this.lblobservacoes.Size = new System.Drawing.Size(85, 13);
            this.lblobservacoes.TabIndex = 31;
            this.lblobservacoes.Text = "Observações:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(222, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(217, 185);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 13);
            this.lblemail.TabIndex = 29;
            this.lblemail.Text = "E-Mail:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(222, 163);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(115, 20);
            this.txtCelular.TabIndex = 18;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(219, 146);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(50, 13);
            this.lblcelular.TabIndex = 27;
            this.lblcelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(220, 121);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(117, 20);
            this.txtTelefone.TabIndex = 17;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(217, 104);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(64, 13);
            this.lbltelefone.TabIndex = 25;
            this.lbltelefone.Text = "TeleFone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(220, 78);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(336, 20);
            this.txtEndereco.TabIndex = 16;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(217, 61);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(65, 13);
            this.lblendereco.TabIndex = 22;
            this.lblendereco.Text = "Endereço:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(220, 36);
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(144, 20);
            this.txtRg.TabIndex = 15;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(217, 19);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(71, 13);
            this.lblrg.TabIndex = 21;
            this.lblrg.Text = "Identidade:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(6, 227);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(46, 13);
            this.lblcpf.TabIndex = 19;
            this.lblcpf.Text = "C.P.F.:";
            // 
            // masktxtCpf
            // 
            this.masktxtCpf.Location = new System.Drawing.Point(9, 243);
            this.masktxtCpf.Mask = "000,000,000-00";
            this.masktxtCpf.Name = "masktxtCpf";
            this.masktxtCpf.ReadOnly = true;
            this.masktxtCpf.Size = new System.Drawing.Size(100, 20);
            this.masktxtCpf.TabIndex = 14;
            // 
            // masktxtAdmissao
            // 
            this.masktxtAdmissao.Location = new System.Drawing.Point(9, 163);
            this.masktxtAdmissao.Mask = "00/00/0000";
            this.masktxtAdmissao.Name = "masktxtAdmissao";
            this.masktxtAdmissao.ReadOnly = true;
            this.masktxtAdmissao.Size = new System.Drawing.Size(78, 20);
            this.masktxtAdmissao.TabIndex = 12;
            this.masktxtAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpts
            // 
            this.txtCpts.Location = new System.Drawing.Point(9, 202);
            this.txtCpts.Name = "txtCpts";
            this.txtCpts.ReadOnly = true;
            this.txtCpts.Size = new System.Drawing.Size(160, 20);
            this.txtCpts.TabIndex = 13;
            // 
            // lblCPTS
            // 
            this.lblCPTS.AutoSize = true;
            this.lblCPTS.Location = new System.Drawing.Point(6, 186);
            this.lblCPTS.Name = "lblCPTS";
            this.lblCPTS.Size = new System.Drawing.Size(103, 13);
            this.lblCPTS.TabIndex = 16;
            this.lblCPTS.Text = "Cart.Profissional:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Location = new System.Drawing.Point(769, 201);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(74, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(726, 202);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // txtAdm
            // 
            this.txtAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdm.Enabled = false;
            this.txtAdm.Location = new System.Drawing.Point(161, 186);
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.ReadOnly = true;
            this.txtAdm.Size = new System.Drawing.Size(39, 13);
            this.txtAdm.TabIndex = 14;
            this.txtAdm.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(576, 46);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 67);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo Funcionário";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblAdmissao
            // 
            this.lblAdmissao.AutoSize = true;
            this.lblAdmissao.Location = new System.Drawing.Point(6, 146);
            this.lblAdmissao.Name = "lblAdmissao";
            this.lblAdmissao.Size = new System.Drawing.Size(64, 13);
            this.lblAdmissao.TabIndex = 13;
            this.lblAdmissao.Text = "Admissão:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(9, 120);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(160, 20);
            this.txtCargo.TabIndex = 11;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(6, 103);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 13);
            this.lblCargo.TabIndex = 11;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Código:";
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(617, 188);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(130, 13);
            this.lblBuscarId.TabIndex = 6;
            this.lblBuscarId.Text = "Consultar Por Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(620, 204);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaId.TabIndex = 1;
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Location = new System.Drawing.Point(617, 136);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(128, 13);
            this.lblBuscarNome.TabIndex = 4;
            this.lblBuscarNome.Text = "Consultar pelo Nome:";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(867, 194);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 69);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(620, 152);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(279, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(867, 44);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 69);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir Funcionário";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(770, 45);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 68);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "&Alterar Funcionário";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(673, 45);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 68);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "&Inserir Funcionário";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmFuncionarios_Administrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 653);
            this.Controls.Add(this.gpbManipulacao);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.dgvFuncAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios_Administrativos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios Administrativos";
            this.Load += new System.EventHandler(this.frmFuncionarios_Administrativos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFuncionarios_Administrativos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncAdm)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbManipulacao.ResumeLayout(false);
            this.gpbManipulacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncAdm;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.GroupBox gpbManipulacao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.TextBox txtAdm;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblAdmissao;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtCpts;
        private System.Windows.Forms.Label lblCPTS;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.MaskedTextBox masktxtCpf;
        private System.Windows.Forms.MaskedTextBox masktxtAdmissao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblobservacoes;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
    }
}