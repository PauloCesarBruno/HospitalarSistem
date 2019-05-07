namespace Apresentacao_Usuario
{
    partial class frmformularioCustos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmformularioCustos));
            this.RelatorioCustosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.RelatorioCustosTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.RelatorioCustosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioCustosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatorioCustosBindingSource
            // 
            this.RelatorioCustosBindingSource.DataMember = "RelatorioCustos";
            this.RelatorioCustosBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RelatorioCustosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.Custos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(944, 489);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(130, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do(a) Paciente:";
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(216, 11);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(116, 38);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // RelatorioCustosTableAdapter
            // 
            this.RelatorioCustosTableAdapter.ClearBeforeFill = true;
            // 
            // frmformularioCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 544);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmformularioCustos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Custos Pacinte";
            this.Load += new System.EventHandler(this.frmformularioCustos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmformularioCustos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioCustosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.BindingSource RelatorioCustosBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.RelatorioCustosTableAdapter RelatorioCustosTableAdapter;

    }
}