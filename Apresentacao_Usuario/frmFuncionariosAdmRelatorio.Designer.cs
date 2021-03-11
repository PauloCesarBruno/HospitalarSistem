namespace Apresentacao_Usuario
{
    partial class frmFuncionariosAdmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionariosAdmRelatorio));
            this.reportFuncionariosAdministrativos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtFuncionariosAdm = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblFuncAdm = new System.Windows.Forms.Label();
            this.tblOutrosFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblOutrosFuncionariosTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblOutrosFuncionariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblOutrosFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportFuncionariosAdministrativos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblOutrosFuncionariosBindingSource;
            this.reportFuncionariosAdministrativos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportFuncionariosAdministrativos.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioFuncionariosAdm.rdlc";
            this.reportFuncionariosAdministrativos.Location = new System.Drawing.Point(1, 66);
            this.reportFuncionariosAdministrativos.Name = "reportFuncionariosAdministrativos";
            this.reportFuncionariosAdministrativos.Size = new System.Drawing.Size(927, 525);
            this.reportFuncionariosAdministrativos.TabIndex = 200;
            this.reportFuncionariosAdministrativos.TabStop = false;
            // 
            // txtFuncionariosAdm
            // 
            this.txtFuncionariosAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionariosAdm.Location = new System.Drawing.Point(12, 29);
            this.txtFuncionariosAdm.Multiline = true;
            this.txtFuncionariosAdm.Name = "txtFuncionariosAdm";
            this.txtFuncionariosAdm.Size = new System.Drawing.Size(264, 31);
            this.txtFuncionariosAdm.TabIndex = 0;
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
            // lblFuncAdm
            // 
            this.lblFuncAdm.AutoSize = true;
            this.lblFuncAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncAdm.ForeColor = System.Drawing.Color.Teal;
            this.lblFuncAdm.Location = new System.Drawing.Point(12, 9);
            this.lblFuncAdm.Name = "lblFuncAdm";
            this.lblFuncAdm.Size = new System.Drawing.Size(270, 15);
            this.lblFuncAdm.TabIndex = 120;
            this.lblFuncAdm.Text = "Nome Funcionário(a) ou (%) para todos):";
            // 
            // tblOutrosFuncionariosBindingSource
            // 
            this.tblOutrosFuncionariosBindingSource.DataMember = "tblOutrosFuncionarios";
            this.tblOutrosFuncionariosBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOutrosFuncionariosTableAdapter
            // 
            this.tblOutrosFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmFuncionariosAdmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtFuncionariosAdm);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblFuncAdm);
            this.Controls.Add(this.reportFuncionariosAdministrativos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFuncionariosAdmRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Funcionários Administrativos";
            this.Load += new System.EventHandler(this.frmFuncionariosAdmRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFuncionariosAdmRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblOutrosFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportFuncionariosAdministrativos;
        private System.Windows.Forms.TextBox txtFuncionariosAdm;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblFuncAdm;
        private System.Windows.Forms.BindingSource tblOutrosFuncionariosBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblOutrosFuncionariosTableAdapter tblOutrosFuncionariosTableAdapter;
    }
}