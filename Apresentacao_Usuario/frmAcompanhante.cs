using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objeto_de_Transferencia;
using Regras_de_Negocios;
using Conexao_SQLServer;
using System.Data.SqlClient;


namespace Apresentacao_Usuario
{
    public partial class frmAcompanhante : Form
    {
        public frmAcompanhante()
        {
            InitializeComponent();
        }

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {
                AcompanhanteColecao Acolecao = new AcompanhanteColecao();
                NegociosAcompanhante Nacompanhante = new NegociosAcompanhante();

                Acolecao = Nacompanhante.ConsultaAcompanhanteNome(txtBuscaNome.Text);
                dgvAcompanhante.DataSource = null;
                dgvAcompanhante.DataSource = Acolecao;
                dgvAcompanhante.Update();
                dgvAcompanhante.Refresh();
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

                if (txtCodAcomp.ReadOnly == false && txtNome.ReadOnly == false && txtEndereco.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false)
                {
                    NegociosAcompanhante Nacompanhante = new NegociosAcompanhante();
                    Acompanhante acompanhante = new Acompanhante();

                    acompanhante.IdAcompanhante  = Convert.ToInt32(txtCodAcomp.Text);
                    acompanhante.Nome  = txtNome.Text;
                    acompanhante.Endereco = txtEndereco.Text;
                    acompanhante.Telefone = txtTelefone.Text;
                    acompanhante.Celular = txtCelular.Text;
                    acompanhante.Email = txtEmail.Text;
                    dgvAcompanhante.DataSource = Nacompanhante.Insere_Acompanhante (acompanhante);

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

                if (txtCodAcomp.ReadOnly == false && txtNome.ReadOnly == false && txtEndereco.ReadOnly == false && txtTelefone.ReadOnly == false && txtCelular.ReadOnly == false)
                {
                    NegociosAcompanhante Nacompanhante = new NegociosAcompanhante();
                    Acompanhante acompanhante = new Acompanhante();

                    acompanhante.IdAcompanhante = Convert.ToInt32(txtCodAcomp.Text);
                    acompanhante.Nome = txtNome.Text;
                    acompanhante.Endereco = txtEndereco.Text;
                    acompanhante.Telefone = txtTelefone.Text;
                    acompanhante.Celular = txtCelular.Text;
                    acompanhante.Email = txtEmail.Text;
                    dgvAcompanhante.DataSource = Nacompanhante.Altera_Acompanhante(acompanhante);
                }
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
                AcompanhanteColecao Acolecao = new AcompanhanteColecao();
                NegociosAcompanhante Nacompanhante = new NegociosAcompanhante();

                Acolecao = Nacompanhante.ConsultaAcompanhanteId(Convert.ToInt32(txtBuscaId.Text));
                dgvAcompanhante.DataSource = null;
                dgvAcompanhante.DataSource = Acolecao;
                dgvAcompanhante.Update();
                dgvAcompanhante.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void Trava_Campos()
        {
            txtCodAcomp.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtBuscaNome.Focus();
        }

        private void Destrava_Campos()
        {
            txtCodAcomp.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtEmail.ReadOnly = false;          
        }

        private void Limpa_Campos()
        {
            txtCodAcomp.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAcompanhante_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvAcompanhante_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAcompanhante.Rows[e.RowIndex];
            txtCodAcomp.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtEndereco.Text = row.Cells[2].Value.ToString();
            txtTelefone.Text = row.Cells[3].Value.ToString();
            txtCelular.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
        }

        private void frmAcompanhante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            Destrava_Campos();
            if (txtBuscaNome.Text == String.Empty)
            {
                Trava_Campos();
            }
            CarregarGrid();
            if (dgvAcompanhante.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado Com o Nome Informado !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos();
            txtBuscaNome.Focus();
            Destrava_Campos();
            txtCodAcomp.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtCodAcomp.ReadOnly == true)
            {
                MessageBox.Show("Para Adicionar um Novo Acompanhante, clicar Primeiramente no Botão (Novo Acompanhante)", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                return;
            }

            if (txtCodAcomp.Text == String.Empty || txtNome.Text == String.Empty || txtEndereco.Text == String.Empty || txtTelefone.Text == String.Empty || txtCelular.Text == String.Empty || txtEmail .Text == String .Empty)
            {
                MessageBox.Show("Para Inserção de novo Acompanhante é Necessário Preencher todos os campos.", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpa_Campos();
                txtCodAcomp.Focus();
                return;
            }
            if (txtCodAcomp.ReadOnly != true)
            Inserir();
            {
                MessageBox.Show("Registro Inserido com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarGrid();
            Trava_Campos();
            txtBuscaNome.Focus();
            //Linha de código abaixo, serve para rolagem automática do Scrool do DataGridView.
            dgvAcompanhante.FirstDisplayedScrollingRowIndex = dgvAcompanhante.RowCount - 1;           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodAcomp.ReadOnly == true)
            {
                MessageBox.Show("É necessario antes de alterar escolher um registro pelas Caixas de Busca", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscaNome.Focus();
                return;
            }
            Alterar();
            Limpa_Campos();
            txtBuscaId.Text = String.Empty;
            txtBuscaNome.Text = String.Empty;
            CarregarGrid();
            Trava_Campos();
            txtBuscaNome.Focus();
            MessageBox.Show("Registro Alterado com Êxito !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            txtBuscaNome.Text = String.Empty;
            txtBuscaId.Text = String.Empty;
            Trava_Campos();
            CarregarGrid();
            txtBuscaNome.Focus();
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
            if (dgvAcompanhante.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro encontrado para o código informado, Clique no botão (Atualizar) para recarregar os dados !!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpa_Campos();
                txtBuscaNome.Text = String.Empty;
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmPacienteEntrada vai = new frmPacienteEntrada(Convert.ToInt32(txtCodAcomp.Text));
            vai.Show();
            this.Close();
        }
    }
}
