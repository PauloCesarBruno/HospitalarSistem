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
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmPacienteEntrada : Form
    {
        public frmPacienteEntrada(String cod)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(cod);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {

            PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
            NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

            Pcolecao = Npentrada.ConsultaPacientePorNome(txtBuscaNome.Text);
            dgvPaciente.DataSource = null;
            dgvPaciente.DataSource = Pcolecao;
            dgvPaciente.Update();
            dgvPaciente.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2

        }

        private void CarregarGridId() // Carrega e Consulta por Id.
        {

            PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
            NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

            Pcolecao = Npentrada.ConsultaPacientePorId(Convert.ToInt64(txtBuscaId.Text));
            dgvPaciente.DataSource = null;
            dgvPaciente.DataSource = Pcolecao;
            dgvPaciente.Update();
            dgvPaciente.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2

        }

        private void Inserir()
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
                Pentrada.Internacao = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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
                dgvPaciente.DataSource = Npentrada.Insere_Paciente(Pentrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe " + ex.Message, "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("O Formulario será Fechado, retorne e tente Novamente...", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void Alterar()
        {
            try
            {
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tblPaciente Set Nome='" + txtNome.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE  tblPaciente Set DataNascimento='" + txtDataNascimento.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set Sexo='" + txtSexo.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set CPF='" + maskedCPF.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set RG='" + txtRg.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set Endereco='" + txtEndereco.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set Telefone='" + txtTelefone.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set Celular='" + txtCelular.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set Plano='" + txtPlano.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set Categoria='" + txtCategoria.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set NomeAcompanhante='" + txtAcomp.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set RGAcompanhante='" + txtRgAcomp.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set EnderecoAcompanhante='" + txtEndAcomp.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set TelefoneAcompanhante='" + txtTelAcomp.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set CeluarAcompanhante='" + txtCelAcomp.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'"
                + "UPDATE tblPaciente Set EmailAcompanhante='" + txtEmailAcomp.Text + "' WHERE IdPaciente='" + txtCodigo.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPaciente.DataSource = (dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Limpa_CamposA()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;   
            txtDataNascimento.Text = String.Empty;
            txtSexo.Text = String.Empty;
            maskedCPF.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtPlano.Text = String.Empty;
            txtCategoria.Text = String.Empty;
            //
            txtAcomp.Text = String.Empty;
            txtRgAcomp.Text = String.Empty;
            txtEndAcomp.Text = String.Empty;
            txtTelAcomp.Text = String.Empty;
            txtCelAcomp.Text = String.Empty;
            txtEmailAcomp.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            dgvPaciente.DataSource = null;
        }

        #endregion
        public class FormCloseButtonDisabler // 2º Paaso -  Classe Criada para desabilitar o "X" de fechar formulário.
        {
            private const int MF_BYPOSITION = 0x400;
            private const int MF_REMOVE = 0x1000;
            private const int MF_DISABLED = 0x2;
            [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
            static extern Int32 DrawMenuBar(
            Int32 hWnd
            );
            [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
            static extern Int32 GetMenuItemCount(
            Int32 hMenu
            );
            [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
            static extern Int32 GetSystemMenu(
            Int32 hWnd,
            bool bRevert
            );
            [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
            static extern Int32 RemoveMenu(
            Int32 hMenu,
            Int32 nPosition,
            Int32 wFlags
            );
            public static void DisableCloseButton(int hWnd)
            {
                int hMenu;
                int menuItemCount;
                hMenu = GetSystemMenu(hWnd, false);
                menuItemCount = GetMenuItemCount(hMenu);
                RemoveMenu(hMenu, menuItemCount - 1, MF_DISABLED | MF_BYPOSITION);
                RemoveMenu(hMenu, menuItemCount - 2, MF_DISABLED | MF_BYPOSITION);
                DrawMenuBar(hWnd);
                // Fim da Classe (2º Passo) para desabilitar o "X" do fchar Form.                
            }
        }
        private void frmPacienteEntrada_Load(object sender, EventArgs e)
        {
            this.txtInternacao.Text = (DateTime.Now.ToShortDateString());
            grpCadastro.Focus();
            txtBuscaNome.Focus();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void frmPacienteEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region Tratamento

            // Tratamento Repetição do CPF e do RG. //
            //=====================================================================================================================================================================//
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CPF  From tblPaciente Where CPF = @CPF", conn);
            cmd.Parameters.AddWithValue("@CPF", maskedCPF.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.P.F., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_CamposA();
                CarregarGrid();
                txtBuscaNome.Focus();
                reader.Close();
                return;
            }
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("Select RG  From tblPaciente Where RG = @RG", conn);
            cmd1.Parameters.AddWithValue("@RG", txtRg.Text);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este R.G., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_CamposA();
                CarregarGrid();
                txtBuscaNome.Focus();
                reader1.Close();
                return;
            }

            // FIM DO Tratamento Repetição //
            //=====================================================================================================================================================================//

            #endregion

            try
            {

                if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || txtDataNascimento.Text == String.Empty || txtSexo.Text == String.Empty ||
                     maskedCPF.Text == String.Empty || txtRg.Text == String.Empty || txtEndereco.Text == String.Empty || txtTelefone.Text == String.Empty ||
                   txtCelular.Text == String.Empty || txtPlano.Text == String.Empty || txtCategoria.Text == String.Empty || txtAcomp.Text == String.Empty ||
                   txtRgAcomp.Text == String.Empty || txtEndAcomp.Text == String.Empty || txtTelAcomp.Text == String.Empty || txtCelAcomp.Text == String.Empty
                    || txtEmailAcomp.Text == String.Empty)
                {
                    MessageBox.Show("ERRO, Detalhe : É Necessário o preenchimeno de TODOS os campos para efetuar o Cadastro.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpa_CamposA();
                    btnEnviarTriagem.Enabled = false;
                    txtCodigo.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, Detalhe: " + ex.Message);
            }
            
            Inserir();
            btnEnviarTriagem.Enabled = true;
            btnInserir.Enabled = false;
            btnLimpar.Enabled = false;
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Focus();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();

            if (dgvPaciente.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_CamposA();
                txtBuscaNome.Focus();
            }
        }

        private void dgvPaciente_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPaciente.Rows[e.RowIndex];
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpa_CamposA();
            txtBuscaNome.Focus();
            Limpa_CamposA();
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {

            if (txtBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nehum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscaId.Focus();
                return;
            }
            CarregarGridId();
            if (dgvPaciente.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado!!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_CamposA();
                txtBuscaId.Focus();
            }
        }

        private void txtBuscaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtMedicamento.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Somente Números", "SUATEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEnviarTriagem_Click(object sender, EventArgs e)
        {
            frmTriagem triagem = new frmTriagem(Convert.ToInt64(txtCodigo.Text), txtNome.Text, txtCastData.Text, txtSexo.Text);
            this.Close();
            triagem.ShowDialog();                       
        }

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            txtCastData.Text = txtDataNascimento.Text;
        }

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            frmCodigoDeBarras cb = new frmCodigoDeBarras();
            try
            {
                cb.ShowDialog();
                if (cb.cod.ToString() != null)
                {
                    txtCodigo.Text = cb.cod.ToString();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtDataNascimento.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Somente Números", "SUATEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtCodigo.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Campo Numérico, digitar somente numeros.","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            Alterar();
            Limpa_CamposA();
            txtBuscaNome.Focus();
        }
    }
}
