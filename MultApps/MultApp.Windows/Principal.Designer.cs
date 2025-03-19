namespace MultApp.Windows
{
    partial class Principal
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
            this.menuStripPrincipral = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculadoraImc = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraDeAposentadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteirinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeIdentificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipral
            // 
            this.menuStripPrincipral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem1,
            this.carteirinhaToolStripMenuItem});
            this.menuStripPrincipral.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipral.Name = "menuStripPrincipral";
            this.menuStripPrincipral.Size = new System.Drawing.Size(800, 25);
            this.menuStripPrincipral.TabIndex = 1;
            this.menuStripPrincipral.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem1
            // 
            this.calculadorasToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.calculadorasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalculadoraImc,
            this.calculadoraDeAposentadoriaToolStripMenuItem});
            this.calculadorasToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadorasToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.calculadorasToolStripMenuItem1.Name = "calculadorasToolStripMenuItem1";
            this.calculadorasToolStripMenuItem1.Size = new System.Drawing.Size(95, 21);
            this.calculadorasToolStripMenuItem1.Text = "Calculadoras";
            // 
            // menuCalculadoraImc
            // 
            this.menuCalculadoraImc.Name = "menuCalculadoraImc";
            this.menuCalculadoraImc.Size = new System.Drawing.Size(253, 22);
            this.menuCalculadoraImc.Text = "Calculadora de IMC";
            this.menuCalculadoraImc.Click += new System.EventHandler(this.cAlculadorasDeIMCToolStripMenuItem_Click);
            // 
            // calculadoraDeAposentadoriaToolStripMenuItem
            // 
            this.calculadoraDeAposentadoriaToolStripMenuItem.Name = "calculadoraDeAposentadoriaToolStripMenuItem";
            this.calculadoraDeAposentadoriaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.calculadoraDeAposentadoriaToolStripMenuItem.Text = "Calculadora de Aposentadoria";
            this.calculadoraDeAposentadoriaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraDeAposentadoriaToolStripMenuItem_Click);
            // 
            // carteirinhaToolStripMenuItem
            // 
            this.carteirinhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaDeIdentificaçãoToolStripMenuItem});
            this.carteirinhaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.carteirinhaToolStripMenuItem.Name = "carteirinhaToolStripMenuItem";
            this.carteirinhaToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.carteirinhaToolStripMenuItem.Text = "Carteirinha";
            // 
            // sistemaDeIdentificaçãoToolStripMenuItem
            // 
            this.sistemaDeIdentificaçãoToolStripMenuItem.Name = "sistemaDeIdentificaçãoToolStripMenuItem";
            this.sistemaDeIdentificaçãoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sistemaDeIdentificaçãoToolStripMenuItem.Text = " sistema de identificação";
            this.sistemaDeIdentificaçãoToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeIdentificaçãoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripPrincipral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipral;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MDIPrincipal_Shown);
            this.menuStripPrincipral.ResumeLayout(false);
            this.menuStripPrincipral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipral;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadoraImc;
        private System.Windows.Forms.ToolStripMenuItem calculadoraDeAposentadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteirinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeIdentificaçãoToolStripMenuItem;
    }
}