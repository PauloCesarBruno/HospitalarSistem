﻿namespace Apresentacao_Usuario
{
    partial class frmFornecedoresRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedoresRelatorio));
            this.tblFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.reportFornecedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtFornecedores = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.tblFornecedorTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblFornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblFornecedorBindingSource
            // 
            this.tblFornecedorBindingSource.DataMember = "tblFornecedor";
            this.tblFornecedorBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportFornecedores
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblFornecedorBindingSource;
            this.reportFornecedores.LocalReport.DataSources.Add(reportDataSource1);
            this.reportFornecedores.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioFornecedores.rdlc";
            this.reportFornecedores.Location = new System.Drawing.Point(1, 66);
            this.reportFornecedores.Name = "reportFornecedores";
            this.reportFornecedores.Size = new System.Drawing.Size(927, 525);
            this.reportFornecedores.TabIndex = 200;
            this.reportFornecedores.TabStop = false;
            // 
            // txtFornecedores
            // 
            this.txtFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedores.Location = new System.Drawing.Point(12, 29);
            this.txtFornecedores.Multiline = true;
            this.txtFornecedores.Name = "txtFornecedores";
            this.txtFornecedores.Size = new System.Drawing.Size(264, 31);
            this.txtFornecedores.TabIndex = 0;
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
            this.btnGerar.Location = new System.Drawing.Point(296, 20);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(176, 40);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "&Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedores.ForeColor = System.Drawing.Color.Teal;
            this.lblFornecedores.Location = new System.Drawing.Point(12, 9);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(284, 17);
            this.lblFornecedores.TabIndex = 116;
            this.lblFornecedores.Text = "Nome Fornecedor ou (%) para todos):";
            // 
            // tblFornecedorTableAdapter
            // 
            this.tblFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmFornecedoresRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtFornecedores);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblFornecedores);
            this.Controls.Add(this.reportFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFornecedoresRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedoresRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFornecedoresRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportFornecedores;
        private System.Windows.Forms.TextBox txtFornecedores;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.BindingSource tblFornecedorBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblFornecedorTableAdapter tblFornecedorTableAdapter;
    }
}