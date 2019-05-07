namespace Apresentacao_Usuario
{
    partial class frmRelatorioCustoAcomodacaoAtual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioCustoAcomodacaoAtual));
            this.reportCustoAcomodacao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustoAcomodacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.CustoAcomodacaoTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.CustoAcomodacaoTableAdapter();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustoAcomodacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportCustoAcomodacao
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustoAcomodacaoBindingSource;
            this.reportCustoAcomodacao.LocalReport.DataSources.Add(reportDataSource1);
            this.reportCustoAcomodacao.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.CustoAcomodAtual.rdlc";
            this.reportCustoAcomodacao.Location = new System.Drawing.Point(1, 81);
            this.reportCustoAcomodacao.Name = "reportCustoAcomodacao";
            this.reportCustoAcomodacao.Size = new System.Drawing.Size(1235, 646);
            this.reportCustoAcomodacao.TabIndex = 0;
            // 
            // CustoAcomodacaoBindingSource
            // 
            this.CustoAcomodacaoBindingSource.DataMember = "CustoAcomodacao";
            this.CustoAcomodacaoBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustoAcomodacaoTableAdapter
            // 
            this.CustoAcomodacaoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(1060, 25);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(161, 49);
            this.btnSair.TabIndex = 105;
            this.btnSair.Text = "&Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.Teal;
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.Location = new System.Drawing.Point(212, 25);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(235, 49);
            this.btnGerar.TabIndex = 103;
            this.btnGerar.Text = "&Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPaciente.Location = new System.Drawing.Point(16, 36);
            this.txtCodigoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPaciente.MaxLength = 13;
            this.txtCodigoPaciente.Multiline = true;
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(178, 37);
            this.txtCodigoPaciente.TabIndex = 102;
            // 
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.AutoSize = true;
            this.lblCodigoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPaciente.ForeColor = System.Drawing.Color.Teal;
            this.lblCodigoPaciente.Location = new System.Drawing.Point(16, 11);
            this.lblCodigoPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(178, 20);
            this.lblCodigoPaciente.TabIndex = 104;
            this.lblCodigoPaciente.Text = "Código do Paciente:";
            // 
            // frmRelatorioCustoAcomodacaoAtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 725);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.reportCustoAcomodacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRelatorioCustoAcomodacaoAtual";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Custos Acomodação  (Pacientes)";
            this.Load += new System.EventHandler(this.frmRelatorioCustoAcomodacaoAtual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustoAcomodacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportCustoAcomodacao;
        private System.Windows.Forms.BindingSource CustoAcomodacaoBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.CustoAcomodacaoTableAdapter CustoAcomodacaoTableAdapter;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label lblCodigoPaciente;
    }
}