namespace Apresentacao_Usuario
{
    partial class frmPacientesAcomodacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientesAcomodacoes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvConPaciente = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.dgvAcomodGeral = new System.Windows.Forms.DataGridView();
            this.LocalAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaNomePaciente = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblExclusao = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.lblConsultaCodigo = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCapCodigo = new System.Windows.Forms.TextBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.dgvConPaciente);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(564, 74);
            this.panelTitulo.TabIndex = 107;
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
            this.lblSubTitulo.Location = new System.Drawing.Point(429, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(118, 24);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = " Acomodações";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(114, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 41);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvConPaciente
            // 
            this.dgvConPaciente.AllowUserToAddRows = false;
            this.dgvConPaciente.AllowUserToDeleteRows = false;
            this.dgvConPaciente.BackgroundColor = System.Drawing.Color.Red;
            this.dgvConPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConPaciente.Location = new System.Drawing.Point(41, 28);
            this.dgvConPaciente.Name = "dgvConPaciente";
            this.dgvConPaciente.ReadOnly = true;
            this.dgvConPaciente.Size = new System.Drawing.Size(14, 18);
            this.dgvConPaciente.TabIndex = 2356;
            this.dgvConPaciente.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(446, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 62);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpa.Location = new System.Drawing.Point(289, 361);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(278, 23);
            this.btnLimpa.TabIndex = 1;
            this.btnLimpa.Text = "&Atualiza Tabela de Acomodações";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblBuscarNome.Location = new System.Drawing.Point(0, 347);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(212, 16);
            this.lblBuscarNome.TabIndex = 2354;
            this.lblBuscarNome.Text = "Consultar Acomodação pelo Nome:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaNome.Location = new System.Drawing.Point(3, 363);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(279, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // dgvAcomodGeral
            // 
            this.dgvAcomodGeral.AllowUserToAddRows = false;
            this.dgvAcomodGeral.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAcomodGeral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcomodGeral.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcomodGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcomodGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalAcomodado,
            this.IdPaciente,
            this.NomePaciente,
            this.Leito,
            this.Quarto});
            this.dgvAcomodGeral.Location = new System.Drawing.Point(4, 73);
            this.dgvAcomodGeral.Name = "dgvAcomodGeral";
            this.dgvAcomodGeral.ReadOnly = true;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAcomodGeral.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAcomodGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcomodGeral.Size = new System.Drawing.Size(563, 263);
            this.dgvAcomodGeral.TabIndex = 2355;
            this.dgvAcomodGeral.TabStop = false;
            // 
            // LocalAcomodado
            // 
            this.LocalAcomodado.DataPropertyName = "LocalAcomodado";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.LocalAcomodado.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocalAcomodado.HeaderText = "Acomodação";
            this.LocalAcomodado.Name = "LocalAcomodado";
            this.LocalAcomodado.ReadOnly = true;
            this.LocalAcomodado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalAcomodado.Width = 115;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdPaciente.HeaderText = "Código";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdPaciente.Width = 110;
            // 
            // NomePaciente
            // 
            this.NomePaciente.DataPropertyName = "NomePaciente";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePaciente.DefaultCellStyle = dataGridViewCellStyle4;
            this.NomePaciente.HeaderText = "Nome Paciênte";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            this.NomePaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomePaciente.Width = 194;
            // 
            // Leito
            // 
            this.Leito.DataPropertyName = "Leito";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leito.DefaultCellStyle = dataGridViewCellStyle5;
            this.Leito.HeaderText = "Leito";
            this.Leito.Name = "Leito";
            this.Leito.ReadOnly = true;
            this.Leito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Leito.Width = 50;
            // 
            // Quarto
            // 
            this.Quarto.DataPropertyName = "Quarto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quarto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quarto.HeaderText = "Quarto";
            this.Quarto.Name = "Quarto";
            this.Quarto.ReadOnly = true;
            this.Quarto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quarto.Width = 50;
            // 
            // txtBuscaNomePaciente
            // 
            this.txtBuscaNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNomePaciente.Location = new System.Drawing.Point(3, 436);
            this.txtBuscaNomePaciente.Name = "txtBuscaNomePaciente";
            this.txtBuscaNomePaciente.Size = new System.Drawing.Size(280, 20);
            this.txtBuscaNomePaciente.TabIndex = 2;
            this.txtBuscaNomePaciente.TextChanged += new System.EventHandler(this.txtBuscaNomePaciente_TextChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Enabled = false;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.Red;
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexcluir.Location = new System.Drawing.Point(302, 417);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(121, 62);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "  &Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(467, 340);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2359;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // lblExclusao
            // 
            this.lblExclusao.AutoSize = true;
            this.lblExclusao.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExclusao.ForeColor = System.Drawing.Color.Red;
            this.lblExclusao.Location = new System.Drawing.Point(1, 417);
            this.lblExclusao.Name = "lblExclusao";
            this.lblExclusao.Size = new System.Drawing.Size(258, 16);
            this.lblExclusao.TabIndex = 2360;
            this.lblExclusao.Text = "Excluir um(a) Paciente (Min. 8 Caracteres)";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(424, 340);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(27, 20);
            this.txtAdmin.TabIndex = 2361;
            this.txtAdmin.Visible = false;
            // 
            // lblConsultaCodigo
            // 
            this.lblConsultaCodigo.AutoSize = true;
            this.lblConsultaCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblConsultaCodigo.Location = new System.Drawing.Point(1, 459);
            this.lblConsultaCodigo.Name = "lblConsultaCodigo";
            this.lblConsultaCodigo.Size = new System.Drawing.Size(116, 16);
            this.lblConsultaCodigo.TabIndex = 2363;
            this.lblConsultaCodigo.Text = "Excluir  p/ Código";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.Location = new System.Drawing.Point(3, 478);
            this.txtBuscaId.MaxLength = 13;
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(114, 20);
            this.txtBuscaId.TabIndex = 3;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.Red;
            this.btnBuscaId.Location = new System.Drawing.Point(120, 475);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 4;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(-1, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 10);
            this.panel1.TabIndex = 2365;
            // 
            // txtCapCodigo
            // 
            this.txtCapCodigo.Location = new System.Drawing.Point(163, 478);
            this.txtCapCodigo.Name = "txtCapCodigo";
            this.txtCapCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCapCodigo.TabIndex = 2366;
            this.txtCapCodigo.Visible = false;
            // 
            // frmPacientesAcomodacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 508);
            this.Controls.Add(this.txtCapCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblConsultaCodigo);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblExclusao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.txtBuscaNomePaciente);
            this.Controls.Add(this.dgvAcomodGeral);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPacientesAcomodacoes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes Acomodacoes";
            this.Load += new System.EventHandler(this.frmPacientesAcomodacoes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPacientesAcomodacoes_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.DataGridView dgvAcomodGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quarto;
        private System.Windows.Forms.DataGridView dgvConPaciente;
        private System.Windows.Forms.TextBox txtBuscaNomePaciente;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblExclusao;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblConsultaCodigo;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCapCodigo;
    }
}