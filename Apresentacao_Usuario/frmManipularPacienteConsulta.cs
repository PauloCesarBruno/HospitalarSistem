using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Regras_de_Negocios;
using Objeto_de_Transferencia;
using Conexao_SQLServer;
using System.Data.SqlClient;

namespace Apresentacao_Usuario
{
    public partial class frmManipularPaciente : Form
    {
        public frmManipularPaciente()
        {
            InitializeComponent();
        }
        public string TheValue { get; set; } // Pega o Nome do Usuario Logado do frmPrincipal

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pcolecao = Npentrada.ConsultaPacientePorNome(txtBuscaNome.Text);
                dgvManipulacao.DataSource = null;
                dgvManipulacao.DataSource = Pcolecao;
                dgvManipulacao.Update();
                dgvManipulacao.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Alterar()
        {
            try
            {

                PacienteEntrada Pentrada = new PacienteEntrada();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pentrada.IdPaciente = Convert.ToInt64(txtCodigo.Text);
                Pentrada.IdMedico = Convert.ToInt32(txtMedico.Text);
                Pentrada.IdProcedimento = Convert.ToInt32(txtProcedimento.Text);
                Pentrada.IdDiaria = Convert.ToInt32(txtDiaria.Text);
                Pentrada.IdInsumo = Convert.ToInt64(txtInsumo.Text);
                Pentrada.IdMedicamento = Convert.ToInt64(txtMedicamento.Text);
                Pentrada.IdExame = Convert.ToInt64(txtExame.Text);
                Pentrada.Nome = txtNome.Text;
                Pentrada.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                Pentrada.Sexo = txtSexo.Text;
                Pentrada.Endereco = txtEndereco.Text;
                Pentrada.CPF = maskedCPF.Text;
                Pentrada.RG = txtRg.Text;
                Pentrada.Telefone = txtTelefone.Text;
                Pentrada.Celular = txtCelular.Text;
                Pentrada.Plano = txtPlano.Text;
                Pentrada.Categoria = txtCategoria.Text;
                Pentrada.Internacao = Convert.ToDateTime(dgvManipulacao.CurrentRow.Cells[17].Value);
                Pentrada.NomeAcompanhante = txtAcomp.Text;
                Pentrada.RGAcompanhante = txtRgAcomp.Text;
                Pentrada.EnderecoAcompanhante = txtEndAcomp.Text;
                Pentrada.TelefoneAcompanhante = txtTelAcomp.Text;
                Pentrada.CeluarAcompanhante = txtCelAcomp.Text;
                Pentrada.EmailAcompanhante = txtEmailAcomp.Text;
                Pentrada.DiasInternados = Convert.ToInt32(txtDiasInternados.Text);
                Pentrada.Leito = Convert.ToInt32(txtLeito.Text);
                Pentrada.Quarto = Convert.ToInt32(txtQuarto.Text);
                Pentrada.Alta = Convert.ToDateTime(txtAlta.Text);
                Pentrada.ObsAlta = txtObsAlta.Text;
                dgvManipulacao.DataSource = Npentrada.Altera_Paciente(Pentrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Limpa_Campos()
        {
            txtInternacao.Text = String.Empty;
            txtControlaDia.Text = String.Empty;
            txtDiasInternados.Text = String.Empty;
            txtMedico.Text = String.Empty;
            txtProcedimento.Text = String.Empty;
            txtDiaria.Text = String.Empty;
            txtInsumo.Text = String.Empty;
            txtMedicamento.Text = String.Empty;
            txtExame.Text = String.Empty;
            txtDiasInternados.Text = String.Empty;
            txtLeito.Text = String.Empty;
            txtQuarto.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
            btnADDCustos.Enabled = false;
            btnInserir.Enabled = false;
        }

        #endregion

        private void dgvManipulacao_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvManipulacao.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[7].Value.ToString();
            txtDataNascimento.Text = row.Cells[8].Value.ToString();
            txtSexo.Text = row.Cells[9].Value.ToString();
            maskedCPF.Text = row.Cells[10].Value.ToString();
            txtRg.Text = row.Cells[11].Value.ToString();
            txtEndereco.Text = row.Cells[12].Value.ToString();
            txtTelefone.Text = row.Cells[13].Value.ToString();
            txtCelular.Text = row.Cells[14].Value.ToString();
            txtPlano.Text = row.Cells[15].Value.ToString();
            txtCategoria.Text = row.Cells[16].Value.ToString();
            txtAcomp.Text = row.Cells[18].Value.ToString();
            txtRgAcomp.Text = row.Cells[19].Value.ToString();
            txtEndAcomp.Text = row.Cells[20].Value.ToString();
            txtTelAcomp.Text = row.Cells[21].Value.ToString();
            txtCelAcomp.Text = row.Cells[22].Value.ToString();
            txtEmailAcomp.Text = row.Cells[23].Value.ToString();
            txtMedico.Text = row.Cells[1].Value.ToString();
            txtProcedimento.Text = row.Cells[2].Value.ToString();
            txtDiaria.Text = row.Cells[3].Value.ToString();
            txtInsumo.Text = row.Cells[4].Value.ToString();
            txtMedicamento.Text = row.Cells[5].Value.ToString();
            txtExame.Text = row.Cells[6].Value.ToString();
            txtInternacao.Text = row.Cells[17].Value.ToString();
            txtDiasInternados.Text = row.Cells[24].Value.ToString();
            txtLeito.Text = row.Cells[25].Value.ToString();
            txtQuarto.Text = row.Cells[26].Value.ToString();
            txtAlta.Text = row.Cells[27].Value.ToString();
            txtObsAlta.Text = row.Cells[28].Value.ToString();
        }

        private void frmManipularPaciente_Load(object sender, EventArgs e)
        {
            txtResponsavel.Text = TheValue; // Carrega o Usuario Logado no txtbox deste form.
            CarregarGrid();
            txtBuscaNome.Focus();
            try
            {
                // Rotina para calcular os dias Internados Automaticamente
                var cd = DateTime.Now;
                txtControlaDia.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays;
                txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
                Alterar();
            }
            catch (Exception)
            {
                MessageBox.Show("Não Há nenhum Paciente Cadstrado", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscaNome.ReadOnly = true;
                return;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();

                if (dgvManipulacao.Rows.Count == 0 || txtBuscaNome.Text == " ")
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaNome.Focus();
                }
                var cd = DateTime.Now;
                txtControlaDia.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays;
                txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
                if (txtBuscaNome.Text != String.Empty)
                {
                    txtMedico.ReadOnly = false;
                    txtProcedimento.ReadOnly = false;
                    txtDiaria.ReadOnly = false;
                    txtLeito.ReadOnly = false;
                    txtQuarto.ReadOnly = false;
                    txtAlta.ReadOnly = false;
                    txtObsAlta.ReadOnly = false;
                    btnInserir.Enabled = true;
                    btnADDCustos.Enabled = true;
                    btnAddAcomodacao.Enabled = true;
                    btnMudarAcomodacao.Enabled = true;
                }
                else
                {
                    btnInserir.Enabled = true;
                    btnADDCustos.Enabled = true;
                    txtMedico.ReadOnly = true;
                    txtProcedimento.ReadOnly = true;
                    txtDiaria.ReadOnly = true;
                    txtDiasInternados.ReadOnly = true;
                    txtLeito.ReadOnly = true;
                    txtQuarto.ReadOnly = true;
                    txtAlta.ReadOnly = true;
                    txtObsAlta.ReadOnly = true;
                    btnInserir.Enabled = false;
                    btnADDCustos.Enabled = false;
                    btnAddAcomodacao.Enabled = false;                  

                }
                if (dgvManipulacao.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpa_Campos();
                    Alterar();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtMedico.Text == String.Empty || txtProcedimento.Text == String.Empty || txtDiaria.Text == String.Empty || txtMedicamento.Text == String.Empty ||
                 txtExame.Text == String.Empty || txtLeito.Text == String.Empty || txtQuarto.Text == String.Empty ||
               txtAlta.Text == String.Empty || txtObsAlta.Text == String.Empty)
            {
                MessageBox.Show("É Necessário o preenchimeno de TODOS os campos para efetuar o Cadastro", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtCodigo.Focus();
                return;
            }
            Alterar();
            Limpa_Campos();
            btnInserir.Enabled = false;
        }

        private void frmManipularPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtBuscaNome.Focus();
            Limpa_Campos();
        }

        private void btnADDCustos_Click(object sender, EventArgs e)
        {
            frmCustos custos = new frmCustos(Convert.ToInt64(txtCodigo.Text), txtNome.Text, txtResponsavel.Text);
            custos.ShowDialog();
        }

        private void btnAddAcomodacao_Click(object sender, EventArgs e)
        {
            frmAcomodacao acomodacao = new frmAcomodacao(Convert.ToInt64(txtCodigo.Text), txtNome.Text, Convert.ToDateTime(txtInternacao.Text), Convert.ToDateTime(txtControlaDia.Text), Convert.ToInt32(txtDiasInternados.Text));
            acomodacao.ShowDialog();
        }

        private void btnMudarAcomodacao_Click(object sender, EventArgs e)
        {
            frmConsultaAcomodacao Cacomod = new frmConsultaAcomodacao();
            Cacomod.ShowDialog();
        }
    }
}
