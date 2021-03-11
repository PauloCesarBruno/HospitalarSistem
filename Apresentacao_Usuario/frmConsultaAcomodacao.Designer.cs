namespace Apresentacao_Usuario
{
    partial class frmConsultaAcomodacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAcomodacao));
            this.dgvConsultaAcomodacao = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasAcomodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAcomodacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscarNome = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtControlaDia = new System.Windows.Forms.TextBox();
            this.txtInternacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDiasInternados = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodico = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataInternacao = new System.Windows.Forms.MaskedTextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblDiasAcomodado = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTotalDiaria = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblCodigoAcomodacao = new System.Windows.Forms.Label();
            this.txtCodAcomod = new System.Windows.Forms.TextBox();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.picSeta = new System.Windows.Forms.PictureBox();
            this.btnreinserir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblConsultaId = new System.Windows.Forms.Label();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.btnBuscaId = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultAcomodacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAcomodacao)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaAcomodacao
            // 
            this.dgvConsultaAcomodacao.AllowUserToAddRows = false;
            this.dgvConsultaAcomodacao.AllowUserToDeleteRows = false;
            this.dgvConsultaAcomodacao.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaAcomodacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAcomodacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.NomePaciente,
            this.Data,
            this.IdDiaria,
            this.LocalAcomodado,
            this.diasAcomodado,
            this.ValorAcomodacao,
            this.Valor_Total});
            this.dgvConsultaAcomodacao.Location = new System.Drawing.Point(1, 78);
            this.dgvConsultaAcomodacao.Name = "dgvConsultaAcomodacao";
            this.dgvConsultaAcomodacao.ReadOnly = true;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultaAcomodacao.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvConsultaAcomodacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaAcomodacao.Size = new System.Drawing.Size(840, 173);
            this.dgvConsultaAcomodacao.TabIndex = 1000;
            this.dgvConsultaAcomodacao.TabStop = false;
            this.dgvConsultaAcomodacao.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaAcomodacao_CellEnter);
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
            this.NomePaciente.Width = 200;
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
            this.Data.Width = 115;
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
            this.LocalAcomodado.Width = 102;
            // 
            // diasAcomodado
            // 
            this.diasAcomodado.DataPropertyName = "diasAcomodado";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.diasAcomodado.DefaultCellStyle = dataGridViewCellStyle6;
            this.diasAcomodado.HeaderText = "Dias";
            this.diasAcomodado.Name = "diasAcomodado";
            this.diasAcomodado.ReadOnly = true;
            this.diasAcomodado.Width = 40;
            // 
            // ValorAcomodacao
            // 
            this.ValorAcomodacao.DataPropertyName = "ValorAcomodacao";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.ValorAcomodacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorAcomodacao.HeaderText = "Valor";
            this.ValorAcomodacao.Name = "ValorAcomodacao";
            this.ValorAcomodacao.ReadOnly = true;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "Valor_Total";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle8;
            this.Valor_Total.HeaderText = "Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Teal;
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(1, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(840, 74);
            this.panelTitulo.TabIndex = 105;
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
            this.lblSubTitulo.Location = new System.Drawing.Point(558, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(259, 28);
            this.lblSubTitulo.TabIndex = 5;
            this.lblSubTitulo.Text = "Manipulação Acomodação";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(168, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(353, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // lblBuscarNome
            // 
            this.lblBuscarNome.AutoSize = true;
            this.lblBuscarNome.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNome.ForeColor = System.Drawing.Color.Red;
            this.lblBuscarNome.Location = new System.Drawing.Point(8, 470);
            this.lblBuscarNome.Name = "lblBuscarNome";
            this.lblBuscarNome.Size = new System.Drawing.Size(248, 16);
            this.lblBuscarNome.TabIndex = 2306;
            this.lblBuscarNome.Text = "Consultar pelo Nome (Min. 8 caracteres):";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaNome.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaNome.Location = new System.Drawing.Point(11, 486);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(279, 20);
            this.txtBuscaNome.TabIndex = 0;
            this.txtBuscaNome.TextChanged += new System.EventHandler(this.txtBuscaNome_TextChanged);
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(120, 388);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(38, 20);
            this.txtDias.TabIndex = 2307;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(120, 416);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(80, 20);
            this.txtValor.TabIndex = 2308;
            // 
            // txtControlaDia
            // 
            this.txtControlaDia.Location = new System.Drawing.Point(772, 287);
            this.txtControlaDia.Name = "txtControlaDia";
            this.txtControlaDia.ReadOnly = true;
            this.txtControlaDia.Size = new System.Drawing.Size(67, 20);
            this.txtControlaDia.TabIndex = 2316;
            this.txtControlaDia.Visible = false;
            // 
            // txtInternacao
            // 
            this.txtInternacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInternacao.ForeColor = System.Drawing.Color.Black;
            this.txtInternacao.Location = new System.Drawing.Point(772, 264);
            this.txtInternacao.Mask = "00/00/0000";
            this.txtInternacao.Name = "txtInternacao";
            this.txtInternacao.ReadOnly = true;
            this.txtInternacao.Size = new System.Drawing.Size(67, 20);
            this.txtInternacao.TabIndex = 2315;
            this.txtInternacao.TabStop = false;
            this.txtInternacao.ValidatingType = typeof(System.DateTime);
            this.txtInternacao.Visible = false;
            // 
            // txtDiasInternados
            // 
            this.txtDiasInternados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDiasInternados.ForeColor = System.Drawing.Color.Red;
            this.txtDiasInternados.Location = new System.Drawing.Point(772, 313);
            this.txtDiasInternados.MaxLength = 10;
            this.txtDiasInternados.Name = "txtDiasInternados";
            this.txtDiasInternados.ReadOnly = true;
            this.txtDiasInternados.Size = new System.Drawing.Size(67, 20);
            this.txtDiasInternados.TabIndex = 2317;
            this.txtDiasInternados.TabStop = false;
            this.txtDiasInternados.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(120, 283);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 2319;
            this.txtNome.TabStop = false;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblNomePaciente.Location = new System.Drawing.Point(10, 286);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(97, 13);
            this.lblNomePaciente.TabIndex = 2321;
            this.lblNomePaciente.Text = "Nome Paciente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Red;
            this.txtCodigo.Location = new System.Drawing.Point(120, 257);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2318;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodico
            // 
            this.lblCodico.AutoSize = true;
            this.lblCodico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodico.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCodico.Location = new System.Drawing.Point(11, 260);
            this.lblCodico.Name = "lblCodico";
            this.lblCodico.Size = new System.Drawing.Size(87, 13);
            this.lblCodico.TabIndex = 2320;
            this.lblCodico.Text = "Cód.Paciente:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblData.Location = new System.Drawing.Point(10, 313);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(103, 13);
            this.lblData.TabIndex = 2322;
            this.lblData.Text = "Data Internação:";
            // 
            // txtDataInternacao
            // 
            this.txtDataInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInternacao.Location = new System.Drawing.Point(120, 310);
            this.txtDataInternacao.Mask = "00/00/0000";
            this.txtDataInternacao.Name = "txtDataInternacao";
            this.txtDataInternacao.ReadOnly = true;
            this.txtDataInternacao.Size = new System.Drawing.Size(80, 20);
            this.txtDataInternacao.TabIndex = 2323;
            this.txtDataInternacao.ValidatingType = typeof(System.DateTime);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblLocal.Location = new System.Drawing.Point(10, 365);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(95, 13);
            this.lblLocal.TabIndex = 2324;
            this.lblLocal.Text = "Local Acomod.:";
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(120, 362);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(170, 20);
            this.txtLocal.TabIndex = 2325;
            // 
            // lblDiasAcomodado
            // 
            this.lblDiasAcomodado.AutoSize = true;
            this.lblDiasAcomodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasAcomodado.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDiasAcomodado.Location = new System.Drawing.Point(9, 392);
            this.lblDiasAcomodado.Name = "lblDiasAcomodado";
            this.lblDiasAcomodado.Size = new System.Drawing.Size(89, 13);
            this.lblDiasAcomodado.TabIndex = 2326;
            this.lblDiasAcomodado.Text = "Dias Acomod.:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblValor.Location = new System.Drawing.Point(8, 419);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(77, 13);
            this.lblValor.TabIndex = 2328;
            this.lblValor.Text = "Valor Diária:";
            // 
            // lblTotalDiaria
            // 
            this.lblTotalDiaria.AutoSize = true;
            this.lblTotalDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiaria.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTotalDiaria.Location = new System.Drawing.Point(6, 446);
            this.lblTotalDiaria.Name = "lblTotalDiaria";
            this.lblTotalDiaria.Size = new System.Drawing.Size(77, 13);
            this.lblTotalDiaria.TabIndex = 2330;
            this.lblTotalDiaria.Text = "Total Atual::";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(120, 443);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(80, 20);
            this.txtValorTotal.TabIndex = 2331;
            // 
            // lblCodigoAcomodacao
            // 
            this.lblCodigoAcomodacao.AutoSize = true;
            this.lblCodigoAcomodacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAcomodacao.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblCodigoAcomodacao.Location = new System.Drawing.Point(9, 339);
            this.lblCodigoAcomodacao.Name = "lblCodigoAcomodacao";
            this.lblCodigoAcomodacao.Size = new System.Drawing.Size(90, 13);
            this.lblCodigoAcomodacao.TabIndex = 2332;
            this.lblCodigoAcomodacao.Text = "Cód. Acomod.:";
            // 
            // txtCodAcomod
            // 
            this.txtCodAcomod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAcomod.Location = new System.Drawing.Point(120, 336);
            this.txtCodAcomod.Name = "txtCodAcomod";
            this.txtCodAcomod.ReadOnly = true;
            this.txtCodAcomod.Size = new System.Drawing.Size(38, 20);
            this.txtCodAcomod.TabIndex = 2333;
            this.txtCodAcomod.TextChanged += new System.EventHandler(this.txtCodAcomod_TextChanged);
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(772, 339);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(67, 20);
            this.txtCast.TabIndex = 2334;
            this.txtCast.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(312, 476);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(140, 68);
            this.btnAlterar.TabIndex = 2335;
            this.btnAlterar.Text = "&Transferir Registro acomodação atual";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(458, 476);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(140, 68);
            this.btnConfirmaAlteracao.TabIndex = 2336;
            this.btnConfirmaAlteracao.Text = "&Alterar o Local de Acomodação";
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Visible = false;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.Color.Blue;
            this.lblInformacao.Location = new System.Drawing.Point(316, 313);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(361, 107);
            this.lblInformacao.TabIndex = 2337;
            this.lblInformacao.Text = resources.GetString("lblInformacao.Text");
            // 
            // picSeta
            // 
            this.picSeta.Image = ((System.Drawing.Image)(resources.GetObject("picSeta.Image")));
            this.picSeta.Location = new System.Drawing.Point(692, 318);
            this.picSeta.Name = "picSeta";
            this.picSeta.Size = new System.Drawing.Size(76, 69);
            this.picSeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeta.TabIndex = 2338;
            this.picSeta.TabStop = false;
            // 
            // btnreinserir
            // 
            this.btnreinserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreinserir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnreinserir.Image = ((System.Drawing.Image)(resources.GetObject("btnreinserir.Image")));
            this.btnreinserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnreinserir.Location = new System.Drawing.Point(608, 475);
            this.btnreinserir.Name = "btnreinserir";
            this.btnreinserir.Size = new System.Drawing.Size(140, 68);
            this.btnreinserir.TabIndex = 2339;
            this.btnreinserir.Text = "&Reinserir Paciênte com nova acomodação";
            this.btnreinserir.UseVisualStyleBackColor = true;
            this.btnreinserir.Visible = false;
            this.btnreinserir.Click += new System.EventHandler(this.btnreinserir_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(763, 476);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 68);
            this.btnSair.TabIndex = 2340;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblConsultaId
            // 
            this.lblConsultaId.AutoSize = true;
            this.lblConsultaId.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaId.ForeColor = System.Drawing.Color.Red;
            this.lblConsultaId.Location = new System.Drawing.Point(8, 509);
            this.lblConsultaId.Name = "lblConsultaId";
            this.lblConsultaId.Size = new System.Drawing.Size(129, 16);
            this.lblConsultaId.TabIndex = 2342;
            this.lblConsultaId.Text = "Consultar p/ Códigp:";
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaId.ForeColor = System.Drawing.Color.Black;
            this.txtBuscaId.Location = new System.Drawing.Point(11, 525);
            this.txtBuscaId.MaxLength = 13;
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(117, 20);
            this.txtBuscaId.TabIndex = 1;
            // 
            // btnBuscaId
            // 
            this.btnBuscaId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaId.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscaId.Location = new System.Drawing.Point(134, 523);
            this.btnBuscaId.Name = "btnBuscaId";
            this.btnBuscaId.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaId.TabIndex = 2;
            this.btnBuscaId.Text = "&Ok";
            this.btnBuscaId.UseVisualStyleBackColor = true;
            this.btnBuscaId.Click += new System.EventHandler(this.btnBuscaId_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancelar.Location = new System.Drawing.Point(173, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancel. Operação";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultAcomodacao
            // 
            this.btnConsultAcomodacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultAcomodacao.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultAcomodacao.Image")));
            this.btnConsultAcomodacao.Location = new System.Drawing.Point(162, 335);
            this.btnConsultAcomodacao.Name = "btnConsultAcomodacao";
            this.btnConsultAcomodacao.Size = new System.Drawing.Size(35, 21);
            this.btnConsultAcomodacao.TabIndex = 2343;
            this.btnConsultAcomodacao.UseVisualStyleBackColor = true;
            this.btnConsultAcomodacao.Click += new System.EventHandler(this.btnConsultAcomodacao_Click);
            // 
            // frmConsultaAcomodacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 552);
            this.Controls.Add(this.btnConsultAcomodacao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscaId);
            this.Controls.Add(this.lblConsultaId);
            this.Controls.Add(this.txtBuscaId);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnreinserir);
            this.Controls.Add(this.picSeta);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.btnConfirmaAlteracao);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.txtCodAcomod);
            this.Controls.Add(this.lblCodigoAcomodacao);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTotalDiaria);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDiasAcomodado);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtDataInternacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodico);
            this.Controls.Add(this.txtDiasInternados);
            this.Controls.Add(this.txtControlaDia);
            this.Controls.Add(this.txtInternacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblBuscarNome);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.dgvConsultaAcomodacao);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaAcomodacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acomodação Paciênte";
            this.Load += new System.EventHandler(this.frmConsultaAcomodacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaAcomodacao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAcomodacao)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaAcomodacao;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscarNome;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtControlaDia;
        private System.Windows.Forms.MaskedTextBox txtInternacao;
        private System.Windows.Forms.TextBox txtDiasInternados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodico;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtDataInternacao;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblDiasAcomodado;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTotalDiaria;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblCodigoAcomodacao;
        private System.Windows.Forms.TextBox txtCodAcomod;
        private System.Windows.Forms.TextBox txtCast;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.PictureBox picSeta;
        private System.Windows.Forms.Button btnreinserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasAcomodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAcomodacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.Label lblConsultaId;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Button btnBuscaId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultAcomodacao;
    }
}