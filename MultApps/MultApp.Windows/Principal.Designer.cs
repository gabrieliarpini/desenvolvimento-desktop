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
            this.menuStripPrincipral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipral
            // 
            this.menuStripPrincipral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem1});
            this.menuStripPrincipral.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipral.Name = "menuStripPrincipral";
            this.menuStripPrincipral.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipral.TabIndex = 1;
            this.menuStripPrincipral.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem1
            // 
            this.calculadorasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalculadoraImc});
            this.calculadorasToolStripMenuItem1.Name = "calculadorasToolStripMenuItem1";
            this.calculadorasToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.calculadorasToolStripMenuItem1.Text = "Calculadoras";
            // 
            // menuCalculadoraImc
            // 
            this.menuCalculadoraImc.Name = "menuCalculadoraImc";
            this.menuCalculadoraImc.Size = new System.Drawing.Size(180, 22);
            this.menuCalculadoraImc.Text = "Calculadora de IMC";
            this.menuCalculadoraImc.Click += new System.EventHandler(this.cAlculadorasDeIMCToolStripMenuItem_Click);
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
            this.menuStripPrincipral.ResumeLayout(false);
            this.menuStripPrincipral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipral;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadoraImc;
    }
}