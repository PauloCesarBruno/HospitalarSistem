namespace Apresentacao_Usuario
{
    partial class frmCadstroInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadstroInsumos));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.dgvCadInsumo = new System.Windows.Forms.DataGridView();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCadInsumos = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpManipulação = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCadInsumos.SuspendLayout();
            this.grpManipulação.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.dgvCadInsumo);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Location = new System.Drawing.Point(3, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(564, 74);
            this.panelTitulo.TabIndex = 108;
            // 
            // dgvCadInsumo
            // 
            this.dgvCadInsumo.BackgroundColor = System.Drawing.Color.Red;
            this.dgvCadInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadInsumo.Location = new System.Drawing.Point(63, 18);
            this.dgvCadInsumo.Name = "dgvCadInsumo";
            this.dgvCadInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadInsumo.Size = new System.Drawing.Size(13, 12);
            this.dgvCadInsumo.TabIndex = 109;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(404, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(149, 24);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Cadastro Insumos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(105, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 41);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
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
            // grpCadInsumos
            // 
            this.grpCadInsumos.Controls.Add(this.txtValor);
            this.grpCadInsumos.Controls.Add(this.lblValor);
            this.grpCadInsumos.Controls.Add(this.txtNome);
            this.grpCadInsumos.Controls.Add(this.lblNome);
            this.grpCadInsumos.Controls.Add(this.txtCodigo);
            this.grpCadInsumos.Controls.Add(this.lblCodigo);
            this.grpCadInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadInsumos.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpCadInsumos.Location = new System.Drawing.Point(3, 81);
            this.grpCadInsumos.Name = "grpCadInsumos";
            this.grpCadInsumos.Size = new System.Drawing.Size(564, 107);
            this.grpCadInsumos.TabIndex = 109;
            this.grpCadInsumos.TabStop = false;
            this.grpCadInsumos.Text = "Cadastro Insumos:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(89, 69);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(104, 20);
            this.txtValor.TabIndex = 12;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(7, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // grpManipulação
            // 
            this.grpManipulação.Controls.Add(this.btnNovo);
            this.grpManipulação.Controls.Add(this.btnExcluir);
            this.grpManipulação.Controls.Add(this.btnAlterar);
            this.grpManipulação.Controls.Add(this.btnInserir);
            this.grpManipulação.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManipulação.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpManipulação.Location = new System.Drawing.Point(3, 194);
            this.grpManipulação.Name = "grpManipulação";
            this.grpManipulação.Size = new System.Drawing.Size(564, 100);
            this.grpManipulação.TabIndex = 110;
            this.grpManipulação.TabStop = false;
            this.grpManipulação.Text = "Manipulação:";
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovo.Location = new System.Drawing.Point(7, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(134, 68);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "&Novo(a) Médico(a)";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(424, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 68);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "&Excluir Médico(a)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(285, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(134, 68);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "&Alterar Médico(a)";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(146, 19);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(134, 68);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "&Inserir Médico(a)";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnSair);
            this.grpConsulta.Controls.Add(this.btnAtualizar);
            this.grpConsulta.Controls.Add(this.btnBuscaId);
            this.grpConsulta.Controls.Add(this.lblBuscarId);
            this.grpConsulta.Controls.Add(this.txtBuscaId);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Controls.Add(this.txtBuscaNome);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpConsulta.Location = new System.Drawing.Point(3, 301);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(564, 79);
            this.grpConsulta.TabIndex = 111;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta:";
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(488, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 55);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Location = new System.Drawing.Point(395, 31);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(74, 23);
            this.btnAtualizar.TabIndex = 25;
            this.btnAtualizar.Text = "&Limpar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Location = new System.Drawing.Point(352, 32);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(37, 23);
            this.btnBuscaId.TabIndex = 24;
            this.btnBuscaId.Text = "OK";
            this.btnBuscaId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaId.UseVisualStyleBackColor = true;
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(243, 16);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(130, 13);
            this.lblBuscarId.TabIndex = 27;
            this.lblBuscarId.Text = "Consultar Por Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(246, 35);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(100, 20);
            this.txtBuscaId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Consultar pelo Nome:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(8, 35);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(223, 20);
            this.txtBuscaNome.TabIndex = 22;
            // 
            // frmCadstroInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 385);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpManipulação);
            this.Controls.Add(this.grpCadInsumos);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadstroInsumos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadstro de Insumos";
            this.Load += new System.EventHandler(this.frmCadstroInsumos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCadInsumos.ResumeLayout(false);
            this.grpCadInsumos.PerformLayout();
            this.grpManipulação.ResumeLayout(false);
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCadInsumo;
        private System.Windows.Forms.GroupBox grpCadInsumos;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpManipulação;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Button btnSair;
    }
}