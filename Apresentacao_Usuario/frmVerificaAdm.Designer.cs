namespace Apresentacao_Usuario
{
    partial class frmVerificaAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerificaAdm));
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSolicitacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.checkAtivar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(253, 125);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Cancelar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(31, 141);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(294, 23);
            this.lblAviso.TabIndex = 59;
            this.lblAviso.Text = "Login de Admin. não Validado!";
            this.lblAviso.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(253, 40);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 60);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(90, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(152, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(42, 95);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 53;
            this.lblSenha.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(44, 69);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 52;
            this.lblLogin.Text = "Login: ";
            // 
            // lblSolicitacao
            // 
            this.lblSolicitacao.AutoSize = true;
            this.lblSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitacao.ForeColor = System.Drawing.Color.Teal;
            this.lblSolicitacao.Location = new System.Drawing.Point(14, 12);
            this.lblSolicitacao.Name = "lblSolicitacao";
            this.lblSolicitacao.Size = new System.Drawing.Size(331, 16);
            this.lblSolicitacao.TabIndex = 58;
            this.lblSolicitacao.Text = "Por favor! Confirme os dados de Administrador";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(89, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(152, 20);
            this.txtNome.TabIndex = 10;
            this.txtNome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "N.Completo:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(90, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '•';
            this.txtUsuario.Size = new System.Drawing.Size(152, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.UseSystemPasswordChar = true;
            // 
            // checkAtivar
            // 
            this.checkAtivar.AutoSize = true;
            this.checkAtivar.ForeColor = System.Drawing.Color.Blue;
            this.checkAtivar.Location = new System.Drawing.Point(45, 118);
            this.checkAtivar.Name = "checkAtivar";
            this.checkAtivar.Size = new System.Drawing.Size(147, 17);
            this.checkAtivar.TabIndex = 62;
            this.checkAtivar.TabStop = false;
            this.checkAtivar.Text = "Ativar Para Administrador.";
            this.checkAtivar.UseVisualStyleBackColor = true;
            this.checkAtivar.CheckedChanged += new System.EventHandler(this.checkAtivar_CheckedChanged);
            // 
            // frmVerificaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 168);
            this.Controls.Add(this.checkAtivar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSolicitacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmVerificaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorização";
            this.Load += new System.EventHandler(this.frmVerificaAdm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVerificaAdm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSolicitacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox checkAtivar;
    }
}