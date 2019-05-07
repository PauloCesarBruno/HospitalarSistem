namespace Apresentacao_Usuario
{
    partial class frmEnfermeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnfermeiro));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureFarmacia = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.dgvEnfermeiros = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpEnfermagem = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCoren = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpManipulacao = new System.Windows.Forms.GroupBox();
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
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfermeiros)).BeginInit();
            this.grpEnfermagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpManipulacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureFarmacia);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.dgvEnfermeiros);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(4, 1);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(992, 91);
            this.panelTitulo.TabIndex = 104;
            // 
            // pictureFarmacia
            // 
            this.pictureFarmacia.Image = ((System.Drawing.Image)(resources.GetObject("pictureFarmacia.Image")));
            this.pictureFarmacia.Location = new System.Drawing.Point(17, 5);
            this.pictureFarmacia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureFarmacia.Name = "pictureFarmacia";
            this.pictureFarmacia.Size = new System.Drawing.Size(132, 81);
            this.pictureFarmacia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFarmacia.TabIndex = 4;
            this.pictureFarmacia.TabStop = false;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(785, 47);
            this.lblSubTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(157, 37);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Enfermeiros";
            // 
            // dgvEnfermeiros
            // 
            this.dgvEnfermeiros.AllowUserToAddRows = false;
            this.dgvEnfermeiros.AllowUserToDeleteRows = false;
            this.dgvEnfermeiros.BackgroundColor = System.Drawing.Color.Red;
            this.dgvEnfermeiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnfermeiros.Location = new System.Drawing.Point(103, 16);
            this.dgvEnfermeiros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEnfermeiros.Name = "dgvEnfermeiros";
            this.dgvEnfermeiros.ReadOnly = true;
            this.dgvEnfermeiros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnfermeiros.Size = new System.Drawing.Size(19, 22);
            this.dgvEnfermeiros.TabIndex = 100;
            this.dgvEnfermeiros.TabStop = false;
            this.dgvEnfermeiros.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnfermeiros_CellEnter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(240, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(429, 60);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // grpEnfermagem
            // 
            this.grpEnfermagem.Controls.Add(this.pictureBox1);
            this.grpEnfermagem.Controls.Add(this.txtEmail);
            this.grpEnfermagem.Controls.Add(this.lblEmail);
            this.grpEnfermagem.Controls.Add(this.txtCelular);
            this.grpEnfermagem.Controls.Add(this.lblCelular);
            this.grpEnfermagem.Controls.Add(this.txtTelefone);
            this.grpEnfermagem.Controls.Add(this.lblTelefone);
            this.grpEnfermagem.Controls.Add(this.txtRg);
            this.grpEnfermagem.Controls.Add(this.lblRg);
            this.grpEnfermagem.Controls.Add(this.lblCpf);
            this.grpEnfermagem.Controls.Add(this.txtCpf);
            this.grpEnfermagem.Controls.Add(this.txtCoren);
            this.grpEnfermagem.Controls.Add(this.lblCRM);
            this.grpEnfermagem.Controls.Add(this.txtEndereco);
            this.grpEnfermagem.Controls.Add(this.lblEndereco);
            this.grpEnfermagem.Controls.Add(this.txtNome);
            this.grpEnfermagem.Controls.Add(this.lblNome);
            this.grpEnfermagem.Controls.Add(this.txtCodigo);
            this.grpEnfermagem.Controls.Add(this.lblCodigo);
            this.grpEnfermagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnfermagem.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpEnfermagem.Location = new System.Drawing.Point(4, 113);
            this.grpEnfermagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEnfermagem.Name = "grpEnfermagem";
            this.grpEnfermagem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEnfermagem.Size = new System.Drawing.Size(992, 334);
            this.grpEnfermagem.TabIndex = 105;
            this.grpEnfermagem.TabStop = false;
            this.grpEnfermagem.Text = "Cadastro Enfermeiros:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 281);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(256, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 284);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(127, 249);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(148, 23);
            this.txtCelular.TabIndex = 12;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(13, 252);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(64, 17);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(127, 217);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(148, 23);
            this.txtTelefone.TabIndex = 11;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 220);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 17);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(127, 185);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRg.Name = "txtRg";
            this.txtRg.ReadOnly = true;
            this.txtRg.Size = new System.Drawing.Size(197, 23);
            this.txtRg.TabIndex = 9;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(17, 188);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(46, 17);
            this.lblRg.TabIndex = 10;
            this.lblRg.Text = "R.G.:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(17, 156);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(57, 17);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "C.P.F.:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(127, 153);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(132, 23);
            this.txtCpf.TabIndex = 8;
            // 
            // txtCoren
            // 
            this.txtCoren.Location = new System.Drawing.Point(127, 121);
            this.txtCoren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoren.Name = "txtCoren";
            this.txtCoren.ReadOnly = true;
            this.txtCoren.Size = new System.Drawing.Size(197, 23);
            this.txtCoren.TabIndex = 7;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(17, 124);
            this.lblCRM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(56, 17);
            this.lblCRM.TabIndex = 6;
            this.lblCRM.Text = "Coren:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(127, 89);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(437, 23);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(17, 92);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 17);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 57);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(353, 23);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 60);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(127, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(88, 23);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // grpManipulacao
            // 
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
            this.grpManipulacao.Location = new System.Drawing.Point(4, 463);
            this.grpManipulacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpManipulacao.Name = "grpManipulacao";
            this.grpManipulacao.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpManipulacao.Size = new System.Drawing.Size(992, 154);
            this.grpManipulacao.TabIndex = 106;
            this.grpManipulacao.TabStop = false;
            this.grpManipulacao.Text = "Manipulação:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(729, 97);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(99, 28);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "  &Limpar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(672, 98);
            this.btnBuscaId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(49, 28);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(527, 79);
            this.lblBuscarId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(167, 17);
            this.lblBuscarId.TabIndex = 21;
            this.lblBuscarId.Text = "Consultar Por Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(531, 102);
            this.txtBuscaId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(132, 23);
            this.txtBuscaId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultar pelo Nome:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(531, 49);
            this.txtBuscaNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(296, 23);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(863, 43);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 84);
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
            this.btnNovo.Location = new System.Drawing.Point(13, 37);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 84);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "&Novo(a) Enfermeiro(a)";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(389, 37);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 84);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "&Excluir Enfermeiro(a)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(264, 37);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(121, 84);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "&Alterar Enfermeiro(a)";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(139, 37);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(121, 84);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "&Inserir Enfermeiro(a)";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmEnfermeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 631);
            this.Controls.Add(this.grpManipulacao);
            this.Controls.Add(this.grpEnfermagem);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEnfermeiro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enfermeiros";
            this.Load += new System.EventHandler(this.frmEnfermeiro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEnfermeiro_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfermeiros)).EndInit();
            this.grpEnfermagem.ResumeLayout(false);
            this.grpEnfermagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpManipulacao.ResumeLayout(false);
            this.grpManipulacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureFarmacia;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridView dgvEnfermeiros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpEnfermagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtCoren;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpManipulacao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
    }
}