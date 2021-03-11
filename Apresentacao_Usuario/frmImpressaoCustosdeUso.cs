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
    public partial class frmImpressaoCustosdeUso : Form
    {
        public frmImpressaoCustosdeUso()
        {
            InitializeComponent();
        }

        private void frmImpressaoCustosdeUso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'HospitalDataSet.CustosdeUso'. Você pode movê-la ou removê-la conforme necessário.
            this.CustosdeUsoTableAdapter.Fill(this.HospitalDataSet.CustosdeUso);

            this.reportCustosdeUso.RefreshReport();
        }
    }
}
