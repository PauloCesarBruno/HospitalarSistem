namespace Apresentacao_Usuario
{
    partial class frmAlmoxarifadoInsumoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmoxarifadoInsumoRelatorio));
            this.tblAlmoxarifadoInsumosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.reportAlmoxarifadoInsumos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtAlmoxarifadoInsumos = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomeInsumos = new System.Windows.Forms.Label();
            this.tblAlmoxarifadoInsumosTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblAlmoxarifadoInsumosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlmoxarifadoInsumosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAlmoxarifadoInsumosBindingSource
            // 
            this.tblAlmoxarifadoInsumosBindingSource.DataMember = "tblAlmoxarifadoInsumos";
            this.tblAlmoxarifadoInsumosBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportAlmoxarifadoInsumos
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblAlmoxarifadoInsumosBindingSource;
            this.reportAlmoxarifadoInsumos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportAlmoxarifadoInsumos.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioAlmoxarifadoInsumos.rdlc";
            this.reportAlmoxarifadoInsumos.Location = new System.Drawing.Point(1, 66);
            this.reportAlmoxarifadoInsumos.Name = "reportAlmoxarifadoInsumos";
            this.reportAlmoxarifadoInsumos.Size = new System.Drawing.Size(927, 525);
            this.reportAlmoxarifadoInsumos.TabIndex = 200;
            this.reportAlmoxarifadoInsumos.TabStop = false;
            // 
            // txtAlmoxarifadoInsumos
            // 
            this.txtAlmoxarifadoInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmoxarifadoInsumos.Location = new System.Drawing.Point(12, 29);
            this.txtAlmoxarifadoInsumos.Multiline = true;
            this.txtAlmoxarifadoInsumos.Name = "txtAlmoxarifadoInsumos";
            this.txtAlmoxarifadoInsumos.Size = new System.Drawing.Size(264, 31);
            this.txtAlmoxarifadoInsumos.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblNomeInsumos
            // 
            this.lblNomeInsumos.AutoSize = true;
            this.lblNomeInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeInsumos.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeInsumos.Location = new System.Drawing.Point(12, 11);
            this.lblNomeInsumos.Name = "lblNomeInsumos";
            this.lblNomeInsumos.Size = new System.Drawing.Size(212, 13);
            this.lblNomeInsumos.TabIndex = 128;
            this.lblNomeInsumos.Text = "Nome do Insumo ou (%) para todos):";
            // 
            // tblAlmoxarifadoInsumosTableAdapter
            // 
            this.tblAlmoxarifadoInsumosTableAdapter.ClearBeforeFill = true;
            // 
            // frmAlmoxarifadoInsumoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtAlmoxarifadoInsumos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomeInsumos);
            this.Controls.Add(this.reportAlmoxarifadoInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAlmoxarifadoInsumoRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Estoque Insumos";
            this.Load += new System.EventHandler(this.frmAlmoxarifadoInsumoRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAlmoxarifadoInsumoRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblAlmoxarifadoInsumosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportAlmoxarifadoInsumos;
        private System.Windows.Forms.TextBox txtAlmoxarifadoInsumos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomeInsumos;
        private System.Windows.Forms.BindingSource tblAlmoxarifadoInsumosBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblAlmoxarifadoInsumosTableAdapter tblAlmoxarifadoInsumosTableAdapter;
    }
}