namespace Apresentacao_Usuario
{
    partial class frmImpressaoCustosdeUso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressaoCustosdeUso));
            this.reportCustosdeUso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.CustosdeUsoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustosdeUsoTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.CustosdeUsoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustosdeUsoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportCustosdeUso
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustosdeUsoBindingSource;
            this.reportCustosdeUso.LocalReport.DataSources.Add(reportDataSource1);
            this.reportCustosdeUso.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.CustosUso.rdlc";
            this.reportCustosdeUso.Location = new System.Drawing.Point(0, 52);
            this.reportCustosdeUso.Name = "reportCustosdeUso";
            this.reportCustosdeUso.Size = new System.Drawing.Size(785, 372);
            this.reportCustosdeUso.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(130, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do(a) Paciente:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(209, 24);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(113, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "&Gerar Relatorio";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustosdeUsoBindingSource
            // 
            this.CustosdeUsoBindingSource.DataMember = "CustosdeUso";
            this.CustosdeUsoBindingSource.DataSource = this.HospitalDataSet;
            // 
            // CustosdeUsoTableAdapter
            // 
            this.CustosdeUsoTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpressaoCustosdeUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 423);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.reportCustosdeUso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmImpressaoCustosdeUso";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Custos de Uso Paciente";
            this.Load += new System.EventHandler(this.frmImpressaoCustosdeUso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustosdeUsoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportCustosdeUso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.BindingSource CustosdeUsoBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.CustosdeUsoTableAdapter CustosdeUsoTableAdapter;

    }
}