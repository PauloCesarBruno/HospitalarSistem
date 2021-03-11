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
    public partial class frmformularioCustos : Form
    {
        public frmformularioCustos()
        {
            InitializeComponent();
        }

        private void frmformularioCustos_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                this.RelatorioCustosTableAdapter.Fill(this.HospitalDataSet.RelatorioCustos, textBox1.Text);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception )
            {
                //
            }
        }

        private void frmformularioCustos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
