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
    public partial class frmMedicamentosRelatorio : Form
    {
        public frmMedicamentosRelatorio()
        {
            InitializeComponent();
        }

        private void frmMedicamentosRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hospitalDataSet.tblCustoMedicamento'. Você pode movê-la ou removê-la conforme necessário.
         
            //this.tblCustoMedicamentoTableAdapter.Fill(this.HospitalDataSet.tblCustoMedicamento);
            //this.reportMedicamentos.RefreshReport();
        }

        private void reportMedicamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            this.tblCustoMedicamentoTableAdapter.Fill(this.HospitalDataSet.tblCustoMedicamento, Convert.ToInt64(txtCodigoMedicamento.Text));
            this.reportMedicamentos.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}