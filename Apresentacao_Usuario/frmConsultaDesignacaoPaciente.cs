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

namespace Apresentacao_Usuario
{
    public partial class frmConsultaDesignacaoPaciente : Form
    {
        public frmConsultaDesignacaoPaciente()
        {
            InitializeComponent();
        }

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                PacienteEntradaColecao Pcolecao = new PacienteEntradaColecao();
                NegociosPacienteEntrada Npentrada = new NegociosPacienteEntrada();

                Pcolecao = Npentrada.ConsultaPacientePorNome(txtBuscaNome.Text);
                dgvManipulacao.DataSource = null;
                dgvManipulacao.DataSource = Pcolecao;
                dgvManipulacao.Update();
                dgvManipulacao.Refresh(); // Este DataGridWiew está Escondido atráz do PictureBox2
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void frmConsultaDesignacaoPaciente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

    }
}
