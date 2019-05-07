namespace Apresentacao_Usuario
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVerssao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picturePrincipal = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblVerssao);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-1, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 70);
            this.panel1.TabIndex = 4;
            // 
            // lblVerssao
            // 
            this.lblVerssao.AutoSize = true;
            this.lblVerssao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerssao.ForeColor = System.Drawing.Color.White;
            this.lblVerssao.Location = new System.Drawing.Point(456, 43);
            this.lblVerssao.Name = "lblVerssao";
            this.lblVerssao.Size = new System.Drawing.Size(85, 13);
            this.lblVerssao.TabIndex = 3;
            this.lblVerssao.Text = "Verssão 1.0.5";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 41);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema Hospitalar ®";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 383);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(564, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 5;
            // 
            // picturePrincipal
            // 
            this.picturePrincipal.Image = ((System.Drawing.Image)(resources.GetObject("picturePrincipal.Image")));
            this.picturePrincipal.Location = new System.Drawing.Point(-1, 2);
            this.picturePrincipal.Name = "picturePrincipal";
            this.picturePrincipal.Size = new System.Drawing.Size(564, 310);
            this.picturePrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePrincipal.TabIndex = 6;
            this.picturePrincipal.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 406);
            this.Controls.Add(this.picturePrincipal);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVerssao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox picturePrincipal;

    }
}