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
    public partial class frmCadastroMedicamentos : Form
    {
        public frmCadastroMedicamentos()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                MedicamentosColecao Medcolecao = new MedicamentosColecao();
                NegociosValorMedicamento Nvmedicamentos = new NegociosValorMedicamento();

                Medcolecao = Nvmedicamentos.ConsultaCustoMedicamentoNome(txtBuscaNome.Text);
                dgvCadMed.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvCadMed.DataSource = Medcolecao;
                dgvCadMed.Update();
                dgvCadMed.Refresh();
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
                dgvCadMed.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvCadMed.DataSource = Medcolecao;
                dgvCadMed.Update();
                dgvCadMed.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Inserir()
        {
            try
            {

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtValor.ReadOnly == false)
                {

                    Medicamentos medicamentos = new Medicamentos();
                    NegociosValorMedicamento Nvmedicamentos = new NegociosValorMedicamento();

                    medicamentos.IdMedicamento = Convert.ToInt64(txtCodigo.Text);
                    medicamentos.NomeMedicamento = txtNome.Text;
                    medicamentos.ValorMedicamento = Convert.ToDecimal(txtValor.Text);
                    dgvCadMed.DataSource = Nvmedicamentos.InsereCustoMedicamento(medicamentos);
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
            try
            {

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtValor.ReadOnly == false)
                {

                    Medicamentos medicamentos = new Medicamentos();
                    NegociosValorMedicamento Nvmedicamentos = new NegociosValorMedicamento();

                    medicamentos.IdMedicamento = Convert.ToInt64(txtCodigo.Text);
                    medicamentos.NomeMedicamento = txtNome.Text;
                    medicamentos.ValorMedicamento = Convert.ToDecimal(txtValor.Text);
                    dgvCadMed.DataSource = Nvmedicamentos.AlteraCustoMedicamento(medicamentos);
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

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtValor.ReadOnly == false)
                {

                    Medicamentos medicamentos = new Medicamentos();
                    NegociosValorMedicamento Nvmedicamentos = new NegociosValorMedicamento();

                    medicamentos.IdMedicamento = Convert.ToInt64(txtCodigo.Text);
                    dgvCadMed.DataSource = Nvmedicamentos.ExcluiCustoMedicamento(medicamentos);
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

        private void Limpa_Campos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
        }

        private void Trava_Campos()
        {
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtValor.ReadOnly = true;
        }

        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtValor.ReadOnly = false;
        }

        #endregion

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro For, que tem os locais Registrados.
        private void CarregarGridVer() // Carrega e Consulta por Nome.
        {
            try
            {
                AmarraExclusaoMedicamentosColecao Medcolecao = new AmarraExclusaoMedicamentosColecao();
                NegociosAmarracaoMedicamentos Amarra = new NegociosAmarracaoMedicamentos();

                Medcolecao = Amarra.ConsultaNome (txtBuscaNomeVer.Text);
                dgvAmarra.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAmarra.DataSource = Medcolecao;
                dgvAmarra.Update();
                dgvAmarra.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        //==================================================================================

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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtCodigo.Focus();
            Destrava_Campos();
            txtCodigo.Focus();
        }

        private void frmCadastroMedicamentos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGridVer();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void dgvCadMed_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCast.Text = String.Format("{0:N}", dgvCadMed.CurrentRow.Cells[2].Value);
            txtValor.Text = txtCast.Text;
            DataGridViewRow row = this.dgvCadMed.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtCast.Text  = row.Cells[2].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            txtBuscaNomeVer.Text = txtBuscaNome.Text;
            Destrava_Campos();
            if (txtBuscaNome.Text == String.Empty)
            {
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
            }
            else
            {
                CarregarGrid();
                CarregarGridVer();

                if (dgvCadMed.Rows.Count == 0)
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
            ConsultaId();
            if (dgvCadMed.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ConsultaId();
                //=====================================
                txtBuscaNome.Text = txtNome.Text;
                //=====================================
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
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Medicamento, clicar Prieiramente no Botão (Novo Medicamento)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }
            if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || txtValor.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de Novo Medicamento é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtCodigo.Focus();
                return;
            }
            if (txtCodigo.ReadOnly != true)
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
            if (txtCodigo.ReadOnly == true)
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
            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de Excluir escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                return;
            }

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste Medicamento) ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                Trava_Campos();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                return;
            }

            CarregarGridVer();
            CarregarGrid();

            if (dgvAmarra.RowCount == 0)
            {
                Deletar();
                Trava_Campos();
                txtBuscaId.Text = String.Empty;
                MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
            }
            else
            {
                MessageBox.Show("Não é Possivel Excluir Este Medicamento, por motivo de que existe Paciente(s) vinculado ao Medicamento que vc está tentando excluir.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtBuscaNome.Focus();
                return;
            }
        }
    }
}