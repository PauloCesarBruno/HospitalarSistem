namespace Apresentacao_Usuario
{
    partial class frmAcomodacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcomodacao));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAcomodacao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtControlaDia = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodico = new System.Windows.Forms.Label();
            this.txtInternacao = new System.Windows.Forms.MaskedTextBox();
            this.lblInternacao = new System.Windows.Forms.Label();
            this.txtDiasInternados = new System.Windows.Forms.TextBox();
            this.lblDiasInternados = new System.Windows.Forms.Label();
            this.lblAcomodacao = new System.Windows.Forms.Label();
            this.txtAcomodacao = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.btnAcomodacoes = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodacao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.dgvAcomodacao);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.txtControlaDia);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(521, 74);
            this.panelTitulo.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgvAcomodacao
            // 
            this.dgvAcomodacao.AllowUserToAddRows = false;
            this.dgvAcomodacao.AllowUserToDeleteRows = false;
            this.dgvAcomodacao.BackgroundColor = System.Drawing.Color.Red;
            this.dgvAcomodacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcomodacao.Location = new System.Drawing.Point(63, 13);
            this.dgvAcomodacao.Name = "dgvAcomodacao";
            this.dgvAcomodacao.ReadOnly = true;
            this.dgvAcomodacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcomodacao.Size = new System.Drawing.Size(12, 15);
            this.dgvAcomodacao.TabIndex = 104;
            this.dgvAcomodacao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2319;
            this.label1.Text = "Hoje:";
            this.label1.Visible = false;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(376, 43);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(125, 18);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Add. Acomodação";
            // 
            // txtControlaDia
            // 
            this.txtControlaDia.Location = new System.Drawing.Point(412, 8);
            this.txtControlaDia.Name = "txtControlaDia";
            this.txtControlaDia.ReadOnly = true;
            this.txtControlaDia.Size = new System.Drawing.Size(89, 20);
            this.txtControlaDia.TabIndex = 2318;
            this.txtControlaDia.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(100, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(286, 87);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 306;
            this.txtNome.TabStop = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNomePaciente.Location = new System.Drawing.Point(232, 90);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(43, 13);
            this.lblNomePaciente.TabIndex = 308;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Red;
            this.txtCodigo.Location = new System.Drawing.Point(112, 87);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 305;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodico
            // 
            this.lblCodico.AutoSize = true;
            this.lblCodico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodico.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCodico.Location = new System.Drawing.Point(7, 90);
            this.lblCodico.Name = "lblCodico";
            this.lblCodico.Size = new System.Drawing.Size(87, 13);
            this.lblCodico.TabIndex = 307;
            this.lblCodico.Text = "Cód.Paciente:";
            // 
            // txtInternacao
            // 
            this.txtInternacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternacao.ForeColor = System.Drawing.Color.Black;
            this.txtInternacao.Location = new System.Drawing.Point(112, 113);
            this.txtInternacao.Mask = "00/00/0000";
            this.txtInternacao.Name = "txtInternacao";
            this.txtInternacao.ReadOnly = true;
            this.txtInternacao.Size = new System.Drawing.Size(89, 20);
            this.txtInternacao.TabIndex = 2316;
            this.txtInternacao.TabStop = false;
            this.txtInternacao.ValidatingType = typeof(System.DateTime);
            // 
            // lblInternacao
            // 
            this.lblInternacao.AutoSize = true;
            this.lblInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblInternacao.Location = new System.Drawing.Point(6, 116);
            this.lblInternacao.Name = "lblInternacao";
            this.lblInternacao.Size = new System.Drawing.Size(72, 13);
            this.lblInternacao.TabIndex = 2317;
            this.lblInternacao.Text = "Internação:";
            // 
            // txtDiasInternados
            // 
            this.txtDiasInternados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDiasInternados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasInternados.ForeColor = System.Drawing.Color.Red;
            this.txtDiasInternados.Location = new System.Drawing.Point(331, 116);
            this.txtDiasInternados.MaxLength = 10;
            this.txtDiasInternados.Name = "txtDiasInternados";
            this.txtDiasInternados.ReadOnly = true;
            this.txtDiasInternados.Size = new System.Drawing.Size(89, 20);
            this.txtDiasInternados.TabIndex = 2320;
            this.txtDiasInternados.TabStop = false;
            this.txtDiasInternados.Visible = false;
            // 
            // lblDiasInternados
            // 
            this.lblDiasInternados.AutoSize = true;
            this.lblDiasInternados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasInternados.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDiasInternados.Location = new System.Drawing.Point(231, 119);
            this.lblDiasInternados.Name = "lblDiasInternados";
            this.lblDiasInternados.Size = new System.Drawing.Size(94, 13);
            this.lblDiasInternados.TabIndex = 2321;
            this.lblDiasInternados.Text = "Dias Internado:";
            this.lblDiasInternados.Visible = false;
            // 
            // lblAcomodacao
            // 
            this.lblAcomodacao.AutoSize = true;
            this.lblAcomodacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcomodacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblAcomodacao.Location = new System.Drawing.Point(133, 162);
            this.lblAcomodacao.Name = "lblAcomodacao";
            this.lblAcomodacao.Size = new System.Drawing.Size(84, 13);
            this.lblAcomodacao.TabIndex = 2322;
            this.lblAcomodacao.Text = "Acomodação:";
            this.lblAcomodacao.Visible = false;
            // 
            // txtAcomodacao
            // 
            this.txtAcomodacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAcomodacao.ForeColor = System.Drawing.Color.Black;
            this.txtAcomodacao.Location = new System.Drawing.Point(222, 159);
            this.txtAcomodacao.MaxLength = 20;
            this.txtAcomodacao.Name = "txtAcomodacao";
            this.txtAcomodacao.Size = new System.Drawing.Size(43, 20);
            this.txtAcomodacao.TabIndex = 1;
            this.txtAcomodacao.Visible = false;
            this.txtAcomodacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcomodacao_KeyPress);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(10, 147);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 42);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "  &Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnInsere
            // 
            this.btnInsere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsere.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnInsere.Image = ((System.Drawing.Image)(resources.GetObject("btnInsere.Image")));
            this.btnInsere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsere.Location = new System.Drawing.Point(309, 147);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(111, 42);
            this.btnInsere.TabIndex = 2;
            this.btnInsere.Text = "  &Prosseguir";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Visible = false;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(449, 166);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "  &Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(480, 121);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(24, 20);
            this.txtBuscaNome.TabIndex = 2327;
            this.txtBuscaNome.TabStop = false;
            this.txtBuscaNome.Visible = false;
            // 
            // btnAcomodacoes
            // 
            this.btnAcomodacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcomodacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAcomodacoes.Image")));
            this.btnAcomodacoes.Location = new System.Drawing.Point(268, 158);
            this.btnAcomodacoes.Name = "btnAcomodacoes";
            this.btnAcomodacoes.Size = new System.Drawing.Size(35, 21);
            this.btnAcomodacoes.TabIndex = 2328;
            this.btnAcomodacoes.UseVisualStyleBackColor = true;
            this.btnAcomodacoes.Visible = false;
            this.btnAcomodacoes.Click += new System.EventHandler(this.btnAcomodacoes_Click);
            // 
            // frmAcomodacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 200);
            this.Controls.Add(this.btnAcomodacoes);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtAcomodacao);
            this.Controls.Add(this.lblAcomodacao);
            this.Controls.Add(this.txtDiasInternados);
            this.Controls.Add(this.lblDiasInternados);
            this.Controls.Add(this.txtInternacao);
            this.Controls.Add(this.lblInternacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodico);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcomodacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add. Acomodação";
            this.Load += new System.EventHandler(this.frmAcomodacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAcomodacao_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAcomodacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtControlaDia;
        private System.Windows.Forms.MaskedTextBox txtInternacao;
        private System.Windows.Forms.Label lblInternacao;
        private System.Windows.Forms.TextBox txtDiasInternados;
        private System.Windows.Forms.Label lblDiasInternados;
        private System.Windows.Forms.Label lblAcomodacao;
        private System.Windows.Forms.TextBox txtAcomodacao;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnAcomodacoes;
    }
}