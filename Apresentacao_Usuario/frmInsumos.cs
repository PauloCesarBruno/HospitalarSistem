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
    public partial class frmInsumos : Form
    {
        public frmInsumos(String cod)
        {
            InitializeComponent();
            dgvInsumo.AutoGenerateColumns = false;
            txtCodigo.Text = Convert.ToString(cod);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                Insumo_Colecao Icolecao = new Insumo_Colecao();
                NegociosInsumos NInsumo = new NegociosInsumos();

                Icolecao = NInsumo.ConsultaInsumoPorNome(txtBuscaNome.Text);
                dgvInsumo.DataSource = null;
                dgvInsumo.DataSource = Icolecao;
                dgvInsumo.Update();
                dgvInsumo.Refresh();
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

                if (txtCodigo.ReadOnly == false && txtInsumo.ReadOnly == false && txtQtd.ReadOnly == false && txtQtdMinima.ReadOnly == false && txtQtdMaxima.ReadOnly == false)
                {
                    Insumos Insumos = new Insumos();
                    NegociosInsumos Ninsumo = new NegociosInsumos();

                    Insumos.IdInsumo = Convert.ToInt64(txtCodigo.Text);
                    Insumos.NomeInsumo = txtInsumo.Text;
                    Insumos.Quantidade = Convert.ToInt32(txtQtd.Text);
                    Insumos.QtdMinima = Convert.ToInt32(txtQtdMinima.Text);
                    Insumos.QtdMaxima = Convert.ToInt32(txtQtdMaxima.Text);

                    dgvInsumo.DataSource = Ninsumo.Insere_Insumo(Insumos);
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

                if (txtCodigo.ReadOnly == false && txtInsumo.ReadOnly == false && txtQtd.ReadOnly == false && txtQtdMinima.ReadOnly == false && txtQtdMaxima.ReadOnly == false)
                {
                    Insumos Insumos = new Insumos();
                    NegociosInsumos Ninsumo = new NegociosInsumos();

                    Insumos.IdInsumo = Convert.ToInt64(txtCodigo.Text);
                    Insumos.NomeInsumo = txtInsumo.Text;
                    Insumos.Quantidade = Convert.ToInt32(txtQtd.Text);
                    Insumos.QtdMinima = Convert.ToInt32(txtQtdMinima.Text);
                    Insumos.QtdMaxima = Convert.ToInt32(txtQtdMaxima.Text);
                    dgvInsumo.DataSource = Ninsumo.Altera_Insumo (Insumos);

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
                Insumos Insumos = new Insumos();
                NegociosInsumos Ninsumo = new NegociosInsumos();

                Insumos.IdInsumo = Convert.ToInt64(txtCodigo.Text);
                dgvInsumo.DataSource = Ninsumo.Exclui_Insumo (Insumos);
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
                Insumo_Colecao Icolecao = new Insumo_Colecao();
                NegociosInsumos Ninsumos = new NegociosInsumos();

                Icolecao = Ninsumos.ConsultaInsumoId (Convert.ToInt64(txtBuscaId.Text));
                dgvInsumo.DataSource = null;
                dgvInsumo.DataSource = Icolecao;
                dgvInsumo.Update();
                dgvInsumo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void Trava_Campos()
        {
            txtCodigo.ReadOnly = true;
            txtInsumo.ReadOnly = true;
            txtQtd.ReadOnly = true;
            txtQtdMinima.ReadOnly = true;
            txtQtdMaxima.ReadOnly = true;
        }
        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtInsumo.ReadOnly = false;
            txtQtd.ReadOnly = false;
            txtQtdMinima.ReadOnly = false;
            txtQtdMaxima.ReadOnly = false;
        }
        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtInsumo.Text = String.Empty;
            txtQtd.Text = String.Empty;
            txtQtdMinima.Text = String.Empty;
            txtQtdMaxima.Text = String.Empty;
        }
          private void Verifica_Estoque_Minimo()
        {
            // Toda vez que o DGV sofrer uma colagem de dados, Faz um Loop em todas as Linhas
            try
            {
                for (int idx = 0; idx < dgvInsumo.RowCount; idx++)
                {
                    /* Se a quantidade for menor ou igual à quantidade mínima
                     * pinta o fundo da linha com a cor vermelha*
                     * Caso Contrário Pinta de Amarelo*/

                    if (int.Parse(dgvInsumo[3, idx].Value.ToString()) >= int.Parse(dgvInsumo[2, idx].Value.ToString()))
                    {
                        dgvInsumo.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(205, 85, 85);
                    }
                    else if (int.Parse(dgvInsumo[4, idx].Value.ToString()) <= int.Parse(dgvInsumo[2, idx].Value.ToString()))
                    {
                        dgvInsumo.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(233, 247, 17);
                    }
                    else
                    {
                        dgvInsumo.Rows[idx].DefaultCellStyle.BackColor = Color.White;
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsumos_MouseMove(object sender, MouseEventArgs e)
        {
            txtBuscaNome.Focus();
        }

        private void frmInsumos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmInsumos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void dgvInsumo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Verifica_Estoque_Minimo();
            DataGridViewRow row = this.dgvInsumo.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtInsumo.Text = row.Cells[1].Value.ToString();
            txtQtd.Text = row.Cells[2].Value.ToString();
            txtQtdMinima.Text = row.Cells[3].Value.ToString();
            txtQtdMaxima.Text = row.Cells[4].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("Desculpe, para inserção de insumos no estoque é necessario apresentação de nota de entrada de insumo(s) no almoxarifado para constar no arquivo... - FOI APRESENTADA NOTA DE ENTRADA EM ESTOQUE (Sim) ou (Não) ???",
             "Requisição Necessária", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (X != System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Desculpe, é necessário nota de entrada de insumos para constar no arquivo !!!", "Requisiçao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            Limpa_Campos();
            txtBuscaNome.Focus();
            Destrava_Campos();
            txtCodigo.Focus();
            frmCodigoDeBarrasInsumos cbi = new frmCodigoDeBarrasInsumos();
            cbi.ShowDialog();
            if (cbi.cod.ToString() != null)
            {
                txtCodigo.Text = cbi.cod.ToString();
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
            if (dgvInsumo.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Insumo, clicar Primeiramente no Botão (Novo Medicamento)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }

            if (txtCodigo.Text == String.Empty || txtInsumo.Text == String.Empty || txtQtd.Text == String.Empty || txtQtdMinima.Text == String.Empty || txtQtdMaxima.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo Insumo é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvInsumo.FirstDisplayedScrollingRowIndex = dgvInsumo.RowCount - 1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("Desculpe, para Manipular estoque é necessario apresentação de requisição de solicitação de retirada assinada pelo responsável do pedido ou nota de entrada de insumo no estoque para constar no arquivo... - FOI APRESENTADA REQUISIÇÃO DE SAIDA OU NOTA DE ENTRADA (Sim) ou (Não) ???",
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
            DialogResult X = MessageBox.Show("Desculpe, para excluir insumos do estoque é necessario apresentação de requisição de solicitação de exclusão de insumo(s) do almoxarifado assinada pelo responsável do pedido de exclusão para constar no arquivo... - FOI APRESENTADA REQUISIÇÃO DE ECLUSÃO (Sim) ou (Não) ???",
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

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste Insumo ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (dgvInsumo.Rows.Count == 0)
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

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            frmCodigoDeBarrasInsumos cbi = new frmCodigoDeBarrasInsumos();
            try
            {
                cbi.ShowDialog();
                if (cbi.cod.ToString() != null)
                {
                    txtCodigo.Text = cbi.cod.ToString();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void frmInsumos_MouseLeave(object sender, EventArgs e)
        {
            Verifica_Estoque_Minimo();
        }
    }
}
