﻿namespace Apresentacao_Usuario
{
    partial class frmAlmoxarifadoFarmaciaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmoxarifadoFarmaciaRelatorio));
            this.tblAlmoxarifadoFarmaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.reportAlmoxarifadoFarmacia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtAlmoxarifadoFarmacia = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomeMedicamento = new System.Windows.Forms.Label();
            this.tblAlmoxarifadoFarmaciaTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblAlmoxarifadoFarmaciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlmoxarifadoFarmaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAlmoxarifadoFarmaciaBindingSource
            // 
            this.tblAlmoxarifadoFarmaciaBindingSource.DataMember = "tblAlmoxarifadoFarmacia";
            this.tblAlmoxarifadoFarmaciaBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportAlmoxarifadoFarmacia
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblAlmoxarifadoFarmaciaBindingSource;
            this.reportAlmoxarifadoFarmacia.LocalReport.DataSources.Add(reportDataSource1);
            this.reportAlmoxarifadoFarmacia.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioAlmoxarifadoFarmacia.rdlc";
            this.reportAlmoxarifadoFarmacia.Location = new System.Drawing.Point(1, 66);
            this.reportAlmoxarifadoFarmacia.Name = "reportAlmoxarifadoFarmacia";
            this.reportAlmoxarifadoFarmacia.Size = new System.Drawing.Size(927, 525);
            this.reportAlmoxarifadoFarmacia.TabIndex = 200;
            this.reportAlmoxarifadoFarmacia.TabStop = false;
            // 
            // txtAlmoxarifadoFarmacia
            // 
            this.txtAlmoxarifadoFarmacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmoxarifadoFarmacia.Location = new System.Drawing.Point(12, 29);
            this.txtAlmoxarifadoFarmacia.Multiline = true;
            this.txtAlmoxarifadoFarmacia.Name = "txtAlmoxarifadoFarmacia";
            this.txtAlmoxarifadoFarmacia.Size = new System.Drawing.Size(264, 31);
            this.txtAlmoxarifadoFarmacia.TabIndex = 0;
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
            // lblNomeMedicamento
            // 
            this.lblNomeMedicamento.AutoSize = true;
            this.lblNomeMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMedicamento.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeMedicamento.Location = new System.Drawing.Point(12, 11);
            this.lblNomeMedicamento.Name = "lblNomeMedicamento";
            this.lblNomeMedicamento.Size = new System.Drawing.Size(247, 13);
            this.lblNomeMedicamento.TabIndex = 124;
            this.lblNomeMedicamento.Text = "Nome do Medicamento ou (%) para todos):";
            // 
            // tblAlmoxarifadoFarmaciaTableAdapter
            // 
            this.tblAlmoxarifadoFarmaciaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAlmoxarifadoFarmaciaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtAlmoxarifadoFarmacia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomeMedicamento);
            this.Controls.Add(this.reportAlmoxarifadoFarmacia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAlmoxarifadoFarmaciaRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Estoque Farmácia";
            this.Load += new System.EventHandler(this.frmAlmoxarifadoFarmaciaRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAlmoxarifadoFarmaciaRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblAlmoxarifadoFarmaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportAlmoxarifadoFarmacia;
        private System.Windows.Forms.TextBox txtAlmoxarifadoFarmacia;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomeMedicamento;
        private System.Windows.Forms.BindingSource tblAlmoxarifadoFarmaciaBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblAlmoxarifadoFarmaciaTableAdapter tblAlmoxarifadoFarmaciaTableAdapter;
    }
}