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
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.
using Regras_de_Negocios;
using Objeto_de_Transferencia;
using Conexao_SQLServer;
using System.Data.SqlClient;

namespace Apresentacao_Usuario
{
    public partial class frmFuncionarios_Administrativos : Form
    {       
        public frmFuncionarios_Administrativos()
        {
            InitializeComponent();
            dgvFuncAdm.AutoGenerateColumns = false;
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                Outros_FuncionariosColecao Ofcolecao = new Outros_FuncionariosColecao();
                Negocios_Outros_Funcionarios Noutrosfuncionarios = new Negocios_Outros_Funcionarios();
               
                Ofcolecao = Noutrosfuncionarios.ConsultaOutrosFuncionariosNome(txtBuscaNome.Text);
                dgvFuncAdm.DataSource = null;
                dgvFuncAdm.DataSource = Ofcolecao;
                dgvFuncAdm.Update();
                dgvFuncAdm.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Inserir()
        {
            try
            {

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtCargo.ReadOnly == false && masktxtAdmissao.ReadOnly == false && txtCpts.ReadOnly == false && txtRg.ReadOnly == false && txtEndereco.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false && txtEmail.ReadOnly == false && txtObs.ReadOnly == false)
                {
                    Negocios_Outros_Funcionarios Noutrosfuncionarios = new Negocios_Outros_Funcionarios();
                    Outros_Funcionarios outrosfuncionarios = new Outros_Funcionarios();

                    outrosfuncionarios.IdFuncionario = Convert.ToInt32(txtCodigo.Text);
                    outrosfuncionarios.NomeFuncionario = txtNome.Text;
                    outrosfuncionarios.Cargo = txtCargo.Text;
                    outrosfuncionarios.Admissao = Convert.ToDateTime(masktxtAdmissao.Text);
                    outrosfuncionarios.CPTS = txtCpts.Text;
                    outrosfuncionarios.CPF = masktxtCpf.Text;
                    outrosfuncionarios.RG = txtRg.Text;
                    outrosfuncionarios.Endereco = txtEndereco.Text;
                    outrosfuncionarios.Telefone = txtTelefone.Text;
                    outrosfuncionarios.Celular = txtCelular.Text;
                    outrosfuncionarios.Email = txtEmail.Text;
                    outrosfuncionarios.Observacoes = txtObs.Text;
                    dgvFuncAdm.DataSource = Noutrosfuncionarios.InsereOutrosFuncionarios(outrosfuncionarios);

                }
                else
                {
                    //
                }
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
                Negocios_Outros_Funcionarios Noutrosfuncionarios = new Negocios_Outros_Funcionarios();
                Outros_Funcionarios outrosfuncionarios = new Outros_Funcionarios();

                outrosfuncionarios.IdFuncionario = Convert.ToInt32(txtCodigo.Text);
                outrosfuncionarios.NomeFuncionario = txtNome.Text;
                outrosfuncionarios.Cargo = txtCargo.Text;
                outrosfuncionarios.Admissao = Convert.ToDateTime(masktxtAdmissao.Text);
                outrosfuncionarios.CPTS = txtCpts.Text;
                outrosfuncionarios.CPF = masktxtCpf.Text;
                outrosfuncionarios.RG = txtRg.Text;
                outrosfuncionarios.Endereco = txtEndereco.Text;
                outrosfuncionarios.Telefone = txtTelefone.Text;
                outrosfuncionarios.Celular = txtCelular.Text;
                outrosfuncionarios.Email = txtEmail.Text;
                outrosfuncionarios.Observacoes = txtObs.Text;
                dgvFuncAdm.DataSource = Noutrosfuncionarios.AlteraOutrosFuncionarios(outrosfuncionarios);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Deletar()
        {
            try
            {
                Negocios_Outros_Funcionarios Noutrosfuncionarios = new Negocios_Outros_Funcionarios();
                Outros_Funcionarios outrosfuncionarios = new Outros_Funcionarios();

                outrosfuncionarios.IdFuncionario = Convert.ToInt32(txtCodigo.Text);
                dgvFuncAdm.DataSource = Noutrosfuncionarios.ExcluirOutrosFuncionarios(outrosfuncionarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void ConsultaId()
        {
            try
            {
                Outros_FuncionariosColecao Ofcolecao = new Outros_FuncionariosColecao();
                Negocios_Outros_Funcionarios Noutrosfuncionarios = new Negocios_Outros_Funcionarios();
                Ofcolecao = Noutrosfuncionarios.ConsultaOutrosFuncionariosId(Convert.ToInt32(txtBuscaId.Text));
                dgvFuncAdm.DataSource = null;
                dgvFuncAdm.DataSource = Ofcolecao;
                dgvFuncAdm.Update();
                dgvFuncAdm.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void Trava_Campos()
        {
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtCargo.ReadOnly = true;
            masktxtAdmissao.ReadOnly = true;
            txtCpts.ReadOnly = true;
            masktxtCpf.ReadOnly = true;
            txtRg.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtObs.ReadOnly = true;
        }
        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtCargo.ReadOnly = false;
            masktxtAdmissao.ReadOnly = false;
            txtCpts.ReadOnly = false;
            masktxtCpf.ReadOnly = false;
            txtRg.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtObs.ReadOnly = false;
        }
        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtCargo.Text = String.Empty;
            masktxtAdmissao.Text = String.Empty;
            txtCpts.Text = String.Empty;
            masktxtCpf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtObs.Text = String.Empty;
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
        private void frmFuncionarios_Administrativos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Funcionário, clicar Prieiramente no Botão (Novo(a) Funcionário(a))", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }

            #region Tratamento

            // Tratamento Repetição do CPTS, do CPF e do RG. //
            //=====================================================================================================================================================================//
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CPTS  From tblOutrosFuncionarios Where CPTS = @CPTS", conn);
            cmd.Parameters.AddWithValue("@CPTS", txtCpts .Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.P.T.S., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader.Close();
                return;
            }
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("Select CPF  From tblOutrosFuncionarios Where CPF = @CPF", conn);
            cmd1.Parameters.AddWithValue("@CPF", masktxtCpf.Text);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.P.F., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader1.Close();
                return;
            }
            reader.Close();
            reader1.Close();
            SqlCommand cmd2 = new SqlCommand("Select RG  From tblOutrosFuncionarios Where RG = @RG", conn);
            cmd2.Parameters.AddWithValue("@RG", txtRg.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este R.G., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader.Close();
                reader1.Close();
                reader2.Close();
                return;
            }
            // FIM DO Tratamento Repetição do CRM //
            //=====================================================================================================================================================================//

            #endregion

            if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || txtCargo.Text == String.Empty || masktxtAdmissao.Text == String.Empty || txtCpts.Text == String.Empty || masktxtCpf.Text == String.Empty || txtRg.Text == String.Empty || txtEndereco.Text == String.Empty || txtTelefone.Text == String.Empty || txtCelular.Text == String.Empty || txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo Funcionario(a) Administrativo(a) é Necessário Preencher todos os campos somente o campo (Observações) pode ser Vazio.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtCodigo.Focus(); 
                return;
            }
            if (txtCodigo.ReadOnly != true)
            {
                MessageBox.Show("Registro Inserido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Inserir();
            CarregarGrid();
            Trava_Campos();
            txtBuscaNome.Focus();
            //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
            dgvFuncAdm.FirstDisplayedScrollingRowIndex = dgvFuncAdm.RowCount - 1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtBuscaNome.Focus();
           /* frmVerificaAdm autorizacao = new frmVerificaAdm();
            if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Vc. Não Forneceu a SENHA de administrador (Mesmo no caso de já ser um Administrador, o fornecimento da Senha é Obrigatorio.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                Destrava_Campos(); // Seria assim se eu quisesse por Senha de Adma Aqu Também.
                txtCodigo.Focus();
            }*/
            Destrava_Campos(); // Seria assim se eu quisesse por Senha de Adma Aqu Também.
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de alterar escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                return;
            }           
                Alterar();
                Limpa_Campos();
                txtBuscaId.Text = String.Empty;
                txtBuscaNome.Text = String.Empty;
                CarregarGrid();
                Trava_Campos();
                txtBuscaNome.Focus();
                MessageBox.Show("Registro Alterado com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de Excluir escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                return;
            }
           
                DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste(a) Funcionário(a) ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (perg != DialogResult.Yes)
                {
                    Limpa_Campos();
                    txtBuscaId.Text = String.Empty;
                    txtBuscaNome.Text = String.Empty;
                    CarregarGrid();
                    Trava_Campos();
                    txtBuscaNome.Focus();
                    return;
                }
                Deletar();
                Limpa_Campos();
                txtBuscaId.Text = String.Empty;
                txtBuscaNome.Text = String.Empty;
                CarregarGrid();
                Trava_Campos();
                txtBuscaNome.Focus();
                MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        

        private void dgvFuncAdm_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvFuncAdm.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtCargo.Text = row.Cells[2].Value.ToString();
            masktxtAdmissao.Text = row.Cells[3].Value.ToString();
            txtCpts.Text = row.Cells[4].Value.ToString();
            masktxtCpf.Text = row.Cells[5].Value.ToString();
            txtRg.Text = row.Cells[6].Value.ToString();
            txtEndereco.Text = row.Cells[7].Value.ToString();
            txtTelefone.Text = row.Cells[8].Value.ToString();
            txtCelular.Text = row.Cells[9].Value.ToString();
            txtEmail.Text = row.Cells[10].Value.ToString();
            txtObs.Text = row.Cells[11].Value.ToString();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            Destrava_Campos();
            if (txtBuscaNome.Text == String.Empty)
            {
                Trava_Campos();
            }
            CarregarGrid();
            if (dgvFuncAdm.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
              if (txtBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nehum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscaId.Focus();
                return;
            }
            ConsultaId();
            if (dgvFuncAdm.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
                btnAtualizar.Focus();
            }
            else
            {
                Destrava_Campos();
                 if (txtBuscaId.Text == String.Empty)
                 {
                     Trava_Campos();
                 }
                 ConsultaId();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            Trava_Campos();
            CarregarGrid();
            txtBuscaNome.Focus();
        }

        private void frmFuncionarios_Administrativos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
    
