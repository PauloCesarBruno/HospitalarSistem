namespace Apresentacao_Usuario
{
    partial class frmMedicamentosRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicamentosRelatorio));
            this.reportMedicamentos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblCodMedicamento = new System.Windows.Forms.Label();
            this.hospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustoMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustoMedicamentoTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblCustoMedicamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustoMedicamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportMedicamentos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblCustoMedicamentoBindingSource;
            this.reportMedicamentos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportMedicamentos.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioMedicamentos.rdlc";
            this.reportMedicamentos.Location = new System.Drawing.Point(1, 66);
            this.reportMedicamentos.Name = "reportMedicamentos";
            this.reportMedicamentos.Size = new System.Drawing.Size(927, 525);
            this.reportMedicamentos.TabIndex = 200;
            this.reportMedicamentos.TabStop = false;
            this.reportMedicamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reportMedicamentos_KeyDown);
            // 
            // txtCodigoMedicamento
            // 
            this.txtCodigoMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMedicamento.Location = new System.Drawing.Point(12, 29);
            this.txtCodigoMedicamento.Multiline = true;
            this.txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            this.txtCodigoMedicamento.Size = new System.Drawing.Size(163, 31);
            this.txtCodigoMedicamento.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.Teal;
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.Location = new System.Drawing.Point(198, 20);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(176, 40);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblCodMedicamento
            // 
            this.lblCodMedicamento.AutoSize = true;
            this.lblCodMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMedicamento.ForeColor = System.Drawing.Color.Teal;
            this.lblCodMedicamento.Location = new System.Drawing.Point(12, 9);
            this.lblCodMedicamento.Name = "lblCodMedicamento";
            this.lblCodMedicamento.Size = new System.Drawing.Size(163, 17);
            this.lblCodMedicamento.TabIndex = 112;
            this.lblCodMedicamento.Text = "Codigo Medicamento:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalDataSetBindingSource
            // 
            this.hospitalDataSetBindingSource.DataSource = this.hospitalDataSet;
            this.hospitalDataSetBindingSource.Position = 0;
            // 
            // tblCustoMedicamentoBindingSource
            // 
            this.tblCustoMedicamentoBindingSource.DataMember = "tblCustoMedicamento";
            this.tblCustoMedicamentoBindingSource.DataSource = this.hospitalDataSetBindingSource;
            // 
            // tblCustoMedicamentoTableAdapter
            // 
            this.tblCustoMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmMedicamentosRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 611);
            this.Controls.Add(this.txtCodigoMedicamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblCodMedicamento);
            this.Controls.Add(this.reportMedicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMedicamentosRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Medicamentos";
            this.Load += new System.EventHandler(this.frmMedicamentosRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustoMedicamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportMedicamentos;
        private System.Windows.Forms.TextBox txtCodigoMedicamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblCodMedicamento;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblCustoMedicamentoBindingSource;
        private HospitalDataSetTableAdapters.tblCustoMedicamentoTableAdapter tblCustoMedicamentoTableAdapter;
    }
}