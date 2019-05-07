namespace Apresentacao_Usuario
{
    partial class frmTecnicodeEnfermagemRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTecnicodeEnfermagemRelatorio));
            this.reportTecnicos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNomeTecnico = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.tblTecnicoEnfermagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblTecnicoEnfermagemTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblTecnicoEnfermagemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblTecnicoEnfermagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTecnicos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblTecnicoEnfermagemBindingSource;
            this.reportTecnicos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportTecnicos.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioTecnicos.rdlc";
            this.reportTecnicos.Location = new System.Drawing.Point(1, 66);
            this.reportTecnicos.Name = "reportTecnicos";
            this.reportTecnicos.Size = new System.Drawing.Size(927, 525);
            this.reportTecnicos.TabIndex = 200;
            this.reportTecnicos.TabStop = false;
            // 
            // txtNomeTecnico
            // 
            this.txtNomeTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTecnico.Location = new System.Drawing.Point(12, 29);
            this.txtNomeTecnico.Multiline = true;
            this.txtNomeTecnico.Name = "txtNomeTecnico";
            this.txtNomeTecnico.Size = new System.Drawing.Size(264, 31);
            this.txtNomeTecnico.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.Teal;
            this.lblNomePaciente.Location = new System.Drawing.Point(12, 9);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(264, 16);
            this.lblNomePaciente.TabIndex = 112;
            this.lblNomePaciente.Text = "Nome Técnico(a) ou (%) para todos):";
            // 
            // tblTecnicoEnfermagemBindingSource
            // 
            this.tblTecnicoEnfermagemBindingSource.DataMember = "tblTecnicoEnfermagem";
            this.tblTecnicoEnfermagemBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTecnicoEnfermagemTableAdapter
            // 
            this.tblTecnicoEnfermagemTableAdapter.ClearBeforeFill = true;
            // 
            // frmTecnicodeEnfermagemRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtNomeTecnico);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.reportTecnicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTecnicodeEnfermagemRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Técnicos de Enfermagem";
            this.Load += new System.EventHandler(this.frmTecnicodeEnfermagemRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTecnicodeEnfermagemRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblTecnicoEnfermagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportTecnicos;
        private System.Windows.Forms.TextBox txtNomeTecnico;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.BindingSource tblTecnicoEnfermagemBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblTecnicoEnfermagemTableAdapter tblTecnicoEnfermagemTableAdapter;
    }
}