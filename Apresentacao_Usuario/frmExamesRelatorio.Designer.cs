namespace Apresentacao_Usuario
{
    partial class frmExamesRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamesRelatorio));
            this.reportExamesCusto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtNomeExames = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomeExames = new System.Windows.Forms.Label();
            this.tblCustoExameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblCustoExameTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblCustoExameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustoExameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportExamesCusto
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblCustoExameBindingSource;
            this.reportExamesCusto.LocalReport.DataSources.Add(reportDataSource1);
            this.reportExamesCusto.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioExames.rdlc";
            this.reportExamesCusto.Location = new System.Drawing.Point(1, 66);
            this.reportExamesCusto.Name = "reportExamesCusto";
            this.reportExamesCusto.Size = new System.Drawing.Size(927, 525);
            this.reportExamesCusto.TabIndex = 200;
            this.reportExamesCusto.TabStop = false;
            // 
            // txtNomeExames
            // 
            this.txtNomeExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeExames.Location = new System.Drawing.Point(12, 29);
            this.txtNomeExames.Multiline = true;
            this.txtNomeExames.Name = "txtNomeExames";
            this.txtNomeExames.Size = new System.Drawing.Size(264, 31);
            this.txtNomeExames.TabIndex = 0;
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
            // lblNomeExames
            // 
            this.lblNomeExames.AutoSize = true;
            this.lblNomeExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeExames.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeExames.Location = new System.Drawing.Point(12, 9);
            this.lblNomeExames.Name = "lblNomeExames";
            this.lblNomeExames.Size = new System.Drawing.Size(240, 15);
            this.lblNomeExames.TabIndex = 120;
            this.lblNomeExames.Text = "Nome do Exame ou (%) para todos):";
            // 
            // tblCustoExameBindingSource
            // 
            this.tblCustoExameBindingSource.DataMember = "tblCustoExame";
            this.tblCustoExameBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustoExameTableAdapter
            // 
            this.tblCustoExameTableAdapter.ClearBeforeFill = true;
            // 
            // frmExamesRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtNomeExames);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomeExames);
            this.Controls.Add(this.reportExamesCusto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmExamesRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Exames Custo";
            this.Load += new System.EventHandler(this.frmExamesRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExamesRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustoExameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportExamesCusto;
        private System.Windows.Forms.TextBox txtNomeExames;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomeExames;
        private System.Windows.Forms.BindingSource tblCustoExameBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblCustoExameTableAdapter tblCustoExameTableAdapter;
    }
}