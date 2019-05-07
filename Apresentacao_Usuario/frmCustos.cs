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
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmCustos : Form
    {

        public frmCustos(Int64 Cod, String Nome, String NomeResp)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(Cod);
            txtNome.Text = Nome;
            txtResponsavel.Text = NomeResp;
        }

        private void Insere()
        {
            try
            {
                Custos custos = new Custos();
                NegociosCustos Ncustos = new NegociosCustos();
                custos.IdPaciente = Convert.ToInt64(txtCodigo.Text);
                custos.NomePaciente = txtNome.Text;
                custos.Data = Convert.ToDateTime(txtData.Text);
                custos.Responsavel = txtResponsavel.Text;
                custos.IdInsumo = Convert.ToInt32(txtInsumo.Text);
                custos.IdMedicamento = Convert.ToInt32(txtMedicamento.Text);
                custos.IdExame = Convert.ToInt32(txtExame.Text);
                dgvCustos.DataSource = Ncustos.Insere_Custos(custos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO, Detalhe :" + ex.Message);
            }
        }
        public class FormCloseButtonDisabler // 2º Paaso -  Classe Criada para desabilitar o "X" de fechar formulário.
        {
            private const int MF_BYPOSITION = 0x400;
            private const int MF_REMOVE = 0x1000;
            private const int MF_DISABLED = 0x2;
            [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]
            static extern Int32 DrawMenuBar(
            Int32 hWnd
            );
            [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
            static extern Int32 GetMenuItemCount(
            Int32 hMenu
            );
            [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
            static extern Int32 GetSystemMenu(
            Int32 hWnd,
            bool bRevert
            );
            [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
            static extern Int32 RemoveMenu(
            Int32 hMenu,
            Int32 nPosition,
            Int32 wFlags
            );
            public static void DisableCloseButton(int hWnd)
            {
                int hMenu;
                int menuItemCount;
                hMenu = GetSystemMenu(hWnd, false);
                menuItemCount = GetMenuItemCount(hMenu);
                RemoveMenu(hMenu, menuItemCount - 1, MF_DISABLED | MF_BYPOSITION);
                RemoveMenu(hMenu, menuItemCount - 2, MF_DISABLED | MF_BYPOSITION);
                DrawMenuBar(hWnd);
                // Fim da Classe (2º Passo) para desabilitar o "X" do fchar Form.                
            }
        }
        private void frmCustos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            lblInsumo.Visible = true;
            lblMedicamento.Visible = true;
            lblExame.Visible = true;
            txtInsumo.Visible = true;
            txtMedicamento.Visible = true;
            txtExame.Visible = true;
            btnInsere.Visible = true;
            btnConInsumo.Visible = true;
            btnConsMedic.Visible = true;
            btnConsExame.Visible = true;
            txtInsumo.Focus();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            if (txtInsumo.Text == String.Empty || txtMedicamento.Text == String.Empty || txtExame.Text == String.Empty)
            {
                MessageBox.Show("É Necessário Preencher todos os campos, caso não houver necessidade de inserir todos os Custos, preencha o campo ignorado sempre com o Numero 1.", "SISTEMA HOSPITALAE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInsumo.Focus();
                return;
            }
            Insere();
            txtInsumo.Text = String.Empty;
            txtMedicamento.Text = String.Empty;
            txtExame.Text = String.Empty;
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustos_Load(object sender, EventArgs e)
        {
            var Dia = DateTime.Now;
            txtData.Text = Dia.ToShortDateString();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
       .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void txtInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtInsumo.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Campo Numérico, digitar somente numeros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInsumo.Focus();
            }
        }

        private void txtMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtMedicamento.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Campo Numérico, digitar somente numeros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicamento.Focus();
            }
        }

        private void txtExame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Trava Letra
            {
                if (((int)e.KeyChar) != ((int)Keys.Back)) // Usar o BackSpace para Apagar
                    if (e.KeyChar != ',') // if (e.KeyChar != '.') - Caso Queira Que entre "Ponto"
                        e.Handled = true;
                    else if (txtExame.Text.IndexOf(',') > 0)
                        e.Handled = true;
                MessageBox.Show("Campo Numérico, digitar somente numeros.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExame.Focus();
            }
        }

        private void btnConInsumo_Click(object sender, EventArgs e)
        {
            frmConsulta_Insumos ci = new frmConsulta_Insumos();
            ci.ShowDialog();
            if (ci.codigo.ToString() != null)
            {
                txtInsumo.Text = ci.codigo.ToString();
            }
        }

        private void btnConsMedic_Click(object sender, EventArgs e)
        {
            frmConsulta_Medicamentos cm = new frmConsulta_Medicamentos();
            cm.ShowDialog();
            if(cm.codigo .ToString () != null)
            {
                txtMedicamento.Text = cm.codigo.ToString();
            }
        }

        private void btnConsExame_Click(object sender, EventArgs e)
        {
            frmConsulta_Exames ce = new frmConsulta_Exames();
            ce.ShowDialog();
            if(ce.codigo .ToString ()!= null)
            {
                txtExame.Text = ce.codigo.ToString();
            }
        }
    }
}