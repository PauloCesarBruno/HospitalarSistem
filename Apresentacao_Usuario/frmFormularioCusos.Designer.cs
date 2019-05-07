namespace Apresentacao_Usuario
{
    partial class frmFormularioCusos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioCusos));
            this.reporCustosdeUso = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.CustosdeUsoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDataSet = new Apresentacao_Usuario.HospitalDataSet();
            this.CustosdeUsoTableAdapter = new Apresentacao_Usuario.HospitalDataSetTableAdapters.CustosdeUsoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustosdeUsoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reporCustosdeUso
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustosdeUsoBindingSource;
            this.reporCustosdeUso.LocalReport.DataSources.Add(reportDataSource1);
            this.reporCustosdeUso.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.CustosDeUso.rdlc";
            this.reporCustosdeUso.Location = new System.Drawing.Point(-1, 51);
            this.reporCustosdeUso.Name = "reporCustosdeUso";
            this.reporCustosdeUso.Size = new System.Drawing.Size(948, 493);
            this.reporCustosdeUso.TabIndex = 0;
            this.reporCustosdeUso.TabStop = false;
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(216, 9);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(116, 38);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "&Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(130, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome do(a) Paciente:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(12, 25);
            this.txtNomePaciente.MaxLength = 13;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(198, 20);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // CustosdeUsoBindingSource
            // 
            this.CustosdeUsoBindingSource.DataMember = "CustosdeUso";
            this.CustosdeUsoBindingSource.DataSource = this.HospitalDataSet;
            // 
            // HospitalDataSet
            // 
            this.HospitalDataSet.DataSetName = "HospitalDataSet";
            this.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustosdeUsoTableAdapter
            // 
            this.CustosdeUsoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFormularioCusos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 544);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.reporCustosdeUso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFormularioCusos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Cusos Paciente";
            this.Load += new System.EventHandler(this.frmFormularioCusos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFormularioCusos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CustosdeUsoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporCustosdeUso;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.BindingSource CustosdeUsoBindingSource;
        private HospitalDataSet HospitalDataSet;
        private HospitalDataSetTableAdapters.CustosdeUsoTableAdapter CustosdeUsoTableAdapter;
    }
}