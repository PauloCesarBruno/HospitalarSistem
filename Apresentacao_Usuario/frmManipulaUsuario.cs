using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objeto_de_Transferencia;
using Regras_de_Negocios;
using Conexao_SQLServer;
using System.Data.SqlClient;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmManipulaUsuario : Form
    {
        public frmManipulaUsuario()
        {
            InitializeComponent();
            dgvUsuario.AutoGenerateColumns = false;
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                UsuarioColecao Ucolecao = new UsuarioColecao();
                NegociosUsuarios Nusuario = new NegociosUsuarios();

                Ucolecao = Nusuario.ConsultaUsuarioPorNome(txtBuscaNome.Text);
                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = Ucolecao;
                dgvUsuario.Update();
                dgvUsuario.Refresh();
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

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtLogin.ReadOnly == false && txtSenha.ReadOnly == false && chkCredencial.Enabled == true)
                {
                    NegociosUsuarios Nusuario = new NegociosUsuarios();
                    Usuario usuario = new Usuario();

                    usuario.IdUsuario = Convert.ToInt32(txtCodigo.Text);
                    usuario.NomeCompleto = txtNome.Text;
                    usuario.LoginUsuario = txtLogin.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.Credencial = chkCredencial.Checked;
                    dgvUsuario.DataSource = Nusuario.IserirUsuario(usuario);

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
                NegociosUsuarios Nusuario = new NegociosUsuarios();
                Usuario usuario = new Usuario();
               
                usuario.IdUsuario = Convert.ToInt32(txtCodigo.Text);
                usuario.NomeCompleto = txtNome.Text;
                usuario.LoginUsuario = txtLogin.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Credencial = chkCredencial.Checked;
                dgvUsuario.DataSource = Nusuario.AlterarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void frmManipulaUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void Deletar()
        {
            try
            {
                NegociosUsuarios Nusuario = new NegociosUsuarios();
                Usuario usuario = new Usuario();

                usuario.IdUsuario = Convert.ToInt32(txtCodigo.Text);
                dgvUsuario.DataSource = Nusuario.ExcluirUsuario(usuario);
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
                UsuarioColecao Ucolecao = new UsuarioColecao();
                NegociosUsuarios Nusuario = new NegociosUsuarios();

                Ucolecao = Nusuario.ConsultaUsuarioPorId(Convert.ToInt32(txtBuscaId.Text));
                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = Ucolecao;
                dgvUsuario.Update();
                dgvUsuario.Refresh();
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
            txtLogin.ReadOnly = true;
            txtSenha.ReadOnly = true;
            chkCredencial.Checked = false;
            txtBuscaNome.Focus();
        }
        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtLogin.ReadOnly = false;
            txtSenha.ReadOnly = false;
            chkCredencial.Enabled = true;
        }
        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;
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
        private void btnInserir_Click(object sender, EventArgs e)
        {
                       
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Usuário, clicar Prieiramente no Botão (Novo Usuário)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }
                // Tratamento Repetição do Campo Login //
                //=================================================================
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select LoginUsuario From tblUsuario Where LoginUsuario = @LoginUsuario", conn);
                cmd.Parameters.AddWithValue("@LoginUsuario", txtLogin.Text);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("Desculpe-me, não posso cadastrar este Login, pois ele já existe...Favor Verificar ou escolher outro Login.", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CarregarGrid();
                    Trava_Campos();
                    
                    return;
                }
                                      
            if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || txtLogin.Text == String.Empty || txtSenha.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo Usuário é Necessário Preencher todos os campos e Marcar se vai ser Usuário Administrador", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                chkCredencial.Checked = false;
                txtCodigo.Focus();
                return;
            }
            if (txtCodigo .ReadOnly != true )
            {
                MessageBox.Show("Registro Inserido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Inserir();
            CarregarGrid();
            Trava_Campos();
            chkCredencial.Enabled = false;
            txtBuscaNome.Focus();
            //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
            dgvUsuario.FirstDisplayedScrollingRowIndex = dgvUsuario.RowCount - 1;
            }

        private void frmManipulaUsuario_KeyDown(object sender, KeyEventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            chkCredencial.Checked = false;
            txtAdm.Visible = false;
            txtBuscaNome.Focus();
           /* frmVerificaAdm autorizacao = new frmVerificaAdm();
            if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Vc. Não Forneceu a SENHA de administrador (Mesmo no caso de já ser um Administrador, o fornecimento da Senha é Obrigatorio.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                Destrava_Campos(); // Exemplo de Como seria se eu quisesse por Chamada de Senha Adm Aqui Também.
                txtCodigo.Focus();
            }*/
            Destrava_Campos();
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
            CarregarGrid();
            Trava_Campos();
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
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
           
                DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste(a) Usuário(a) ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (perg != DialogResult.Yes)
                {
                    CarregarGrid();
                    Trava_Campos();
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaId.Text = String.Empty;
                    return;
                }
                Deletar();
                CarregarGrid();
                Trava_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
        
        private void dgvUsuario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvUsuario.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtLogin.Text = row.Cells[2].Value.ToString();
            txtSenha.Text = row.Cells[3].Value.ToString();

            txtAdm.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
            if (txtAdm .Text == "True")
            {
                txtAdm.Text = "Sim";
            }
            else
            {
                txtAdm.Text = "Não";
            }

        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtLogin.ReadOnly = false;
            txtSenha.ReadOnly = false;
            if (txtBuscaNome.Text == String.Empty)
            {
                txtCodigo.ReadOnly = true;
                txtNome.ReadOnly = true;
                txtLogin.ReadOnly = true;
                txtSenha.ReadOnly = true;
            }
            CarregarGrid();
            if (dgvUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
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
            if (dgvUsuario.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                btnAtualizar.Focus ();
            }
            else
            {

                txtCodigo.ReadOnly = false;
                txtNome.ReadOnly = false;
                txtLogin.ReadOnly = false;
                txtSenha.ReadOnly = false;
                if (txtBuscaId.Text == String.Empty)
                {
                    txtCodigo.ReadOnly = true;
                    txtNome.ReadOnly = true;
                    txtLogin.ReadOnly = true;
                    txtSenha.ReadOnly = true;
                }
                ConsultaId();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtLogin.ReadOnly = true;
            txtSenha.ReadOnly = true;
            CarregarGrid();
            txtBuscaNome.Focus();
        }
    }
}