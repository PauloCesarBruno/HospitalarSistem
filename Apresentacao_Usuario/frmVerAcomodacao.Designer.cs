namespace Apresentacao_Usuario
{
    partial class frmVerAcomodacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerAcomodacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvVerAcomodacao = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAcomodacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.txtInternacao = new System.Windows.Forms.MaskedTextBox();
            this.txtControlaDia = new System.Windows.Forms.TextBox();
            this.txtDiasInternados = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCloneNome = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textInternacao = new System.Windows.Forms.TextBox();
            this.textCodAcomd = new System.Windows.Forms.TextBox();
            this.textAcomodacao = new System.Windows.Forms.TextBox();
            this.textLeito = new System.Windows.Forms.TextBox();
            this.textQuarto = new System.Windows.Forms.TextBox();
            this.textDias = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.textBuscaId = new System.Windows.Forms.TextBox();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.lblBuscaId = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerAcomodacao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(3, 1);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(792, 74);
            this.panelTitulo.TabIndex = 106;
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
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubTitulo.Location = new System.Drawing.Point(526, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(246, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Consulta de Acomodação";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(148, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // dgvVerAcomodacao
            // 
            this.dgvVerAcomodacao.AllowUserToAddRows = false;
            this.dgvVerAcomodacao.AllowUserToDeleteRows = false;
            this.dgvVerAcomodacao.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerAcomodacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerAcomodacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.NomePaciente,
            this.Data,
            this.IdDiaria,
            this.LocalAcomodado,
            this.Leito,
            this.Quarto,
            this.diasAcomodado,
            this.ValorAcomodacao,
            this.Valor_Total});
            this.dgvVerAcomodacao.Location = new System.Drawing.Point(3, 76);
            this.dgvVerAcomodacao.Name = "dgvVerAcomodacao";
            this.dgvVerAcomodacao.ReadOnly = true;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVerAcomodacao.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVerAcomodacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVerAcomodacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerAcomodacao.Size = new System.Drawing.Size(792, 45);
            this.dgvVerAcomodacao.TabIndex = 1001;
            this.dgvVerAcomodacao.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerAcomodacao_CellEnter);
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.IdPaciente.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdPaciente.HeaderText = "Código";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NomePaciente
            // 
            this.NomePaciente.DataPropertyName = "NomePaciente";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.NomePaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.NomePaciente.HeaderText = "Nome do Paciênte";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            this.NomePaciente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomePaciente.Width = 180;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data.HeaderText = "Internação";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Visible = false;
            this.Data.Width = 80;
            // 
            // IdDiaria
            // 
            this.IdDiaria.DataPropertyName = "IdDiaria";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.IdDiaria.DefaultCellStyle = dataGridViewCellStyle4;
            this.IdDiaria.HeaderText = "Cód.";
            this.IdDiaria.Name = "IdDiaria";
            this.IdDiaria.ReadOnly = true;
            this.IdDiaria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdDiaria.Width = 40;
            // 
            // LocalAcomodado
            // 
            this.LocalAcomodado.DataPropertyName = "LocalAcomodado";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.LocalAcomodado.DefaultCellStyle = dataGridViewCellStyle5;
            this.LocalAcomodado.HeaderText = "Acomodação";
            this.LocalAcomodado.Name = "LocalAcomodado";
            this.LocalAcomodado.ReadOnly = true;
            this.LocalAcomodado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalAcomodado.Width = 97;
            // 
            // Leito
            // 
            this.Leito.DataPropertyName = "Leito";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leito.DefaultCellStyle = dataGridViewCellStyle6;
            this.Leito.HeaderText = "Leito";
            this.Leito.Name = "Leito";
            this.Leito.ReadOnly = true;
            this.Leito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Leito.Width = 50;
            // 
            // Quarto
            // 
            this.Quarto.DataPropertyName = "Quarto";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quarto.DefaultCellStyle = dataGridViewCellStyle7;
            this.Quarto.HeaderText = "Quarto";
            this.Quarto.Name = "Quarto";
            this.Quarto.ReadOnly = true;
            this.Quarto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quarto.Width = 50;
            // 
            // diasAcomodado
            // 
            this.diasAcomodado.DataPropertyName = "diasAcomodado";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.diasAcomodado.DefaultCellStyle = dataGridViewCellStyle8;
            this.diasAcomodado.HeaderText = "Dias";
            this.diasAcomodado.Name = "diasAcomodado";
            this.diasAcomodado.ReadOnly = true;
            this.diasAcomodado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diasAcomodado.Width = 40;
            // 
            // ValorAcomodacao
            // 
            this.ValorAcomodacao.DataPropertyName = "ValorAcomodacao";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.ValorAcomodacao.DefaultCellStyle = dataGridViewCellStyle9;
            this.ValorAcomodacao.HeaderText = "Valor";
            this.ValorAcomodacao.Name = "ValorAcomodacao";
            this.ValorAcomodacao.ReadOnly = true;
            this.ValorAcomodacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorAcomodacao.Width = 95;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "Valor_Total";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle10;
            this.Valor_Total.HeaderText = "Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor_Total.Width = 98;
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarNome.Location = new System.Drawing.Point(0, 145);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(249, 16);
            this.lblBuscarNome.TabIndex = 2308;
            this.lblBuscarNome.Text = "Consultar pelo Nome (Min. 8 Caracteres).";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaNome.Location = new System.Drawing.Point(3, 162);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(250, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // txtInternacao
            // 
            this.txtInternacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInternacao.ForeColor = System.Drawing.Color.Black;
            this.txtInternacao.Location = new System.Drawing.Point(260, 123);
            this.txtInternacao.Mask = "00/00/0000";
            this.txtInternacao.Name = "txtInternacao";
            this.txtInternacao.ReadOnly = true;
            this.txtInternacao.Size = new System.Drawing.Size(77, 20);
            this.txtInternacao.TabIndex = 2345;
            this.txtInternacao.TabStop = false;
            this.txtInternacao.ValidatingType = typeof(System.DateTime);
            this.txtInternacao.Visible = false;
            // 
            // txtControlaDia
            // 
            this.txtControlaDia.Location = new System.Drawing.Point(425, 123);
            this.txtControlaDia.Name = "txtControlaDia";
            this.txtControlaDia.ReadOnly = true;
            this.txtControlaDia.Size = new System.Drawing.Size(44, 20);
            this.txtControlaDia.TabIndex = 2346;
            this.txtControlaDia.TabStop = false;
            this.txtControlaDia.Visible = false;
            // 
            // txtDiasInternados
            // 
            this.txtDiasInternados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDiasInternados.ForeColor = System.Drawing.Color.Red;
            this.txtDiasInternados.Location = new System.Drawing.Point(342, 123);
            this.txtDiasInternados.MaxLength = 10;
            this.txtDiasInternados.Name = "txtDiasInternados";
            this.txtDiasInternados.ReadOnly = true;
            this.txtDiasInternados.Size = new System.Drawing.Size(77, 20);
            this.txtDiasInternados.TabIndex = 2347;
            this.txtDiasInternados.TabStop = false;
            this.txtDiasInternados.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(122, 123);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(63, 20);
            this.txtValor.TabIndex = 2348;
            this.txtValor.TabStop = false;
            this.txtValor.Visible = false;
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(190, 123);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(63, 20);
            this.txtTot.TabIndex = 2349;
            this.txtTot.TabStop = false;
            this.txtTot.Visible = false;
            // 
            // btnLimpa
            // 
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpa.Image")));
            this.btnLimpa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpa.Location = new System.Drawing.Point(324, 172);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(121, 39);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "&Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSair.Location = new System.Drawing.Point(658, 172);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 39);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCloneNome
            // 
            this.txtCloneNome.Location = new System.Drawing.Point(742, 123);
            this.txtCloneNome.Name = "txtCloneNome";
            this.txtCloneNome.Size = new System.Drawing.Size(31, 20);
            this.txtCloneNome.TabIndex = 2350;
            this.txtCloneNome.Visible = false;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(481, 123);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(15, 20);
            this.textCodigo.TabIndex = 2352;
            this.textCodigo.Visible = false;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(507, 123);
            this.textNome.Margin = new System.Windows.Forms.Padding(2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(15, 20);
            this.textNome.TabIndex = 2353;
            this.textNome.Visible = false;
            // 
            // textInternacao
            // 
            this.textInternacao.Location = new System.Drawing.Point(536, 123);
            this.textInternacao.Margin = new System.Windows.Forms.Padding(2);
            this.textInternacao.Name = "textInternacao";
            this.textInternacao.Size = new System.Drawing.Size(15, 20);
            this.textInternacao.TabIndex = 2354;
            this.textInternacao.Visible = false;
            // 
            // textCodAcomd
            // 
            this.textCodAcomd.Location = new System.Drawing.Point(640, 123);
            this.textCodAcomd.Margin = new System.Windows.Forms.Padding(2);
            this.textCodAcomd.Name = "textCodAcomd";
            this.textCodAcomd.Size = new System.Drawing.Size(43, 20);
            this.textCodAcomd.TabIndex = 2355;
            this.textCodAcomd.Visible = false;
            // 
            // textAcomodacao
            // 
            this.textAcomodacao.Location = new System.Drawing.Point(694, 123);
            this.textAcomodacao.Margin = new System.Windows.Forms.Padding(2);
            this.textAcomodacao.Name = "textAcomodacao";
            this.textAcomodacao.Size = new System.Drawing.Size(43, 20);
            this.textAcomodacao.TabIndex = 2356;
            this.textAcomodacao.Visible = false;
            // 
            // textLeito
            // 
            this.textLeito.Location = new System.Drawing.Point(566, 123);
            this.textLeito.Margin = new System.Windows.Forms.Padding(2);
            this.textLeito.Name = "textLeito";
            this.textLeito.Size = new System.Drawing.Size(43, 20);
            this.textLeito.TabIndex = 2357;
            this.textLeito.Visible = false;
            // 
            // textQuarto
            // 
            this.textQuarto.Location = new System.Drawing.Point(527, 174);
            this.textQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.textQuarto.Name = "textQuarto";
            this.textQuarto.Size = new System.Drawing.Size(43, 20);
            this.textQuarto.TabIndex = 2358;
            this.textQuarto.Visible = false;
            // 
            // textDias
            // 
            this.textDias.Location = new System.Drawing.Point(581, 174);
            this.textDias.Margin = new System.Windows.Forms.Padding(2);
            this.textDias.Name = "textDias";
            this.textDias.Size = new System.Drawing.Size(43, 20);
            this.textDias.TabIndex = 2359;
            this.textDias.Visible = false;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(634, 174);
            this.textValor.Margin = new System.Windows.Forms.Padding(2);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(43, 20);
            this.textValor.TabIndex = 2360;
            this.textValor.Visible = false;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(694, 145);
            this.textTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(43, 20);
            this.textTotal.TabIndex = 2361;
            this.textTotal.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnImprimir.Location = new System.Drawing.Point(491, 172);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 39);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(3, 123);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtAdmin.TabIndex = 2363;
            this.txtAdmin.Visible = false;
            // 
            // textBuscaId
            // 
            this.textBuscaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscaId.ForeColor = System.Drawing.Color.Black;
            this.textBuscaId.Location = new System.Drawing.Point(4, 212);
            this.textBuscaId.MaxLength = 13;
            this.textBuscaId.Name = "textBuscaId";
            this.textBuscaId.Size = new System.Drawing.Size(115, 20);
            this.textBuscaId.TabIndex = 1;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(125, 210);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "&Ok";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // lblBuscaId
            // 
            this.lblBuscaId.AutoSize = true;
            this.lblBuscaId.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaId.ForeColor = System.Drawing.Color.Red;
            this.lblBuscaId.Location = new System.Drawing.Point(0, 195);
            this.lblBuscaId.Name = "lblBuscaId";
            this.lblBuscaId.Size = new System.Drawing.Size(124, 16);
            this.lblBuscaId.TabIndex = 2364;
            this.lblBuscaId.Text = "Consulta p/ Código:";
            // 
            // frmVerAcomodacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 243);
            this.Controls.Add(this.lblBuscaId);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.textBuscaId);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textDias);
            this.Controls.Add(this.textQuarto);
            this.Controls.Add(this.textLeito);
            this.Controls.Add(this.textAcomodacao);
            this.Controls.Add(this.textCodAcomd);
            this.Controls.Add(this.textInternacao);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.txtCloneNome);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDiasInternados);
            this.Controls.Add(this.txtControlaDia);
            this.Controls.Add(this.txtInternacao);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.dgvVerAcomodacao);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmVerAcomodacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Acomodacão de Paciênte";
            this.Load += new System.EventHandler(this.frmVerAcomodacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVerAcomodacao_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerAcomodacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVerAcomodacao;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.MaskedTextBox txtInternacao;
        private System.Windows.Forms.TextBox txtControlaDia;
        private System.Windows.Forms.TextBox txtDiasInternados;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAcomodacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.TextBox txtCloneNome;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textInternacao;
        private System.Windows.Forms.TextBox textCodAcomd;
        private System.Windows.Forms.TextBox textAcomodacao;
        private System.Windows.Forms.TextBox textLeito;
        private System.Windows.Forms.TextBox textQuarto;
        private System.Windows.Forms.TextBox textDias;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox textBuscaId;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Label lblBuscaId;
    }
}