using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // 1ª Passo para desabilitar o "X" do Fechar Formulario.

//using BarcodeLib; // Livraria Baixada pelo NugGet.

namespace Apresentacao_Usuario
{
    public partial class frmCodigoDeBarras : Form
    {
        public String cod { get; set; }

        public frmCodigoDeBarras()
        {
            InitializeComponent();
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
             Random randNum = new Random();
            
             for (int i = 0; i <= 13; i++)
                              
             if (txtCodigo.Text.Length != 13 )
             {
                 txtCodigo.Text = ("789" + randNum.Next().ToString());
             }
             btnGerar.Enabled = false;
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                panelResultado.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 400, 100);
                btnGuardar.Enabled = true;
            }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();

            SaveFileDialog CaixaDeDialogoGuardar = new SaveFileDialog();
            CaixaDeDialogoGuardar.InitialDirectory = @"C:\Users\pf\Documents\Sistema Hospitalar\Pacientes Codigo de Barras\";
            CaixaDeDialogoGuardar.AddExtension = true;
            CaixaDeDialogoGuardar.Filter = "Image PNG (*.png)|*.png";
            CaixaDeDialogoGuardar.ShowDialog();
            if (!String.IsNullOrEmpty(CaixaDeDialogoGuardar.FileName))
            {
                imgFinal.Save(CaixaDeDialogoGuardar.FileName, ImageFormat.Png);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            cod = txtCodigo.Text;
            this.Close();           
        }
               
        private void frmCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmCodigoDeBarras_Load(object sender, EventArgs e)
        {
            FormCloseButtonDisabler // esta é a Classe Criada e Chamada no Load para desabilitar o "X".
                                    // 3º Passo Para desabilitar o "X".
      .DisableCloseButton(this.Handle.ToInt32()); // Desabilitar o "X".           
            // Fim da dos 3 Passos para desabilitar o "X" do Form.
        }
    }
}
