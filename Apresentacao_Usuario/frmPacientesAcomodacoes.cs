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
    public partial class frmPacientesAcomodacoes : Form
    {
        public frmPacientesAcomodacoes(String Admin)
        {
            InitializeComponent();
            dgvAcomodGeral.AutoGenerateColumns = false;
            txtAdmin.Text = Convert.ToString(Admin);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacoesColecao Acolecao = new AcomodacoesColecao();
                NegociosAcomodacoes NAcomodacoes = new NegociosAcomodacoes();

                Acolecao = NAcomodacoes.ConsultaNome(txtBuscaNome.Text);
                dgvAcomodGeral.DataSource = null;
                dgvAcomodGeral.DataSource = Acolecao;
                dgvAcomodGeral.Update();
                dgvAcomodGeral.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void CarregarGrid2() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacoesColecao Acolecao = new AcomodacoesColecao();
                NegociosAcomodacoes NAcomodacoes = new NegociosAcomodacoes();

                Acolecao = NAcomodacoes.ConsultaNomePaciente(txtBuscaNomePaciente.Text);
                dgvAcomodGeral.DataSource = null;
                dgvAcomodGeral.DataSource = Acolecao;
                dgvAcomodGeral.Update();
                dgvAcomodGeral.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void BuscaId()
        {
            try
            {

                AcomodacoesColecao Acolecao = new AcomodacoesColecao();
                NegociosAcomodacoes NAcomodacoes = new NegociosAcomodacoes();

                Acolecao = NAcomodacoes.ConsultaNomePacienteID(Convert.ToInt64(txtBuscaId.Text));
                dgvAcomodGeral.DataSource = null;
                dgvAcomodGeral.DataSource = Acolecao;
                dgvAcomodGeral.Update();
                dgvAcomodGeral.Refresh();
            }
            catch (Exception)
            {
                //
            }
        }
             
        private void Deletar()
        {
            try
            {
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete From tblAcomodacao Where IdPaciente ='" + txtCapCodigo .Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAcomodGeral.DataSource = (dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
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
        private void frmPacientesAcomodacoes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGrid2();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
            if (dgvAcomodGeral.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            txtBuscaNome.Text = String.Empty;
            txtBuscaNomePaciente.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Focus();
        }

        private void frmPacientesAcomodacoes_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBuscaNomePaciente_TextChanged(object sender, EventArgs e)
        {
            try
            {

                CarregarGrid();
                CarregarGrid2();

                txtCapCodigo.Text = dgvAcomodGeral.CurrentRow.Cells[1].Value.ToString();

                if (dgvAcomodGeral.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaNomePaciente.Text = String.Empty;
                    txtBuscaNomePaciente.Focus();
                }
                if (txtBuscaNomePaciente.Text.ToString().Length >= 8)
                {
                    btnexcluir.Enabled = true;
                }
                else
                {
                    btnexcluir.Enabled = false;
                }
            }
            catch (Exception )
            {
                //
            }
            try
            {               
                if (dgvAcomodGeral.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaNomePaciente.Text = String.Empty;
                    txtBuscaNomePaciente.Focus();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            if (txtAdmin.Text == "Sim")
            {
                DialogResult perg = MessageBox.Show("NÃO ESQUEÇA DE IMPRIMIR O RELATÓRIO DE CUSTOS ANTES DA EXCLUSÃO NO FORMULARIO (CONSULTA ACOMODAÇÃO ATUAL), POIS UMA VEZ EXCLUIDO NÃO PODERÁ SER MAIS IMPRESSO ...Deseja Relamente Excluir o Registro de custos deste(a) Paciente ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (perg != DialogResult.Yes)
                {
                    CarregarGrid();
                    txtBuscaNomePaciente.Text = String.Empty;
                    txtBuscaId.Text = String.Empty;
                    txtBuscaNomePaciente.Focus();
                    btnexcluir.Enabled = false;
                    return;
                }
                Deletar();
                MessageBox.Show("Registro Excluido com êxito", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                txtCodigo.Text = String.Empty;
                txtBuscaNomePaciente.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                txtBuscaNomePaciente.Focus();
                btnexcluir.Enabled = false;
                txtBuscaNomePaciente.Focus();
            }
            else if (txtAdmin.Text == "Não")
            {
                frmVerificaAdm autorizacao = new frmVerificaAdm(null);

                MessageBox.Show("Exclusão permitida somente a Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                             
                txtCodigo.Text = String.Empty;
                txtBuscaNomePaciente.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                btnexcluir.Enabled = false;
                txtBuscaNomePaciente.Focus();
                CarregarGrid();
                return;
            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            BuscaId();
            txtCapCodigo.Text = txtBuscaId.Text;

            if (txtBuscaId.Text != "")
            {
                btnexcluir.Enabled = true;
            }
            else if (txtBuscaId.Text == "")
            {
                btnexcluir.Enabled = false;
            }
            if (txtBuscaId .Text == String .Empty)
            {
                MessageBox.Show("Nenhum  Código foi Digitado!!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvConPaciente.Rows.Count == 0 && dgvAcomodGeral .Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Código Informado !!! !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaId.Text = String.Empty;
                btnexcluir.Enabled = false;
                txtBuscaId.Focus();
                return;
            }
        }
    }
}
