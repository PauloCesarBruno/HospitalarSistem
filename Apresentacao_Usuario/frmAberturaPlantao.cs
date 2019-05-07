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
//
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

namespace Apresentacao_Usuario
{
    public partial class frmAberturaPlantao : Form
    {
        public frmAberturaPlantao(String Usuario_Logado)
        {
            InitializeComponent();
            txtUsuario.Text = Convert.ToString(Usuario_Logado);
        }

        #region Metodos
        private void carregaDadosTreeView()
        {
            TreePlantonistas.Nodes.Clear();
            try
            {
                TreeNode rootNode = TreePlantonistas.Nodes.Add("Médicos");
                rootNode.ImageIndex = 0;

                TreeNode rootNode1 = TreePlantonistas.Nodes.Add("Enfermeiros");
                rootNode.ImageIndex = 1;

                TreeNode rootNode2 = TreePlantonistas.Nodes.Add("Tecnicos");
                rootNode.ImageIndex = 2;

                TreeNode rootNode3 = TreePlantonistas.Nodes.Add("Paciêntes");
                rootNode.ImageIndex = 3;

                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                SqlDataReader dr;
                SqlDataReader dr1;
                SqlDataReader dr2;
                SqlDataReader dr3;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nome  FROM tblMedico order by Nome", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TreeNode states1 = rootNode.Nodes.Add(dr.GetValue(0).ToString());
                    states1.ImageIndex = 1;

                }
                dr.Close();
                SqlCommand cmd1 = new SqlCommand("SELECT NomeEnfermeiro  FROM tblEnfermeiro order by NomeEnfermeiro", conn);
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    TreeNode states1 = rootNode1.Nodes.Add(dr1.GetValue(0).ToString());
                    states1.ImageIndex = 1;
                }
                dr1.Close();
                SqlCommand cmd2 = new SqlCommand("SELECT NomeTecnico  FROM tblTecnicoEnfermagem order by NomeTecnico", conn);
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    TreeNode states1 = rootNode2.Nodes.Add(dr2.GetValue(0).ToString());
                    states1.ImageIndex = 1;
                }
                dr2.Close();
                SqlCommand cmd3 = new SqlCommand("SELECT Nome  FROM tblPaciente order by Nome", conn);
                dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    TreeNode states1 = rootNode3.Nodes.Add(dr3.GetValue(0).ToString());
                    states1.ImageIndex = 1;
                }
                dr3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void carregaDadosTextBox(string nome)
        {
            try
            {
                Conect conect = new Conect();
                SqlConnection conn = new SqlConnection(conect.sql);
                SqlDataReader dr;
                SqlDataReader dr1;
                SqlDataReader dr2;
                SqlDataReader dr3;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblMedico where Nome = '" + nome + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listMedicos.Items.Add(dr["Nome"].ToString());
                }
                dr.Close();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM tblEnfermeiro where NomeEnfermeiro = '" + nome + "'", conn);
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    listEnfermeiro.Items.Add(dr1["NomeEnfermeiro"].ToString());
                }
                dr1.Close();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM tblTecnicoEnfermagem where NomeTecnico = '" + nome + "'", conn);
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    lisTecnicos_Pacientes.Items.Add("Técnico(a):");
                    lisTecnicos_Pacientes.Items.Add(dr2["NomeTecnico"].ToString());
                }
                dr2.Close();
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM tblPaciente where Nome = '" + nome + "'", conn);
                dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    lisTecnicos_Pacientes.Items.Add("Paciente:");
                    lisTecnicos_Pacientes.Items.Add(dr3["Nome"].ToString());
                }
                dr3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

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
        private void frmAberturaPlantao_Load(object sender, EventArgs e)
        {
            carregaDadosTreeView();
            lblDia.Text = DateTime.Now.ToShortDateString();
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparEscala_Click(object sender, EventArgs e)
        {
            if (listMedicos.Items.Count == 0 && listEnfermeiro.Items.Count == 0 && lisTecnicos_Pacientes.Items.Count == 0)
            {
                MessageBox.Show("Não há Nada Para ser Limpo...!!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lisTecnicos_Pacientes.Items.Clear();
            listEnfermeiro.Items.Clear();
            listMedicos.Items.Clear();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lisTecnicos_Pacientes.Items.Count == 0)
            {
                MessageBox.Show("Não há Nada Para ser Limpo...!!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            while (lisTecnicos_Pacientes.SelectedItems.Count > 0)
            {
                lisTecnicos_Pacientes.Items.Remove(lisTecnicos_Pacientes.SelectedItems[0]);
            }
        }

        private void btnRemoverEnfermeiro_Click(object sender, EventArgs e)
        {
            if (listEnfermeiro.Items.Count == 0)
            {
                MessageBox.Show("Não há Nada Para ser Limpo...!!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            while (listEnfermeiro.SelectedItems.Count > 0)
            {
                listEnfermeiro.Items.Remove(listEnfermeiro.SelectedItems[0]);
            }
        }

        private void btnRemoverMedico_Click(object sender, EventArgs e)
        {
            if (listMedicos.Items.Count == 0)
            {
                MessageBox.Show("Não há Nada Para ser Limpo...!!!", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            while (listMedicos.SelectedItems.Count > 0)
            {
                listMedicos.Items.Remove(listMedicos.SelectedItems[0]);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (listMedicos.Items.Count == 0 || listEnfermeiro.Items.Count == 0 || lisTecnicos_Pacientes.Items.Count == 0)
            {
                DialogResult res = MessageBox.Show("Não Foi Preenchida toda a Escala.  Deseja Salvar Assim Mesmo ???", "SISTEMA HOSPITLAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    MessageBox.Show("Ok, Verifique ...", "SISTEMA HOSPITALAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //verifica se existe algo digitado na caixa de texto
            if (listMedicos.Items.ToString() == String.Empty || listEnfermeiro.Items.ToString() == String.Empty || lisTecnicos_Pacientes.Items.ToString() == String.Empty)
            {
                MessageBox.Show("Informe algo na caixa de texto");
                return;
            }

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo Texto";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.txt";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Escala " + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".txt";
            //define o diretório padrão

            #region Atenção Diretório

            //===============================================================================================================
            // -- ATENÇÃO: MUDAR CONFORME A NECESSIDADE -- Geralmente, Usa-se o Diretório em C:\Documentos\Pasta...

            saveFileDialog1.InitialDirectory = @"C:\Users\p_bru\Documents\Sistema Hospitalar\Abertura de Plantao Escala\";
            //
            //
            //===============================================================================================================

            #endregion

            //restaura o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;

            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                #region Dados do Hospital (sujeito à Alterações)

                //Cria um escrito que irá escrever no stream
                using (var tw = new StreamWriter(fs))
                {
                    //escreve o conteúdo da caixa de texto no stream
                    tw.Write("\r\nHospital  ( -- >> Nome do Hospital");
                    tw.Write("\r\nEndereçco ( -- >> Endereço do Hospital");
                    tw.Write("\r\nTelefones ( -- >> 0000-0000 / 0000-0000");
                    tw.Write("\r\n=======================================================");
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    tw.Write("\r\nEscala e Distribuição do dia: " + DateTime.Now.ToShortDateString() + "  Elaborada por: " + txtUsuario.Text);
                    tw.Write("\r\n================================================================================");
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    tw.Write("Médicos: ");
                    tw.Write("\r\n=========");
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    foreach (ListViewItem item in listMedicos.Items)
                    {
                        tw.WriteLine(item.Text);
                    }
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    tw.Write("Enfermeiros: ");
                    tw.Write("\r\n=============");
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    foreach (ListViewItem item in listEnfermeiro.Items)
                    {
                        tw.WriteLine(item.Text);
                    }
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    tw.Write("Técnico(s) e Paciênte(s) - Distribuição do dia: ");
                    tw.Write("\r\n===============================================");
                    tw.Write("\r\n");
                    tw.Write("\r\n");
                    foreach (ListViewItem item in lisTecnicos_Pacientes.Items)
                    {
                        tw.WriteLine(item.Text);
                    }
                    //fecha o escrito e o stream
                    tw.Dispose();

                #endregion
                }
            }
        }

        private void TreePlantonistas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string strNome = this.TreePlantonistas.SelectedNode.Text.ToString();
                carregaDadosTextBox(strNome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
    }
}