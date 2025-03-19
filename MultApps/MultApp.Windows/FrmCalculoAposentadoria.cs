using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class FrmCalculoAposentadoria : Form
    {
        public FrmCalculoAposentadoria()
        {
            InitializeComponent();
        }

        private void chkFem_CheckedChanged(object sender, EventArgs e)
        {
            chkFem.ForeColor = Color.DarkOrange;
            chkMasc.ForeColor = Color.DimGray;
            chkMasc.Checked = false;
        }

        private void chkMasc_CheckedChanged(object sender, EventArgs e)
        {
            chkMasc.ForeColor = Color.DarkOrange;
            chkFem.ForeColor = Color.DimGray;
            chkFem.Checked = false;
        }

       

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            var nascimento = DateTime.Parse( dateNascimento.Text);
            var hoje = DateTime.Now.Year;

            int idade = hoje -nascimento.Year ;

            var anosTrabalhados = int.Parse(tempoContribuicao.Text);

            var pontos = (idade + anosTrabalhados);

            if (chkMasc.Checked)
            {
                if (pontos >= 101)
                {
                    lblResultado2.Text = $@"Você pode dar entrada no processo de aposentadoria.";
                    
                }
                else
                {
                    lblResultado2.Text = $@"Você não compre o requisitos para se aposentar.";
                }
                
            }

            if (chkFem.Checked)
            {
                if (pontos >= 91)
                {
                    lblResultado2.Text = $@"Você pode dar entrada no processo de aposentadoria.";

                }
                else
                {
                    lblResultado2.Text = $@"Você não compre o requisitos para se aposentar.";
                }

            }
            if (chkFem.Checked && idade >= 62)
            {
                lblResultado2.Text = $@"Você pode dar entrada no processo de aposentadoria.";
            }
            else
            {
                lblResultado2.Text = $@"Você não compre o requisitos para se aposentar.";
            }

            if (chkMasc.Checked && idade >= 65)
            {
                lblResultado2.Text = $@"Você pode dar entrada no processo de aposentadoria.";
            }
            else
            {
                lblResultado2.Text = $@"Você não compre o requisitos para se aposentar.";
            }

        }

        
    }
}