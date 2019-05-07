namespace Apresentacao_Usuario
{
    partial class frmProntuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProntuario));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureFarmacia = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.dgvProntuario = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpProntuario = new System.Windows.Forms.GroupBox();
            this.txtEvolucao = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.lblCodPaciente = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.lblResponsável = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProntuario)).BeginInit();
            this.grpProntuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureFarmacia);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.dgvProntuario);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(1, 1);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(846, 74);
            this.panelTitulo.TabIndex = 105;
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
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(586, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(223, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Prontuário (Evolução)";
            // 
            // dgvProntuario
            // 
            this.dgvProntuario.AllowUserToAddRows = false;
            this.dgvProntuario.AllowUserToDeleteRows = false;
            this.dgvProntuario.BackgroundColor = System.Drawing.Color.Red;
            this.dgvProntuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProntuario.Location = new System.Drawing.Point(82, 25);
            this.dgvProntuario.Name = "dgvProntuario";
            this.dgvProntuario.ReadOnly = true;
            this.dgvProntuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProntuario.Size = new System.Drawing.Size(10, 10);
            this.dgvProntuario.TabIndex = 100;
            this.dgvProntuario.TabStop = false;
            this.dgvProntuario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProntuario_CellEnter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(186, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // grpProntuario
            // 
            this.grpProntuario.Controls.Add(this.txtEvolucao);
            this.grpProntuario.Controls.Add(this.pictureBox1);
            this.grpProntuario.Controls.Add(this.txtNomePaciente);
            this.grpProntuario.Controls.Add(this.lblNomePaciente);
            this.grpProntuario.Controls.Add(this.txtCodPaciente);
            this.grpProntuario.Controls.Add(this.lblCodPaciente);
            this.grpProntuario.Controls.Add(this.txtResponsavel);
            this.grpProntuario.Controls.Add(this.lblResponsável);
            this.grpProntuario.Controls.Add(this.txtData);
            this.grpProntuario.Controls.Add(this.lblData);
            this.grpProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProntuario.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpProntuario.Location = new System.Drawing.Point(1, 78);
            this.grpProntuario.Name = "grpProntuario";
            this.grpProntuario.Size = new System.Drawing.Size(846, 391);
            this.grpProntuario.TabIndex = 106;
            this.grpProntuario.TabStop = false;
            this.grpProntuario.Text = "Prontuário )Evolução de Pâciente)";
            // 
            // txtEvolucao
            // 
            this.txtEvolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEvolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEvolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvolucao.Location = new System.Drawing.Point(438, 19);
            this.txtEvolucao.Name = "txtEvolucao";
            this.txtEvolucao.Size = new System.Drawing.Size(402, 365);
            this.txtEvolucao.TabIndex = 10;
            this.txtEvolucao.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(190, 99);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.ReadOnly = true;
            this.txtNomePaciente.Size = new System.Drawing.Size(232, 20);
            this.txtNomePaciente.TabIndex = 4;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(9, 102);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(115, 13);
            this.lblNomePaciente.TabIndex = 6;
            this.lblNomePaciente.Text = "Nome do Paciente:";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Location = new System.Drawing.Point(190, 74);
            this.txtCodPaciente.MaxLength = 13;
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.ReadOnly = true;
            this.txtCodPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtCodPaciente.TabIndex = 3;
            // 
            // lblCodPaciente
            // 
            this.lblCodPaciente.AutoSize = true;
            this.lblCodPaciente.Location = new System.Drawing.Point(9, 77);
            this.lblCodPaciente.Name = "lblCodPaciente";
            this.lblCodPaciente.Size = new System.Drawing.Size(122, 13);
            this.lblCodPaciente.TabIndex = 4;
            this.lblCodPaciente.Text = "Código do Paciente:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.ForeColor = System.Drawing.Color.Red;
            this.txtResponsavel.Location = new System.Drawing.Point(190, 49);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(232, 20);
            this.txtResponsavel.TabIndex = 2;
            this.txtResponsavel.TabStop = false;
            // 
            // lblResponsável
            // 
            this.lblResponsável.AutoSize = true;
            this.lblResponsável.Location = new System.Drawing.Point(9, 52);
            this.lblResponsável.Name = "lblResponsável";
            this.lblResponsável.Size = new System.Drawing.Size(169, 13);
            this.lblResponsável.TabIndex = 2;
            this.lblResponsável.Text = "Responsável pela Evolução:";
            // 
            // txtData
            // 
            this.txtData.ForeColor = System.Drawing.Color.Red;
            this.txtData.Location = new System.Drawing.Point(190, 24);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(134, 20);
            this.txtData.TabIndex = 1;
            this.txtData.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(9, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data / Horário:";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(749, 481);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 69);
            this.btnSair.TabIndex = 2341;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarNome.Location = new System.Drawing.Point(98, 475);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(134, 16);
            this.lblBuscarNome.TabIndex = 2343;
            this.lblBuscarNome.Text = "Consultar pelo Nome:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(259, 532);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "  &Limpar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(210, 532);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(43, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.AutoSize = true;
            this.lblBuscaId.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaId.ForeColor = System.Drawing.Color.Red;
            this.lblBuscaId.Location = new System.Drawing.Point(97, 518);
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(116, 16);
            this.lblBuscaId.TabIndex = 2342;
            this.lblBuscaId.Text = "Consultar por Cód.";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaId.Location = new System.Drawing.Point(100, 534);
            this.txtBuscaId.MaxLength = 13;
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(105, 20);
            this.txtBuscaId.TabIndex = 1;
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaNome.Location = new System.Drawing.Point(100, 494);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(245, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(361, 483);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 67);
            this.btnNovo.TabIndex = 2344;
            this.btnNovo.Text = "&Novo Prontuário";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(652, 481);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 69);
            this.btnExcluir.TabIndex = 2347;
            this.btnExcluir.Text = "&Excluir Prontuário";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.Blue;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(555, 482);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 68);
            this.btnAlterar.TabIndex = 2346;
            this.btnAlterar.Text = "Evoluir &Prontuário";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(458, 482);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 68);
            this.btnInserir.TabIndex = 2345;
            this.btnInserir.Text = "&Inserir Prontuário";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.Red;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(1, 483);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(91, 72);
            this.btnRelatorio.TabIndex = 2348;
            this.btnRelatorio.TabStop = false;
            this.btnRelatorio.Text = "&Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // frmProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 562);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblBuscaId);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.grpProntuario);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProntuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prontuário (Evolução Paciênte)";
            this.Load += new System.EventHandler(this.frmProntuario_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProntuario)).EndInit();
            this.grpProntuario.ResumeLayout(false);
            this.grpProntuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureFarmacia;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridView dgvProntuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpProntuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Label lblCodPaciente;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label lblResponsável;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RichTextBox txtEvolucao;
        private System.Windows.Forms.Button btnRelatorio;
    }
}