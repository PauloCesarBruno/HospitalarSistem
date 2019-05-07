namespace Apresentacao_Usuario
{
    partial class frmEnfermeiroRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnfermeiroRelatorio));
            this.reportEnfermeiros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.tblEnfermeiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblEnfermeiroTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblEnfermeiroTableAdapter();
            this.txtNomeEnfermeiro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnfermeiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportEnfermeiros
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblEnfermeiroBindingSource;
            this.reportEnfermeiros.LocalReport.DataSources.Add(reportDataSource3);
            this.reportEnfermeiros.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioEnfermeiro.rdlc";
            this.reportEnfermeiros.Location = new System.Drawing.Point(1, 66);
            this.reportEnfermeiros.Name = "reportEnfermeiros";
            this.reportEnfermeiros.Size = new System.Drawing.Size(927, 525);
            this.reportEnfermeiros.TabIndex = 200;
            this.reportEnfermeiros.TabStop = false;
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
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.Teal;
            this.lblNomePaciente.Location = new System.Drawing.Point(12, 9);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(265, 15);
            this.lblNomePaciente.TabIndex = 112;
            this.lblNomePaciente.Text = "Nome Enfermeiro(a) ou (%) para todos):";
            // 
            // tblEnfermeiroBindingSource
            // 
            this.tblEnfermeiroBindingSource.DataMember = "tblEnfermeiro";
            this.tblEnfermeiroBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEnfermeiroTableAdapter
            // 
            this.tblEnfermeiroTableAdapter.ClearBeforeFill = true;
            // 
            // txtNomeEnfermeiro
            // 
            this.txtNomeEnfermeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEnfermeiro.Location = new System.Drawing.Point(12, 29);
            this.txtNomeEnfermeiro.Multiline = true;
            this.txtNomeEnfermeiro.Name = "txtNomeEnfermeiro";
            this.txtNomeEnfermeiro.Size = new System.Drawing.Size(264, 31);
            this.txtNomeEnfermeiro.TabIndex = 0;
            // 
            // frmEnfermeiroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtNomeEnfermeiro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.reportEnfermeiros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEnfermeiroRelatorio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatírio de Enfermeiros(as)";
            this.Load += new System.EventHandler(this.frmEnfermeiroRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEnfermeiroRelatorio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblEnfermeiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportEnfermeiros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.BindingSource tblEnfermeiroBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblEnfermeiroTableAdapter tblEnfermeiroTableAdapter;
        private System.Windows.Forms.TextBox txtNomeEnfermeiro;
    }
}