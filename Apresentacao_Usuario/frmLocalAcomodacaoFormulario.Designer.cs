namespace Apresentacao_Usuario
{
    partial class frmLocalAcomodacaoFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalAcomodacaoFormulario));
            this.reportLocalAcomodacao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtLocalAcomodacao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblLocalAcomodacao = new System.Windows.Forms.Label();
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.tblAcomodacoesPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcomodacoesPacientesTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.tblAcomodacoesPacientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcomodacoesPacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportLocalAcomodacao
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tblAcomodacoesPacientesBindingSource;
            this.reportLocalAcomodacao.LocalReport.DataSources.Add(reportDataSource3);
            this.reportLocalAcomodacao.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.RelatorioLocalAcomodacao.rdlc";
            this.reportLocalAcomodacao.Location = new System.Drawing.Point(1, 66);
            this.reportLocalAcomodacao.Name = "reportLocalAcomodacao";
            this.reportLocalAcomodacao.Size = new System.Drawing.Size(927, 525);
            this.reportLocalAcomodacao.TabIndex = 200;
            this.reportLocalAcomodacao.TabStop = false;
            // 
            // txtLocalAcomodacao
            // 
            this.txtLocalAcomodacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalAcomodacao.Location = new System.Drawing.Point(12, 29);
            this.txtLocalAcomodacao.Multiline = true;
            this.txtLocalAcomodacao.Name = "txtLocalAcomodacao";
            this.txtLocalAcomodacao.Size = new System.Drawing.Size(264, 31);
            this.txtLocalAcomodacao.TabIndex = 0;
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
            // lblLocalAcomodacao
            // 
            this.lblLocalAcomodacao.AutoSize = true;
            this.lblLocalAcomodacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalAcomodacao.ForeColor = System.Drawing.Color.Teal;
            this.lblLocalAcomodacao.Location = new System.Drawing.Point(12, 9);
            this.lblLocalAcomodacao.Name = "lblLocalAcomodacao";
            this.lblLocalAcomodacao.Size = new System.Drawing.Size(231, 15);
            this.lblLocalAcomodacao.TabIndex = 120;
            this.lblLocalAcomodacao.Text = "Nome do Local ou (%) para todos):";
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAcomodacoesPacientesBindingSource
            // 
            this.tblAcomodacoesPacientesBindingSource.DataMember = "tblAcomodacoesPacientes";
            this.tblAcomodacoesPacientesBindingSource.DataSource = this.HospitalDataSet;
            // 
            // tblAcomodacoesPacientesTableAdapter
            // 
            this.tblAcomodacoesPacientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmLocalAcomodacaoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 589);
            this.Controls.Add(this.txtLocalAcomodacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblLocalAcomodacao);
            this.Controls.Add(this.reportLocalAcomodacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLocalAcomodacaoFormulario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Locais de Acomodação X Pacientes";
            this.Load += new System.EventHandler(this.frmLocalAcomodacaoFormulario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLocalAcomodacaoFormulario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcomodacoesPacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportLocalAcomodacao;
        private System.Windows.Forms.TextBox txtLocalAcomodacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblLocalAcomodacao;
        private System.Windows.Forms.BindingSource tblAcomodacoesPacientesBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.tblAcomodacoesPacientesTableAdapter tblAcomodacoesPacientesTableAdapter;
    }
}