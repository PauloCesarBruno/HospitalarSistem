using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Regras_de_Negocios;
using Objeto_de_Transferencia;
using Conexao_SQLServer;
using System.Data.SqlClient;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmFarmacia : Form
    {
        public frmFarmacia(String cod)
        {
            InitializeComponent();
            dgvFarmacia.AutoGenerateColumns = false;
            txtCodigo.Text = Convert.ToString(cod);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                Farmacia_Colecao Fcolecao = new Farmacia_Colecao();
                NegociosFarmacia Nfarmacia = new NegociosFarmacia();

                Fcolecao = Nfarmacia.ConsultaFarmaciaPorNome(txtBuscaNome.Text);
                dgvFarmacia.DataSource = null;
                dgvFarmacia.DataSource = Fcolecao;
                dgvFarmacia.Update();
                dgvFarmacia.Refresh();
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

                if (txtCodigo.ReadOnly == false && txtMedicamento.ReadOnly == false && txtQtd.ReadOnly == false && txtQtdMinima.ReadOnly == false && txtQtdMaxima.ReadOnly == false)
                {

                    Farmacia farmacia = new Farmacia();
                    NegociosFarmacia Nfarmacia = new NegociosFarmacia();

                    farmacia.IdMedicamento = Convert.ToInt64(txtCodigo.Text);
                    farmacia.NomeMedicamento = txtMedicamento.Text;
                    farmacia.Quantidade = Convert.ToInt32(txtQtd.Text);
                    farmacia.QtdMinima = Convert.ToInt32(txtQtdMinima.Text);
                    farmacia.QtdMaxima = Convert.ToInt32(txtQtdMaxima.Text);

                    dgvFarmacia.DataSource = Nfarmacia.Insere_Farmacia(farmacia);

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

                if (txtCodigo.ReadOnly == false && txtMedicamento.ReadOnly == false && txtQtd.ReadOnly == false && txtQtdMinima.ReadOnly == false && txtQtdMaxima.ReadOnly == false)
                {

                    Farmacia farmacia = new Farmacia();
                    NegociosFarmacia Nfarmacia = new NegociosFarmacia();

                    farmacia.IdMedicamento = Convert.ToInt64(txtCodigo.Text);
                    farmacia.NomeMedicamento = txtMedicamento.Text;
                    farmacia.Quantidade = Convert.ToInt32(txtQtd.Text);
                    farmacia.QtdMinima = Convert.ToInt32(txtQtdMinima.Text);
                    farmacia.QtdMaxima = Convert.ToInt32(txtQtdMaxima.Text);

                    dgvFarmacia.DataSource = Nfarmacia.Altera_Farmacia(farmacia);

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
                Farmacia farmacia = new Farmacia();
                NegociosFarmacia Nfarmacia = new NegociosFarmacia();

                farmacia.IdMedicamento = Convert.ToInt64(txtCodigo.Text);
                dgvFarmacia.DataSource = Nfarmacia.Exclui_Farmacia(farmacia);
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
                Farmacia_Colecao Fcolecao = new Farmacia_Colecao();
                NegociosFarmacia Nfarmacia = new NegociosFarmacia();

                Fcolecao = Nfarmacia.ConsultaFarmaciaPorId(Convert.ToInt64(txtBuscaId.Text));
                dgvFarmacia.DataSource = null;
                dgvFarmacia.DataSource = Fcolecao;
                dgvFarmacia.Update();
                dgvFarmacia.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Trava_Campos()
        {
            txtCodigo.ReadOnly = true;
            txtMedicamento.ReadOnly = true;
            txtQtd.ReadOnly = true;
            txtQtdMinima.ReadOnly = true;
            txtQtdMaxima.ReadOnly = true;
        }

        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtMedicamento.ReadOnly = false;
            txtQtd.ReadOnly = false;
            txtQtdMinima.ReadOnly = false;
            txtQtdMaxima.ReadOnly = false;
        }

        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtMedicamento.Text = String.Empty;
            txtQtd.Text = String.Empty;
            txtQtdMinima.Text = String.Empty;
            txtQtdMaxima.Text = String.Empty;
        }

        private void Verifica_Estoque_Minimo()
        {
            // Toda vez que o DGV sofrer uma colagem de dados, Faz um Loop em todas as Linhas
            try
            {
                for (int idx = 0; idx < dgvFarmacia.RowCount; idx++)
                {
                    /* Se a quantidade for menor ou igual à quantidade mínima
                     * pinta o fundo da linha com a cor vermelha*
                     * Caso Contrário Pinta de Amarelo*/
                    
                    if (int.Parse(dgvFarmacia[3, idx].Value.ToString()) >= int.Parse(dgvFarmacia[2, idx].Value.ToString()))
                    {
                        dgvFarmacia.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(205, 85, 85);
                    }
                    else if  (int.Parse(dgvFarmacia[4, idx].Value.ToString()) <= int.Parse(dgvFarmacia[2, idx].Value.ToString()))
                    {
                        dgvFarmacia.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(233, 247, 17);
                    }
                    else
                    {
                        dgvFarmacia.Rows[idx].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO :, Detalhe " + ex.Message);
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
        private void frmFarmacia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmFarmacia_Load(object sender, EventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
              DialogResult X = MessageBox.Show("Desculpe, para inserção de medicamentos no estoque é necessario apresentação de nota de entrada de medicamento(s) no almoxarifado para constar no arquivo... - FOI APRESENTADA NOTA DE ENTRADA EM ESTOQUE (Sim) ou (Não) ???",
             "Requisição Necessária", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (X != System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Desculpe, é necessário nota de entrada de medicamentos para constar no arquivo !!!", "Requisiçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            Limpa_Campos();
            txtBuscaNome.Focus();
            Destrava_Campos();
            txtCodigo.Focus();
            frmCodigoDeBarrasMedicamentos cbm = new frmCodigoDeBarrasMedicamentos();
            cbm.ShowDialog();
            if (cbm.cod.ToString() != null)
            {
                txtCodigo.Text = cbm.cod.ToString();
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            Destrava_Campos();
            if (txtBuscaNome.Text == String.Empty)
            {
                Trava_Campos();
            }
            CarregarGrid();
            Verifica_Estoque_Minimo();
            if (dgvFarmacia.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
            }
        }

        private void dgvFarmacia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Verifica_Estoque_Minimo();
            DataGridViewRow row = this.dgvFarmacia.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtMedicamento.Text = row.Cells[1].Value.ToString();
            txtQtd.Text = row.Cells[2].Value.ToString();
            txtQtdMinima.Text = row.Cells[3].Value.ToString();
            txtQtdMaxima.Text = row.Cells[4].Value.ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Medicamento, clicar Primeiramente no Botão (Novo Medicamento)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }

            if (txtCodigo.Text == String.Empty || txtMedicamento.Text == String.Empty || txtQtd.Text == String.Empty || txtQtdMinima.Text == String.Empty || txtQtdMaxima.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo Medicamento é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Verifica_Estoque_Minimo();
            //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
            dgvFarmacia.FirstDisplayedScrollingRowIndex = dgvFarmacia.RowCount - 1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("Desculpe, para Manipular estoque é necessario apresentação de requisição de solicitação de retirada assinada pelo responsável do pedido ou nota de entrada de medicamento no estoque para constar no arquivo... - FOI APRESENTADA REQUISIÇÃO DE SAIDA OU NOTA DE ENTRADA (Sim) ou (Não) ???",
       "Requisição Necessária", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (X != System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Desculpe, é necessário requisição ou nota de entrada para constar no arquivo !!!", "Requisiçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
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
            Verifica_Estoque_Minimo();
            MessageBox.Show("Registro Alterado com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("Desculpe, para excluir medicamentos do estoque é necessario apresentação de requisição de solicitação de exclusão de medicamento(s) do almoxarifado assinada pelo responsável do pedido de exclusão para constar no arquivo... - FOI APRESENTADA REQUISIÇÃO DE ECLUSÃO (Sim) ou (Não) ???",
     "Requisição Necessária", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (X != System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Desculpe, é necessário Requisição de exclusão para constar no arquivo !!!", "Requisiçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de Excluir escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                Verifica_Estoque_Minimo();
                return;
            }

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste Medicamento ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                CarregarGrid();
                Trava_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                Verifica_Estoque_Minimo();
                return;
            }
            Deletar();
            Trava_Campos();
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
            MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
            Verifica_Estoque_Minimo();
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
            if (dgvFarmacia.Rows.Count == 0)
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
            Verifica_Estoque_Minimo();
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
                MessageBox.Show("Campo Numérico, digitar somente numeros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
            }
        }

        private void frmFarmacia_MouseMove(object sender, MouseEventArgs e)
        {
            txtBuscaNome.Focus();
        }

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            frmCodigoDeBarrasMedicamentos cbm = new frmCodigoDeBarrasMedicamentos();
            try
            {
                cbm.ShowDialog();
                if (cbm.cod.ToString() != null)
                {
                    txtCodigo.Text = cbm.cod.ToString();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void frmFarmacia_MouseLeave(object sender, EventArgs e)
        {
            Verifica_Estoque_Minimo();
        }
    }
}