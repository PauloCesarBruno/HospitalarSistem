namespace Apresentacao_Usuario
{
    partial class frmPacienteCadastroRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacienteCadastroRelatorio));
            this.reportPacienteCadastro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPacienteCadastro = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblPacienteCadastro = new System.Windows.Forms.Label();
            this.tblPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblPacienteTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblPacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPacienteCadastro
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblPacienteBindingSource;
            this.reportPacienteCadastro.LocalReport.DataSources.Add(reportDataSource1);
            this.reportPacienteCadastro.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioPacienteCadastro.rdlc";
            this.reportPacienteCadastro.Location = new System.Drawing.Point(1, 66);
            this.reportPacienteCadastro.Name = "reportPacienteCadastro";
            this.reportPacienteCadastro.Size = new System.Drawing.Size(927, 525);
            this.reportPacienteCadastro.TabIndex = 200;
            this.reportPacienteCadastro.TabStop = false;
            // 
            // txtPacienteCadastro
            // 
            this.txtPacienteCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteCadastro.Location = new System.Drawing.Point(12, 29);
            this.txtPacienteCadastro.Multiline = true;
            this.txtPacienteCadastro.Name = "txtPacienteCadastro";
            this.txtPacienteCadastro.Size = new System.Drawing.Size(264, 31);
            this.txtPacienteCadastro.TabIndex = 0;
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
            // lblPacienteCadastro
            // 
            this.lblPacienteCadastro.AutoSize = true;
            this.lblPacienteCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteCadastro.ForeColor = System.Drawing.Color.Teal;
            this.lblPacienteCadastro.Location = new System.Drawing.Point(12, 9);
            this.lblPacienteCadastro.Name = "lblPacienteCadastro";
            this.lblPacienteCadastro.Size = new System.Drawing.Size(264, 17);
            this.lblPacienteCadastro.TabIndex = 112;
            this.lblPacienteCadastro.Text = "Nome Paciente ou (%) para todos):";
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
            // tblPacienteTableAdapter
            // 
            this.tblPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmPacienteCadastroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtPacienteCadastro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblPacienteCadastro);
            this.Controls.Add(this.reportPacienteCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPacienteCadastroRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Cadastro Pacientes";
            this.Load += new System.EventHandler(this.frmPacienteCadastroRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPacienteCadastroRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportPacienteCadastro;
        private System.Windows.Forms.TextBox txtPacienteCadastro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblPacienteCadastro;
        private System.Windows.Forms.BindingSource tblPacienteBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblPacienteTableAdapter tblPacienteTableAdapter;
    }
}