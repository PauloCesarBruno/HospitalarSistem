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
//
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmVerAcomodacao_Anterior : Form
    {
        public frmVerAcomodacao_Anterior(String Admin)
        {
            InitializeComponent();
            dgvAnterior.AutoGenerateColumns = false;
            txtAdmin.Text = Convert.ToString(Admin);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacaoAnteriorColecao Acolecao = new AcomodacaoAnteriorColecao();
                NegociosAcomodacaoAnterior Nacomodacao = new NegociosAcomodacaoAnterior();

                Acolecao = Nacomodacao.ConsultaAcomodacaoAnteriorNome(txtBuscaNome.Text);
                dgvAnterior.DataSource = null;
                dgvAnterior.DataSource = Acolecao;
                dgvAnterior.Update();
                dgvAnterior.Refresh();
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

                AcomodacaoAnteriorColecao Acolecao = new AcomodacaoAnteriorColecao();
                NegociosAcomodacaoAnterior Nacomodacao = new NegociosAcomodacaoAnterior();

                Acolecao = Nacomodacao.ConsultaAcomodacaoAnteriorId (Convert.ToInt64(textBuscaId.Text));
                dgvAnterior.DataSource = null;
                dgvAnterior.DataSource = Acolecao;
                dgvAnterior.Update();
                dgvAnterior.Refresh();
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
                SqlCommand cmd = new SqlCommand("Delete From tblAcomodacaoAnterior Where IdPaciente ='" + txtCapCodigo.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAnterior.DataSource = (dt);
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
        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
                txtCapCodigo.Text = dgvAnterior.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                //
            }
            if (txtBuscaNome.Text.ToString().Length >= 8)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
            try
            {
                txtCodigo.Text = dgvAnterior.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                //
            }

            if (dgvAnterior.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Text = String.Empty;
                return;
            }
            if (txtBuscaNome.Text == String.Empty || txtBuscaNome.Text == "%" || txtBuscaNome.Text == " ")
            {
                dgvAnterior.DataSource = null;
                txtTotal.Text = String.Empty;
                btnCalcula.Enabled = false;
            }
            else if (txtBuscaNome.Text.ToString().Length >= 8)
            {
                btnCalcula.Enabled = true;
            }
        }

        private void frmVerAcomodacao_Anterior_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Decimal valorTotal = 0;  // Somar Coluna DGV
            foreach (DataGridViewRow col in dgvAnterior.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[7].Value);
            }
            txtTotal.Text = String.Format("{0:N}", valorTotal);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtAdmin.Text == "Sim")
            {
                DialogResult perg = MessageBox.Show("NÃO ESQUEÇA DE IMPRIMIR O RELATÓRIO DE CUSTOS ANTES DA EXCLUSÃO, POIS UMA VEZ EXCLUIDO NÃO PODERÁ SER MAIS IMPRESSO ...Deseja Relamente Excluir o Registro de custos deste(a) Paciente ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (perg != DialogResult.Yes)
                {
                    CarregarGrid();
                    txtBuscaNome.Text = String.Empty;
                    textBuscaId.Text = String.Empty;
                    txtBuscaNome.Focus();
                    return;
                }
                else

                Deletar();
                MessageBox.Show("Registro Excluido com êxito", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                txtCodigo.Text = String.Empty;
                txtBuscaNome.Text = String.Empty;
                textBuscaId.Text = String.Empty;
                txtBuscaNome.Focus();
            }
                else if (txtAdmin.Text  == "Não")
            {
                frmVerificaAdm autorizacao = new frmVerificaAdm(null);

                MessageBox.Show("Exclusão permitida somente a Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                txtCodigo.Text = String.Empty;
                txtBuscaNome.Text = String.Empty;
                textBuscaId.Text = String.Empty;
                txtBuscaNome.Focus();
                return;
            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            BuscaId();
            btnExcluir.Enabled = true;
            btnCalcula.Enabled = true;
            if (textBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nenhum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBuscaId.Focus();
                btnExcluir.Enabled = false;
                return;
            }           
            try
            {
                if (dgvAnterior.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado para o código informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBuscaId.Text = String.Empty;
                    txtBuscaNome.Text = String.Empty;
                    btnExcluir.Enabled = false;
                    textBuscaId.Focus();
                }
            }
            catch (Exception)
            {
                //
            }
            try
            {               
                txtCapCodigo.Text = dgvAnterior.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                //
            }
        }
            
        private void frmVerAcomodacao_Anterior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}