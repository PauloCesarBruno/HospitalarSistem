namespace Apresentacao_Usuario
{
    partial class frmTratamentoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTratamentoRelatorio));
            this.reportTratamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNomeTratamento = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomeTratamento = new System.Windows.Forms.Label();
            this.tblProcedimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblProcedimentoTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblProcedimentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblProcedimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTratamento
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblProcedimentoBindingSource;
            this.reportTratamento.LocalReport.DataSources.Add(reportDataSource1);
            this.reportTratamento.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioTratamento.rdlc";
            this.reportTratamento.Location = new System.Drawing.Point(1, 66);
            this.reportTratamento.Name = "reportTratamento";
            this.reportTratamento.Size = new System.Drawing.Size(927, 525);
            this.reportTratamento.TabIndex = 200;
            this.reportTratamento.TabStop = false;
            // 
            // txtNomeTratamento
            // 
            this.txtNomeTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTratamento.Location = new System.Drawing.Point(12, 29);
            this.txtNomeTratamento.Multiline = true;
            this.txtNomeTratamento.Name = "txtNomeTratamento";
            this.txtNomeTratamento.Size = new System.Drawing.Size(264, 31);
            this.txtNomeTratamento.TabIndex = 0;
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
            // lblNomeTratamento
            // 
            this.lblNomeTratamento.AutoSize = true;
            this.lblNomeTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTratamento.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeTratamento.Location = new System.Drawing.Point(12, 9);
            this.lblNomeTratamento.Name = "lblNomeTratamento";
            this.lblNomeTratamento.Size = new System.Drawing.Size(269, 15);
            this.lblNomeTratamento.TabIndex = 116;
            this.lblNomeTratamento.Text = "Nome do Tratamento ou (%) para todos):";
            // 
            // tblProcedimentoBindingSource
            // 
            this.tblProcedimentoBindingSource.DataMember = "tblProcedimento";
            this.tblProcedimentoBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProcedimentoTableAdapter
            // 
            this.tblProcedimentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmTratamentoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtNomeTratamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomeTratamento);
            this.Controls.Add(this.reportTratamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTratamentoRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de tratamentos";
            this.Load += new System.EventHandler(this.frmTratamentoRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTratamentoRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblProcedimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportTratamento;
        private System.Windows.Forms.TextBox txtNomeTratamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomeTratamento;
        private System.Windows.Forms.BindingSource tblProcedimentoBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblProcedimentoTableAdapter tblProcedimentoTableAdapter;
    }
}