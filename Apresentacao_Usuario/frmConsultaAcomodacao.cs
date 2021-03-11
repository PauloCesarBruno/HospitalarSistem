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
    public partial class frmConsultaAcomodacao : Form
    {
        public frmConsultaAcomodacao()
        {
            InitializeComponent();
            dgvConsultaAcomodacao.AutoGenerateColumns = false;
        }

        #region Metodos

        private void LimpaCampos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtDataInternacao.Text = String.Empty;
            txtCodAcomod.Text = String.Empty;
            txtLocal.Text = String.Empty;
            txtDias.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtValorTotal.Text = String.Empty;
        }

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacaoColecao Acolecao = new AcomodacaoColecao();
                NegociosAcomodacao Nacomodacao = new NegociosAcomodacao();

                Acolecao = Nacomodacao.ConsultaAcomodacaoNome(txtBuscaNome.Text);
                dgvConsultaAcomodacao.DataSource = null;
                dgvConsultaAcomodacao.DataSource = Acolecao;
                dgvConsultaAcomodacao.Update();
                dgvConsultaAcomodacao.Refresh();
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

                AcomodacaoColecao Acolecao = new AcomodacaoColecao();
                NegociosAcomodacao Nacomodacao = new NegociosAcomodacao();

                Acolecao = Nacomodacao.ConsultaAcomodacaoId(Convert.ToInt64(txtBuscaId.Text));
                dgvConsultaAcomodacao.DataSource = null;
                dgvConsultaAcomodacao.DataSource = Acolecao;
                dgvConsultaAcomodacao.Update();
                dgvConsultaAcomodacao.Refresh();
            }
            catch (Exception)
            {
                //
            }
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
                acomodacao.IdDiaria = Convert.ToInt32(txtCodAcomod.Text);
                dgvConsultaAcomodacao.DataSource = NAcomodacao.Insere_Acomodacao(acomodacao);
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
                Acomodacao acomodacao = new Acomodacao();
                NegociosAcomodacao Nacomodacao = new NegociosAcomodacao();

                acomodacao.IdPaciente = Convert.ToInt64(txtCodigo.Text);
                dgvConsultaAcomodacao.DataSource = Nacomodacao.Deleta_Acomodacao(acomodacao);
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
            if (txtBuscaNome.Text != String.Empty)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
            if (txtBuscaNome.Text.ToString().Length >= 8)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
            if (txtBuscaNome.Text == "%" || txtBuscaNome.Text == " ")
            {
                dgvConsultaAcomodacao.DataSource = null;
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }
            try
            {
                CarregarGrid();
                if (dgvConsultaAcomodacao.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscaNome.Text = String.Empty;
                    txtBuscaNome.Focus();
                }
                // Rotina para calcular os dias Internados Automaticamente

                txtInternacao.Text = dgvConsultaAcomodacao.CurrentRow.Cells[2].Value.ToString();
                var cd = DateTime.Now;
                txtControlaDia.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays; // Ou TotalDays -1;
                txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
                dgvConsultaAcomodacao.CurrentRow.Cells[5].Value = txtDiasInternados.Text;
            }
            catch (Exception)
            {
                //
            }
            try
            {
                txtDias.Text = txtDiasInternados.Text;

                Int32 dias;
                Decimal Valor;
                Decimal Total;

                dias = Convert.ToInt32(txtDiasInternados.Text);
                Valor = Convert.ToDecimal(dgvConsultaAcomodacao.CurrentRow.Cells[6].Value);
                Total = dias * Valor;
                dgvConsultaAcomodacao.CurrentRow.Cells[7].Value = Total;

                txtValorTotal.Text = String.Format("{0:N}", dgvConsultaAcomodacao.CurrentRow.Cells[7].Value);
                if (txtBuscaNome.Text == String.Empty)
                {
                    LimpaCampos();
                    dgvConsultaAcomodacao.DataSource = null;
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void frmConsultaAcomodacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgvConsultaAcomodacao_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvConsultaAcomodacao.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtDataInternacao.Text = row.Cells[2].Value.ToString();
            txtCodAcomod.Text = row.Cells[3].Value.ToString();
            txtLocal.Text = row.Cells[4].Value.ToString();
            txtDias.Text = row.Cells[5].Value.ToString();
            txtValor.Text = row.Cells[6].Value.ToString();
            txtValorTotal.Text = row.Cells[7].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                picSeta.Visible = false;
                btnAlterar.Enabled = false;
                btnConfirmaAlteracao.Visible = true;
                lblInformacao.Visible = false;
                txtCodAcomod.ReadOnly = true;
                btnConfirmaAlteracao.Focus();
                frmAcomodacaoAnterior Anterior = new frmAcomodacaoAnterior(Convert.ToInt64(txtCodigo.Text), txtNome.Text, Convert.ToDateTime(txtDataInternacao.Text), Convert.ToInt32(txtCodAcomod.Text), txtLocal.Text, Convert.ToInt32(txtDias.Text), Convert.ToDecimal(txtValor.Text), Convert.ToDecimal(txtValorTotal.Text));
                Anterior.ShowDialog();
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você está Alterando um Paciente de uma Acomodação pra outra, não Esqueça de ir no formulario 'DESIGNAÇÃO PACIÊNTE' e designar Leito ou Quarto conforme Novo Local.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtInternacao.Text = DateTime.Now.ToString();
            var cd = DateTime.Now;
            txtControlaDia.Text = cd.ToShortDateString();
            var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
            var Resposta = cd.Subtract(cd2).TotalDays;
            txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
            txtDias.Text = txtDiasInternados.Text;
            Deletar();
            btnConfirmaAlteracao.Enabled = false;
            btnreinserir.Visible = true;
            txtCodAcomod.Text = String.Empty;
            txtCodAcomod.Focus();
        }

        private void btnreinserir_Click(object sender, EventArgs e)
        {
            Insere();
            CarregarGrid();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaAcomodacao_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void txtCodAcomod_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            if (txtBuscaId.Text != String.Empty)
            {
                btnAlterar.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
            }
            try
            {

                BuscaId();

                if (dgvConsultaAcomodacao.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro encontrado Com o Codigo Informado, ou nada foi digitado no Campo, Favor Verificar. !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscaId.Text = String.Empty;
                    btnAlterar.Enabled = false;
                    txtBuscaId.Focus();
                }

                // Rotina para calcular os dias Internados Automaticamente

                txtInternacao.Text = dgvConsultaAcomodacao.CurrentRow.Cells[2].Value.ToString();
                var cd = DateTime.Now;
                txtControlaDia.Text = cd.ToShortDateString();
                var cd2 = DateTime.Parse(txtInternacao.Text.ToString());
                var Resposta = cd.Subtract(cd2).TotalDays; // Ou TotalDays -1;
                txtDiasInternados.Text = Convert.ToInt32(Resposta).ToString();
                dgvConsultaAcomodacao.CurrentRow.Cells[5].Value = txtDiasInternados.Text;
            }
            catch (Exception)
            {
                //
            }
            try
            {
                txtDias.Text = txtDiasInternados.Text;

                Int32 dias;
                Decimal Valor;
                Decimal Total;

                dias = Convert.ToInt32(txtDiasInternados.Text);
                Valor = Convert.ToDecimal(dgvConsultaAcomodacao.CurrentRow.Cells[6].Value);
                Total = dias * Valor;
                dgvConsultaAcomodacao.CurrentRow.Cells[7].Value = Total;

                txtValorTotal.Text = String.Format("{0:N}", dgvConsultaAcomodacao.CurrentRow.Cells[7].Value);
                if (txtBuscaNome.Text == String.Empty)
                {
                    //
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvConsultaAcomodacao.DataSource = null;
            LimpaCampos();
            btnAlterar.Enabled = false;
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Focus();
        }

        private void btnConsultAcomodacao_Click(object sender, EventArgs e)
        {
            frmConsultaLocalAcomodacao cla = new frmConsultaLocalAcomodacao();
            cla.ShowDialog();
            if (cla.codigo.ToString() != null)
            {
                txtCodAcomod.Text = cla.codigo.ToString();
            }
        }
    }
}