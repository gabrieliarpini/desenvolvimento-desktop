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
    public partial class frmCalculadoraIMC : Form
    {
        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.DimGray;
            chkAdulto.Checked = false;

            lblIdade.Text = "Abaixo dos 19";

            
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DimGray;
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima dos 19";
        }

        private void chkMasc_CheckedChanged(object sender, EventArgs e)
        {
            chkMasc.ForeColor = Color.DarkOrange;
            chkFem.ForeColor = Color.DimGray;
            chkFem.Checked = false;

        }

        private void chkFem_CheckedChanged(object sender, EventArgs e)
        {
            chkFem.ForeColor = Color.DarkOrange;
            chkMasc.ForeColor = Color.DimGray;
            chkMasc.Checked = false;

        }
    }
}
