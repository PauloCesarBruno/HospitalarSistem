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
    public partial class frmAcomodacaoAnterior : Form
    {
        public frmAcomodacaoAnterior(Int64 Cod, String Nome, DateTime Data, Int32 CodAcomod, String Local, Int32 Dias, Decimal Valor, Decimal Vt)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(Cod);
            txtNome.Text = Nome;
            txtDataInternacao.Text = Convert.ToString(Data);
            txtCodAcomod.Text = Convert.ToString(CodAcomod);
            txtLocal.Text = Local;
            txtDias.Text = Convert.ToString(Dias);
            txtValor.Text = Convert.ToString(Valor);
            txtValorTotal.Text = Convert.ToString(Vt);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacaoAnteriorColecao Acolecao = new AcomodacaoAnteriorColecao();
                NegociosAcomodacaoAnterior Nacomodacao = new NegociosAcomodacaoAnterior();

                Acolecao = Nacomodacao.ConsultaAcomodacaoAnteriorNome(txtBuscaNome.Text);
                dgvAcomodacaoAnterior.DataSource = null;
                dgvAcomodacaoAnterior.DataSource = Acolecao;
                dgvAcomodacaoAnterior.Update();
                dgvAcomodacaoAnterior.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void Insere()
        {
            try
            {
                acomodacaoAnterior acomodacao = new acomodacaoAnterior();
                NegociosAcomodacaoAnterior Nacomodacao = new NegociosAcomodacaoAnterior();
                acomodacao.IdPaciente = Convert.ToInt64(txtCodigo.Text);
                acomodacao.NomePaciente = txtNome.Text;
                acomodacao.Data = Convert.ToDateTime(txtDataInternacao.Text);
                acomodacao.IdDiaria = Convert.ToInt32(txtCodAcomod.Text);
                acomodacao.LocalAcomodado = txtLocal.Text;
                acomodacao.diasAcomodado = Convert.ToInt32(txtDias.Text);
                acomodacao.ValorAcomodacao = Convert.ToDecimal(txtValor.Text);
                acomodacao.Valor_Total = Convert.ToDecimal(txtValorTotal.Text);
                dgvAcomodacaoAnterior.DataSource = Nacomodacao.Insere_AcomodacaoAnterior(acomodacao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        #endregion // Finaliza uma Regiao

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
        private void frmAcomodacaoAnterior_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Insere();
            CarregarGrid();
            this.Close();
        }
    }
}