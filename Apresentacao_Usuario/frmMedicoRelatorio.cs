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
    public partial class frmMedicoRelatorio : Form
    {
        public frmMedicoRelatorio()
        {
            InitializeComponent();
        }

        private void frmMedicoRelatorio_Load(object sender, EventArgs e)
        {
            //            
        }

        private void frmMedicoRelatorio_KeyDown(object sender, KeyEventArgs e)
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.tblMedicoTableAdapter.Fill(this.HospitalDataSet.tblMedico, txtNomeMedico .Text);
            this.reportMedicos.RefreshReport();
        }
    }
}
