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
    public partial class frmVerAcomodacao : Form
    {
        public frmVerAcomodacao(String nome, String Admin)
        {
            InitializeComponent();
            dgvVerAcomodacao.AutoGenerateColumns = false;
            txtCloneNome.Text = Convert.ToString(nome);
            txtAdmin.Text = Convert.ToString(Admin);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacaoColecao Acolecao = new AcomodacaoColecao();
                NegociosAcomodacao Nacomodacao = new NegociosAcomodacao();

                Acolecao = Nacomodacao.ConsultaAcomodacaoNome(txtBuscaNome.Text);
                dgvVerAcomodacao.DataSource = null;
                dgvVerAcomodacao.DataSource = Acolecao;
                dgvVerAcomodacao.Update();
                dgvVerAcomodacao.Refresh();
            }
            catch (Exception)
            {
                //
            }
        }

        private void BuscaId()
        {
            try
            {

                AcomodacaoColecao Acolecao = new AcomodacaoColecao();
                NegociosAcomodacao Nacomodacao = new NegociosAcomodacao();

                Acolecao = Nacomodacao.ConsultaAcomodacaoId(Convert.ToInt64(textBuscaId.Text));
                dgvVerAcomodacao.DataSource = null;
                dgvVerAcomodacao.DataSource = Acolecao;
                dgvVerAcomodacao.Update();
                dgvVerAcomodacao.Refresh();
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
                Acomodacao acomodacao = new Acomodacao();
                NegociosAcomodacao Nacomodacao = new NegociosAcomodacao();

                acomodacao.NomePaciente = Convert.ToString(txtBuscaNome.Text);
                dgvVerAcomodacao.DataSource = Nacomodacao.Deleta_Acomodacao(acomodacao);
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
                btnImprimir.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
            }
            if (txtBuscaNome.Text == "%" || txtBuscaNome.Text == " ")
            {
                dgvVerAcomodacao.DataSource = null;
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }
            if (dgvVerAcomodacao.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Text = String.Empty;
                return;
            }
            else
            {
                // Rotina para calcular os dias Internados Automaticamente
                txtInternacao.Text = dgvVerAcomodacao.CurrentRow.Cells[2].Value.ToString();
                var cd = DateTime.Now;
                txtControlaDia.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays;
                dgvVerAcomodacao.CurrentRow.Cells[7].Value = Convert.ToInt32(Resposta).ToString();
                txtDiasInternados.Text = dgvVerAcomodacao.CurrentRow.Cells[7].Value.ToString();

                //==============================================================================
                // Calcula Totais
                Int32 dias;
                Decimal Valor;
                Decimal Total;

                dias = Convert.ToInt32(txtDiasInternados.Text);
                Valor = Convert.ToDecimal(dgvVerAcomodacao.CurrentRow.Cells[8].Value);
                Total = dias * Valor;
                dgvVerAcomodacao.CurrentRow.Cells[9].Value = Total;
            }
            if (txtBuscaNome.Text == String.Empty)
            {
                dgvVerAcomodacao.DataSource = null;
            }
        }

        private void frmVerAcomodacao_Load(object sender, EventArgs e)
        {
            txtBuscaNome.Text = txtCloneNome.Text;
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtBuscaNome.Text = String.Empty;
            textBuscaId.Text = String.Empty;
            btnImprimir.Enabled = false;
            txtBuscaNome.Focus();
        }

        private void frmVerAcomodacao_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvVerAcomodacao_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVerAcomodacao.Rows[e.RowIndex];
            textCodigo.Text = row.Cells[0].Value.ToString();
            textNome.Text = row.Cells[1].Value.ToString();
            textInternacao.Text = row.Cells[2].Value.ToString();
            textCodAcomd.Text = row.Cells[3].Value.ToString();
            textAcomodacao.Text = row.Cells[4].Value.ToString();
            textLeito.Text = row.Cells[5].Value.ToString();
            textQuarto.Text = row.Cells[6].Value.ToString();
            textDias.Text = txtDiasInternados.Text;
            textValor.Text = String.Format("{0:N}", row.Cells[8].Value);

            // Calcula Totais
            Int32 dias;
            Decimal Valor;
            Decimal Total;

            dias = Convert.ToInt32(txtDiasInternados.Text);
            Valor = Convert.ToDecimal(dgvVerAcomodacao.CurrentRow.Cells[8].Value);
            Total = dias * Valor;
            textTotal.Text = String.Format("{0:N}", Total);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Add Referências System.Web / System.Web.Extencion / 
            // Microsoft.ReprterViewer.WebForms / Microsoft.ReprterViewer.WinForms
            //
            //==================================================================================
            // Using´s Usados: using System.Diagnostics + using Microsoft.Reporting.WinForms
            // + using System.IO;
            //==================================================================================

            if (txtAdmin.Text == "Sim")
            {

                ReportViewer reportViewer = new ReportViewer();
                reportViewer.ProcessingMode = ProcessingMode.Local;

                // Caminho para Encontrar Relatório
                reportViewer.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.AcomodacaoAtual.rdlc";

                // Parametros do Relatório
                List<ReportParameter> listReporterParameter = new List<ReportParameter>();

                listReporterParameter.Add(new ReportParameter("Codigo", textCodigo.Text));
                listReporterParameter.Add(new ReportParameter("Nome", textNome.Text));
                listReporterParameter.Add(new ReportParameter("Acomodacao", textAcomodacao.Text));
                listReporterParameter.Add(new ReportParameter("Leito", textLeito.Text));
                listReporterParameter.Add(new ReportParameter("Quarto", textQuarto.Text));
                listReporterParameter.Add(new ReportParameter("Dias", textDias.Text));
                listReporterParameter.Add(new ReportParameter("Valor", textValor.Text));
                listReporterParameter.Add(new ReportParameter("Total", textTotal.Text));

                reportViewer.LocalReport.SetParameters(listReporterParameter);
                try
                {
                    Warning[] warnings; // Renderização.
                    String[] streamids;
                    String mimeType;
                    String encoding;
                    String extension;

                    byte[] bytePDF = reportViewer.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                    FileStream fileStreamPDF = null;


                    // Mandando para diretório Temp.
                    //==============================
                    String nomeArquivoPDF = Path.GetTempPath() + "Acomodacao Atual " + DateTime.Now.ToString(" dd_MM_yyyy-HH_mm_ss") + ".pdf";

                    fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);
                    fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
                    fileStreamPDF.Close();
                    Process.Start(nomeArquivoPDF);

                    #region Gerando em Word (Exemplo)

                    /* Gerando para Word
                /=====================================================================================================================================

                byte[] byteWord = reportViewer.LocalReport.Render("Word", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                FileStream fileStreamWord = null;
                // Mandando para Ficheiro " Temp ".
                String nomeArquivoWord = Path.GetTempPath() + "Prescrição Médica " + DateTime.Now.ToString(" dd_MM_yyyy-HH_mm_ss") + ".doc";

                fileStreamWord = new FileStream(nomeArquivoWord, FileMode.Create);
                fileStreamWord.Write(byteWord, 0, byteWord.Length);
                fileStreamWord.Close();
                Process.Start(nomeArquivoWord);
                =====================================================================================================================================*/

                    #endregion

                }
                catch (Exception)
                {
                    MessageBox.Show("Atenção: Algum Campo não foi preenchido para gerar este Relatório., Favor Verificar e tentar de novo", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }
            else if (txtAdmin.Text == "Não")
            {
                frmVerificaAdm autorizacao = new frmVerificaAdm(null);

                MessageBox.Show("Impressão permitida somente a Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
                return;

            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {           
            if (textBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nehum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBuscaId.Focus();
                return;
            }
            BuscaId();
            if (dgvVerAcomodacao.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBuscaId.Text = String.Empty;
                textBuscaId.Text = String.Empty;
                textBuscaId.Focus();
            }
            else
            {
                btnImprimir.Enabled = true;        
                // Rotina para calcular os dias Internados Automaticamente
                txtInternacao.Text = dgvVerAcomodacao.CurrentRow.Cells[2].Value.ToString();
                var cd = DateTime.Now;
                txtControlaDia.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays;
                dgvVerAcomodacao.CurrentRow.Cells[7].Value = Convert.ToInt32(Resposta).ToString();
                txtDiasInternados.Text = dgvVerAcomodacao.CurrentRow.Cells[7].Value.ToString();

                //==============================================================================
                // Calcula Totais
                Int32 dias;
                Decimal Valor;
                Decimal Total;

                dias = Convert.ToInt32(txtDiasInternados.Text);
                Valor = Convert.ToDecimal(dgvVerAcomodacao.CurrentRow.Cells[8].Value);
                Total = dias * Valor;
                dgvVerAcomodacao.CurrentRow.Cells[9].Value = Total;
            }
            if (textBuscaId.Text == String.Empty)
            {
                dgvVerAcomodacao.DataSource = null;
            }
        }
    }
}