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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                MedicosColecao Mcolecao = new MedicosColecao();
                NegociosMedicos Nmedicos = new NegociosMedicos();

                Mcolecao = Nmedicos.ConsultaMedicoPorNome(txtBuscaNome.Text);
                dgvMedicos.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvMedicos.DataSource = Mcolecao;
                dgvMedicos.Update();
                dgvMedicos.Refresh();
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
                MedicosColecao Mcolecao = new MedicosColecao();
                NegociosMedicos Nmedicos = new NegociosMedicos();

                Mcolecao = Nmedicos.ConsultaMedicoPorId(Convert.ToInt32(txtBuscaId.Text));
                dgvMedicos.DataSource = null;
                dgvMedicos.DataSource = Mcolecao;
                dgvMedicos.Update();
                dgvMedicos.Refresh();
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

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtEndereco.ReadOnly == false && txtCrm.ReadOnly == false && txtCpf.ReadOnly == false && txtRg.ReadOnly == false && txtEspecialidade.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false && txtEmail.ReadOnly == false)
                {

                    Medicos medicos = new Medicos();
                    NegociosMedicos Nmedicos = new NegociosMedicos();

                    medicos.IdMedico = Convert.ToInt32(txtCodigo.Text);
                    medicos.Nome = txtNome.Text;
                    medicos.Endereco = txtEndereco.Text;
                    medicos.CRM = txtCrm.Text;
                    medicos.CPF = txtCpf.Text;
                    medicos.RG = txtRg.Text;
                    medicos.Especialidade = txtEspecialidade.Text;
                    medicos.Telefone = txtTelefone.Text;
                    medicos.Celular = txtCelular.Text;
                    medicos.Email = txtEmail.Text;
                    dgvMedicos.DataSource = Nmedicos.Insere_Medico(medicos);
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

                if (txtCodigo.ReadOnly == false && txtNome.ReadOnly == false && txtEndereco.ReadOnly == false && txtCrm.ReadOnly == false && txtCpf.ReadOnly == false && txtRg.ReadOnly == false && txtEspecialidade.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false && txtEmail.ReadOnly == false)
                {

                    Medicos medicos = new Medicos();
                    NegociosMedicos Nmedicos = new NegociosMedicos();

                    medicos.IdMedico = Convert.ToInt32(txtCodigo.Text);
                    medicos.Nome = txtNome.Text;
                    medicos.Endereco = txtEndereco.Text;
                    medicos.CRM = txtCrm.Text;
                    medicos.CPF = txtCpf.Text;
                    medicos.RG = txtRg.Text;
                    medicos.Especialidade = txtEspecialidade.Text;
                    medicos.Telefone = txtTelefone.Text;
                    medicos.Celular = txtCelular.Text;
                    medicos.Email = txtEmail.Text;
                    dgvMedicos.DataSource = Nmedicos.Altera_Medico(medicos);
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
                Medicos medicos = new Medicos();
                NegociosMedicos Nmedicos = new NegociosMedicos();

                medicos.IdMedico = Convert.ToInt32(txtCodigo.Text);
                dgvMedicos.DataSource = Nmedicos.Exclui_Medico(medicos);
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
            txtEndereco.Text = String.Empty;
            txtCrm.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtRg.Text = String.Empty;
            txtEspecialidade.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
        }

        private void Trava_Campos()
        {
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtCrm.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtRg.ReadOnly = true;
            txtEspecialidade.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        private void Destrava_Campos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtCrm.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtRg.ReadOnly = false;
            txtEspecialidade.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }


        #endregion

        // Este Metodo serve para comparação entre os DGV´s para permitir ou não exclusão
        // Este Metodo Pertence a outro For, que tem os locais Registrados.
        private void CarregarGridVer() // Carrega e Consulta por Nome.
        {
            try
            {
                AmarraExclusaoMedicoColecao Procolecao = new AmarraExclusaoMedicoColecao();
                NegociosAmarracaoMedicos Amarra = new NegociosAmarracaoMedicos();

                Procolecao = Amarra.Consulta(txtBuscaNomeVer.Text);
                dgvAmarra.DataSource = null; // dgv Escondido Atras do Picturebox
                dgvAmarra.DataSource = Procolecao;
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
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGridVer();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void frmMedicos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgvMedicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvMedicos.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtEndereco.Text = row.Cells[2].Value.ToString();
            txtCrm.Text = row.Cells[3].Value.ToString();
            txtCpf.Text = row.Cells[4].Value.ToString();
            txtRg.Text = row.Cells[5].Value.ToString();
            txtEspecialidade.Text = row.Cells[6].Value.ToString();
            txtTelefone.Text = row.Cells[7].Value.ToString();
            txtCelular.Text = row.Cells[8].Value.ToString();
            txtEmail.Text = row.Cells[9].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtCodigo.Focus();
            Destrava_Campos();
            txtCodigo.Focus();
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

                if (dgvMedicos.Rows.Count == 0)
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
            //=====================================
            txtBuscaNome.Text = txtNome.Text;
            //=====================================
            if (dgvMedicos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Limpar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            #region Tratamento

            // Tratamento Repetição do CRM, do CPF e do RG. //
            //=====================================================================================================================================================================//
            Conect conect = new Conect();
            SqlConnection conn = new SqlConnection(conect.sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CRM  From tblMedico Where CRM = @CRM", conn);
            cmd.Parameters.AddWithValue("@CRM", txtCrm.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.R.M., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader.Close();
                return;
            }
            reader.Close();
            SqlCommand cmd1 = new SqlCommand("Select CPF  From tblMedico Where CPF = @CPF", conn);
            cmd1.Parameters.AddWithValue("@CPF", txtCpf.Text);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este C.P.F., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader1.Close();
                return;
            }
            reader.Close();
            reader1.Close();
            SqlCommand cmd2 = new SqlCommand("Select RG  From tblMedico Where RG = @RG", conn);
            cmd2.Parameters.AddWithValue("@RG", txtRg.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                MessageBox.Show("Desculpe-me, não posso cadastrar este R.G., pois ele já existe...Favor Verificar", "ATENÇÃO !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarGrid();
                Limpa_Campos();
                Trava_Campos();
                txtBuscaNome.Focus();
                reader.Close();
                reader1.Close();
                reader2.Close();
                return;
            }
            // FIM DO Tratamento Repetição//
            //=====================================================================================================================================================================//

            #endregion

            if (txtCodigo.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um(a) Novo(a) Médico(a), clicar Prieiramente no Botão (Novo Médico(a))", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }
            if (txtCodigo.Text == String.Empty || txtNome.Text == String.Empty || txtEndereco.Text == String.Empty || txtCrm.Text == String.Empty || txtCpf.Text == String.Empty || txtRg.Text == String.Empty || txtEspecialidade.Text == String.Empty || txtTelefone.Text == String.Empty || txtCelular.Text == String.Empty || txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Para Inserção de novo(a) Médico(a) é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            DialogResult perg = MessageBox.Show("Deseja Relamente Excluir o Registro deste(a) Médico(a) ?", "SISTEMA HOSPITALAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Não é Possivel Excluir Este(a) Médico(a), por motivo de que existe Paciente(s) vinculado ao Médico(a) que vc está tentando excluir.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtBuscaNome.Focus();
                return;
            }
        }
    }
}
