﻿using System;
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
    public partial class frmAlmoxarifadoFarmaciaRelatorio : Form
    {
        public frmAlmoxarifadoFarmaciaRelatorio()
        {
            InitializeComponent();
        }

        private void frmAlmoxarifadoFarmaciaRelatorio_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.tblAlmoxarifadoFarmaciaTableAdapter.Fill(this.HospitalDataSet.tblAlmoxarifadoFarmacia, txtAlmoxarifadoFarmacia.Text);
            this.reportAlmoxarifadoFarmacia.RefreshReport();
        }

        private void frmAlmoxarifadoFarmaciaRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}