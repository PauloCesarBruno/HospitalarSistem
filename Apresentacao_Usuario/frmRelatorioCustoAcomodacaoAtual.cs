using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_Usuario
{
    public partial class frmRelatorioCustoAcomodacaoAtual : Form
    {
        public frmRelatorioCustoAcomodacaoAtual()
        {
            InitializeComponent();
        }

        private void frmRelatorioCustoAcomodacaoAtual_Load(object sender, EventArgs e)
        {         
           //
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.CustoAcomodacaoTableAdapter.Fill(this.HospitalDataSet.CustoAcomodacao, Convert.ToInt64 (txtCodigoPaciente .Text));
            this.reportCustoAcomodacao.RefreshReport();
        }
    }
}
