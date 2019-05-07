namespace Apresentacao_Usuario
{
    partial class frmConsultaEnfermeiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEnfermeiros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureFarmacia = new System.Windows.Forms.PictureBox();
            this.dgvConEnfermeiros = new System.Windows.Forms.DataGridView();
            this.IdEnfermeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEnfermeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COREN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConEnfermeiros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.pictureFarmacia);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1027, 74);
            this.panelTitulo.TabIndex = 105;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(776, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(224, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Consultar Enfermeiros";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(276, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
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
            // dgvConEnfermeiros
            // 
            this.dgvConEnfermeiros.AllowUserToAddRows = false;
            this.dgvConEnfermeiros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvConEnfermeiros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConEnfermeiros.BackgroundColor = System.Drawing.Color.White;
            this.dgvConEnfermeiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConEnfermeiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEnfermeiro,
            this.NomeEnfermeiro,
            this.Endereco,
            this.COREN,
            this.CPF,
            this.RG,
            this.Telefone,
            this.Celular,
            this.Email});
            this.dgvConEnfermeiros.Location = new System.Drawing.Point(3, 78);
            this.dgvConEnfermeiros.Name = "dgvConEnfermeiros";
            this.dgvConEnfermeiros.ReadOnly = true;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConEnfermeiros.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvConEnfermeiros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConEnfermeiros.Size = new System.Drawing.Size(1027, 263);
            this.dgvConEnfermeiros.TabIndex = 106;
            this.dgvConEnfermeiros.TabStop = false;
            // 
            // IdEnfermeiro
            // 
            this.IdEnfermeiro.DataPropertyName = "IdEnfermeiro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.IdEnfermeiro.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdEnfermeiro.HeaderText = "Código";
            this.IdEnfermeiro.Name = "IdEnfermeiro";
            this.IdEnfermeiro.ReadOnly = true;
            this.IdEnfermeiro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdEnfermeiro.Width = 50;
            // 
            // NomeEnfermeiro
            // 
            this.NomeEnfermeiro.DataPropertyName = "NomeEnfermeiro";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEnfermeiro.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeEnfermeiro.HeaderText = "Nome";
            this.NomeEnfermeiro.Name = "NomeEnfermeiro";
            this.NomeEnfermeiro.ReadOnly = true;
            this.NomeEnfermeiro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeEnfermeiro.Width = 200;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.DefaultCellStyle = dataGridViewCellStyle4;
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Endereco.Width = 380;
            // 
            // COREN
            // 
            this.COREN.DataPropertyName = "COREN";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COREN.DefaultCellStyle = dataGridViewCellStyle5;
            this.COREN.HeaderText = "COREN";
            this.COREN.Name = "COREN";
            this.COREN.ReadOnly = true;
            this.COREN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.COREN.Width = 120;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.DefaultCellStyle = dataGridViewCellStyle6;
            this.CPF.HeaderText = "C.P.F.";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG.DefaultCellStyle = dataGridViewCellStyle7;
            this.RG.HeaderText = "R.G.";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RG.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle8;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefone.Width = 110;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.DefaultCellStyle = dataGridViewCellStyle9;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Celular.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle10;
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 200;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(945, 372);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 61);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "     &Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizar.Location = new System.Drawing.Point(175, 409);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(86, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(125, 409);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(43, 23);
            this.btnBuscaId.TabIndex = 3;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.AutoSize = true;
            this.lblBuscaId.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaId.ForeColor = System.Drawing.Color.Red;
            this.lblBuscaId.Location = new System.Drawing.Point(12, 395);
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(116, 16);
            this.lblBuscaId.TabIndex = 2322;
            this.lblBuscaId.Text = "Consultar por Cód.";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaId.Location = new System.Drawing.Point(15, 411);
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
            this.txtBuscaNome.Location = new System.Drawing.Point(15, 371);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(325, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarNome.Location = new System.Drawing.Point(13, 352);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(134, 16);
            this.lblBuscarNome.TabIndex = 2323;
            this.lblBuscarNome.Text = "Consultar pelo Nome:";
            // 
            // frmConsultaEnfermeiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 462);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblBuscaId);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.dgvConEnfermeiros);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmConsultaEnfermeiros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Enfermeiros";
            this.Load += new System.EventHandler(this.frmConsultaEnfermeiros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaEnfermeiros_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConEnfermeiros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureFarmacia;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvConEnfermeiros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEnfermeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEnfermeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn COREN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}