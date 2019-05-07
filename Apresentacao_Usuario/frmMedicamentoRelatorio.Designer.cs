namespace Apresentacao_Usuario
{
    partial class frmMedicamentoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamentoRelatorio));
            this.reportMedicamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomeMedicamento = new System.Windows.Forms.Label();
            this.tblCustoMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblCustoMedicamentoTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblCustoMedicamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustoMedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportMedicamentos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblCustoMedicamentoBindingSource;
            this.reportMedicamentos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportMedicamentos.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioMedicamento.rdlc";
            this.reportMedicamentos.Location = new System.Drawing.Point(1, 66);
            this.reportMedicamentos.Name = "reportMedicamentos";
            this.reportMedicamentos.Size = new System.Drawing.Size(927, 525);
            this.reportMedicamentos.TabIndex = 200;
            this.reportMedicamentos.TabStop = false;
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMedicamento.Location = new System.Drawing.Point(12, 29);
            this.txtNomeMedicamento.Multiline = true;
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.Size = new System.Drawing.Size(264, 31);
            this.txtNomeMedicamento.TabIndex = 0;
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
            // lblNomeMedicamento
            // 
            this.lblNomeMedicamento.AutoSize = true;
            this.lblNomeMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMedicamento.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeMedicamento.Location = new System.Drawing.Point(12, 9);
            this.lblNomeMedicamento.Name = "lblNomeMedicamento";
            this.lblNomeMedicamento.Size = new System.Drawing.Size(263, 15);
            this.lblNomeMedicamento.TabIndex = 112;
            this.lblNomeMedicamento.Text = "Nome Médicamento ou (%) para todos):";
            // 
            // tblCustoMedicamentoBindingSource
            // 
            this.tblCustoMedicamentoBindingSource.DataMember = "tblCustoMedicamento";
            this.tblCustoMedicamentoBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustoMedicamentoTableAdapter
            // 
            this.tblCustoMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmMedicamentoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtNomeMedicamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomeMedicamento);
            this.Controls.Add(this.reportMedicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMedicamentoRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Medicamentos Custo";
            this.Load += new System.EventHandler(this.frmMedicamentoRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMedicamentoRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustoMedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportMedicamentos;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomeMedicamento;
        private System.Windows.Forms.BindingSource tblCustoMedicamentoBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblCustoMedicamentoTableAdapter tblCustoMedicamentoTableAdapter;
    }
}