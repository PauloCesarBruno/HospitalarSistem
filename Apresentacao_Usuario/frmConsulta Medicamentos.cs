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
    public partial class frmConsulta_Medicamentos : Form
    {
        public String codigo { get; set; }

        public frmConsulta_Medicamentos()
        {
            InitializeComponent();
            dgcConsultMedic.AutoGenerateColumns = false;
        }

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                MedicamentosColecao Medcolecao = new MedicamentosColecao();
                NegociosValorMedicamento Nvmedicamentos = new NegociosValorMedicamento();

                Medcolecao = Nvmedicamentos.ConsultaCustoMedicamentoNome(txtBuscaNome.Text);
                dgcConsultMedic.DataSource = null;
                dgcConsultMedic.DataSource = Medcolecao;
                dgcConsultMedic.Update();
                dgcConsultMedic.Refresh();
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
                MedicamentosColecao Medcolecao = new MedicamentosColecao();
                NegociosValorMedicamento Nvmedicamentos = new NegociosValorMedicamento();

                Medcolecao = Nvmedicamentos.ConsultaCustoMedicamentoId(Convert.ToInt64(txtBuscaId.Text));
                dgcConsultMedic.DataSource = null; // dgv Escondido Atras do Picturebox
                dgcConsultMedic.DataSource = Medcolecao;
                dgcConsultMedic.Update();
                dgcConsultMedic.Refresh();
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
            }
        }

        private void frmConsulta_Medicamentos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
        .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
                if (dgcConsultMedic.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaNome.Focus();
                }
                txtCapCodigo.Text = dgcConsultMedic.CurrentRow.Cells[0].Value.ToString();               
            }
            catch (Exception)
            {
                //
            }

        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            if (txtBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nenhum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscaId.Focus();
                return;
            }
            try
            {
                ConsultaId();
                if (dgcConsultMedic.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaId.Text = String.Empty;
                    txtBuscaNome.Text = String.Empty;
                }
                txtCapCodigo.Text = dgcConsultMedic.CurrentRow.Cells[0].Value.ToString();                
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Focus();
        }

        private void frmConsulta_Medicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = txtCapCodigo.Text;
            this.Close();
        }

        private void dgcConsultMedic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgcConsultMedic.Rows[e.RowIndex];
            txtCapCodigo.Text = row.Cells[0].Value.ToString();
        }
    }
}
