namespace MultApp.Windows
{
    partial class CarteirinhaParque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelCor = new System.Windows.Forms.Panel();
            this.lblCpfResultado = new System.Windows.Forms.Label();
            this.lblIdadeResultado = new System.Windows.Forms.Label();
            this.PictureImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.dataNascimento);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblCpf);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 465);
            this.panel1.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGerar.Location = new System.Drawing.Point(68, 310);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(113, 39);
            this.btnGerar.TabIndex = 9;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl1.Location = new System.Drawing.Point(28, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(179, 27);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Gerar Carteirinha";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(29, 208);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(129, 21);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(33, 244);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dataNascimento.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 154);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 31);
            this.textBox2.TabIndex = 4;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(29, 130);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 21);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(33, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 31);
            this.textBox1.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(125, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Completo";
            // 
            // panelCor
            // 
            this.panelCor.Controls.Add(this.PictureImage);
            this.panelCor.Controls.Add(this.lblIdadeResultado);
            this.panelCor.Controls.Add(this.lblCpfResultado);
            this.panelCor.Controls.Add(this.lblResultadoNome);
            this.panelCor.Location = new System.Drawing.Point(12, 12);
            this.panelCor.Name = "panelCor";
            this.panelCor.Padding = new System.Windows.Forms.Padding(3);
            this.panelCor.Size = new System.Drawing.Size(302, 401);
            this.panelCor.TabIndex = 0;
            // 
            // lblCpfResultado
            // 
            this.lblCpfResultado.AutoSize = true;
            this.lblCpfResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfResultado.Location = new System.Drawing.Point(70, 246);
            this.lblCpfResultado.Name = "lblCpfResultado";
            this.lblCpfResultado.Size = new System.Drawing.Size(0, 16);
            this.lblCpfResultado.TabIndex = 2;
            // 
            // lblIdadeResultado
            // 
            this.lblIdadeResultado.AutoSize = true;
            this.lblIdadeResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeResultado.Location = new System.Drawing.Point(70, 274);
            this.lblIdadeResultado.Name = "lblIdadeResultado";
            this.lblIdadeResultado.Size = new System.Drawing.Size(0, 16);
            this.lblIdadeResultado.TabIndex = 3;
            // 
            // PictureImage
            // 
            this.PictureImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureImage.Location = new System.Drawing.Point(70, 32);
            this.PictureImage.Name = "PictureImage";
            this.PictureImage.Size = new System.Drawing.Size(166, 135);
            this.PictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureImage.TabIndex = 4;
            this.PictureImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Controls.Add(this.panelCor);
            this.panel2.Location = new System.Drawing.Point(494, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 426);
            this.panel2.TabIndex = 10;
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNome.Location = new System.Drawing.Point(70, 214);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(0, 16);
            this.lblResultadoNome.TabIndex = 1;
            // 
            // CarteirinhaParque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(877, 490);
            this.Controls.Add(this.panel1);
            this.Name = "CarteirinhaParque";
            this.Text = "CarteirinhaParque";
            this.Load += new System.EventHandler(this.CarteirinhaParque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCor.ResumeLayout(false);
            this.panelCor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Panel panelCor;
        private System.Windows.Forms.Label lblCpfResultado;
        private System.Windows.Forms.PictureBox PictureImage;
        private System.Windows.Forms.Label lblIdadeResultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultadoNome;
    }
}