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
    public partial class frmTriagem : Form
    {
        public frmTriagem(Int64 Codigo, String Nome, String Data, String Sexo)
        {
            InitializeComponent();
            dgvTriagem.AutoGenerateColumns = false;
            textCodigo.Text = Convert.ToString(Codigo);
            textNome.Text = Convert.ToString(Nome);
            textDataNascimento.Text = Convert.ToString(Data);
            textSexo.Text = Convert.ToString(Sexo);
        }

        #region METODOS

        private void Carregar()
        {
            try
            {
                Triagem_Colecao  Tcolecao = new Triagem_Colecao ();
                NegociosTriagem  Ntriagem = new NegociosTriagem ();

               Tcolecao = Ntriagem.ConsultaTriagemPorNome (txtBuscaNome.Text);
               dgvTriagem.DataSource = null;
               dgvTriagem.DataSource = Tcolecao;
               dgvTriagem.Update();
               dgvTriagem.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
                
        private void Gravar()
        {
            try
            {    
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into tblTriagem_Provisoria(Codigo, Nome, Data, Sexo, DiaHora, Pbaixa, Pmedia, Palta) Values ('" + textCodigo.Text + "', '" + textNome.Text + "','" + textDataNascimento.Text + "', '" + textSexo.Text + "', '" + DateTime.Now.ToLongTimeString() + "','" + checkBx.Checked + "', '" + checkMd.Checked + "', '" + checkAl.Checked + "')", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTriagem.DataSource = (dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, Detalhe: " + ex);
                btnAtendido.Enabled = false;
            }
        }

        #region UPDATE (Nao Usada Aqui)

        //=====================================================================================================================================================================================================================================================================================================================================================================================
        /*  private void Alterar() // Não Vou Usar, somente para constar
          {
              try
              {
                  Conect conect = new Conect();
                  SqlConnection conn = new SqlConnection(conect.sql);
                  conn.Open();
                  SqlCommand cmd = new SqlCommand("UPDATE tblTriagem_provisoria Set Nome='" + textNome.Text + "' WHERE Codigo='" + textCodigo.Text + "'" + "UPDATE  tblTriagem_provisoria Set Data='" + textDataNascimento.Text + "' WHERE Codigo='" + textCodigo.Text + "'" + "UPDATE tblTriagem_Provisoria Set Sexo='" + textSexo.Text + "' WHERE Codigo='" + textCodigo.Text + "'" + "UPDATE tblTriagem_Provisoria Set DiaHoha='" + textDiaHora.Text + "' WHERE Codigo='" + textCodigo.Text + "'", conn);
                  SqlDataAdapter da = new SqlDataAdapter(cmd);
                  DataTable dt = new DataTable();
                  da.Fill(dt);
                  dgvTriagem.DataSource = (dt);
                  conn.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("" + ex);
              }
          }*/

        //=====================================================================================================================================================================================================================================================================================================================================================================================

        #endregion

        private void Deletar()
        {
            try
            {
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete From tblTriagem_Provisoria Where Codigo='" + textCodigo.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTriagem.DataSource = (dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void BuscaNome()
        {
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Codigo, Nome, Data, Sexo, DiaHora, Pbaixa, Pmedia, Palta From tblTriagem_Provisoria WHERE Nome LIKE '%" + txtBuscaNome.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTriagem.DataSource = (dt);
            conn.Close();
        }

        private void BuscaId()
        {
            try
            {
                try
                {
                    Triagem_Colecao Tcolecao = new Triagem_Colecao();
                    NegociosTriagem Ntriagem = new NegociosTriagem();

                    Tcolecao = Ntriagem.ConsultaTriagemPorId (Convert.ToInt64(txtBuscaId.Text));
                    dgvTriagem.DataSource = null;
                    dgvTriagem.DataSource = Tcolecao;
                    dgvTriagem.Update();
                    dgvTriagem.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO, Detalhe :" + ex.Message);
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void Limpar()
        {
            textCodigo.Text = String.Empty;
            textNome.Text = String.Empty;
            textDataNascimento.Text = String.Empty;
            textSexo.Text = String.Empty;
        }

        private void atualiza()
        {
            Carregar();
            Verifica_Prioridade();
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            btnImprimir.Enabled = false;
            btnAtendido.Enabled = false;
            btnGravar.Enabled = false;
            txtBuscaNome.Focus();
        }

        private void Verifica_Prioridade()
        {
            // Toda vez que o DGV sofrer uma colagem de dados, Faz um Loop em todas as Linhas
            try
            {
                for (int idx = 0; idx < dgvTriagem.RowCount; idx++)
                {
                    /* Se a quantidade for menor ou igual à quantidade mínima
                     * pinta o fundo da linha com a cor vermelha*
                     * Caso Contrário Pinta de Amarelo*/

                    if (bool.Parse(dgvTriagem[5, idx].Value.ToString()))
                    {
                        dgvTriagem.Rows[idx].DefaultCellStyle.BackColor = Color.FromArgb(0, 192, 0);
                    }
                    else if (bool.Parse(dgvTriagem[6, idx].Value.ToString()))
                    {
                        dgvTriagem.Rows[idx].DefaultCellStyle.BackColor = Color.Gold;
                    }
                    else if (bool.Parse(dgvTriagem[7, idx].Value.ToString()))
                    {
                        dgvTriagem.Rows[idx].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        //
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
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text == String.Empty || textNome.Text == String.Empty || textDataNascimento.Text == String.Empty || textSexo.Text == String.Empty)
            {
                MessageBox.Show("Não foi possível registrar; Este(a) Paciente já esta Registrada, Clique em ATUALIZAR.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Carregar();
                checkBx.Checked = false;
                checkMd.Checked = false;
                checkAl.Checked = false;
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
                return;
            }
            else
            {
                Gravar();
                Carregar();
                Verifica_Prioridade();
                Limpar();
                btnGravar.Enabled = false;
                checkBx.Checked = false;
                checkMd.Checked = false;
                checkAl.Checked = false;
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
                //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
                dgvTriagem.FirstDisplayedScrollingRowIndex = dgvTriagem.RowCount - 1;
            }
        }

        private void frmTriagem_Load(object sender, EventArgs e)
        {
            Carregar();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
            .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuscaNome();
                if (dgvTriagem.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaNome.Focus();
                }
                txtCapNome.Text = dgvTriagem.CurrentRow.Cells[1].Value.ToString();
                Verifica_Prioridade();
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {
            Deletar();
            Carregar();
            Verifica_Prioridade();
            Limpar();
            MessageBox.Show("Paciente Encaminhado. DESIGNAR", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Focus();
            btnAtendido.Enabled = false;
            btnImprimir.Enabled = false;
            lblAnotações.Visible = false;
            textAnotacoes.Visible = false;
            btnImprimir.Focus();
        }

        private void dgvTriagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTriagem.RowCount <= 1)
                {
                    btnImprimir.Enabled = true;
                    btnAtendido.Enabled = false;

                    lblAnotações.Visible = true;
                    textAnotacoes.Visible = true;
                    textAnotacoes.Focus();
                }
                
                textDiaHora.Text = txtBuscaId.Text;
                textCodigo.Text = txtBuscaId.Text;
                txtCapNome.Text = dgvTriagem.CurrentRow.Cells[1].Value.ToString();
                textDiaHora.Text = dgvTriagem.CurrentRow.Cells[4].Value.ToString();

                DataGridViewRow row = this.dgvTriagem.Rows[e.RowIndex];
                textCodigo.Text = row.Cells[0].Value.ToString();
                textNome.Text = row.Cells[1].Value.ToString();
                textDataNascimento.Text = row.Cells[2].Value.ToString();
                textSexo.Text = row.Cells[3].Value.ToString();
                textDiaHora.Text = row.Cells[4].Value.ToString();
                checkBx.Text = row.Cells[5].Value.ToString();
                checkMd.Text = row.Cells[6].Value.ToString();
                checkAl.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                //
            }

            if (checkBx.Text == "True" || checkBx.Text == "False" || checkMd.Text == "True" || checkMd.Text == "False" || checkAl.Text == "True" || checkAl.Text == "False")
            {
                checkBx.Text = "Prioridade Baixa";
                checkMd.Text = "Prioridade Média";
                checkAl.Text = "Prioridade Alta";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualiza();
            lblAnotações.Visible = false;
            textAnotacoes.Visible = false;
            atualiza();
        }

        private void checkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBx.Checked == true)
            {
                btnGravar.Enabled = true;
            }
        }

        private void checkMd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMd.Checked == true)
            {
                btnGravar.Enabled = true;
            }
        }

        private void checkAl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAl.Checked == true)
            {
                btnGravar.Enabled = true;
            }
        }

        private void frmTriagem_MouseLeave(object sender, EventArgs e)
        {
            Verifica_Prioridade();           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnAtendido.Enabled = true;
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
            reportViewer.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.ReatorioTriagem.rdlc";

            // Parametros do Relatório
            List<ReportParameter> listReporterParameter = new List<ReportParameter>();

            listReporterParameter.Add(new ReportParameter("Codigo", textCodigo.Text));
            listReporterParameter.Add(new ReportParameter("Nome", textNome.Text));
            listReporterParameter.Add(new ReportParameter("Nascimento", textDataNascimento.Text));
            listReporterParameter.Add(new ReportParameter("Sexo", textSexo.Text));
            listReporterParameter.Add(new ReportParameter("Hora", textDiaHora.Text));
            listReporterParameter.Add(new ReportParameter("Anotacoes", textAnotacoes.Text));

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
                String nomeArquivoPDF = @"C:\Users\p_bru\Documents\Sistema Hospitalar\Ficha Cadastral\" + "Ficha Cadastral " + textNome.Text + DateTime.Now.ToString(" dd_MM_yyyy-HH_mm_ss") + ".pdf";

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
                MessageBox.Show("É Necessário o preenchimento do Campo de Anotações.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textAnotacoes.Focus();
                return;
            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            if (txtBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nenhum Código Digitado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                txtBuscaId.Text = String.Empty;
                txtBuscaId.Focus();
                return;
            }
            try
            {
                BuscaId();
                // btnImprimir.Enabled = true;
                btnAtendido.Enabled = false;
                if (dgvTriagem.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    btnImprimir.Enabled = false;
                    txtBuscaId.Text = String.Empty;
                    Carregar();
                    txtBuscaId.Focus();
                }
                textCodigo.Text = dgvTriagem.CurrentRow.Cells[0].Value.ToString();
                textNome.Text = dgvTriagem.CurrentRow.Cells[1].Value.ToString();
                textDataNascimento.Text = dgvTriagem.CurrentRow.Cells[2].Value.ToString();
                textSexo.Text = dgvTriagem.CurrentRow.Cells[3].Value.ToString();

                textDiaHora.Text = dgvTriagem.CurrentRow.Cells[4].Value.ToString();
                Verifica_Prioridade();

            }
            catch (Exception)
            {
                //
            }
        }
               
        private void txtBuscaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtBuscaId.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
}