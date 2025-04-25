using MultApps.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class Principal : Form
    {
        public Usuario UsuarioLogado { get; set; }

        public Principal()
        {
            InitializeComponent();
        }

        public Principal (Usuario usuario)
        {
            InitializeComponent();
            UsuarioLogado = usuario;
        }

        private void cAlculadorasDeIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCalculadoraIMC();
            form.ShowDialog();
        }

        private void MDIPrincipal_Shown(object sender, EventArgs e)
        {
            var loading = new SplashSreen();
            loading.ShowDialog();
        }

        private void calculadoraDeAposentadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCalculoAposentadoria();
            form.ShowDialog();
        }

        private void sistemaDeIdentificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new CarteirinhaParque();
            form.ShowDialog();
        }

        private void fazerPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LojaAcai();
            form.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCategoria();
            form.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCadastroUsuario();
            form.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            statusLabelUsuario.Text = UsuarioLogado.Nome;
        }

      
    }
    
}
