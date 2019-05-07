using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Objeto_de_Transferencia;


namespace Apresentacao_Usuario
{
    public partial class frmVerificaAdm : Form
    {
        public frmVerificaAdm(String Logado)
        {
            InitializeComponent();
            txtNome.Text = Convert.ToString(Logado);
        }

        private Usuario usuario;

        
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                 //cria uma nova instancia
                
                this.usuario = new Usuario();

                //faz o login e verifica se é administrador
                this.usuario = this.usuario.GetLogin(txtNome.Text, txtUsuario.Text, txtSenha.Text);
                if (usuario.Credencial )
                {
                    //se ok para o formulario que abriu
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }

                else
                {
                    lblAviso.Visible = true;
                    txtNome.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                    btnSair.Focus();
                 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro");
               
                
            }
        }

        private void frmVerificaAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void checkAtivar_CheckedChanged(object sender, EventArgs e)
        {


            if (checkAtivar.Checked == true)
            {
                txtNome.Text = String.Empty;
                txtNome.ReadOnly = false;
                txtNome.Focus();
            }
        }

        private void frmVerificaAdm_Load(object sender, EventArgs e)
        {
            checkAtivar.Checked = false;
            txtNome.ReadOnly = true;
        }
    }
}