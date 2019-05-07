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
    public partial class frmTecnicoEnfermagem : Form
    {
        public frmTecnicoEnfermagem()
        {
            InitializeComponent();
        }

        #region Métodos

        private void Carrega_Grid() // Carrega e Consulta por Nome.
        {
            try
            {
                TecnicoEnfermagemColecao Tecolecao = new TecnicoEnfermagemColecao();
                NegociosTecnicosEnfermagem Ntecnfermagem = new NegociosTecnicosEnfermagem();

                Tecolecao = Ntecnfermagem.ConsultaTecnicoNome(txtBuscaNome.Text);
                DgvTecnico.DataSource = null; // Dgv Escondido atras do Picturebox.
                DgvTecnico.DataSource = Tecolecao;
                DgvTecnico.Update();
                DgvTecnico.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void ConsultaPorId()
        {
            try
            {
                TecnicoEnfermagemColecao Tecolecao = new TecnicoEnfermagemColecao();
                NegociosTecnicosEnfermagem Ntecnfermagem = new NegociosTecnicosEnfermagem();

                Tecolecao = Ntecnfermagem.ConsultaTecnicoId(Convert.ToInt32(txtBuscaId.Text));
                DgvTecnico.DataSource = null;
                DgvTecnico.DataSource = Tecolecao;
                DgvTecnico.Update();
                DgvTecnico.Refresh();
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
                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtEndereco.ReadOnly == false && txtCoren.ReadOnly == false && txtCpf.ReadOnly == false && txtRg.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false && txtEmail.ReadOnly == false)
                {
                    TecnicoEnfermagem Tecnfermagem = new TecnicoEnfermagem();
                    NegociosTecnicosEnfermagem Ntecnfermagem = new NegociosTecnicosEnfermagem();

                    Tecnfermagem.IdTecnico = Convert.ToInt32(txtCodigo.Text);
                    Tecnfermagem.NomeTecnico = txtNome.Text;
                    Tecnfermagem.Endereco = txtEndereco.Text;
                    Tecnfermagem.COREN = txtCoren.Text;
                    Tecnfermagem.CPF = txtCpf.Text;
                    Tecnfermagem.RG = txtRg.Text;
                    Tecnfermagem.Telefone = txtTelefone.Text;
                    Tecnfermagem.Celular = txtCelular.Text;
                    Tecnfermagem.Email = txtEmail.Text;
                    DgvTecnico.DataSource = Ntecnfermagem.Insere_Tecico(Tecnfermagem);
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
                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtEndereco.ReadOnly == false && txtCoren.ReadOnly == false && txtCpf.ReadOnly == false && txtRg.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false && txtEmail.ReadOnly == false)
                {
                    TecnicoEnfermagem Tecnfermagem = new TecnicoEnfermagem();
                    NegociosTecnicosEnfermagem Ntecnfermagem = new NegociosTecnicosEnfermagem();

                    Tecnfermagem.IdTecnico = Convert.ToInt32(txtCodigo.Text);
                    Tecnfermagem.NomeTecnico = txtNome.Text;
                    Tecnfermagem.Endereco = txtEndereco.Text;
                    Tecnfermagem.COREN = txtCoren.Text;
                    Tecnfermagem.CPF = txtCpf.Text;
                    Tecnfermagem.RG = txtRg.Text;
                    Tecnfermagem.Telefone = txtTelefone.Text;
                    Tecnfermagem.Celular = txtCelular.Text;
                    Tecnfermagem.Email = txtEmail.Text;
                    DgvTecnico.DataSource = Ntecnfermagem.Altera_Tecico(Tecnfermagem);
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

        private void Deletar()
        {
            try
            {

                TecnicoEnfermagem Tecnfermagem = new TecnicoEnfermagem();
                NegociosTecnicosEnfermagem Ntecnfermagem = new NegociosTecnicosEnfermagem();

                Tecnfermagem.IdTecnico = Convert.ToInt32(txtCodigo.Text);
                DgvTecnico.DataSource = Ntecnfermagem.Exclui_Tecico(Tecnfermagem);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtCoren.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
        }
        private void Trava_Campos()
        {
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtCoren.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtRg.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }
        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtCoren.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtRg.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtEmail.ReadOnly = false;
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTecnicoEnfermagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void DgvTecnico_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DgvTecnico.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtEndereco.Text = row.Cells[2].Value.ToString();
            txtCoren.Text = row.Cells[3].Value.ToString();
            txtCpf.Text = row.Cells[4].Value.ToString();
            txtRg.Text = row.Cells[5].Value.ToString();
            txtTelefone.Text = row.Cells[6].Value.ToString();
            txtCelular.Text = row.Cells[7].Value.ToString();
            txtEmail.Text = row.Cells[8].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtCodigo.Focus();
            Destrava_Campos();
            txtCodigo.Focus();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            Destrava_Campos();
            if (txtBuscaNome.Text == String.Empty)
            {
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
            }
            else
            {
                Carrega_Grid();
                if (DgvTecnico.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpa_Campos();
                    txtBuscaNome.Text = String.Empty;
                }
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
            ConsultaPorId();
            if (DgvTecnico.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaId.Text = String.Empty;
                btnAtualizar.Focus();
            }
            else
            {
                Destrava_Campos();
                if (txtBuscaId.Text == String.Empty)
                {
                    Trava_Campos();
                }
                ConsultaPorId();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            Limpa_Campos();
            Trava_Campos();
            txtBuscaNome.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region Tratamento

            // Tratamento Repetição do COREN, do CPF e do RG. //
            //=====================================================================================================================================================================//
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select COREN  From tblTecnicoEnfermagem Where COREN = @COREN", conn);
            cmd.Parameters.AddWithValue("@COREN", txtCoren.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.O.R.E.M., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Carrega_Grid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader.Close();
                return;
            }
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("Select CPF  From tblTecnicoEnfermagem Where CPF = @CPF", conn);
            cmd1.Parameters.AddWithValue("@CPF", txtCpf.Text);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.P.F., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Carrega_Grid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader1.Close();
                return;
            }
            reader.Close();
            reader1.Close();
            SqlCommand cmd2 = new SqlCommand("Select RG  From tblTecnicoEnfermagem Where RG = @RG", conn);
            cmd2.Parameters.AddWithValue("@RG", txtRg.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este R.G., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Carrega_Grid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader.Close();
                reader1.Close();
                reader2.Close();
                return;
            }
            // FIM DO Tratamento Repetição//
            //=====================================================================================================================================================================//

            #endregion
            
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um(a) Novo(a) Técnico(a), clicar Prieiramente no Botão (Novo(a) Técnico(a))", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }
            if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || txtEndereco.Text == String.Empty || txtCoren.Text == String.Empty || txtCpf.Text == String.Empty || txtRg.Text == String.Empty || txtTelefone.Text == String.Empty || txtCelular.Text == String.Empty || txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo(a) Técnico(a) é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtCodigo.Focus();
                return;
            }
            if (txtCodigo.ReadOnly != true)
            {
                MessageBox.Show("Registro Inserido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Inserir();
            Limpa_Campos();
            Trava_Campos();
            txtBuscaNome.Focus();
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
            Limpa_Campos();
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

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste(a) Técnico(a) ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                Trava_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                return;
            }
            Deletar();
            Trava_Campos();
            txtBuscaId.Text = String.Empty;
            MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpa_Campos();
        }

        private void frmTecnicoEnfermagem_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }
    }
}
