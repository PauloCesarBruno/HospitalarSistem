namespace Apresentacao_Usuario
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picCadeado = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomoe = new System.Windows.Forms.Label();
            this.btnLembrarSenha = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtAmarra = new System.Windows.Forms.TextBox();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.checkAdm = new System.Windows.Forms.CheckBox();
            this.picImagemSegredo_Destrava = new System.Windows.Forms.PictureBox();
            this.dgvAdm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picCadeado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemSegredo_Destrava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.ForeColor = System.Drawing.Color.Blue;
            this.btnEntrar.Location = new System.Drawing.Point(194, 310);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 30);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picCadeado
            // 
            this.picCadeado.Image = ((System.Drawing.Image)(resources.GetObject("picCadeado.Image")));
            this.picCadeado.Location = new System.Drawing.Point(-1, 129);
            this.picCadeado.Name = "picCadeado";
            this.picCadeado.Size = new System.Drawing.Size(184, 174);
            this.picCadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadeado.TabIndex = 6;
            this.picCadeado.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 87);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '•';
            this.txtUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 128);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(181, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(303, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // picImg
            // 
            this.picImg.Image = ((System.Drawing.Image)(resources.GetObject("picImg.Image")));
            this.picImg.Location = new System.Drawing.Point(-1, 1);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(410, 125);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 10;
            this.picImg.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(11, 71);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(9, 112);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNomoe
            // 
            this.lblNomoe.AutoSize = true;
            this.lblNomoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomoe.Location = new System.Drawing.Point(11, 32);
            this.lblNomoe.Name = "lblNomoe";
            this.lblNomoe.Size = new System.Drawing.Size(85, 13);
            this.lblNomoe.TabIndex = 14;
            this.lblNomoe.Text = "Nome Completo:";
            // 
            // btnLembrarSenha
            // 
            this.btnLembrarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLembrarSenha.FlatAppearance.BorderSize = 0;
            this.btnLembrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLembrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLembrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLembrarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLembrarSenha.Location = new System.Drawing.Point(1, 309);
            this.btnLembrarSenha.Name = "btnLembrarSenha";
            this.btnLembrarSenha.Size = new System.Drawing.Size(184, 31);
            this.btnLembrarSenha.TabIndex = 6;
            this.btnLembrarSenha.Text = "Esqueci meus &Dados de Login";
            this.btnLembrarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLembrarSenha.UseVisualStyleBackColor = true;
            this.btnLembrarSenha.Click += new System.EventHandler(this.btnLembrarSenha_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtAmarra);
            this.gpbDados.Controls.Add(this.txtBuscaNome);
            this.gpbDados.Controls.Add(this.checkAdm);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.txtUsuario);
            this.gpbDados.Controls.Add(this.lblNomoe);
            this.gpbDados.Controls.Add(this.txtSenha);
            this.gpbDados.Controls.Add(this.lblLogin);
            this.gpbDados.Controls.Add(this.lblSenha);
            this.gpbDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.ForeColor = System.Drawing.Color.Teal;
            this.gpbDados.Location = new System.Drawing.Point(194, 132);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(203, 172);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados de Entrada";
            // 
            // txtAmarra
            // 
            this.txtAmarra.Location = new System.Drawing.Point(72, 149);
            this.txtAmarra.Name = "txtAmarra";
            this.txtAmarra.Size = new System.Drawing.Size(42, 20);
            this.txtAmarra.TabIndex = 16;
            this.txtAmarra.TabStop = false;
            this.txtAmarra.Visible = false;
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(131, 149);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(42, 20);
            this.txtBuscaNome.TabIndex = 13;
            this.txtBuscaNome.TabStop = false;
            this.txtBuscaNome.Visible = false;
            // 
            // checkAdm
            // 
            this.checkAdm.AutoSize = true;
            this.checkAdm.Location = new System.Drawing.Point(12, 150);
            this.checkAdm.Name = "checkAdm";
            this.checkAdm.Size = new System.Drawing.Size(54, 17);
            this.checkAdm.TabIndex = 15;
            this.checkAdm.TabStop = false;
            this.checkAdm.Text = "Adm:";
            this.checkAdm.UseVisualStyleBackColor = true;
            this.checkAdm.Visible = false;
            // 
            // picImagemSegredo_Destrava
            // 
            this.picImagemSegredo_Destrava.Enabled = false;
            this.picImagemSegredo_Destrava.Image = ((System.Drawing.Image)(resources.GetObject("picImagemSegredo_Destrava.Image")));
            this.picImagemSegredo_Destrava.Location = new System.Drawing.Point(7, 314);
            this.picImagemSegredo_Destrava.Name = "picImagemSegredo_Destrava";
            this.picImagemSegredo_Destrava.Size = new System.Drawing.Size(21, 22);
            this.picImagemSegredo_Destrava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagemSegredo_Destrava.TabIndex = 11;
            this.picImagemSegredo_Destrava.TabStop = false;
            this.picImagemSegredo_Destrava.DoubleClick += new System.EventHandler(this.picImagemSegredo_Destrava_DoubleClick);
            // 
            // dgvAdm
            // 
            this.dgvAdm.AllowUserToAddRows = false;
            this.dgvAdm.AllowUserToDeleteRows = false;
            this.dgvAdm.BackgroundColor = System.Drawing.Color.Red;
            this.dgvAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdm.Location = new System.Drawing.Point(119, 88);
            this.dgvAdm.Name = "dgvAdm";
            this.dgvAdm.ReadOnly = true;
            this.dgvAdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdm.Size = new System.Drawing.Size(10, 15);
            this.dgvAdm.TabIndex = 12;
            this.dgvAdm.TabStop = false;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 351);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.dgvAdm);
            this.Controls.Add(this.picImagemSegredo_Destrava);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.btnLembrarSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.picCadeado);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Hospitalar - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCadeado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemSegredo_Destrava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox picCadeado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomoe;
        private System.Windows.Forms.Button btnLembrarSenha;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.PictureBox picImagemSegredo_Destrava;
        private System.Windows.Forms.DataGridView dgvAdm;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.CheckBox checkAdm;
        private System.Windows.Forms.TextBox txtAmarra;
    }
}