using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conexao_SQLServer;
using Objeto_de_Transferencia;
using System.Data.SqlClient;
using Regras_de_Negocios;
//
using System.Threading;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.



namespace Apresentacao_Usuario
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {

            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            try
            {
                Application.Run(new SplashScreen());
            }
            catch (Exception)
                {
                    //
                }
        }

       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
         
        bool verificaLogin()
        {
            bool result = false;
            Conect conect = new Conect();
            string StringDeConexao = conect.sql;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = StringDeConexao;
                try
                {
                    SqlCommand cmd = new SqlCommand("Sp_AutenticaAdm",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NomeCompleto", txtNome.Text);
                    cmd.Parameters.AddWithValue("@LoginUsuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@Credencial", checkAdm.Checked);
                    conn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro, Detalhe :" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }

        private void CarregarGridAdm() // Carrega e Consulta por Nome.
        {
            try
            {
                UsuarioColecao Ucolecao = new UsuarioColecao();
                NegociosUsuarios Nusuario = new NegociosUsuarios();

                Ucolecao = Nusuario.ConsultaUsuarioPorNome(txtBuscaNome.Text);
                dgvAdm.DataSource = null;
                dgvAdm.DataSource = Ucolecao;
                dgvAdm.Update();
                dgvAdm.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }

        }

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
                // Fim da dos 3 Passos para desabilitar o "X" do Form.
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarGridAdm();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                // 3º Passo Para desabilitar o "X".
         .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult perg = MessageBox.Show("DesejaRealmente Cancelar, Sim ou Não ?", "Sistema Hospitalar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(perg == DialogResult.No)
            {
                MessageBox.Show("OK, Entre com seu Login", "Sistema Hospitalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = String.Empty;
                txtUsuario.Text = String.Empty;
                txtSenha.Text = String.Empty;
                checkAdm.Checked = false;
                txtNome.Focus();
                return;
            }
            MessageBox.Show("Ok, Cancelando Entrada no Sistema !!!", "Sistema Hospitalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private bool Logado = false;
        int contador = 0;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty || txtSenha.Text == String.Empty || txtNome.Text == String.Empty)
            {
                MessageBox.Show("Favor Preencher Os campos: Nome Completo, Login e Senha !!!", "ATENÇÂO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = String.Empty;
                txtSenha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtNome.Focus();
                return;
            }
            else
            {
                bool result = verificaLogin();
                Logado = result;

                if (result)
                {
                    this.Hide();
                    frmPrincipal principal = new frmPrincipal(txtNome.Text, txtAmarra.Text );
                    principal.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Um dos Campos: Nome completo, usuário ou senha não estão corretos.", "ATENÇÂO, O sistema irá TRAVAR em 03 tentativas sem Êxito !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Text = String.Empty;
                    txtSenha.Text = String.Empty;
                    txtNome.Focus();
                    contador += 1;
                    if (contador == 3)
                    {
                        MessageBox.Show("Você Atingiu o Numero Máximo de 03 (três) tentativas de Logar.", "ATENÇÃO !!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Text = String.Empty;
                        txtSenha.Text = String.Empty;
                        txtNome.Enabled = false;
                        txtUsuario.Enabled = false;
                        txtSenha.Enabled = false;
                        btnEntrar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnLembrarSenha.Enabled = false;
                        picImagemSegredo_Destrava.Enabled = true;
                        MessageBox.Show("Sistema Travado por  " + txtNome.Text + "  ATENÇÃO: Não tente mais nada, afaste-se do Computador para que a situação não venha a se agravar; Chame IMEDIATAMENTE seu Supervisor ou um Responsável pelo C.P.D. para que sejam tomadas as devidas Providências.", "ATENÇÃO !!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Tentativa de Login = " + contador + "  Para  " + txtNome.Text + " Falhou !!!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnLembrarSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre em contato com o C.P.D. ou Administrador do Sistema.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUsuario.Text = String.Empty;
            txtSenha.Text = String.Empty;
            // txtNome.Text = String.Empty;
            txtNome.Focus();
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void picImagemSegredo_Destrava_DoubleClick(object sender, EventArgs e)
        {
            frmVerificaAdm autorizacao = new frmVerificaAdm(null);
             if (autorizacao.ShowDialog() != System.Windows.Forms.DialogResult.OK)
             {
                 MessageBox.Show("O Sistema só Poderar ser Destravado por usuário com Credencil de (Administrador).", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 this.Close();
             }
             else
             {
                 txtNome.Enabled = true;
                 txtUsuario.Enabled = true;
                 txtSenha.Enabled = true;
                 btnEntrar.Enabled = true;
                 btnCancelar.Enabled = true;
                 btnLembrarSenha.Enabled = true;
                 txtNome.Text = String.Empty;
                 contador = 0;
                 picImagemSegredo_Destrava.Enabled = false;
                 txtNome.Focus();
             }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGridAdm();
                txtBuscaNome.Text = txtNome.Text;
                checkAdm.Checked = (Convert.ToBoolean(dgvAdm.CurrentRow.Cells[4].Value.ToString()));
                if(checkAdm .Checked == true)
                {
                    txtAmarra.Text = "Sim";
                }
                else
                {
                    txtAmarra.Text = "Não";
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}