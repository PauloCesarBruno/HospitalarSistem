namespace Apresentacao_Usuario
{
    partial class frmPacienteAcompanhante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteAcompanhante));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPacAcomp = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAcompanhante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCapCodigo = new System.Windows.Forms.TextBox();
            this.txtCapNome = new System.Windows.Forms.TextBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacAcomp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(1, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(946, 74);
            this.panelTitulo.TabIndex = 105;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(599, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(286, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Consulta Paciênte X Filiação";
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(193, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvPacAcomp
            // 
            this.dgvPacAcomp.AllowUserToAddRows = false;
            this.dgvPacAcomp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPacAcomp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacAcomp.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacAcomp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacAcomp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.Nome,
            this.NomeAcompanhante,
            this.RGAcompanhante,
            this.EnderecoAcompanhante,
            this.TelefoneAcompanhante,
            this.CelularAcompanhante,
            this.EmailAcompanhante});
            this.dgvPacAcomp.Location = new System.Drawing.Point(1, 78);
            this.dgvPacAcomp.Name = "dgvPacAcomp";
            this.dgvPacAcomp.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPacAcomp.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPacAcomp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacAcomp.Size = new System.Drawing.Size(946, 260);
            this.dgvPacAcomp.TabIndex = 106;
            this.dgvPacAcomp.TabStop = false;
            this.dgvPacAcomp.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacAcomp_CellEnter);
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.IdPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdPaciente.HeaderText = "Código";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome.HeaderText = "Nome Paciente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 200;
            // 
            // NomeAcompanhante
            // 
            this.NomeAcompanhante.DataPropertyName = "NomeAcompanhante";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeAcompanhante.DefaultCellStyle = dataGridViewCellStyle4;
            this.NomeAcompanhante.HeaderText = "Nome - Filiação (Mãe ou Pai)";
            this.NomeAcompanhante.Name = "NomeAcompanhante";
            this.NomeAcompanhante.ReadOnly = true;
            this.NomeAcompanhante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeAcompanhante.Width = 200;
            // 
            // RGAcompanhante
            // 
            this.RGAcompanhante.DataPropertyName = "RGAcompanhante";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGAcompanhante.DefaultCellStyle = dataGridViewCellStyle5;
            this.RGAcompanhante.HeaderText = "R.G.";
            this.RGAcompanhante.Name = "RGAcompanhante";
            this.RGAcompanhante.ReadOnly = true;
            this.RGAcompanhante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RGAcompanhante.Width = 150;
            // 
            // EnderecoAcompanhante
            // 
            this.EnderecoAcompanhante.DataPropertyName = "EnderecoAcompanhante";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoAcompanhante.DefaultCellStyle = dataGridViewCellStyle6;
            this.EnderecoAcompanhante.HeaderText = "Endereço";
            this.EnderecoAcompanhante.Name = "EnderecoAcompanhante";
            this.EnderecoAcompanhante.ReadOnly = true;
            this.EnderecoAcompanhante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnderecoAcompanhante.Width = 300;
            // 
            // TelefoneAcompanhante
            // 
            this.TelefoneAcompanhante.DataPropertyName = "TelefoneAcompanhante";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneAcompanhante.DefaultCellStyle = dataGridViewCellStyle7;
            this.TelefoneAcompanhante.HeaderText = "Telefone";
            this.TelefoneAcompanhante.Name = "TelefoneAcompanhante";
            this.TelefoneAcompanhante.ReadOnly = true;
            this.TelefoneAcompanhante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TelefoneAcompanhante.Width = 120;
            // 
            // CelularAcompanhante
            // 
            this.CelularAcompanhante.DataPropertyName = "CelularAcompanhante";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularAcompanhante.DefaultCellStyle = dataGridViewCellStyle8;
            this.CelularAcompanhante.HeaderText = "Celular";
            this.CelularAcompanhante.Name = "CelularAcompanhante";
            this.CelularAcompanhante.ReadOnly = true;
            this.CelularAcompanhante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CelularAcompanhante.Width = 120;
            // 
            // EmailAcompanhante
            // 
            this.EmailAcompanhante.DataPropertyName = "EmailAcompanhante";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAcompanhante.DefaultCellStyle = dataGridViewCellStyle9;
            this.EmailAcompanhante.HeaderText = "E-MAIL";
            this.EmailAcompanhante.Name = "EmailAcompanhante";
            this.EmailAcompanhante.ReadOnly = true;
            this.EmailAcompanhante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmailAcompanhante.Width = 200;
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarNome.Location = new System.Drawing.Point(9, 349);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(134, 16);
            this.lblBuscarNome.TabIndex = 2363;
            this.lblBuscarNome.Text = "Consultar pelo Nome:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizar.Location = new System.Drawing.Point(171, 406);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(121, 406);
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
            this.lblBuscaId.Location = new System.Drawing.Point(8, 392);
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(116, 16);
            this.lblBuscaId.TabIndex = 2362;
            this.lblBuscaId.Text = "Consultar por Cód.";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaId.Location = new System.Drawing.Point(11, 408);
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
            this.txtBuscaNome.Location = new System.Drawing.Point(11, 368);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(325, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(742, 360);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(195, 69);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCapCodigo
            // 
            this.txtCapCodigo.Location = new System.Drawing.Point(370, 368);
            this.txtCapCodigo.Name = "txtCapCodigo";
            this.txtCapCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCapCodigo.TabIndex = 2364;
            this.txtCapCodigo.Visible = false;
            // 
            // txtCapNome
            // 
            this.txtCapNome.Location = new System.Drawing.Point(370, 395);
            this.txtCapNome.Name = "txtCapNome";
            this.txtCapNome.Size = new System.Drawing.Size(211, 20);
            this.txtCapNome.TabIndex = 2365;
            this.txtCapNome.Visible = false;
            // 
            // frmPacienteAcompanhante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 440);
            this.Controls.Add(this.txtCapNome);
            this.Controls.Add(this.txtCapCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblBuscaId);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.dgvPacAcomp);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPacienteAcompanhante";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Paciente X Acompanhante";
            this.Load += new System.EventHandler(this.frmPacienteAcompanhante_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPacienteAcompanhante_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacAcomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvPacAcomp;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCapCodigo;
        private System.Windows.Forms.TextBox txtCapNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAcompanhante;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGAcompanhante;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoAcompanhante;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneAcompanhante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularAcompanhante;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAcompanhante;
    }
}