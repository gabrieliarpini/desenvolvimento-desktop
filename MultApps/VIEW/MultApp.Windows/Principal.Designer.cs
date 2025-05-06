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
            this.pedidoAçaíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroUSuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cadastroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipral.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipral
            // 
            this.menuStripPrincipral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem1,
            this.carteirinhaToolStripMenuItem,
            this.pedidoAçaíToolStripMenuItem,
            this.categoriaDeProdutosToolStripMenuItem,
            this.cadastroUSuarioToolStripMenuItem,
            this.cadastroDeProdutoToolStripMenuItem});
            this.menuStripPrincipral.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipral.Name = "menuStripPrincipral";
            this.menuStripPrincipral.Size = new System.Drawing.Size(800, 25);
            this.menuStripPrincipral.TabIndex = 1;
            this.menuStripPrincipral.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem1
            // 
            this.calculadorasToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calculadorasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalculadoraImc,
            this.calculadoraDeAposentadoriaToolStripMenuItem});
            this.calculadorasToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadorasToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Black;
            this.calculadorasToolStripMenuItem1.Name = "calculadorasToolStripMenuItem1";
            this.calculadorasToolStripMenuItem1.Size = new System.Drawing.Size(111, 21);
            this.calculadorasToolStripMenuItem1.Text = "| Calculadoras |";
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
            this.carteirinhaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.carteirinhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaDeIdentificaçãoToolStripMenuItem});
            this.carteirinhaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.carteirinhaToolStripMenuItem.Name = "carteirinhaToolStripMenuItem";
            this.carteirinhaToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.carteirinhaToolStripMenuItem.Text = "| Carteirinha |";
            // 
            // sistemaDeIdentificaçãoToolStripMenuItem
            // 
            this.sistemaDeIdentificaçãoToolStripMenuItem.Name = "sistemaDeIdentificaçãoToolStripMenuItem";
            this.sistemaDeIdentificaçãoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sistemaDeIdentificaçãoToolStripMenuItem.Text = " sistema de identificação";
            this.sistemaDeIdentificaçãoToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeIdentificaçãoToolStripMenuItem_Click);
            // 
            // pedidoAçaíToolStripMenuItem
            // 
            this.pedidoAçaíToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pedidoAçaíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerPedidoToolStripMenuItem});
            this.pedidoAçaíToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.pedidoAçaíToolStripMenuItem.Name = "pedidoAçaíToolStripMenuItem";
            this.pedidoAçaíToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.pedidoAçaíToolStripMenuItem.Text = "| Pedido Açaí |";
            // 
            // fazerPedidoToolStripMenuItem
            // 
            this.fazerPedidoToolStripMenuItem.Name = "fazerPedidoToolStripMenuItem";
            this.fazerPedidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fazerPedidoToolStripMenuItem.Text = "Fazer Pedido";
            this.fazerPedidoToolStripMenuItem.Click += new System.EventHandler(this.fazerPedidoToolStripMenuItem_Click);
            // 
            // categoriaDeProdutosToolStripMenuItem
            // 
            this.categoriaDeProdutosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.categoriaDeProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem});
            this.categoriaDeProdutosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.categoriaDeProdutosToolStripMenuItem.Name = "categoriaDeProdutosToolStripMenuItem";
            this.categoriaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(172, 21);
            this.categoriaDeProdutosToolStripMenuItem.Text = "| Categoria de Categoria |";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // cadastroUSuarioToolStripMenuItem
            // 
            this.cadastroUSuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cadastroUSuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.cadastroUSuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cadastroUSuarioToolStripMenuItem.Name = "cadastroUSuarioToolStripMenuItem";
            this.cadastroUSuarioToolStripMenuItem.Size = new System.Drawing.Size(138, 21);
            this.cadastroUSuarioToolStripMenuItem.Text = "| Cadastro USuario |";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro ";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelUsuario
            // 
            this.statusLabelUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelUsuario.ForeColor = System.Drawing.Color.MediumBlue;
            this.statusLabelUsuario.Name = "statusLabelUsuario";
            this.statusLabelUsuario.Size = new System.Drawing.Size(151, 20);
            this.statusLabelUsuario.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 394);
            this.panel1.TabIndex = 5;
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            this.cadastroDeProdutoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cadastroDeProdutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.cadastroDeProdutoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            this.cadastroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripPrincipral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipral;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Shown += new System.EventHandler(this.MDIPrincipal_Shown);
            this.menuStripPrincipral.ResumeLayout(false);
            this.menuStripPrincipral.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem pedidoAçaíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUsuario;
        private System.Windows.Forms.ToolStripMenuItem cadastroUSuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
    }
}