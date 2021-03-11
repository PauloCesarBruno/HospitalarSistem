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
    public partial class frmAcomodacao : Form
    {
        public frmAcomodacao(Int64 Cod, String Nome, DateTime internacao, DateTime Cdia, Int32 Dinternados)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(Cod);
            txtNome.Text = Nome;
            txtInternacao.Text = Convert.ToString(internacao);
            txtControlaDia.Text = Convert.ToString(Cdia);
            txtDiasInternados.Text = Convert.ToString(Dinternados);
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {

            AcomodacaoColecao Acolecao = new AcomodacaoColecao();
            NegociosAcomodacao Nacomod = new NegociosAcomodacao();

            Acolecao = Nacomod.ConsultaAcomodacaoNome(txtBuscaNome.Text);
            dgvAcomodacao.DataSource = null;
            dgvAcomodacao.DataSource = Acolecao;
            dgvAcomodacao.Update();
            dgvAcomodacao.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2
        }

        private void Insere()
        {
            try
            {
                Acomodacao acomodacao = new Acomodacao();
                NegociosAcomodacao NAcomodacao = new NegociosAcomodacao();
                acomodacao.IdPaciente = Convert.ToInt64(txtCodigo.Text);
                acomodacao.NomePaciente = txtNome.Text;
                acomodacao.Data = Convert.ToDateTime(txtInternacao.Text);
                acomodacao.diasAcomodado = Convert.ToInt32(txtDiasInternados.Text);
                acomodacao.IdDiaria = Convert.ToInt32(txtAcomodacao.Text);
                dgvAcomodacao.DataSource = NAcomodacao.Insere_Acomodacao(acomodacao);
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
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            lblAcomodacao.Visible = true;
            txtAcomodacao.Visible = true;
            btnAcomodacoes.Visible = true;
            btnInsere.Visible = true;
            txtAcomodacao.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmAcomodacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
             // Tratamento Repetição de Acomodacao //
                //=================================================================
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select IdPaciente From tblAcomodacao Where IdPaciente = @IdPaciente", conn);
                cmd.Parameters.AddWithValue("@IdPaciente", txtCodigo.Text);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("Desculpe-me, não posso efetuar este Registro, O(A) Paciente já se encontra acomodado. Para Mudar o(a) Paciênte, Você terá que Clicar no Botão (MUDAR ACOMODAÇÃO)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    //frmConsultaAcomodacao consultaacomodacao = new frmConsultaAcomodacao(null);
                    //consultaacomodacao.ShowDialog();
                   
                    return;
                }
            if (txtAcomodacao.Text == String.Empty)
            {
                MessageBox.Show("É Necessário Preencher o campo Acomodação.", "SISTEMA HOSPITALAE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAcomodacao.Focus();
                return;
            }
            Insere();
            txtAcomodacao.Text = String.Empty;
            this.Close();
        }
            
        private void frmAcomodacao_Load(object sender, EventArgs e)
        {
            btnConfirmar.Focus();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void txtAcomodacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtAcomodacao.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Campo Numérico, digitar somente numeros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAcomodacao.Focus();
            }
        }

        private void btnAcomodacoes_Click(object sender, EventArgs e)
        {
            frmConsultaLocalAcomodacao cla = new frmConsultaLocalAcomodacao();
            cla.ShowDialog();
            if (cla.codigo.ToString() != null)
            {
                txtAcomodacao.Text = cla.codigo.ToString();
            }
        }
    }
}