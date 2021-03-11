namespace Apresentacao_Usuario
{
    partial class frmAcomodacaoAnterior
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcomodacaoAnterior));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAcomodacaoAnterior = new System.Windows.Forms.DataGridView();
            this.txtCodAcomod = new System.Windows.Forms.TextBox();
            this.lblCodigoAcomodacao = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblTotalDiaria = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDiasAcomodado = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtDataInternacao = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodico = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodacaoAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.dgvAcomodacaoAnterior);
            this.panelTitulo.Location = new System.Drawing.Point(1, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(799, 74);
            this.panelTitulo.TabIndex = 106;
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
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(537, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(215, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Acomodação Anterior";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(171, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvAcomodacaoAnterior
            // 
            this.dgvAcomodacaoAnterior.AllowUserToAddRows = false;
            this.dgvAcomodacaoAnterior.AllowUserToDeleteRows = false;
            this.dgvAcomodacaoAnterior.BackgroundColor = System.Drawing.Color.Red;
            this.dgvAcomodacaoAnterior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcomodacaoAnterior.Location = new System.Drawing.Point(61, 13);
            this.dgvAcomodacaoAnterior.Name = "dgvAcomodacaoAnterior";
            this.dgvAcomodacaoAnterior.ReadOnly = true;
            this.dgvAcomodacaoAnterior.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcomodacaoAnterior.Size = new System.Drawing.Size(18, 15);
            this.dgvAcomodacaoAnterior.TabIndex = 1001;
            this.dgvAcomodacaoAnterior.TabStop = false;
            // 
            // txtCodAcomod
            // 
            this.txtCodAcomod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAcomod.Location = new System.Drawing.Point(117, 165);
            this.txtCodAcomod.Name = "txtCodAcomod";
            this.txtCodAcomod.ReadOnly = true;
            this.txtCodAcomod.Size = new System.Drawing.Size(38, 20);
            this.txtCodAcomod.TabIndex = 3;
            this.txtCodAcomod.TabStop = false;
            // 
            // lblCodigoAcomodacao
            // 
            this.lblCodigoAcomodacao.AutoSize = true;
            this.lblCodigoAcomodacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAcomodacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCodigoAcomodacao.Location = new System.Drawing.Point(6, 168);
            this.lblCodigoAcomodacao.Name = "lblCodigoAcomodacao";
            this.lblCodigoAcomodacao.Size = new System.Drawing.Size(90, 13);
            this.lblCodigoAcomodacao.TabIndex = 2348;
            this.lblCodigoAcomodacao.Text = "Cód. Acomod.:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(117, 272);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(80, 20);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.TabStop = false;
            // 
            // lblTotalDiaria
            // 
            this.lblTotalDiaria.AutoSize = true;
            this.lblTotalDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiaria.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTotalDiaria.Location = new System.Drawing.Point(3, 275);
            this.lblTotalDiaria.Name = "lblTotalDiaria";
            this.lblTotalDiaria.Size = new System.Drawing.Size(77, 13);
            this.lblTotalDiaria.TabIndex = 2346;
            this.lblTotalDiaria.Text = "Total Atual::";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblValor.Location = new System.Drawing.Point(5, 248);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(77, 13);
            this.lblValor.TabIndex = 2345;
            this.lblValor.Text = "Valor Diária:";
            // 
            // lblDiasAcomodado
            // 
            this.lblDiasAcomodado.AutoSize = true;
            this.lblDiasAcomodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasAcomodado.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDiasAcomodado.Location = new System.Drawing.Point(6, 221);
            this.lblDiasAcomodado.Name = "lblDiasAcomodado";
            this.lblDiasAcomodado.Size = new System.Drawing.Size(89, 13);
            this.lblDiasAcomodado.TabIndex = 2344;
            this.lblDiasAcomodado.Text = "Dias Acomod.:";
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(117, 191);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(170, 20);
            this.txtLocal.TabIndex = 4;
            this.txtLocal.TabStop = false;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblLocal.Location = new System.Drawing.Point(7, 194);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(95, 13);
            this.lblLocal.TabIndex = 2342;
            this.lblLocal.Text = "Local Acomod.:";
            // 
            // txtDataInternacao
            // 
            this.txtDataInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInternacao.Location = new System.Drawing.Point(117, 139);
            this.txtDataInternacao.Mask = "00/00/0000";
            this.txtDataInternacao.Name = "txtDataInternacao";
            this.txtDataInternacao.ReadOnly = true;
            this.txtDataInternacao.Size = new System.Drawing.Size(80, 20);
            this.txtDataInternacao.TabIndex = 2;
            this.txtDataInternacao.TabStop = false;
            this.txtDataInternacao.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblData.Location = new System.Drawing.Point(7, 142);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(103, 13);
            this.lblData.TabIndex = 2340;
            this.lblData.Text = "Data Internação:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(117, 112);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TabStop = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNomePaciente.Location = new System.Drawing.Point(7, 115);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(97, 13);
            this.lblNomePaciente.TabIndex = 2339;
            this.lblNomePaciente.Text = "Nome Paciente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Red;
            this.txtCodigo.Location = new System.Drawing.Point(117, 86);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodico
            // 
            this.lblCodico.AutoSize = true;
            this.lblCodico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodico.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCodico.Location = new System.Drawing.Point(8, 89);
            this.lblCodico.Name = "lblCodico";
            this.lblCodico.Size = new System.Drawing.Size(87, 13);
            this.lblCodico.TabIndex = 2338;
            this.lblCodico.Text = "Cód.Paciente:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(117, 245);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(80, 20);
            this.txtValor.TabIndex = 6;
            this.txtValor.TabStop = false;
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(117, 217);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(38, 20);
            this.txtDias.TabIndex = 5;
            this.txtDias.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(316, 224);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 68);
            this.btnInserir.TabIndex = 2350;
            this.btnInserir.Text = "&Inserir Registro";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(307, 142);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaNome.TabIndex = 2351;
            this.txtBuscaNome.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2352;
            this.pictureBox2.TabStop = false;
            // 
            // frmAcomodacaoAnterior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 303);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCodAcomod);
            this.Controls.Add(this.lblCodigoAcomodacao);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTotalDiaria);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDiasAcomodado);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtDataInternacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodico);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcomodacaoAnterior";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acomodacao Anterior";
            this.Load += new System.EventHandler(this.frmAcomodacaoAnterior_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcomodacaoAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAcomodacaoAnterior;
        private System.Windows.Forms.TextBox txtCodAcomod;
        private System.Windows.Forms.Label lblCodigoAcomodacao;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblTotalDiaria;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDiasAcomodado;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.MaskedTextBox txtDataInternacao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodico;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}