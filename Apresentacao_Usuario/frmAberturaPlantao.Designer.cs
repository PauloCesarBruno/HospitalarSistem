namespace Apresentacao_Usuario
{
    partial class frmAberturaPlantao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAberturaPlantao));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpAberturaPlantao = new System.Windows.Forms.GroupBox();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblEscala = new System.Windows.Forms.Label();
            this.btnLimparEscala = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lisTecnicos_Pacientes = new System.Windows.Forms.ListView();
            this.lblTecnico_X_Paciênte = new System.Windows.Forms.Label();
            this.btnRemoverEnfermeiro = new System.Windows.Forms.Button();
            this.listEnfermeiro = new System.Windows.Forms.ListView();
            this.lblEnfermeiros = new System.Windows.Forms.Label();
            this.btnRemoverMedico = new System.Windows.Forms.Button();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.listMedicos = new System.Windows.Forms.ListView();
            this.TreePlantonistas = new System.Windows.Forms.TreeView();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAberturaPlantao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(1, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(916, 74);
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
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(588, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(286, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Abertura de Plantão (Escala)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(191, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // grpAberturaPlantao
            // 
            this.grpAberturaPlantao.Controls.Add(this.lblInformativo);
            this.grpAberturaPlantao.Controls.Add(this.txtUsuario);
            this.grpAberturaPlantao.Controls.Add(this.lblDia);
            this.grpAberturaPlantao.Controls.Add(this.lblEscala);
            this.grpAberturaPlantao.Controls.Add(this.btnLimparEscala);
            this.grpAberturaPlantao.Controls.Add(this.pictureBox2);
            this.grpAberturaPlantao.Controls.Add(this.btnSalvar);
            this.grpAberturaPlantao.Controls.Add(this.btnSair);
            this.grpAberturaPlantao.Controls.Add(this.btnRemoveItem);
            this.grpAberturaPlantao.Controls.Add(this.lisTecnicos_Pacientes);
            this.grpAberturaPlantao.Controls.Add(this.lblTecnico_X_Paciênte);
            this.grpAberturaPlantao.Controls.Add(this.btnRemoverEnfermeiro);
            this.grpAberturaPlantao.Controls.Add(this.listEnfermeiro);
            this.grpAberturaPlantao.Controls.Add(this.lblEnfermeiros);
            this.grpAberturaPlantao.Controls.Add(this.btnRemoverMedico);
            this.grpAberturaPlantao.Controls.Add(this.lblMedicos);
            this.grpAberturaPlantao.Controls.Add(this.listMedicos);
            this.grpAberturaPlantao.Controls.Add(this.TreePlantonistas);
            this.grpAberturaPlantao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAberturaPlantao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.grpAberturaPlantao.Location = new System.Drawing.Point(12, 93);
            this.grpAberturaPlantao.Name = "grpAberturaPlantao";
            this.grpAberturaPlantao.Size = new System.Drawing.Size(894, 524);
            this.grpAberturaPlantao.TabIndex = 0;
            this.grpAberturaPlantao.TabStop = false;
            this.grpAberturaPlantao.Text = "Escala de Pantonistas  / Distribuição Técnicos X Paciêntes";
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.ForeColor = System.Drawing.Color.Red;
            this.lblInformativo.Location = new System.Drawing.Point(24, 27);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(365, 13);
            this.lblInformativo.TabIndex = 36;
            this.lblInformativo.Text = "label e txt invisíveis para Captura do nome do Usuário Logado:";
            this.lblInformativo.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtUsuario.Location = new System.Drawing.Point(395, 24);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(34, 20);
            this.txtUsuario.TabIndex = 35;
            this.txtUsuario.Visible = false;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(607, 16);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(55, 33);
            this.lblDia.TabIndex = 34;
            this.lblDia.Text = "Dia";
            // 
            // lblEscala
            // 
            this.lblEscala.AutoSize = true;
            this.lblEscala.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscala.Location = new System.Drawing.Point(435, 16);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(171, 33);
            this.lblEscala.TabIndex = 33;
            this.lblEscala.Text = "Escala do Dia:";
            // 
            // btnLimparEscala
            // 
            this.btnLimparEscala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparEscala.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimparEscala.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparEscala.Image")));
            this.btnLimparEscala.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimparEscala.Location = new System.Drawing.Point(669, 444);
            this.btnLimparEscala.Name = "btnLimparEscala";
            this.btnLimparEscala.Size = new System.Drawing.Size(99, 68);
            this.btnLimparEscala.TabIndex = 32;
            this.btnLimparEscala.Text = "&Limpar Escala";
            this.btnLimparEscala.UseVisualStyleBackColor = true;
            this.btnLimparEscala.Click += new System.EventHandler(this.btnLimparEscala_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(549, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvar.Location = new System.Drawing.Point(549, 444);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 68);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "S&alvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(789, 444);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 68);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoveItem.Location = new System.Drawing.Point(287, 489);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(184, 23);
            this.btnRemoveItem.TabIndex = 28;
            this.btnRemoveItem.Text = "&Remover Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lisTecnicos_Pacientes
            // 
            this.lisTecnicos_Pacientes.ForeColor = System.Drawing.Color.Red;
            this.lisTecnicos_Pacientes.HideSelection = false;
            this.lisTecnicos_Pacientes.Location = new System.Drawing.Point(287, 321);
            this.lisTecnicos_Pacientes.Name = "lisTecnicos_Pacientes";
            this.lisTecnicos_Pacientes.Size = new System.Drawing.Size(243, 165);
            this.lisTecnicos_Pacientes.TabIndex = 27;
            this.lisTecnicos_Pacientes.UseCompatibleStateImageBehavior = false;
            this.lisTecnicos_Pacientes.View = System.Windows.Forms.View.Tile;
            // 
            // lblTecnico_X_Paciênte
            // 
            this.lblTecnico_X_Paciênte.AutoSize = true;
            this.lblTecnico_X_Paciênte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico_X_Paciênte.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTecnico_X_Paciênte.Location = new System.Drawing.Point(284, 304);
            this.lblTecnico_X_Paciênte.Name = "lblTecnico_X_Paciênte";
            this.lblTecnico_X_Paciênte.Size = new System.Drawing.Size(169, 17);
            this.lblTecnico_X_Paciênte.TabIndex = 26;
            this.lblTecnico_X_Paciênte.Text = "Tecnicos X Paciêntes:";
            // 
            // btnRemoverEnfermeiro
            // 
            this.btnRemoverEnfermeiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverEnfermeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverEnfermeiro.Image")));
            this.btnRemoverEnfermeiro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoverEnfermeiro.Location = new System.Drawing.Point(287, 269);
            this.btnRemoverEnfermeiro.Name = "btnRemoverEnfermeiro";
            this.btnRemoverEnfermeiro.Size = new System.Drawing.Size(184, 23);
            this.btnRemoverEnfermeiro.TabIndex = 25;
            this.btnRemoverEnfermeiro.Text = "Remover &Enfermeiro";
            this.btnRemoverEnfermeiro.UseVisualStyleBackColor = true;
            this.btnRemoverEnfermeiro.Click += new System.EventHandler(this.btnRemoverEnfermeiro_Click);
            // 
            // listEnfermeiro
            // 
            this.listEnfermeiro.HideSelection = false;
            this.listEnfermeiro.Location = new System.Drawing.Point(287, 187);
            this.listEnfermeiro.Name = "listEnfermeiro";
            this.listEnfermeiro.Size = new System.Drawing.Size(243, 79);
            this.listEnfermeiro.TabIndex = 24;
            this.listEnfermeiro.UseCompatibleStateImageBehavior = false;
            this.listEnfermeiro.View = System.Windows.Forms.View.List;
            // 
            // lblEnfermeiros
            // 
            this.lblEnfermeiros.AutoSize = true;
            this.lblEnfermeiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermeiros.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblEnfermeiros.Location = new System.Drawing.Point(284, 170);
            this.lblEnfermeiros.Name = "lblEnfermeiros";
            this.lblEnfermeiros.Size = new System.Drawing.Size(100, 17);
            this.lblEnfermeiros.TabIndex = 23;
            this.lblEnfermeiros.Text = "Enfermeiros:";
            // 
            // btnRemoverMedico
            // 
            this.btnRemoverMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverMedico.Image")));
            this.btnRemoverMedico.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoverMedico.Location = new System.Drawing.Point(287, 134);
            this.btnRemoverMedico.Name = "btnRemoverMedico";
            this.btnRemoverMedico.Size = new System.Drawing.Size(184, 23);
            this.btnRemoverMedico.TabIndex = 22;
            this.btnRemoverMedico.Text = "Remover &Médico";
            this.btnRemoverMedico.UseVisualStyleBackColor = true;
            this.btnRemoverMedico.Click += new System.EventHandler(this.btnRemoverMedico_Click);
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicos.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblMedicos.Location = new System.Drawing.Point(284, 58);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(72, 17);
            this.lblMedicos.TabIndex = 21;
            this.lblMedicos.Text = "Médicos:";
            // 
            // listMedicos
            // 
            this.listMedicos.HideSelection = false;
            this.listMedicos.Location = new System.Drawing.Point(287, 75);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(243, 56);
            this.listMedicos.TabIndex = 20;
            this.listMedicos.UseCompatibleStateImageBehavior = false;
            this.listMedicos.View = System.Windows.Forms.View.List;
            // 
            // TreePlantonistas
            // 
            this.TreePlantonistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TreePlantonistas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TreePlantonistas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TreePlantonistas.Location = new System.Drawing.Point(12, 58);
            this.TreePlantonistas.Name = "TreePlantonistas";
            this.TreePlantonistas.Size = new System.Drawing.Size(254, 454);
            this.TreePlantonistas.TabIndex = 11;
            this.TreePlantonistas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreePlantonistas_AfterSelect);
            // 
            // frmAberturaPlantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 629);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.grpAberturaPlantao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAberturaPlantao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de Plantão (Escala do Dia)";
            this.Load += new System.EventHandler(this.frmAberturaPlantao_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAberturaPlantao.ResumeLayout(false);
            this.grpAberturaPlantao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpAberturaPlantao;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.Button btnLimparEscala;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListView lisTecnicos_Pacientes;
        internal System.Windows.Forms.Label lblTecnico_X_Paciênte;
        private System.Windows.Forms.Button btnRemoverEnfermeiro;
        private System.Windows.Forms.ListView listEnfermeiro;
        internal System.Windows.Forms.Label lblEnfermeiros;
        private System.Windows.Forms.Button btnRemoverMedico;
        internal System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.ListView listMedicos;
        internal System.Windows.Forms.TreeView TreePlantonistas;
    }
}