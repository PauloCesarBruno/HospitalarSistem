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
using System.Data.SqlClient;
using Conexao_SQLServer;
using Objeto_de_Transferencia;
using Regras_de_Negocios;
using System.Runtime.InteropServices; 
// ======================================================
// 1ª Passo para desabilitar o "X" do Fechar Formulario.
// ======================================================

namespace Apresentacao_Usuario
{
    public partial class frmPrincipal : Form
    {
        //======================================================================
        // Estas Variáveis Amarrao a data de expiração da autorização do sistema.
        public DateTime data = DateTime.Now.Date;
        public DateTime outraData = Convert.ToDateTime("20/12/2021");
        //======================================================================

        Int64 codigo = 0;
        String nome = null;

        // Travar O Form
        //=================================================== 
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        // Fim do Trava Form
        //=================================================== 

        public frmPrincipal(String UsuarioLogado, String Adm)
        {
            InitializeComponent();
            toolStripStatusUsuarioLogado.Text = (UsuarioLogado);
            toolStripStatusAdm.Text = (Adm);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //data atual
            this.toolStripStatusData.Text = DateTime.Now.ToShortDateString();

            //hora atual
            this.toolStripStatusHora.Text = DateTime.Now.ToLongTimeString();
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            panelAcessoRapido.Focus();
            #region Amarra Mensalidade

            if (System.DateTime.Now.ToShortDateString() == "15/12/2021" || System.DateTime.Now.ToShortDateString() == "16/12/2021" ||
            System.DateTime.Now.ToShortDateString() == "17/12/2021" || System.DateTime.Now.ToShortDateString() == "18/12/2021" ||
            System.DateTime.Now.ToShortDateString() == "19/12/2021")
            {
                MessageBox.Show("ATENÇÃO: A sua chave expira em 20/12/2021, entre em contato com o desenvolvedor para renovar a chave antes da data de expiração evitando o bloqueio do sistema !!!", "SISTEME HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("OBS.IMPORTANTE: Não é aconselhavel 'MUDAR' a data no sistema windows com o objetivo de manter o Sistema Hospitalar funcionando sem ter que renovar a chave, pois isso causará uma 'PANE' no banco de dados, e no próprio programa, gerando problemas incalculáveis para a gestão do seu negócio; RENOVE AGORA SUA CHAVE, entre em contato com o desenvolvedor.", "SISTEME HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            else if (data > outraData || data == outraData)//verifica se é maior OU igual, Variaveis de Amarração Publicadas no Topo (Global).
            {
                MessageBox.Show("A sua Chave Expirou, entre em contato com o desenvolvedor para definir nova Chave; O Sistema sera Encerrado !!!", "SISTEME HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            
            else
            {
                //
            }

            #endregion

            txtCapturaAdmin.Text = toolStripStatusAdm.Text;
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                // 3º Passo Para desabilitar o "X".
          .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".
            MessageBox.Show("Bem Vindo Ao Sistema Hospitalar !!!", "Sistema Hospitalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult X = MessageBox.Show("Deseja REALMENTE Finalizar a Aplicação ???",
              "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (X == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Obrigado e até a proxima !!!", "Sistema Hospitalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else MessageBox.Show("OK, Mantendo SISTEMA HOSPITALAR !!!", "Sistema Hospitalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.MdiParent = this;
            sobre.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmManipulaUsuario Musuario = new frmManipulaUsuario();
                Musuario.MdiParent = this;
                Musuario.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void fucionáriosAdministrativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {

                frmFuncionarios_Administrativos FuncAdm = new frmFuncionarios_Administrativos();
                FuncAdm.MdiParent = this;
                FuncAdm.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {

                frmFornecedores Fornec = new frmFornecedores();
                Fornec.MdiParent = this;
                Fornec.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodigoDeBarrasMedicamentos codigo_barras = new frmCodigoDeBarrasMedicamentos();
            codigo_barras.MdiParent = this;
            codigo_barras.Show();
        }

        private void insumosAlmoxarifadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodigoDeBarrasInsumos codigo_barras = new frmCodigoDeBarrasInsumos();
            codigo_barras.MdiParent = this;
            codigo_barras.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodigoDeBarras codigo_barras = new frmCodigoDeBarras();
            codigo_barras.MdiParent = this;
            codigo_barras.Show();
        }

        private void farmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmFarmacia farmacia = new frmFarmacia(null);
                farmacia.MdiParent = this;
                farmacia.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmInsumos insumos = new frmInsumos(null);
                insumos.MdiParent = this;
                insumos.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void entradaPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacienteEntrada Pentrada = new frmPacienteEntrada(null);
            Pentrada.MdiParent = this;
            Pentrada.Show();
        }

        private void paciênteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {

                frmManipularPaciente Mnpaciente = new frmManipularPaciente();
                Mnpaciente.TheValue = this.toolStripStatusUsuarioLogado.Text.ToString(); // Manda o Usuario Logado Paro o Form ManipulaPaciente
                Mnpaciente.MdiParent = this;
                Mnpaciente.Show();

            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void consultaCustosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCustos consultaCustos = new frmConsultaCustos(txtCapturaAdmin.Text);
            consultaCustos.MdiParent = this;
            consultaCustos.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVerAcomodacao veracomodacao = new frmVerAcomodacao(null, txtCapturaAdmin.Text);
            veracomodacao.MdiParent = this;
            veracomodacao.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmVerAcomodacao_Anterior verAanterior = new frmVerAcomodacao_Anterior(txtCapturaAdmin.Text);
            verAanterior.MdiParent = this;
            verAanterior.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmConsultaPaciente Cpaciente = new frmConsultaPaciente();
            Cpaciente.MdiParent = this;
            Cpaciente.Show();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmMedicos Medicos = new frmMedicos();
                Medicos.MdiParent = this;
                Medicos.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedicos Cmedicos = new frmConsultaMedicos();
            Cmedicos.MdiParent = this;
            Cmedicos.Show();
        }

        private void enfermeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {

                frmEnfermeiro enfermeiros = new frmEnfermeiro();
                enfermeiros.MdiParent = this;
                enfermeiros.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void enfermeirosasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEnfermeiros Cenfermeiros = new frmConsultaEnfermeiros();
            Cenfermeiros.MdiParent = this;
            Cenfermeiros.Show();
        }

        private void técnicoDeEnfermagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {

                frmTecnicoEnfermagem Tecenfermagem = new frmTecnicoEnfermagem();
                Tecenfermagem.MdiParent = this;
                Tecenfermagem.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTecnico TecEnfermagem = new frmConsultaTecnico();
            TecEnfermagem.MdiParent = this;
            TecEnfermagem.Show();
        }

        private void pacienteMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDesignacao cd = new frmConsultaDesignacao();
            cd.MdiParent = this;
            cd.Show();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmPacientesAcomodacoes Acomodacoes = new frmPacientesAcomodacoes(txtCapturaAdmin.Text);
            Acomodacoes.MdiParent = this;
            Acomodacoes.Show();
        }

        #region controles do Windows

        //============================================================================================

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void worToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendario cal = new frmCalendario();
            cal.MdiParent = this;
            cal.Show();
        }

        private void siteDoDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                System.Diagnostics.Process.Start("http://pb-techprogramas.gear.host/index.cshtml");
            }
        }

        //============================================================================================

        #endregion

        private void medicamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmCadastroMedicamentos Cadmedicamentos = new frmCadastroMedicamentos();
                Cadmedicamentos.MdiParent = this;
                Cadmedicamentos.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta_Medicamentos ConsultaMedicamentos = new frmConsulta_Medicamentos();
            ConsultaMedicamentos.MdiParent = this;
            ConsultaMedicamentos.Show();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmCadastroInsumos CadmedInsumos = new frmCadastroInsumos();
                CadmedInsumos.MdiParent = this;
                CadmedInsumos.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsulta_Insumos ConInsumos = new frmConsulta_Insumos();
            ConInsumos.MdiParent = this;
            ConInsumos.Show();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmCadastroExames Cadexames = new frmCadastroExames();
                Cadexames.MdiParent = this;
                Cadexames.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta_Exames Cexames = new frmConsulta_Exames();
            Cexames.MdiParent = this;
            Cexames.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmCadastroProcedimento CadProc = new frmCadastroProcedimento();
                CadProc.MdiParent = this;
                CadProc.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmConsulta_Procedimento ConProced = new frmConsulta_Procedimento();
            ConProced.MdiParent = this;
            ConProced.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmCadastroLocalDeAcomodacao CadLocalAcomod = new frmCadastroLocalDeAcomodacao();
                CadLocalAcomod.MdiParent = this;
                CadLocalAcomod.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmConsultaLocalAcomodacao ConsLocalAcomod = new frmConsultaLocalAcomodacao();
            ConsLocalAcomod.MdiParent = this;
            ConsLocalAcomod.Show();
        }

        private void pacênteAcompanhanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacienteAcompanhante pacienteAcompanhante = new frmPacienteAcompanhante();
            pacienteAcompanhante.MdiParent = this;
            pacienteAcompanhante.Show();
        }

        private void aberturaDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberturaPlantao Abertura = new frmAberturaPlantao(toolStripStatusUsuarioLogado.Text);
            Abertura.MdiParent = this;
            Abertura.Show();
        }

        private void prescriçãoMédicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrescricao_Medica Presc_Med = new frmPrescricao_Medica(toolStripStatusUsuarioLogado.Text);
            Presc_Med.MdiParent = this;
            Presc_Med.Show();
        }

        private void prontuárioEvoluçãoDePaciênteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProntuario prontuario = new frmProntuario(toolStripStatusUsuarioLogado.Text, codigo, nome);
            prontuario.MdiParent = this;
            prontuario.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmPacienteEntrada Pentrada = new frmPacienteEntrada(null);
            Pentrada.MdiParent = this;
            Pentrada.Show();
        }

        private void btnEntradaPaciente_Click(object sender, EventArgs e)
        {
            frmPacienteEntrada Pentrada = new frmPacienteEntrada(null);
            Pentrada.MdiParent = this;
            Pentrada.Show();
        }

        private void btnAberturaPlantao_Click(object sender, EventArgs e)
        {
            frmAberturaPlantao Abertura = new frmAberturaPlantao(toolStripStatusUsuarioLogado.Text);
            Abertura.MdiParent = this;
            Abertura.Show();
        }

        private void btnPrescricao_Click(object sender, EventArgs e)
        {
            frmPrescricao_Medica Presc_Med = new frmPrescricao_Medica(toolStripStatusUsuarioLogado.Text);
            Presc_Med.MdiParent = this;
            Presc_Med.Show();
        }

        private void btnProntuario_Click(object sender, EventArgs e)
        {
            frmProntuario prontuario = new frmProntuario(toolStripStatusUsuarioLogado.Text, codigo, nome);
            prontuario.MdiParent = this;
            prontuario.Show();
        }

        private void btnAcomodacaoLocal_Click(object sender, EventArgs e)
        {
            frmPacientesAcomodacoes Acomodacoes = new frmPacientesAcomodacoes(txtCapturaAdmin.Text);
            Acomodacoes.MdiParent = this;
            Acomodacoes.Show();
        }

        private void btnCustos_Click(object sender, EventArgs e)
        {
            frmConsultaCustos consultaCustos = new frmConsultaCustos(txtCapturaAdmin.Text);
            consultaCustos.MdiParent = this;
            consultaCustos.Show();
        }

        #region Cor Butões

        private void btnEntradaPaciente_MouseEnter(object sender, EventArgs e)
        {
            btnEntradaPaciente.BackColor = Color.Blue;
            pictureBox1.BackColor = Color.Blue;
        }

        private void btnEntradaPaciente_MouseLeave(object sender, EventArgs e)
        {
            btnEntradaPaciente.BackColor = Color.Teal;
            pictureBox1.BackColor = Color.Teal;
        }

        private void btnTriagem_MouseEnter(object sender, EventArgs e)
        {
            btnTriagem.BackColor = Color.Blue;
            pictureBox2.BackColor = Color.Blue;
        }

        private void btnTriagem_MouseLeave(object sender, EventArgs e)
        {
            btnTriagem.BackColor = Color.Teal;
            pictureBox2.BackColor = Color.Teal;
        }

        private void btnAberturaPlantao_MouseEnter(object sender, EventArgs e)
        {
            btnAberturaPlantao.BackColor = Color.Blue;
            pictureBox3.BackColor = Color.Blue;
        }

        private void btnAberturaPlantao_MouseLeave(object sender, EventArgs e)
        {
            btnAberturaPlantao.BackColor = Color.Teal;
            pictureBox3.BackColor = Color.Teal;
        }

        private void btnPrescricao_MouseEnter(object sender, EventArgs e)
        {
            btnPrescricao.BackColor = Color.Blue;
            pictureBox4.BackColor = Color.Blue;
        }

        private void btnPrescricao_MouseLeave(object sender, EventArgs e)
        {
            btnPrescricao.BackColor = Color.Teal;
            pictureBox4.BackColor = Color.Teal;
        }

        private void btnProntuario_MouseEnter(object sender, EventArgs e)
        {
            btnProntuario.BackColor = Color.Blue;
            pictureBox5.BackColor = Color.Blue;
        }

        private void btnProntuario_MouseLeave(object sender, EventArgs e)
        {
            btnProntuario.BackColor = Color.Teal;
            pictureBox5.BackColor = Color.Teal;
        }

        private void btnAcomodacaoLocal_MouseEnter(object sender, EventArgs e)
        {
            btnAcomodacaoLocal.BackColor = Color.Blue;
            pictureBox6.BackColor = Color.Blue;
        }

        private void btnAcomodacaoLocal_MouseLeave(object sender, EventArgs e)
        {
            btnAcomodacaoLocal.BackColor = Color.Teal;
            pictureBox6.BackColor = Color.Teal;
        }

        private void btnCustos_MouseEnter(object sender, EventArgs e)
        {
            btnCustos.BackColor = Color.Blue;
            pictureBox7.BackColor = Color.Blue;
        }

        private void btnCustos_MouseLeave(object sender, EventArgs e)
        {
            btnCustos.BackColor = Color.Teal;
            pictureBox7.BackColor = Color.Teal;
        }

        #endregion

        private void impressãoDeCustosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustosUsoRelatorio Cur = new frmCustosUsoRelatorio();
            Cur.MdiParent = this;
            Cur.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

            if (toolStripStatusAdm.Text == "Sim")
            {
                frmAlta alta = new frmAlta();
                alta.MdiParent = this;
                alta.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void triagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 Codigo = 0;
            String Nome = null;
            String Data = null;
            String Sexo = null;

            frmTriagem triagem = new frmTriagem(Codigo, Nome, Data, Sexo);
            triagem.MdiParent = this;
            triagem.Show();
        }

        private void btnTriagem_Click(object sender, EventArgs e)
        {
            Int64 Codigo = 0;
            String Nome = null;
            String Data = null;
            String Sexo = null;

            frmTriagem triagem = new frmTriagem(Codigo, Nome, Data, Sexo);
            triagem.MdiParent = this;
            triagem.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            frmCustosUsoRelatorio Cur = new frmCustosUsoRelatorio();
            Cur.MdiParent = this;
            Cur.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Relatório é impresso pelo próprio Formulario, Redirecionando...", "SISTEMA hOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmVerAcomodacao veracomod = new frmVerAcomodacao(null, txtCapturaAdmin.Text);
            veracomod.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            frmAcomodacaoAnteriorRelatorio FormAcomodAnt = new frmAcomodacaoAnteriorRelatorio();
            FormAcomodAnt.MdiParent = this;
            FormAcomodAnt.Show();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            frmDesignacaoPaciente fdep = new frmDesignacaoPaciente();
            fdep.MdiParent = this;
            fdep.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmMedicoRelatorio fmr = new frmMedicoRelatorio();
            fmr.MdiParent = this;
            fmr.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            frmEnfermeiroRelatorio fer = new frmEnfermeiroRelatorio();
            fer.MdiParent = this;
            fer.Show();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            frmTecnicodeEnfermagemRelatorio tEr = new frmTecnicodeEnfermagemRelatorio();
            tEr.MdiParent = this;
            tEr.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            frmMedicamentoRelatorio fmedrel = new frmMedicamentoRelatorio();
            fmedrel.MdiParent = this;
            fmedrel.Show();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            frmInsumosRelatorio fir = new frmInsumosRelatorio();
            fir.MdiParent = this;
            fir.Show();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            frmExamesRelatorio fexrel = new frmExamesRelatorio();
            fexrel.MdiParent = this;
            fexrel.Show();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            frmTratamentoRelatorio ftrel = new frmTratamentoRelatorio();
            ftrel.MdiParent = this;
            ftrel.Show();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            frmPacienteCadastroRelatorio fpcrel = new frmPacienteCadastroRelatorio();
            fpcrel.MdiParent = this;
            fpcrel.Show();
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            frmPacienteFiliacaoRelatorio fpfcad = new frmPacienteFiliacaoRelatorio();
            fpfcad.MdiParent = this;
            fpfcad.Show();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            frmLocalAcomodacaoFormulario flafor = new frmLocalAcomodacaoFormulario();
            flafor.MdiParent = this;
            flafor.Show();
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmUsuarioRelatorio frmuRelatorio = new frmUsuarioRelatorio();
                frmuRelatorio.MdiParent = this;
                frmuRelatorio.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmFuncionariosAdmRelatorio frmfadm = new frmFuncionariosAdmRelatorio();
                frmfadm.MdiParent = this;
                frmfadm.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmFornecedoresRelatorio frmForrelat = new frmFornecedoresRelatorio();
                frmForrelat.MdiParent = this;
                frmForrelat.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmAlmoxarifadoFarmaciaRelatorio frmafrel = new frmAlmoxarifadoFarmaciaRelatorio();
                frmafrel.MdiParent = this;
                frmafrel.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            if (toolStripStatusAdm.Text == "Sim")
            {
                frmAlmoxarifadoInsumoRelatorio frmains = new frmAlmoxarifadoInsumoRelatorio();
                frmains.MdiParent = this;
                frmains.Show();
            }
            else
            {
                MessageBox.Show("Conta Logada de não Administrador.", "AUTORIZAÇAO NEGADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            #region Teclas de Função para Atalho usando switch case

            switch (e.KeyCode)
            {

                case Keys.F1:

                    btnEntradaPaciente_Click(sender, e);

                    break;

                case Keys.F2:

                    btnTriagem_Click(sender, e);

                    break;

                case Keys.F3:

                   btnAberturaPlantao_Click(sender, e);

                    break;

                case Keys.F4:

                    btnPrescricao_Click(sender, e);

                    break;

                case Keys.F5:

                   btnProntuario_Click(sender, e);

                    break;

                case Keys.F6:

                   btnAcomodacaoLocal_Click(sender, e);

                    break;
                    
                case Keys.F7:

                    btnCustos_Click(sender, e);

                    break;

                case Keys.F8:

                    paciênteToolStripMenuItem_Click(sender, e);

                    break;

                case Keys.F9:

                    toolStripMenuItem11_Click(sender, e);

                    break;

                case Keys.F10:

                    toolStripMenuItem19_Click(sender, e);

                    break;
                    
                case Keys.F11:

                    sobreToolStripMenuItem_Click(sender, e);

                    break;

                case Keys.F12:

                    toolStripMenuItem1_Click(sender, e);

                    break;
            }

            #endregion
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason .UserClosing : // Evita o ALT + F4
                    e.Cancel = true;
                    break;
            }
        }

        private void mudarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Sistema Irá REINICIAR para Login do novo Usuário.", "Sistema Hospitalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void impressoesAdminostrativasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
} 