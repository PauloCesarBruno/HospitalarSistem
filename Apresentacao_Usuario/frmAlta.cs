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
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
            dgvAlta.AutoGenerateColumns = false;
            dgvAmarra.AutoGenerateColumns = false; // Dgv de amarração Médicos
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pcolecao = Npentrada.ConsultaPacientePorNome(txtBuscaNome.Text);
                dgvAlta.DataSource = null;
                dgvAlta.DataSource = Pcolecao;
                dgvAlta.Update();
                dgvAlta.Refresh();
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

                PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pcolecao = Npentrada.ConsultaPacientePorId(Convert.ToInt64(txtBuscaId.Text));
                dgvAlta.DataSource = null;
                dgvAlta.DataSource = Pcolecao;
                dgvAlta.Update();
                dgvAlta.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
       
        private void excluir()
        {
            try
            {

                PacienteEntrada Pentrada = new PacienteEntrada();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pentrada.IdPaciente = Convert.ToInt64(txtCodigo.Text);
                dgvAlta.DataSource = Npentrada.Excluir_Pacientes(Pentrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        #endregion

        #region Metodos de Amarracao

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro Form, que tem os locais Registrados.
        private void CarregarGridVer() // Carrega e Consulta por Nome.
        {
            try
            {
                AmarraExclusaoPacienteColecao Medcolecao = new AmarraExclusaoPacienteColecao();
                NegociosAmarraPaciente Amarra = new NegociosAmarraPaciente();

                Medcolecao = Amarra.ConsultaNome(txtBuscaNomeVer.Text);
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

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro Form, que tem os locais Registrados.
        private void ConsultaId2()
        {
            try
            {

                PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pcolecao = Npentrada.ConsultaPacientePorId(Convert.ToInt64(txtBuscaIdVer.Text));
                dgvAmarra.DataSource = null;
                dgvAmarra.DataSource = Pcolecao;
                dgvAmarra.Update();
                dgvAmarra.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        //==================================================================================

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro Form, que tem os locais Registrados.
        private void CarregarGridVerProntuario() // Carrega e Consulta por Nome.
        {
            try
            {
                AmarraProntuarioColecao Predcolecao = new AmarraProntuarioColecao();
                NegociosAmarraProntuario Amarra = new NegociosAmarraProntuario();

                Predcolecao = Amarra.ConsultaNome (txtBuscaProntuario .Text);
                dgvAmarraProntuario.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAmarraProntuario.DataSource = Predcolecao;
                dgvAmarraProntuario.Update();
                dgvAmarraProntuario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        //==================================================================================

        private void ConsultaId3()
        {
            try
            {

                AmarraProntuarioColecao Pcolecao = new AmarraProntuarioColecao();
                NegociosAmarraProntuario Npentrada = new NegociosAmarraProntuario();

                Pcolecao = Npentrada.ConsultaId (Convert.ToInt64 (txtBuscaIdProntuario.Text));
                dgvAmarraProntuario.DataSource = null;
                dgvAmarraProntuario.DataSource = Pcolecao;
                dgvAmarraProntuario.Update();
                dgvAmarraProntuario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
      
        //==================================================================================

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro Form, que tem os locais Registrados.
        private void CarregarGridCustos() // Carrega e Consulta por Nome.
        {
            try
            {

                CustosColecao Ccolecao = new CustosColecao();
                NegociosCustos Ncustos = new NegociosCustos();

                Ccolecao = Ncustos.ConsultaCustosNome(txtBuscaCustos.Text);
                dgvAmarraCustos.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAmarraCustos.DataSource = Ccolecao;
                dgvAmarraCustos.Update();
                dgvAmarraCustos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        //==================================================================================

        private void ConsultaId4()
        {
            try
            {

                CustosColecao Ccolecao = new CustosColecao();
                NegociosCustos Ncustos = new NegociosCustos();

                Ccolecao = Ncustos.ConsultaCustosId (Convert.ToInt64 (txtBuscaIdCustos.Text));
                dgvAmarraCustos.DataSource = null;
                dgvAmarraCustos.DataSource = Ccolecao;
                dgvAmarraCustos.Update();
                dgvAmarraCustos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro Form, que tem os locais Registrados.
        private void CarregarGridAcomodacao() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacoesColecao Acolecao = new AcomodacoesColecao();
                NegociosAcomodacoes NAcomodacoes = new NegociosAcomodacoes();

                Acolecao = NAcomodacoes.ConsultaNomePaciente (txtBuscaAcomodacao .Text);
                dgvAmarraAcomodacao.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAmarraAcomodacao.DataSource = Acolecao;
                dgvAmarraAcomodacao.Update();
                dgvAmarraAcomodacao.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        //==================================================================================
        private void ConsultaId5() 
        {
            try
            {

                AcomodacoesColecao Acolecao = new AcomodacoesColecao();
                NegociosAcomodacoes NAcomodacoes = new NegociosAcomodacoes();

                Acolecao = NAcomodacoes.ConsultaNomePacienteID (Convert.ToInt64(txtBuscaIdAcomodacao.Text));
                dgvAmarraAcomodacao.DataSource = null; 
                dgvAmarraAcomodacao.DataSource = Acolecao;
                dgvAmarraAcomodacao.Update();
                dgvAmarraAcomodacao.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        private void CarregarGridAcomodacaoAnterior() // Carrega e Consulta por Nome.
        {
            try
            {

                AcomodacaoAnteriorColecao Acolecao = new AcomodacaoAnteriorColecao();
                NegociosAcomodacaoAnterior Nacomodacao = new NegociosAcomodacaoAnterior();

                Acolecao = Nacomodacao.ConsultaAcomodacaoAnteriorNome(txtBuscaNomeAcomodAnterior.Text);
                dgvAcomodacaoAnterior.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAcomodacaoAnterior.DataSource = Acolecao;
                dgvAcomodacaoAnterior.Update();
                dgvAcomodacaoAnterior.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        //==================================================================================
        private void ConsultaId6() 
        {
            try
            {

                AcomodacaoAnteriorColecao Acolecao = new AcomodacaoAnteriorColecao();
                NegociosAcomodacaoAnterior Nacomodacao = new NegociosAcomodacaoAnterior();

                Acolecao = Nacomodacao.ConsultaAcomodacaoAnteriorId(Convert.ToInt64 (txtBuscaAcoAnteriorId.Text));
                dgvAcomodacaoAnterior.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAcomodacaoAnterior.DataSource = Acolecao;
                dgvAcomodacaoAnterior.Update();
                dgvAcomodacaoAnterior.Refresh();
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
        private void frmAlta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGridVer();
            CarregarGridVerProntuario();
            CarregarGridCustos();
            CarregarGridAcomodacao();
            CarregarGridAcomodacaoAnterior();
            //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
            dgvAlta.FirstDisplayedScrollingRowIndex = dgvAlta.RowCount - 1;
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste(a) Paciente ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (perg != DialogResult.Yes)
            {
                CarregarGrid();
                CarregarGridVer();
                CarregarGridVerProntuario();
                CarregarGridCustos();
                CarregarGridAcomodacao();
                CarregarGridAcomodacaoAnterior();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                txtBuscaIdVer.Text = String.Empty;
                txtCodigo.Text = String.Empty;
                txtBuscaNome.Focus();
                return;
            }

            if (dgvAmarra.CurrentRow.Cells[2].Value.ToString() == "1" && dgvAmarraProntuario.RowCount == 0 && dgvAmarraCustos.RowCount == 0 && dgvAmarraAcomodacao.RowCount == 0 && dgvAcomodacaoAnterior.RowCount == 0)
            {
                excluir();
                txtBuscaId.Text = String.Empty;
                MessageBox.Show("Registro Excluido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
            }
            else 
            {
                MessageBox.Show("Não é Possivel Excluir Este Paciente, por motivo de que existem Vínculos com este Paciente, Antes de excluir, elimine todos os vínculos; É Provavel Que Os Vínculos sejam os Seguintes: (Viculo com Médico / Vínculo de Prontuário Aberto / Vínculo de Custos / Vínculo de Acomodação Atual / Vínculo de Acomodações Anteriores). Para eliminar os vínculos Imprima o Relatório de Custos, após exclua Custos, imprima o Relatório de Acomodação Atual, após exclua Acomodação Atual, imprima o Relatório de Acomodações Anteriores, depois exclua Acomodação Anteriores, imprima o Relatório de Prontuário depois exclua o Prontuário, retire o vínculo de médico(a) indo no Formulário (Designação Paciente) e altere o campo Médico para (1), Feita a eliminação de todos vínculos volte a exclusão.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                CarregarGridVer();
                CarregarGridVerProntuario();
                CarregarGridCustos();
                CarregarGridAcomodacao();
                CarregarGridAcomodacaoAnterior();
                txtBuscaNome.Text = String.Empty;
                txtBuscaId.Text = String.Empty;
                txtBuscaIdVer.Text = String.Empty;
                txtCodigo.Text = String.Empty;
                txtBuscaNome.Focus();
                           
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {           
            txtBuscaNomeVer.Text = txtBuscaNome.Text;
            txtBuscaProntuario.Text = txtBuscaNome.Text;
            txtBuscaCustos.Text = txtBuscaNome.Text;
            txtBuscaAcomodacao.Text = txtBuscaNome.Text;
            txtBuscaNomeAcomodAnterior.Text = txtBuscaNome.Text;
            CarregarGrid();
            CarregarGridVer();
            CarregarGridVerProntuario();
            CarregarGridCustos();
            CarregarGridAcomodacao();
            CarregarGridAcomodacaoAnterior();
        
            if (txtBuscaId.Text.ToString ().Length >= 8 || txtBuscaNome.Text.ToString ().Length >= 8)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
            if (dgvAlta.Rows.Count == 0 || txtBuscaNome.Text == " ")
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Text = String.Empty;
                txtBuscaNome.Focus();
            }
        }

        private void btnBuscaId_Click(object sender, EventArgs e)
        {
            txtBuscaIdVer.Text = txtBuscaId.Text;
            txtBuscaIdProntuario.Text = txtBuscaId.Text;
            txtBuscaIdCustos.Text = txtBuscaId.Text;
            txtBuscaIdAcomodacao.Text = txtBuscaId.Text;
            txtBuscaAcoAnteriorId.Text = txtBuscaId.Text;
            if (txtBuscaId.Text == String.Empty)
            {
                MessageBox.Show("Nehum Código Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuscaId.Focus();
                return;
            }
            ConsultaId();
            ConsultaId2();
            ConsultaId3();
            ConsultaId4();
            ConsultaId5();
            ConsultaId6();
            if (dgvAlta.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBuscaId.Text = String.Empty;
                txtBuscaNome.Focus();
            }
            else

                ConsultaId();
                ConsultaId2();
                ConsultaId3();
                ConsultaId4();
                ConsultaId5();
                ConsultaId6();
        }
        
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGridVer();
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            txtBuscaIdVer.Text = String.Empty;
            txtCodigo.Text = String.Empty;
            txtBuscaNome.Focus();
        }

        private void frmAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtBuscaId_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaId.Text != String.Empty || txtBuscaNome.Text != String.Empty)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        private void txtBuscaNomeVer_TextChanged(object sender, EventArgs e)
        {
            txtBuscaNomeVer.Text = txtBuscaNome.Text;
        }

        private void dgvAlta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAlta.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
