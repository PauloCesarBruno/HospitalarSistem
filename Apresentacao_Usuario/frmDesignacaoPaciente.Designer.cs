namespace Apresentacao_Usuario
{
    partial class frmDesignacaoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignacaoPaciente));
            this.reportDesignacaoPaciente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblDesignacaoPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDesignacaoPacienteTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblDesignacaoPacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDesignacaoPacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDesignacaoPaciente
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblDesignacaoPacienteBindingSource;
            this.reportDesignacaoPaciente.LocalReport.DataSources.Add(reportDataSource1);
            this.reportDesignacaoPaciente.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.Relatorio Designacao.rdlc";
            this.reportDesignacaoPaciente.Location = new System.Drawing.Point(1, 66);
            this.reportDesignacaoPaciente.Name = "reportDesignacaoPaciente";
            this.reportDesignacaoPaciente.Size = new System.Drawing.Size(927, 525);
            this.reportDesignacaoPaciente.TabIndex = 200;
            this.reportDesignacaoPaciente.TabStop = false;
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
            // txtNomePaciente
            // 
            this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(12, 29);
            this.txtNomePaciente.Multiline = true;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(264, 31);
            this.txtNomePaciente.TabIndex = 0;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.Teal;
            this.lblNomePaciente.Location = new System.Drawing.Point(12, 9);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(264, 17);
            this.lblNomePaciente.TabIndex = 108;
            this.lblNomePaciente.Text = "Nome Paciente ou (%) para todos):";
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDesignacaoPacienteBindingSource
            // 
            this.tblDesignacaoPacienteBindingSource.DataMember = "tblDesignacaoPaciente";
            this.tblDesignacaoPacienteBindingSource.DataSource = this.HospitalDataSet;
            // 
            // tblDesignacaoPacienteTableAdapter
            // 
            this.tblDesignacaoPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmDesignacaoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.reportDesignacaoPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDesignacaoPaciente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Designação Paciente";
            this.Load += new System.EventHandler(this.frmDesignacaoPaciente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDesignacaoPaciente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDesignacaoPacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDesignacaoPaciente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.BindingSource tblDesignacaoPacienteBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblDesignacaoPacienteTableAdapter tblDesignacaoPacienteTableAdapter;
    }
}