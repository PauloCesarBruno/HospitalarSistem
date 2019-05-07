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
    public partial class frmConsultaDesignacao : Form
    {
        public frmConsultaDesignacao()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                PacienteEntradaColecao Ppcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Nnpentrada = new NegociosPacienteEntrada();

                Ppcolecao = Nnpentrada.ConsultaPacientePorNome(txtBuscaNome.Text);
                dgvConsultaDesignacao.DataSource = null;
                dgvConsultaDesignacao.DataSource = Ppcolecao;
                dgvConsultaDesignacao.Update();
                dgvConsultaDesignacao.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2
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

                PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pcolecao = Npentrada.ConsultaPacientePorId(Convert.ToInt64(txtBuscaId.Text));
                dgvConsultaDesignacao.DataSource = null;
                dgvConsultaDesignacao.DataSource = Pcolecao;
                dgvConsultaDesignacao.Update();
                dgvConsultaDesignacao.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2
            }
            catch (Exception)
            {
                //
            }
        }
        private void Limpa_Campos()
        {
            txtInternacao.Text = String.Empty;
            txtMedico.Text = String.Empty;
            txtProcedimento.Text = String.Empty;
            txtDiaria.Text = String.Empty;
            txtInsumo.Text = String.Empty;
            txtMedicamento.Text = String.Empty;
            txtExame.Text = String.Empty;
            txtDiasInternados.Text = String.Empty;
            txtLeito.Text = String.Empty;
            txtQuarto.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
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
        private void frmConsultaDesignacao_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            txtBuscaNome.Focus();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void dgvConsultaDesignacao_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvConsultaDesignacao.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[7].Value.ToString();
            txtDataNascimento.Text = row.Cells[8].Value.ToString();
            txtSexo.Text = row.Cells[9].Value.ToString();
            maskedCPF.Text = row.Cells[10].Value.ToString();
            txtRg.Text = row.Cells[11].Value.ToString();
            txtEndereco.Text = row.Cells[12].Value.ToString();
            txtTelefone.Text = row.Cells[13].Value.ToString();
            txtCelular.Text = row.Cells[14].Value.ToString();
            txtPlano.Text = row.Cells[15].Value.ToString();
            txtCategoria.Text = row.Cells[16].Value.ToString();
            txtAcomp.Text = row.Cells[18].Value.ToString();
            txtRgAcomp.Text = row.Cells[19].Value.ToString();
            txtEndAcomp.Text = row.Cells[20].Value.ToString();
            txtTelAcomp.Text = row.Cells[21].Value.ToString();
            txtCelAcomp.Text = row.Cells[22].Value.ToString();
            txtEmailAcomp.Text = row.Cells[23].Value.ToString();
            txtMedico.Text = row.Cells[1].Value.ToString();
            txtProcedimento.Text = row.Cells[2].Value.ToString();
            txtDiaria.Text = row.Cells[3].Value.ToString();
            txtInsumo.Text = row.Cells[4].Value.ToString();
            txtMedicamento.Text = row.Cells[5].Value.ToString();
            txtExame.Text = row.Cells[6].Value.ToString();
            txtInternacao.Text = row.Cells[17].Value.ToString();
            txtDiasInternados.Text = row.Cells[24].Value.ToString();
            txtLeito.Text = row.Cells[25].Value.ToString();
            txtQuarto.Text = row.Cells[26].Value.ToString();
            txtAlta.Text = row.Cells[27].Value.ToString();
            txtObsAlta.Text = row.Cells[28].Value.ToString();
        }

        private void frmConsultaDesignacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();

                if (dgvConsultaDesignacao.Rows.Count == 0 || txtBuscaNome.Text == " ")
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaNome.Focus();
                }
                var cd = DateTime.Now;
                dgvConsultaDesignacao.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays;
                txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
                if (txtBuscaNome.Text != String.Empty)
                {
                    txtMedico.ReadOnly = false;
                    txtProcedimento.ReadOnly = false;
                    txtDiaria.ReadOnly = false;
                    txtLeito.ReadOnly = false;
                    txtQuarto.ReadOnly = false;
                    txtAlta.ReadOnly = false;
                    txtObsAlta.ReadOnly = false;

                }
                else
                {

                    txtMedico.ReadOnly = true;
                    txtProcedimento.ReadOnly = true;
                    txtDiaria.ReadOnly = true;
                    txtDiasInternados.ReadOnly = true;
                    txtLeito.ReadOnly = true;
                    txtQuarto.ReadOnly = true;
                    txtAlta.ReadOnly = true;
                    txtObsAlta.ReadOnly = true;


                }
                if (dgvConsultaDesignacao.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpa_Campos();

                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtBuscaNome.Focus();
            Limpa_Campos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaMedico_Click(object sender, EventArgs e)
        {
            frmConsultaMedicos cm = new frmConsultaMedicos();
            cm.ShowDialog();
        }

        private void butConsAcomod_Click(object sender, EventArgs e)
        {
            frmVerAcomodacao va = new frmVerAcomodacao(txtNome.Text, null);
            va.ShowDialog();
        }

        private void btnConsultaProcedimento_Click(object sender, EventArgs e)
        {
            frmConsulta_Procedimento cp = new frmConsulta_Procedimento();
            cp.ShowDialog();
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaId();

                if (dgvConsultaDesignacao.Rows.Count == 0 || txtBuscaId.Text == String.Empty)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Código Informado ou Campo não Preenchido !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaId.Text = String.Empty;
                    txtBuscaId.Focus();
                }

                var cd = DateTime.Now;
                dgvConsultaDesignacao.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays;
                txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
                if (txtBuscaId.Text != String.Empty)
                {
                    txtMedico.ReadOnly = false;
                    txtProcedimento.ReadOnly = false;
                    txtDiaria.ReadOnly = false;
                    txtLeito.ReadOnly = false;
                    txtQuarto.ReadOnly = false;
                    txtAlta.ReadOnly = false;
                    txtObsAlta.ReadOnly = false;
                }
                else
                {
                    txtMedico.ReadOnly = true;
                    txtProcedimento.ReadOnly = true;
                    txtDiaria.ReadOnly = true;
                    txtDiasInternados.ReadOnly = true;
                    txtLeito.ReadOnly = true;
                    txtQuarto.ReadOnly = true;
                    txtAlta.ReadOnly = true;
                    txtObsAlta.ReadOnly = true;
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
