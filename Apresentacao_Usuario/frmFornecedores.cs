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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
            dgvFornec.AutoGenerateColumns = false;
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                FornecedoresColecao Fcolecao = new FornecedoresColecao();
                NegocioFornecedores Nfornecedores = new NegocioFornecedores();

                Fcolecao = Nfornecedores.ConsultaFornecedorPorNome(txtBuscaNome.Text);
                dgvFornec.DataSource = null;
                dgvFornec.DataSource = Fcolecao;
                dgvFornec.Update();
                dgvFornec.Refresh();
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

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && masktxtCnpj.ReadOnly == false && txtInscEstadual.ReadOnly == false && txtInscMunicipal.ReadOnly == false && txtEndereco.ReadOnly == false && txtEndereco.ReadOnly == false && txtTel1.ReadOnly == false && txtTel2.ReadOnly == false && txtEmail.ReadOnly == false && txtContato.ReadOnly == false)
                {

                    Fornecedores fornecedores = new Fornecedores();
                    NegocioFornecedores Nfornecedores = new NegocioFornecedores();

                    fornecedores.IdFornecedor = Convert.ToInt32(txtCodigo.Text);
                    fornecedores.Nome = txtNome.Text;
                    fornecedores.CNPJ = masktxtCnpj.Text;
                    fornecedores.InscricaoEstadual = txtInscEstadual.Text;
                    fornecedores.InscricaoMunicipal = txtInscMunicipal.Text;
                    fornecedores.Endereco = txtEndereco.Text;
                    fornecedores.Telefone1 = txtTel1.Text;
                    fornecedores.Telefone2 = txtTel2.Text;
                    fornecedores.Email = txtEmail.Text;
                    fornecedores.Contato = txtContato.Text;
                    dgvFornec.DataSource = Nfornecedores.Insere_Fornecedor(fornecedores);

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

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && masktxtCnpj.ReadOnly == false && txtInscEstadual.ReadOnly == false && txtInscMunicipal.ReadOnly == false && txtEndereco.ReadOnly == false && txtEndereco.ReadOnly == false && txtTel1.ReadOnly == false && txtTel2.ReadOnly == false && txtEmail.ReadOnly == false && txtContato.ReadOnly == false)
                {

                    Fornecedores fornecedores = new Fornecedores();
                    NegocioFornecedores Nfornecedores = new NegocioFornecedores();

                    fornecedores.IdFornecedor = Convert.ToInt32(txtCodigo.Text);
                    fornecedores.Nome = txtNome.Text;
                    fornecedores.CNPJ = masktxtCnpj.Text;
                    fornecedores.InscricaoEstadual = txtInscEstadual.Text;
                    fornecedores.InscricaoMunicipal = txtInscMunicipal.Text;
                    fornecedores.Endereco = txtEndereco.Text;
                    fornecedores.Telefone1 = txtTel1.Text;
                    fornecedores.Telefone2 = txtTel2.Text;
                    fornecedores.Email = txtEmail.Text;
                    fornecedores.Contato = txtContato.Text;
                    dgvFornec.DataSource = Nfornecedores.Altera_Fornecedor(fornecedores);

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
                Fornecedores fornecedores = new Fornecedores();
                NegocioFornecedores Nfornecedores = new NegocioFornecedores();

                fornecedores.IdFornecedor = Convert.ToInt32(txtCodigo.Text);
                dgvFornec.DataSource = Nfornecedores.Exclui_Fornecedor(fornecedores);
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
                FornecedoresColecao Fcolecao = new FornecedoresColecao();
                NegocioFornecedores Nfornecedores = new NegocioFornecedores();

                Fcolecao = Nfornecedores.ConsultaFornecedorPorId(Convert.ToInt32(txtBuscaId.Text));
                dgvFornec.DataSource = null;
                dgvFornec.DataSource = Fcolecao;
                dgvFornec.Update();
                dgvFornec.Refresh();
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
            masktxtCnpj.ReadOnly = true;
            txtInscEstadual.ReadOnly = true;
            txtInscMunicipal.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtTel1.ReadOnly = true;
            txtTel2.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContato.ReadOnly = true;
        }

        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            masktxtCnpj.ReadOnly = false;
            txtInscEstadual.ReadOnly = false;
            txtInscMunicipal.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtTel1.ReadOnly = false;
            txtTel2.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContato.ReadOnly = false;
        }

        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            masktxtCnpj.Text = String.Empty;
            txtInscEstadual.Text = String.Empty;
            txtInscMunicipal.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTel1.Text = String.Empty;
            txtTel2.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtContato.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
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
        private void frmFornecedores_Load(object sender, EventArgs e)
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

        private void frmFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
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
            // Seria assim (ACIMA) se eu quisesse por Senha de Adma Aqui Também.
            Destrava_Campos(); 
            txtCodigo.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Fornecedor, clicar Prieiramente no Botão (Novo Fornecedor)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }
            // Tratamento Repetição do Campo CNPJ //
            //=================================================================
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CNPJ From tblFornecedor Where CNPJ = @CNPJ", conn);
            cmd.Parameters.AddWithValue("@CNPJ", masktxtCnpj.Text);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                MessageBox.Show("Desculpe-me, não posso Efetuar este Registro, pois o C.N.P.J. informado já existe em um registro deste Banco de Dados...Favor Verificar.", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Trava_Campos();
                txtBuscaNome.Focus();

                return;
            }

            if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || masktxtCnpj.Text == String.Empty || txtEndereco.Text == String.Empty || txtTel1.Text == String.Empty || txtEmail.Text == String.Empty || txtContato.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo Fornecedor é Necessário Preencher todos os campos somente os campos (Inscricão Estadual ou Inscrição Municipal ou o Segundo Telefone) podem ser Vazios.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvFornec.FirstDisplayedScrollingRowIndex = dgvFornec.RowCount - 1;
        }

        private void dgvFornec_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dgvFornec.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            masktxtCnpj.Text = row.Cells[2].Value.ToString();
            txtInscEstadual.Text = row.Cells[3].Value.ToString();
            txtInscMunicipal.Text = row.Cells[4].Value.ToString();
            txtEndereco.Text = row.Cells[5].Value.ToString();
            txtTel1.Text = row.Cells[6].Value.ToString();
            txtTel2.Text = row.Cells[7].Value.ToString();
            txtEmail.Text = row.Cells[8].Value.ToString();
            txtContato.Text = row.Cells[9].Value.ToString();
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

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            Destrava_Campos();
            if (txtBuscaNome.Text == String.Empty)
            {
                Trava_Campos();
            }
            CarregarGrid();
            if (dgvFornec.Rows.Count == 0)
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
            if (dgvFornec.Rows.Count == 0)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de Excluir escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                return;
            }

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste(a) Fornecedor(a) ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                CarregarGrid();
                Trava_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                return;
            }
            Deletar();
            Trava_Campos();
            txtBuscaId.Text = String.Empty;
            CarregarGrid();
            MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpa_Campos();
        }
    }
}