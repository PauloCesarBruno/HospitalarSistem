namespace Apresentacao_Usuario
{
    partial class frmCustos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustos));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCustos = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodico = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.lblExame = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblInternacao = new System.Windows.Forms.Label();
            this.lblresponsavel = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.btnConInsumo = new System.Windows.Forms.Button();
            this.btnConsMedic = new System.Windows.Forms.Button();
            this.btnConsExame = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.dgvCustos);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(475, 74);
            this.panelTitulo.TabIndex = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(374, 43);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(90, 18);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Add. Custos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(114, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvCustos
            // 
            this.dgvCustos.AllowUserToAddRows = false;
            this.dgvCustos.AllowUserToDeleteRows = false;
            this.dgvCustos.BackgroundColor = System.Drawing.Color.Red;
            this.dgvCustos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustos.Location = new System.Drawing.Point(43, 13);
            this.dgvCustos.Name = "dgvCustos";
            this.dgvCustos.ReadOnly = true;
            this.dgvCustos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustos.Size = new System.Drawing.Size(24, 25);
            this.dgvCustos.TabIndex = 103;
            this.dgvCustos.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(244, 91);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(205, 20);
            this.txtNome.TabIndex = 302;
            this.txtNome.TabStop = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNomePaciente.Location = new System.Drawing.Point(198, 94);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(43, 13);
            this.lblNomePaciente.TabIndex = 304;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Red;
            this.txtCodigo.Location = new System.Drawing.Point(95, 91);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 301;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodico
            // 
            this.lblCodico.AutoSize = true;
            this.lblCodico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodico.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCodico.Location = new System.Drawing.Point(5, 94);
            this.lblCodico.Name = "lblCodico";
            this.lblCodico.Size = new System.Drawing.Size(87, 13);
            this.lblCodico.TabIndex = 303;
            this.lblCodico.Text = "Cód.Paciente:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(7, 160);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 72);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtExame
            // 
            this.txtExame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtExame.ForeColor = System.Drawing.Color.Black;
            this.txtExame.Location = new System.Drawing.Point(184, 212);
            this.txtExame.MaxLength = 20;
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(51, 20);
            this.txtExame.TabIndex = 4;
            this.txtExame.Visible = false;
            this.txtExame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExame_KeyPress);
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExame.Location = new System.Drawing.Point(94, 215);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(48, 13);
            this.lblExame.TabIndex = 2304;
            this.lblExame.Text = "Exame:";
            this.lblExame.Visible = false;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMedicamento.ForeColor = System.Drawing.Color.Black;
            this.txtMedicamento.Location = new System.Drawing.Point(184, 186);
            this.txtMedicamento.MaxLength = 20;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(51, 20);
            this.txtMedicamento.TabIndex = 3;
            this.txtMedicamento.Visible = false;
            this.txtMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicamento_KeyPress);
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(95, 189);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(86, 13);
            this.lblMedicamento.TabIndex = 2307;
            this.lblMedicamento.Text = "Medicamento:";
            this.lblMedicamento.Visible = false;
            // 
            // txtInsumo
            // 
            this.txtInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInsumo.ForeColor = System.Drawing.Color.Black;
            this.txtInsumo.Location = new System.Drawing.Point(184, 160);
            this.txtInsumo.MaxLength = 20;
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(51, 20);
            this.txtInsumo.TabIndex = 2;
            this.txtInsumo.Visible = false;
            this.txtInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsumo_KeyPress);
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumo.Location = new System.Drawing.Point(96, 163);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(51, 13);
            this.lblInsumo.TabIndex = 2306;
            this.lblInsumo.Text = "Insumo:";
            this.lblInsumo.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-399, 117);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 2305;
            this.textBox1.TabStop = false;
            // 
            // btnInsere
            // 
            this.btnInsere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsere.Image = ((System.Drawing.Image)(resources.GetObject("btnInsere.Image")));
            this.btnInsere.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInsere.Location = new System.Drawing.Point(289, 160);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(89, 75);
            this.btnInsere.TabIndex = 2308;
            this.btnInsere.Text = "&Inserir";
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
            this.btnSair.Location = new System.Drawing.Point(393, 202);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 2309;
            this.btnSair.Text = "  &Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtData.ForeColor = System.Drawing.Color.Black;
            this.txtData.Location = new System.Drawing.Point(398, 120);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(51, 20);
            this.txtData.TabIndex = 2310;
            this.txtData.TabStop = false;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.Visible = false;
            // 
            // lblInternacao
            // 
            this.lblInternacao.AutoSize = true;
            this.lblInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternacao.Location = new System.Drawing.Point(306, 123);
            this.lblInternacao.Name = "lblInternacao";
            this.lblInternacao.Size = new System.Drawing.Size(87, 13);
            this.lblInternacao.TabIndex = 2311;
            this.lblInternacao.Text = "Data (Oculta):";
            this.lblInternacao.Visible = false;
            // 
            // lblresponsavel
            // 
            this.lblresponsavel.AutoSize = true;
            this.lblresponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresponsavel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblresponsavel.Location = new System.Drawing.Point(5, 123);
            this.lblresponsavel.Name = "lblresponsavel";
            this.lblresponsavel.Size = new System.Drawing.Size(78, 13);
            this.lblresponsavel.TabIndex = 2312;
            this.lblresponsavel.Text = "Inserido por:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.Location = new System.Drawing.Point(95, 120);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(205, 20);
            this.txtResponsavel.TabIndex = 2313;
            // 
            // btnConInsumo
            // 
            this.btnConInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnConInsumo.Image")));
            this.btnConInsumo.Location = new System.Drawing.Point(241, 160);
            this.btnConInsumo.Name = "btnConInsumo";
            this.btnConInsumo.Size = new System.Drawing.Size(35, 21);
            this.btnConInsumo.TabIndex = 2314;
            this.btnConInsumo.UseVisualStyleBackColor = true;
            this.btnConInsumo.Visible = false;
            this.btnConInsumo.Click += new System.EventHandler(this.btnConInsumo_Click);
            // 
            // btnConsMedic
            // 
            this.btnConsMedic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsMedic.Image = ((System.Drawing.Image)(resources.GetObject("btnConsMedic.Image")));
            this.btnConsMedic.Location = new System.Drawing.Point(241, 185);
            this.btnConsMedic.Name = "btnConsMedic";
            this.btnConsMedic.Size = new System.Drawing.Size(35, 21);
            this.btnConsMedic.TabIndex = 2315;
            this.btnConsMedic.UseVisualStyleBackColor = true;
            this.btnConsMedic.Visible = false;
            this.btnConsMedic.Click += new System.EventHandler(this.btnConsMedic_Click);
            // 
            // btnConsExame
            // 
            this.btnConsExame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsExame.Image = ((System.Drawing.Image)(resources.GetObject("btnConsExame.Image")));
            this.btnConsExame.Location = new System.Drawing.Point(241, 211);
            this.btnConsExame.Name = "btnConsExame";
            this.btnConsExame.Size = new System.Drawing.Size(35, 21);
            this.btnConsExame.TabIndex = 2316;
            this.btnConsExame.UseVisualStyleBackColor = true;
            this.btnConsExame.Visible = false;
            this.btnConsExame.Click += new System.EventHandler(this.btnConsExame_Click);
            // 
            // frmCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 245);
            this.Controls.Add(this.btnConsExame);
            this.Controls.Add(this.btnConsMedic);
            this.Controls.Add(this.btnConInsumo);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.lblresponsavel);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblInternacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInsere);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodico);
            this.Controls.Add(this.panelTitulo);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add. Custos";
            this.Load += new System.EventHandler(this.frmCustos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustos_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCustos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodico;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblInternacao;
        private System.Windows.Forms.Label lblresponsavel;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Button btnConInsumo;
        private System.Windows.Forms.Button btnConsMedic;
        private System.Windows.Forms.Button btnConsExame;
    }
}