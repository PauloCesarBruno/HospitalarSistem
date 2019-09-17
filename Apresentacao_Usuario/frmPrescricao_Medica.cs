using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
//
using Conexao_SQLServer;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmPrescricao_Medica : Form
    {
        public frmPrescricao_Medica(String medico)
        {
            InitializeComponent();
            txtMedico.Text = Convert.ToString(medico);
        }

        private void carregaDadosCombos()
        {
            try
            {
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                SqlDataReader dr;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nome  FROM tblPaciente order by Nome", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbPaciente.Items.Add(dr["Nome"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void frmPrescricao_Medica_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
            txtHora.Text = DateTime.Now.ToShortTimeString();
            carregaDadosCombos();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToShortTimeString();
        
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
            reportViewer.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.Prescricao_Medica.rdlc";

            // Parametros do Relatório
            List<ReportParameter> listReporterParameter = new List<ReportParameter>();

            listReporterParameter.Add(new ReportParameter("Data", txtData.Text));
            listReporterParameter.Add(new ReportParameter("Hora", txtHora.Text));
            listReporterParameter.Add(new ReportParameter("Medico", txtMedico.Text));
            listReporterParameter.Add(new ReportParameter("Paciente", cmbPaciente.Text));
            listReporterParameter.Add(new ReportParameter("Prescricao", txtPrescricao.Text));

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
                String nomeArquivoPDF = @"C:\Users\paulo\Documents\Sistema Hospitalar\Prescrições Médicas\" + "Prescrição Médica " + cmbPaciente.SelectedItem + DateTime.Now.ToString(" dd_MM_yyyy-HH_mm_ss") + ".pdf";

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
                MessageBox.Show("Atenção: Algum Campo não foi preenchido para gerar-se uma Prescrição Médica., Favor Verificar e tentar de novo", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaciente.Text = String.Empty;
                cmbPaciente.Focus();
                return;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbPaciente.Text = null;
            txtPrescricao.Text = String.Empty;
            txtPrescricao.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}