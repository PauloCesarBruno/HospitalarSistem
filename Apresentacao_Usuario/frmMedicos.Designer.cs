namespace Apresentacao_Usuario
{
    partial class frmMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureFarmacia = new System.Windows.Forms.PictureBox();
            this.dgvAmarra = new System.Windows.Forms.DataGridView();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpMedicos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpManipulacao = new System.Windows.Forms.GroupBox();
            this.txtBuscaNomeVer = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarra)).BeginInit();
            this.grpMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpManipulacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.Red;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(31, 13);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(10, 13);
            this.dgvMedicos.TabIndex = 100;
            this.dgvMedicos.TabStop = false;
            this.dgvMedicos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellEnter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureFarmacia);
            this.panelTitulo.Controls.Add(this.dgvAmarra);
            this.panelTitulo.Controls.Add(this.dgvMedicos);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 3);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(744, 74);
            this.panelTitulo.TabIndex = 103;
            // 
            // pictureFarmacia
            // 
            this.pictureFarmacia.Image = ((System.Drawing.Image)(resources.GetObject("pictureFarmacia.Image")));
            this.pictureFarmacia.Location = new System.Drawing.Point(13, 4);
            this.pictureFarmacia.Name = "pictureFarmacia";
            this.pictureFarmacia.Size = new System.Drawing.Size(99, 66);
            this.pictureFarmacia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFarmacia.TabIndex = 4;
            this.pictureFarmacia.TabStop = false;
            // 
            // dgvAmarra
            // 
            this.dgvAmarra.AllowUserToAddRows = false;
            this.dgvAmarra.AllowUserToDeleteRows = false;
            this.dgvAmarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmarra.Location = new System.Drawing.Point(79, 38);
            this.dgvAmarra.Name = "dgvAmarra";
            this.dgvAmarra.ReadOnly = true;
            this.dgvAmarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmarra.Size = new System.Drawing.Size(12, 16);
            this.dgvAmarra.TabIndex = 21;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(598, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(90, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Médicos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(184, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // grpMedicos
            // 
            this.grpMedicos.Controls.Add(this.pictureBox1);
            this.grpMedicos.Controls.Add(this.txtEmail);
            this.grpMedicos.Controls.Add(this.lblEmail);
            this.grpMedicos.Controls.Add(this.txtCelular);
            this.grpMedicos.Controls.Add(this.lblCelular);
            this.grpMedicos.Controls.Add(this.txtTelefone);
            this.grpMedicos.Controls.Add(this.lblTelefone);
            this.grpMedicos.Controls.Add(this.txtEspecialidade);
            this.grpMedicos.Controls.Add(this.lblEspecialidade);
            this.grpMedicos.Controls.Add(this.txtRg);
            this.grpMedicos.Controls.Add(this.lblRg);
            this.grpMedicos.Controls.Add(this.lblCpf);
            this.grpMedicos.Controls.Add(this.txtCpf);
            this.grpMedicos.Controls.Add(this.txtCrm);
            this.grpMedicos.Controls.Add(this.lblCRM);
            this.grpMedicos.Controls.Add(this.txtEndereco);
            this.grpMedicos.Controls.Add(this.lblEndereco);
            this.grpMedicos.Controls.Add(this.txtNome);
            this.grpMedicos.Controls.Add(this.lblNome);
            this.grpMedicos.Controls.Add(this.txtCodigo);
            this.grpMedicos.Controls.Add(this.lblCodigo);
            this.grpMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMedicos.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpMedicos.Location = new System.Drawing.Point(3, 93);
            this.grpMedicos.Name = "grpMedicos";
            this.grpMedicos.Size = new System.Drawing.Size(744, 283);
            this.grpMedicos.TabIndex = 104;
            this.grpMedicos.TabStop = false;
            this.grpMedicos.Text = "Cadastro Médicos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(95, 228);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(112, 20);
            this.txtCelular.TabIndex = 12;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(10, 231);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 13);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(95, 202);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(112, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(10, 205);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 13);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(95, 176);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.ReadOnly = true;
            this.txtEspecialidade.Size = new System.Drawing.Size(193, 20);
            this.txtEspecialidade.TabIndex = 10;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(12, 179);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(79, 13);
            this.lblEspecialidade.TabIndex = 12;
            this.lblEspecialidade.Text = "Especialista:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(95, 150);
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(149, 20);
            this.txtRg.TabIndex = 9;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(13, 153);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(37, 13);
            this.lblRg.TabIndex = 10;
            this.lblRg.Text = "R.G.:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(13, 127);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(46, 13);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "C.P.F.:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(95, 124);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 8;
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(95, 98);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.ReadOnly = true;
            this.txtCrm.Size = new System.Drawing.Size(149, 20);
            this.txtCrm.TabIndex = 7;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(13, 101);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(50, 13);
            this.lblCRM.TabIndex = 6;
            this.lblCRM.Text = "C.R.M.:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(95, 72);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(329, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(13, 75);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(65, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(95, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(67, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // grpManipulacao
            // 
            this.grpManipulacao.Controls.Add(this.txtBuscaNomeVer);
            this.grpManipulacao.Controls.Add(this.btnAtualizar);
            this.grpManipulacao.Controls.Add(this.btnBuscaId);
            this.grpManipulacao.Controls.Add(this.lblBuscarId);
            this.grpManipulacao.Controls.Add(this.txtBuscaId);
            this.grpManipulacao.Controls.Add(this.label1);
            this.grpManipulacao.Controls.Add(this.txtBuscaNome);
            this.grpManipulacao.Controls.Add(this.btnSair);
            this.grpManipulacao.Controls.Add(this.btnNovo);
            this.grpManipulacao.Controls.Add(this.btnExcluir);
            this.grpManipulacao.Controls.Add(this.btnAlterar);
            this.grpManipulacao.Controls.Add(this.btnInserir);
            this.grpManipulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManipulacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpManipulacao.Location = new System.Drawing.Point(3, 382);
            this.grpManipulacao.Name = "grpManipulacao";
            this.grpManipulacao.Size = new System.Drawing.Size(744, 125);
            this.grpManipulacao.TabIndex = 0;
            this.grpManipulacao.TabStop = false;
            this.grpManipulacao.Text = "Manipulação:";
            // 
            // txtBuscaNomeVer
            // 
            this.txtBuscaNomeVer.Location = new System.Drawing.Point(529, 14);
            this.txtBuscaNomeVer.Name = "txtBuscaNomeVer";
            this.txtBuscaNomeVer.Size = new System.Drawing.Size(207, 20);
            this.txtBuscaNomeVer.TabIndex = 22;
            this.txtBuscaNomeVer.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(547, 80);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(74, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "  &Limpar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(504, 80);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(395, 64);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(130, 13);
            this.lblBuscarId.TabIndex = 21;
            this.lblBuscarId.Text = "Consultar Por Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(398, 83);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultar pelo Nome:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(398, 40);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(223, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(647, 35);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 68);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(10, 30);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 68);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "&Novo(a) Médico(a)";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(292, 30);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 68);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "&Excluir Médico(a)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(198, 30);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 68);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "&Alterar Médico(a)";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(104, 30);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 68);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "&Inserir Médico(a)";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 513);
            this.Controls.Add(this.grpManipulacao);
            this.Controls.Add(this.grpMedicos);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMedicos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMedicos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmarra)).EndInit();
            this.grpMedicos.ResumeLayout(false);
            this.grpMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpManipulacao.ResumeLayout(false);
            this.grpManipulacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureFarmacia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpMedicos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox grpManipulacao;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaNomeVer;
        private System.Windows.Forms.DataGridView dgvAmarra;
    }
}