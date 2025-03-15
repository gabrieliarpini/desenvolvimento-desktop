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
        public Principal()
        {
            InitializeComponent();
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
    }
}
