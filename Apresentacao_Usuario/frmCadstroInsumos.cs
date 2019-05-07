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
    public partial class frmCadstroInsumos : Form
    {
        public frmCadstroInsumos()
        {
            InitializeComponent();
           // dgvCadInsumo.AutoGenerateColumns = false;
        }

        private void CarregarGrid() // Carrega e Consulta por Nome.
        {
            try
            {

                CustoInsumoColecao Cicolecao = new CustoInsumoColecao();
                NegociosValorInsumo Ncinsumo = new NegociosValorInsumo();

                Cicolecao = Ncinsumo.ConsultaCustoInsumoNome (txtBuscaNome.Text);
                dgvCadInsumo.DataSource = null;
                dgvCadInsumo.DataSource = Cicolecao;
                dgvCadInsumo.Update();
                dgvCadInsumo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }

        private void frmCadstroInsumos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
