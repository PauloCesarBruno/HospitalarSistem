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
    public partial class frmConsultaCustos : Form
    {
        public frmConsultaCustos(String Admin)
        {
            InitializeComponent();
            dgvConCustos.AutoGenerateColumns = false;
            txtAdmin.Text = Convert.ToString(Admin);
        }

        #region Metodos

        private void BuscaId()
        {
            try
            {

                CustosColecao Ccolecao = new CustosColecao();
                NegociosCustos Ncustos = new NegociosCustos();

                Ccolecao = Ncustos.ConsultaCustosId (Convert.ToInt64(txtBuscaId.Text));
                dgvConCustos.DataSource = null;
                dgvConCustos.DataSource = Ccolecao;
                dgvConCustos.Update();
                dgvConCustos.Refresh();
            }
            catch (Exception)
            {
               //
            }
        }
        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                CustosColecao Ccolecao = new CustosColecao();
                NegociosCustos Ncustos = new NegociosCustos();

                Ccolecao = Ncustos.ConsultaCustosNome(txtBuscaNome.Text);
                dgvConCustos.DataSource = null;
                dgvConCustos.DataSource = Ccolecao;
                dgvConCustos.Update();
                dgvConCustos.Refresh();
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
                Custos custos = new Custos();
                NegociosCustos Ncustos = new NegociosCustos();

                custos.NomePaciente  = Convert.ToString (txtBuscaNome .Text );
                dgvConCustos.DataSource = Ncustos.Exclui_Custos(custos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
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

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();

              if (txtBuscaNome.Text.ToString().Length >= 8)
              {
                  btnExcluiCustos.Enabled = true;
              }
              else
              {
                  btnExcluiCustos.Enabled = false;
              }

            if (dgvConCustos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Text = String.Empty;
                return;
            }

            if (txtBuscaNome.Text == "%" || txtBuscaNome.Text == " ")
            {
                dgvConCustos.DataSource = null;
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }

            Decimal valorTotal = 0;  // Somar Coluna DGV Insumos.
            foreach (DataGridViewRow col in dgvConCustos.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[6].Value);
            }
            txtInsumosTotal.Text = String.Format("{0:N}", valorTotal);

            //===========================================================================

            Decimal valorTotal1 = 0;  // Somar Coluna DGV Medicamentos.
            foreach (DataGridViewRow col in dgvConCustos.Rows)
            {
                valorTotal1 = valorTotal1 + Convert.ToDecimal(col.Cells[9].Value);
            }
            txtMedicamentosTotal.Text = String.Format("{0:N}", valorTotal1);

            //===========================================================================

            Decimal valorTotal2 = 0;  // Somar Coluna DGV Medicamentos.
            foreach (DataGridViewRow col in dgvConCustos.Rows)
            {
                valorTotal2 = valorTotal2 + Convert.ToDecimal(col.Cells[12].Value);
            }
            txtExamesTotal.Text = String.Format("{0:N}", valorTotal2);

            //===========================================================================

            Decimal Tgeral = 0;
            Tgeral = valorTotal + valorTotal1 + valorTotal2;
            txtTotalGeral.Text = String.Format("{0:N}", Tgeral);


            if (txtBuscaNome.Text == String.Empty)
            {
                dgvConCustos.DataSource = null;
                txtInsumosTotal.Text = String.Empty;
                txtMedicamentosTotal.Text = String.Empty;
                txtExamesTotal.Text = String.Empty;
                txtTotalGeral.Text = String.Empty;
            }
        }

        private void frmConsultaCustos_Load(object sender, EventArgs e)
        {
            grpBusca.Focus();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluiCustos_Click(object sender, EventArgs e)
        {           
            if (txtAdmin.Text == "Sim")
            {
                DialogResult perg = MessageBox.Show("NÃO ESQUEÇA DE IMPRIMIR O RELATÓRIO DE CUSTOS ANTES DA EXCLUSÃO, POIS UMA VEZ EXCLUIDO NÃO PODERÁ SER MAIS IMPRESSO ...Deseja Relamente Excluir o Registro de custos deste(a) Paciente ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (perg != DialogResult.Yes)
                {
                    CarregarGrid();
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaId.Text = String.Empty;
                    dgvConCustos.DataSource = null;
                    btnExcluiCustos.Enabled = false;
                    txtBuscaNome.Focus();
                    return;
                }
                               
                Deletar();
                MessageBox.Show("Registro Excluido com êxito", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }
               else if (txtAdmin.Text  == "Não")
            {
                frmVerificaAdm autorizacao = new frmVerificaAdm(null);

                MessageBox.Show("Exclusão permitida somente a Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                CarregarGrid();
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
                return;
            }
        }

        private void frmConsultaCustos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            BuscaId();
            if (txtBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nehum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscaId.Focus();
                return;
            }

            if (dgvConCustos.Rows.Count == 0  || txtBuscaId .Text == String.Empty)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaId.Text = String.Empty;
                txtBuscaId.Focus();
                return;
            }

            btnExcluiCustos.Enabled = true;

            if (txtBuscaId.Text == String.Empty)
            {
                dgvConCustos.DataSource = null;
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }

            Decimal valorTotal = 0;  // Somar Coluna DGV Insumos.
            foreach (DataGridViewRow col in dgvConCustos.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[6].Value);
            }
            txtInsumosTotal.Text = String.Format("{0:N}", valorTotal);

            //===========================================================================

            Decimal valorTotal1 = 0;  // Somar Coluna DGV Medicamentos.
            foreach (DataGridViewRow col in dgvConCustos.Rows)
            {
                valorTotal1 = valorTotal1 + Convert.ToDecimal(col.Cells[9].Value);
            }
            txtMedicamentosTotal.Text = String.Format("{0:N}", valorTotal1);

            //===========================================================================

            Decimal valorTotal2 = 0;  // Somar Coluna DGV Medicamentos.
            foreach (DataGridViewRow col in dgvConCustos.Rows)
            {
                valorTotal2 = valorTotal2 + Convert.ToDecimal(col.Cells[12].Value);
            }
            txtExamesTotal.Text = String.Format("{0:N}", valorTotal2);

            //===========================================================================

            Decimal Tgeral = 0;
            Tgeral = valorTotal + valorTotal1 + valorTotal2;
            txtTotalGeral.Text = String.Format("{0:N}", Tgeral);


            if (txtBuscaId.Text == String.Empty)
            {
                dgvConCustos.DataSource = null;
                txtInsumosTotal.Text = String.Empty;
                txtMedicamentosTotal.Text = String.Empty;
                txtExamesTotal.Text = String.Empty;
                txtTotalGeral.Text = String.Empty;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvConCustos.DataSource = null;
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtInsumosTotal.Text = String.Empty;
            txtExamesTotal.Text = String.Empty;
            txtMedicamentosTotal.Text = String.Empty;
            txtTotalGeral.Text = String.Empty;
            btnExcluiCustos.Enabled = false;
            txtBuscaNome.Focus();
        }
    }
}