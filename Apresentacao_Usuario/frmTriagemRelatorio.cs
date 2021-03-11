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
    public partial class frmTriagemRelatorio : Form
    {
        public frmTriagemRelatorio(String nome)
        {
            InitializeComponent();
            txtNomePaciente.Text = Convert.ToString(nome);
        }

        private void frmTriagemRelatorio_Load(object sender, EventArgs e)
        {           
           //
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.tblTriagem_ProvisoriaTableAdapter.Fill(this.HospitalDataSet.tblTriagem_Provisoria, txtNomePaciente.Text);
            this.reportFichaPaciente.RefreshReport();
        }

        private void frmTriagemRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
