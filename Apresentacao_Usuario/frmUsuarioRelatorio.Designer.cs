namespace Apresentacao_Usuario
{
    partial class frmUsuarioRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioRelatorio));
            this.reportUsuariosdoSistema = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomeUsuarios = new System.Windows.Forms.Label();
            this.tblUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblUsuarioTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportUsuariosdoSistema
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblUsuarioBindingSource;
            this.reportUsuariosdoSistema.LocalReport.DataSources.Add(reportDataSource1);
            this.reportUsuariosdoSistema.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatórioUsuariosDoSistema.rdlc";
            this.reportUsuariosdoSistema.Location = new System.Drawing.Point(1, 66);
            this.reportUsuariosdoSistema.Name = "reportUsuariosdoSistema";
            this.reportUsuariosdoSistema.Size = new System.Drawing.Size(927, 525);
            this.reportUsuariosdoSistema.TabIndex = 200;
            this.reportUsuariosdoSistema.TabStop = false;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(12, 29);
            this.txtNomeUsuario.Multiline = true;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(264, 31);
            this.txtNomeUsuario.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(795, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.Teal;
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.Location = new System.Drawing.Point(296, 20);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(176, 40);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblNomeUsuarios
            // 
            this.lblNomeUsuarios.AutoSize = true;
            this.lblNomeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuarios.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lblNomeUsuarios.Name = "lblNomeUsuarios";
            this.lblNomeUsuarios.Size = new System.Drawing.Size(244, 15);
            this.lblNomeUsuarios.TabIndex = 124;
            this.lblNomeUsuarios.Text = "Nome Usuario(a) ou (%) para todos):";
            // 
            // tblUsuarioBindingSource
            // 
            this.tblUsuarioBindingSource.DataMember = "tblUsuario";
            this.tblUsuarioBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsuarioTableAdapter
            // 
            this.tblUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuarioRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomeUsuarios);
            this.Controls.Add(this.reportUsuariosdoSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmUsuarioRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Usuários do Sistema";
            this.Load += new System.EventHandler(this.frmUsuarioRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuarioRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportUsuariosdoSistema;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomeUsuarios;
        private System.Windows.Forms.BindingSource tblUsuarioBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblUsuarioTableAdapter tblUsuarioTableAdapter;
    }
}