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
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmProntuario : Form
    {
        public frmProntuario(String Responsavel, Int64 codigo, String nome)
        {
            InitializeComponent();
            txtResponsavel.Text = Convert.ToString(Responsavel);
            txtCodPaciente.Text = Convert.ToString(codigo);
            txtNomePaciente.Text = Convert.ToString(nome);
        }

        #region Metodos

        private void Carrega_Grid() // Carrega e Consulta por Nome.
        {
            try
            {
                ProntuarioColecao Pcolecao = new ProntuarioColecao();
                NegociosProntuario Nprontuario = new NegociosProntuario();

                Pcolecao = Nprontuario.ConsultaProntuarioPorNome(txtBuscaNome.Text);
                dgvProntuario.DataSource = null; // Dgv Escondido atras do Picturebox.
                dgvProntuario.DataSource = Pcolecao;
                dgvProntuario.Update();
                dgvProntuario.Refresh();
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
                ProntuarioColecao Pcolecao = new ProntuarioColecao();
                NegociosProntuario Nprontuario = new NegociosProntuario();

                Pcolecao = Nprontuario.ConsultaProntuarioPorId(Convert.ToInt64(txtBuscaId.Text));
                dgvProntuario.DataSource = null; // Dgv Escondido atras do Picturebox.
                dgvProntuario.DataSource = Pcolecao;
                dgvProntuario.Update();
                dgvProntuario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void Inserir()
        {
            String separador = "\r\n";
            String responsavel = "\r\nResponsável Primeiro Registro: ";
            String dataHora = "\r\nDia/Hora: ";

            try
            {
                if (txtData.ReadOnly == false && txtCodPaciente.ReadOnly == false && txtNomePaciente.ReadOnly == false && txtEvolucao.ReadOnly == false)
                {
                    Prontuario prontuario = new Prontuario();
                    NegociosProntuario Nprontuaro = new NegociosProntuario();

                    prontuario.Data = Convert.ToDateTime(txtData.Text);
                    prontuario.IdPaciente = Convert.ToInt64(txtCodPaciente.Text);
                    prontuario.NomePaciente = txtNomePaciente.Text;
                    prontuario.ProntuarioPaciente = txtEvolucao.Text + separador + responsavel + txtResponsavel.Text + dataHora + txtData.Text + separador;
                    dgvProntuario.DataSource = Nprontuaro.Insere_Prontuario(prontuario);
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
            String resp = "\r\nEvoluido Por: ";
            String dataH = "\r\nDia/Hora: ";

            try
            {
                if (txtData.ReadOnly == false && txtCodPaciente.ReadOnly == false && txtNomePaciente.ReadOnly == false && txtEvolucao.ReadOnly == false)
                {
                    Prontuario prontuario = new Prontuario();
                    NegociosProntuario Nprontuaro = new NegociosProntuario();

                    prontuario.Data = Convert.ToDateTime(txtData.Text);
                    prontuario.IdPaciente = Convert.ToInt64(txtCodPaciente.Text);
                    prontuario.NomePaciente = txtNomePaciente.Text;
                    prontuario.ProntuarioPaciente = txtEvolucao.Text + resp + txtResponsavel.Text + dataH + txtData.Text;
                    dgvProntuario.DataSource = Nprontuaro.Altera_Prontuario(prontuario);
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

                Prontuario prontuario = new Prontuario();
                NegociosProntuario Nprontuaro = new NegociosProntuario();
                prontuario.IdPaciente = Convert.ToInt64(txtCodPaciente.Text);
                dgvProntuario.DataSource = Nprontuaro.Exclui_Prontuario(prontuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void Limpa_Campos()
        {
            txtData.Text = String.Empty;
            txtCodPaciente.Text = String.Empty;
            txtNomePaciente.Text = String.Empty;
            txtEvolucao.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
        }
        private void Trava_Campos()
        {
            txtCodPaciente.ReadOnly = true;
            txtNomePaciente.ReadOnly = true;
        }
        private void Destrava_Campos()
        {
            txtCodPaciente.ReadOnly = false;
            txtNomePaciente.ReadOnly = false;
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
        private void frmProntuario_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.            
        }

        private void dgvProntuario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvProntuario.Rows[e.RowIndex];
            txtData.Text = row.Cells[0].Value.ToString();
            txtCodPaciente.Text = row.Cells[1].Value.ToString();
            txtNomePaciente.Text = row.Cells[2].Value.ToString();
            txtEvolucao.Text = row.Cells[3].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Destrava_Campos();
            txtData.Text = DateTime.Now.ToString();
            frmPacienteAcompanhante pa = new frmPacienteAcompanhante();
            pa.ShowDialog();
            if (pa.codigo.ToString() != null && pa.nome != null)
            {
                txtCodPaciente.Text = pa.codigo.ToString();
                txtNomePaciente.Text = pa.nome;
                txtEvolucao.Focus();
            }
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
                if (dgvProntuario.Rows.Count == 0)
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
            if (dgvProntuario.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtCodPaciente.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Prontuário, clicar Prieiramente no Botão (Novo Prontuário)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }

            #region Tratamento duplicidade

            // Tratamento Repetição de Prontuário //
            //=================================================================
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select IdPaciente From tblProntuario Where IdPaciente = @IdPaciente", conn);
            cmd.Parameters.AddWithValue("@IdPAciente", txtCodPaciente.Text);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                MessageBox.Show("Desculpe-me, não posso Efetuar este Registro, pois já existe um Prontuário em Aberto para esse Paciênte, Favor Verificar.", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Trava_Campos();
                txtBuscaNome.Focus();

                return;
            }

            #endregion

            if (txtData.Text == String.Empty || txtResponsavel.Text == String.Empty || txtCodPaciente.Text == String.Empty || txtNomePaciente.Text == String.Empty || txtEvolucao.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo Prontuário é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtCodPaciente.Focus();
                return;
            }
            if (txtCodPaciente.ReadOnly != true)
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
            txtData.Text = DateTime.Now.ToString();
            if (txtCodPaciente.ReadOnly == true)
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
            if (txtCodPaciente.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de Excluir escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                return;
            }

            frmVerificaAdm autorizacao = new frmVerificaAdm(null);
            if (autorizacao.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste Prontuário ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            else
            {
                MessageBox.Show("Você não forneceu a SENHA de administrador, como esse procedimento é de suma importância, mesmo sendo um administrador, se faz necessário esta validação.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Carrega_Grid();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                txtBuscaNome.Focus();
                return;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            // Add Referências System.Web / System.Web.Extencion / 
            // Microsoft.ReprterViewer.WebForms / Microsoft.ReprterViewer.WinForms
            //
            //==================================================================================
            // Using´s Usados: using System.Diagnostics + using Microsoft.Reporting.WinForms
            // + using System.IO;
            //==================================================================================
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            // Caminho para Encontrar Relatório
            reportViewer.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.Prontuario_Medico.rdlc";

            // Parametros do Relatório
            List<ReportParameter> listReporterParameter = new List<ReportParameter>();

            listReporterParameter.Add(new ReportParameter("Data", txtData.Text));
            listReporterParameter.Add(new ReportParameter("Paciente", txtNomePaciente.Text));
            listReporterParameter.Add(new ReportParameter("Prontuario", txtEvolucao.Text));

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

                #region Mandando Diretorio TEMP (Exemplo)

                //===============================================================================================================================
                /* Mandando para Ficheiro " Temp " - Exemplo Abaixo:
                String nomeArquivoPDF = Path.GetTempPath() + "Prescrição Médica " + DateTime.Now.ToString(" dd_MM_yyyy-HH_mm_ss") + ".pdf";*/
                //===============================================================================================================================

                #endregion

                // Mandando para diretório Escolhido:
                //===================================
                String nomeArquivoPDF = @"C:\Users\p_bru\Documents\Sistema Hospitalar\Prontuário Evolução\" + "Prontuário (Evolução) " + txtNomePaciente.Text + DateTime.Now.ToString(" dd_MM_yyyy-HH_mm_ss") + ".pdf";

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
                MessageBox.Show("Atenção: Algum Campo não foi preenchido para gerar-se um Prontuário Médico., Favor Verificar e tentar de novo", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                return;
            }
        }
    }
}