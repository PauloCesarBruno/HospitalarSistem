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
    public partial class frmFormularioCusos : Form
    {
        public frmFormularioCusos()
        {
            InitializeComponent();
        }

        private void frmFormularioCusos_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {                    
            this.CustosdeUsoTableAdapter.Fill(this.HospitalDataSet.CustosdeUso, txtNomePaciente.Text);

            this.reporCustosdeUso.RefreshReport();
        }

        private void frmFormularioCusos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
