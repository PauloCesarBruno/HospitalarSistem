namespace Apresentacao_Usuario
{
    partial class frmConsultaCustos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCustos));
            this.dgvConCustos = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSomaInsumo = new System.Windows.Forms.Label();
            this.txtInsumosTotal = new System.Windows.Forms.TextBox();
            this.txtMedicamentosTotal = new System.Windows.Forms.TextBox();
            this.lblSomaMedicamentos = new System.Windows.Forms.Label();
            this.txtExamesTotal = new System.Windows.Forms.TextBox();
            this.lblSomaExames = new System.Windows.Forms.Label();
            this.grpTotalizadores = new System.Windows.Forms.GroupBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.lblTGeral = new System.Windows.Forms.Label();
            this.lblBuscaNome = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.picTeclado = new System.Windows.Forms.PictureBox();
            this.grpBusca = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblConsultaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.btnExcluiCustos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConCustos)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpTotalizadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeclado)).BeginInit();
            this.grpBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConCustos
            // 
            this.dgvConCustos.AllowUserToAddRows = false;
            this.dgvConCustos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvConCustos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConCustos.BackgroundColor = System.Drawing.Color.White;
            this.dgvConCustos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConCustos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.NomePaciente,
            this.Data,
            this.Responsavel,
            this.IdInsumo,
            this.NomeInsumo,
            this.ValorInsumo,
            this.IdMedicamento,
            this.NomeMedicamento,
            this.ValorMedicamento,
            this.IdExame,
            this.NomeExame,
            this.ValorExame});
            this.dgvConCustos.Location = new System.Drawing.Point(2, 78);
            this.dgvConCustos.Name = "dgvConCustos";
            this.dgvConCustos.ReadOnly = true;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConCustos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvConCustos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConCustos.Size = new System.Drawing.Size(946, 271);
            this.dgvConCustos.TabIndex = 1000;
            this.dgvConCustos.TabStop = false;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.IdPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdPaciente.HeaderText = "Código";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NomePaciente
            // 
            this.NomePaciente.DataPropertyName = "NomePaciente";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.NomePaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomePaciente.HeaderText = "Nome";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            this.NomePaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomePaciente.Width = 200;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.DefaultCellStyle = dataGridViewCellStyle4;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Responsavel
            // 
            this.Responsavel.DataPropertyName = "Responsavel";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsavel.DefaultCellStyle = dataGridViewCellStyle5;
            this.Responsavel.HeaderText = "Lançado por:";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            this.Responsavel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Responsavel.Width = 200;
            // 
            // IdInsumo
            // 
            this.IdInsumo.DataPropertyName = "IdInsumo";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInsumo.DefaultCellStyle = dataGridViewCellStyle6;
            this.IdInsumo.HeaderText = "Código";
            this.IdInsumo.Name = "IdInsumo";
            this.IdInsumo.ReadOnly = true;
            this.IdInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdInsumo.Visible = false;
            // 
            // NomeInsumo
            // 
            this.NomeInsumo.DataPropertyName = "NomeInsumo";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInsumo.DefaultCellStyle = dataGridViewCellStyle7;
            this.NomeInsumo.HeaderText = "Insumo";
            this.NomeInsumo.Name = "NomeInsumo";
            this.NomeInsumo.ReadOnly = true;
            this.NomeInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeInsumo.Width = 200;
            // 
            // ValorInsumo
            // 
            this.ValorInsumo.DataPropertyName = "ValorInsumo";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.ValorInsumo.DefaultCellStyle = dataGridViewCellStyle8;
            this.ValorInsumo.HeaderText = "Valor";
            this.ValorInsumo.Name = "ValorInsumo";
            this.ValorInsumo.ReadOnly = true;
            this.ValorInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdMedicamento
            // 
            this.IdMedicamento.DataPropertyName = "IdMedicamento";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMedicamento.DefaultCellStyle = dataGridViewCellStyle9;
            this.IdMedicamento.HeaderText = "Código";
            this.IdMedicamento.Name = "IdMedicamento";
            this.IdMedicamento.ReadOnly = true;
            this.IdMedicamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdMedicamento.Visible = false;
            // 
            // NomeMedicamento
            // 
            this.NomeMedicamento.DataPropertyName = "NomeMedicamento";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeMedicamento.DefaultCellStyle = dataGridViewCellStyle10;
            this.NomeMedicamento.HeaderText = "Medicamento";
            this.NomeMedicamento.Name = "NomeMedicamento";
            this.NomeMedicamento.ReadOnly = true;
            this.NomeMedicamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeMedicamento.Width = 200;
            // 
            // ValorMedicamento
            // 
            this.ValorMedicamento.DataPropertyName = "ValorMedicamento";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.ValorMedicamento.DefaultCellStyle = dataGridViewCellStyle11;
            this.ValorMedicamento.HeaderText = "Valor";
            this.ValorMedicamento.Name = "ValorMedicamento";
            this.ValorMedicamento.ReadOnly = true;
            this.ValorMedicamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdExame
            // 
            this.IdExame.DataPropertyName = "IdExame";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdExame.DefaultCellStyle = dataGridViewCellStyle12;
            this.IdExame.HeaderText = "Código";
            this.IdExame.Name = "IdExame";
            this.IdExame.ReadOnly = true;
            this.IdExame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdExame.Visible = false;
            // 
            // NomeExame
            // 
            this.NomeExame.DataPropertyName = "NomeExame";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeExame.DefaultCellStyle = dataGridViewCellStyle13;
            this.NomeExame.HeaderText = "Exame";
            this.NomeExame.Name = "NomeExame";
            this.NomeExame.ReadOnly = true;
            this.NomeExame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeExame.Width = 200;
            // 
            // ValorExame
            // 
            this.ValorExame.DataPropertyName = "ValorExame";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.ValorExame.DefaultCellStyle = dataGridViewCellStyle14;
            this.ValorExame.HeaderText = "Valor";
            this.ValorExame.Name = "ValorExame";
            this.ValorExame.ReadOnly = true;
            this.ValorExame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(2, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(946, 74);
            this.panelTitulo.TabIndex = 104;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(705, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(192, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Consulta de Custos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(231, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // lblSomaInsumo
            // 
            this.lblSomaInsumo.AutoSize = true;
            this.lblSomaInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaInsumo.ForeColor = System.Drawing.Color.Black;
            this.lblSomaInsumo.Location = new System.Drawing.Point(15, 23);
            this.lblSomaInsumo.Name = "lblSomaInsumo";
            this.lblSomaInsumo.Size = new System.Drawing.Size(63, 13);
            this.lblSomaInsumo.TabIndex = 2314;
            this.lblSomaInsumo.Text = "Insumos R$";
            // 
            // txtInsumosTotal
            // 
            this.txtInsumosTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtInsumosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsumosTotal.ForeColor = System.Drawing.Color.Red;
            this.txtInsumosTotal.Location = new System.Drawing.Point(129, 20);
            this.txtInsumosTotal.Name = "txtInsumosTotal";
            this.txtInsumosTotal.ReadOnly = true;
            this.txtInsumosTotal.Size = new System.Drawing.Size(92, 20);
            this.txtInsumosTotal.TabIndex = 2315;
            this.txtInsumosTotal.TabStop = false;
            // 
            // txtMedicamentosTotal
            // 
            this.txtMedicamentosTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtMedicamentosTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentosTotal.ForeColor = System.Drawing.Color.Red;
            this.txtMedicamentosTotal.Location = new System.Drawing.Point(129, 43);
            this.txtMedicamentosTotal.Name = "txtMedicamentosTotal";
            this.txtMedicamentosTotal.ReadOnly = true;
            this.txtMedicamentosTotal.Size = new System.Drawing.Size(92, 20);
            this.txtMedicamentosTotal.TabIndex = 2317;
            this.txtMedicamentosTotal.TabStop = false;
            // 
            // lblSomaMedicamentos
            // 
            this.lblSomaMedicamentos.AutoSize = true;
            this.lblSomaMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaMedicamentos.ForeColor = System.Drawing.Color.Black;
            this.lblSomaMedicamentos.Location = new System.Drawing.Point(15, 47);
            this.lblSomaMedicamentos.Name = "lblSomaMedicamentos";
            this.lblSomaMedicamentos.Size = new System.Drawing.Size(93, 13);
            this.lblSomaMedicamentos.TabIndex = 2316;
            this.lblSomaMedicamentos.Text = "Medicamentos R$";
            // 
            // txtExamesTotal
            // 
            this.txtExamesTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtExamesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamesTotal.ForeColor = System.Drawing.Color.Red;
            this.txtExamesTotal.Location = new System.Drawing.Point(129, 66);
            this.txtExamesTotal.Name = "txtExamesTotal";
            this.txtExamesTotal.ReadOnly = true;
            this.txtExamesTotal.Size = new System.Drawing.Size(92, 20);
            this.txtExamesTotal.TabIndex = 2319;
            this.txtExamesTotal.TabStop = false;
            // 
            // lblSomaExames
            // 
            this.lblSomaExames.AutoSize = true;
            this.lblSomaExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomaExames.ForeColor = System.Drawing.Color.Black;
            this.lblSomaExames.Location = new System.Drawing.Point(14, 69);
            this.lblSomaExames.Name = "lblSomaExames";
            this.lblSomaExames.Size = new System.Drawing.Size(61, 13);
            this.lblSomaExames.TabIndex = 2318;
            this.lblSomaExames.Text = "Exames R$";
            // 
            // grpTotalizadores
            // 
            this.grpTotalizadores.BackColor = System.Drawing.SystemColors.Control;
            this.grpTotalizadores.Controls.Add(this.txtTotalGeral);
            this.grpTotalizadores.Controls.Add(this.lblTGeral);
            this.grpTotalizadores.Controls.Add(this.txtInsumosTotal);
            this.grpTotalizadores.Controls.Add(this.txtExamesTotal);
            this.grpTotalizadores.Controls.Add(this.lblSomaInsumo);
            this.grpTotalizadores.Controls.Add(this.lblSomaExames);
            this.grpTotalizadores.Controls.Add(this.lblSomaMedicamentos);
            this.grpTotalizadores.Controls.Add(this.txtMedicamentosTotal);
            this.grpTotalizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalizadores.ForeColor = System.Drawing.Color.Teal;
            this.grpTotalizadores.Location = new System.Drawing.Point(712, 355);
            this.grpTotalizadores.Name = "grpTotalizadores";
            this.grpTotalizadores.Size = new System.Drawing.Size(236, 137);
            this.grpTotalizadores.TabIndex = 2320;
            this.grpTotalizadores.TabStop = false;
            this.grpTotalizadores.Text = "Totalizadores:";
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.Color.Red;
            this.txtTotalGeral.Location = new System.Drawing.Point(128, 103);
            this.txtTotalGeral.Multiline = true;
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(92, 22);
            this.txtTotalGeral.TabIndex = 2322;
            this.txtTotalGeral.TabStop = false;
            // 
            // lblTGeral
            // 
            this.lblTGeral.AutoSize = true;
            this.lblTGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGeral.ForeColor = System.Drawing.Color.Red;
            this.lblTGeral.Location = new System.Drawing.Point(11, 108);
            this.lblTGeral.Name = "lblTGeral";
            this.lblTGeral.Size = new System.Drawing.Size(67, 13);
            this.lblTGeral.TabIndex = 2321;
            this.lblTGeral.Text = "TOTAL R$";
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaNome.ForeColor = System.Drawing.Color.Teal;
            this.lblBuscaNome.Location = new System.Drawing.Point(12, 12);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(244, 16);
            this.lblBuscaNome.TabIndex = 2306;
            this.lblBuscaNome.Text = "Consultar pelo Nome (Min 8 caracteres):";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.Location = new System.Drawing.Point(15, 28);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(249, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // picTeclado
            // 
            this.picTeclado.Image = ((System.Drawing.Image)(resources.GetObject("picTeclado.Image")));
            this.picTeclado.Location = new System.Drawing.Point(2, 355);
            this.picTeclado.Name = "picTeclado";
            this.picTeclado.Size = new System.Drawing.Size(422, 137);
            this.picTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeclado.TabIndex = 2321;
            this.picTeclado.TabStop = false;
            // 
            // grpBusca
            // 
            this.grpBusca.Controls.Add(this.btnAtualizar);
            this.grpBusca.Controls.Add(this.btnBuscaId);
            this.grpBusca.Controls.Add(this.lblConsultaId);
            this.grpBusca.Controls.Add(this.txtBuscaId);
            this.grpBusca.Controls.Add(this.txtAdmin);
            this.grpBusca.Controls.Add(this.btnExcluiCustos);
            this.grpBusca.Controls.Add(this.btnSair);
            this.grpBusca.Controls.Add(this.lblBuscaNome);
            this.grpBusca.Controls.Add(this.txtBuscaNome);
            this.grpBusca.Location = new System.Drawing.Point(430, 355);
            this.grpBusca.Name = "grpBusca";
            this.grpBusca.Size = new System.Drawing.Size(276, 137);
            this.grpBusca.TabIndex = 2322;
            this.grpBusca.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(190, 62);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(74, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "  &Limpar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(149, 62);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "&Ok";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblConsultaId
            // 
            this.lblConsultaId.AutoSize = true;
            this.lblConsultaId.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaId.ForeColor = System.Drawing.Color.Teal;
            this.lblConsultaId.Location = new System.Drawing.Point(12, 48);
            this.lblConsultaId.Name = "lblConsultaId";
            this.lblConsultaId.Size = new System.Drawing.Size(129, 16);
            this.lblConsultaId.TabIndex = 2325;
            this.lblConsultaId.Text = "Consultar p/ Código:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.Location = new System.Drawing.Point(15, 64);
            this.txtBuscaId.MaxLength = 13;
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(126, 20);
            this.txtBuscaId.TabIndex = 1;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(132, 99);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(15, 20);
            this.txtAdmin.TabIndex = 2323;
            this.txtAdmin.Visible = false;
            // 
            // btnExcluiCustos
            // 
            this.btnExcluiCustos.Enabled = false;
            this.btnExcluiCustos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluiCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiCustos.ForeColor = System.Drawing.Color.Black;
            this.btnExcluiCustos.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluiCustos.Image")));
            this.btnExcluiCustos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluiCustos.Location = new System.Drawing.Point(15, 91);
            this.btnExcluiCustos.Name = "btnExcluiCustos";
            this.btnExcluiCustos.Size = new System.Drawing.Size(113, 34);
            this.btnExcluiCustos.TabIndex = 3;
            this.btnExcluiCustos.Text = "  &Encerrar  Custos";
            this.btnExcluiCustos.UseVisualStyleBackColor = true;
            this.btnExcluiCustos.Click += new System.EventHandler(this.btnExcluiCustos_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(151, 91);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmConsultaCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 500);
            this.Controls.Add(this.grpBusca);
            this.Controls.Add(this.picTeclado);
            this.Controls.Add(this.grpTotalizadores);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.dgvConCustos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmConsultaCustos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta De Custos Gerais";
            this.Load += new System.EventHandler(this.frmConsultaCustos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaCustos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConCustos)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpTotalizadores.ResumeLayout(false);
            this.grpTotalizadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeclado)).EndInit();
            this.grpBusca.ResumeLayout(false);
            this.grpBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConCustos;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSomaInsumo;
        private System.Windows.Forms.TextBox txtInsumosTotal;
        private System.Windows.Forms.TextBox txtMedicamentosTotal;
        private System.Windows.Forms.Label lblSomaMedicamentos;
        private System.Windows.Forms.TextBox txtExamesTotal;
        private System.Windows.Forms.Label lblSomaExames;
        private System.Windows.Forms.GroupBox grpTotalizadores;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label lblTGeral;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.PictureBox picTeclado;
        private System.Windows.Forms.GroupBox grpBusca;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorExame;
        private System.Windows.Forms.Button btnExcluiCustos;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label lblConsultaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Button btnAtualizar;

    }
}