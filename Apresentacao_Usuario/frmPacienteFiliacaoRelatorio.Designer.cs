namespace Apresentacao_Usuario
{
    partial class frmPacienteFiliacaoRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteFiliacaoRelatorio));
            this.tblPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.reportPacienteFiliacao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPacienteFiliacao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblPacienteFiliacao = new System.Windows.Forms.Label();
            this.tblPacienteTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblPacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPacienteBindingSource
            // 
            this.tblPacienteBindingSource.DataMember = "tblPaciente";
            this.tblPacienteBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportPacienteFiliacao
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblPacienteBindingSource;
            this.reportPacienteFiliacao.LocalReport.DataSources.Add(reportDataSource1);
            this.reportPacienteFiliacao.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatórioPacienteFiliacao.rdlc";
            this.reportPacienteFiliacao.Location = new System.Drawing.Point(1, 66);
            this.reportPacienteFiliacao.Name = "reportPacienteFiliacao";
            this.reportPacienteFiliacao.Size = new System.Drawing.Size(927, 525);
            this.reportPacienteFiliacao.TabIndex = 200;
            this.reportPacienteFiliacao.TabStop = false;
            // 
            // txtPacienteFiliacao
            // 
            this.txtPacienteFiliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteFiliacao.Location = new System.Drawing.Point(12, 29);
            this.txtPacienteFiliacao.Multiline = true;
            this.txtPacienteFiliacao.Name = "txtPacienteFiliacao";
            this.txtPacienteFiliacao.Size = new System.Drawing.Size(264, 31);
            this.txtPacienteFiliacao.TabIndex = 0;
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
            // lblPacienteFiliacao
            // 
            this.lblPacienteFiliacao.AutoSize = true;
            this.lblPacienteFiliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteFiliacao.ForeColor = System.Drawing.Color.Teal;
            this.lblPacienteFiliacao.Location = new System.Drawing.Point(12, 9);
            this.lblPacienteFiliacao.Name = "lblPacienteFiliacao";
            this.lblPacienteFiliacao.Size = new System.Drawing.Size(264, 17);
            this.lblPacienteFiliacao.TabIndex = 116;
            this.lblPacienteFiliacao.Text = "Nome Paciente ou (%) para todos):";
            // 
            // tblPacienteTableAdapter
            // 
            this.tblPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmPacienteFiliacaoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtPacienteFiliacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblPacienteFiliacao);
            this.Controls.Add(this.reportPacienteFiliacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPacienteFiliacaoRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Pacientes X Filiação";
            this.Load += new System.EventHandler(this.frmPacienteFiliacaoRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPacienteFiliacaoRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportPacienteFiliacao;
        private System.Windows.Forms.TextBox txtPacienteFiliacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblPacienteFiliacao;
        private System.Windows.Forms.BindingSource tblPacienteBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblPacienteTableAdapter tblPacienteTableAdapter;
    }
}