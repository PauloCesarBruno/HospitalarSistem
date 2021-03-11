namespace Apresentacao_Usuario
{
    partial class frmConsultaLocalAcomodacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaLocalAcomodacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvConsultaLocalAcomodacao = new System.Windows.Forms.DataGridView();
            this.IdDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasAcomodados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAcomodacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.txtCapCodigo = new System.Windows.Forms.TextBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalAcomodacao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(507, 74);
            this.panelTitulo.TabIndex = 110;
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
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(339, 43);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(153, 14);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Consulta Local Acomodação";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(104, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 28);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvConsultaLocalAcomodacao
            // 
            this.dgvConsultaLocalAcomodacao.AllowUserToAddRows = false;
            this.dgvConsultaLocalAcomodacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvConsultaLocalAcomodacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaLocalAcomodacao.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaLocalAcomodacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLocalAcomodacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDiaria,
            this.LocalAcomodado,
            this.DiasAcomodados,
            this.ValorAcomodacao});
            this.dgvConsultaLocalAcomodacao.Location = new System.Drawing.Point(3, 77);
            this.dgvConsultaLocalAcomodacao.Name = "dgvConsultaLocalAcomodacao";
            this.dgvConsultaLocalAcomodacao.ReadOnly = true;
            this.dgvConsultaLocalAcomodacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaLocalAcomodacao.Size = new System.Drawing.Size(507, 236);
            this.dgvConsultaLocalAcomodacao.TabIndex = 111;
            this.dgvConsultaLocalAcomodacao.TabStop = false;
            this.dgvConsultaLocalAcomodacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaLocalAcomodacao_CellClick);
            // 
            // IdDiaria
            // 
            this.IdDiaria.DataPropertyName = "IdDiaria";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.IdDiaria.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdDiaria.HeaderText = "Código";
            this.IdDiaria.Name = "IdDiaria";
            this.IdDiaria.ReadOnly = true;
            this.IdDiaria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LocalAcomodado
            // 
            this.LocalAcomodado.DataPropertyName = "LocalAcomodado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalAcomodado.DefaultCellStyle = dataGridViewCellStyle3;
            this.LocalAcomodado.HeaderText = "Nome do Local de Acomodação";
            this.LocalAcomodado.Name = "LocalAcomodado";
            this.LocalAcomodado.ReadOnly = true;
            this.LocalAcomodado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalAcomodado.Width = 254;
            // 
            // DiasAcomodados
            // 
            this.DiasAcomodados.DataPropertyName = "DiasAcomodados";
            this.DiasAcomodados.HeaderText = "Dias";
            this.DiasAcomodados.Name = "DiasAcomodados";
            this.DiasAcomodados.ReadOnly = true;
            this.DiasAcomodados.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DiasAcomodados.Visible = false;
            this.DiasAcomodados.Width = 50;
            // 
            // ValorAcomodacao
            // 
            this.ValorAcomodacao.DataPropertyName = "ValorAcomodacao";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Format = "C2";
            this.ValorAcomodacao.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorAcomodacao.HeaderText = "Valor";
            this.ValorAcomodacao.Name = "ValorAcomodacao";
            this.ValorAcomodacao.ReadOnly = true;
            this.ValorAcomodacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorAcomodacao.Width = 110;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(411, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 69);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarNome.Location = new System.Drawing.Point(12, 317);
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
            this.btnAtualizar.Location = new System.Drawing.Point(174, 374);
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
            this.btnBuscaId.Location = new System.Drawing.Point(124, 374);
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
            this.lblBuscaId.Location = new System.Drawing.Point(11, 360);
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
            this.txtBuscaId.Location = new System.Drawing.Point(14, 376);
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
            this.txtBuscaNome.Location = new System.Drawing.Point(14, 336);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(325, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // txtCapCodigo
            // 
            this.txtCapCodigo.Location = new System.Drawing.Point(266, 376);
            this.txtCapCodigo.Name = "txtCapCodigo";
            this.txtCapCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCapCodigo.TabIndex = 2345;
            this.txtCapCodigo.Visible = false;
            // 
            // frmConsultaLocalAcomodacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 402);
            this.Controls.Add(this.txtCapCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblBuscaId);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.dgvConsultaLocalAcomodacao);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmConsultaLocalAcomodacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Local de Acomodacao";
            this.Load += new System.EventHandler(this.frmConsultaLocalAcomodacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaLocalAcomodacao_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLocalAcomodacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvConsultaLocalAcomodacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasAcomodados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAcomodacao;
        private System.Windows.Forms.TextBox txtCapCodigo;
    }
}