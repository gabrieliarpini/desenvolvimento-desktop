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
    public partial class LojaAcai : Form
    {
        public LojaAcai()
        {
            InitializeComponent();
        }

        private void btnSelecionar300ml_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Pequeno (300 ml) - R$ 15,00");
        }

        private void btnSelecionar500ml_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Medio (500 ml) - R$ 20,00");
        }

        private void btnSelecionar700ml_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Grande (700 ml) - R$ 25,00");
        }

        private void btnSelecionar1L_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Familia (1 L) - R$ 35,00");
        }

        private void QntBanana_ValueChanged(object sender, EventArgs e)
        {
            listBoxComplementos.Items.Clear();

            if (QntBanana.Value > 0)
            {
                listBoxComplementos.Items.Add($"Banana - {QntBanana.Value}");
            }
        }

        private void QntMorango_ValueChanged(object sender, EventArgs e)
        {

            listBoxComplementos.Items.Clear();

            if (QntMorango.Value > 0)
            {
                listBoxComplementos.Items.Add($"Morango - {QntMorango.Value}");
            }
        }

        private void QntUva_ValueChanged(object sender, EventArgs e)
        {
            if (QntUva.Value > 0)
            {
                listBoxComplementos.Items.Add($"Uva - {QntUva.Value}");
            }
        }

        private void QntKiwi_ValueChanged(object sender, EventArgs e)
        {
            if (QntKiwi.Value > 0)
            {
                listBoxComplementos.Items.Add($"Kiwi - {QntKiwi.Value}");
            }
        }

        private void QntGranola_ValueChanged(object sender, EventArgs e)
        {
            if (QntGranola.Value > 0)
            {
                listBoxComplementos.Items.Add($"Granola - {QntGranola.Value}");
            }
        }

        private void QntGotasChoco_ValueChanged(object sender, EventArgs e)
        {
            if (QntGotasChoco.Value > 0)
            {
                listBoxComplementos.Items.Add($"GotasChoco - {QntGotasChoco.Value}");
            }
        }

        private void QntLeiteEmPo_ValueChanged(object sender, EventArgs e)
        {
            if (QntLeiteEmPo.Value > 0)
            {
                listBoxComplementos.Items.Add($"LeiteEmPo - {QntLeiteEmPo.Value}");
            }
        }

        private void QntOvomaltine_ValueChanged(object sender, EventArgs e)
        {
            if (QntOvomaltine.Value > 0)
            {
                listBoxComplementos.Items.Add($"Ovomaltine - {QntOvomaltine.Value}");
            }
        }

        private void QntCobertMorango_ValueChanged(object sender, EventArgs e)
        {
            if (QntCobertMorango.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Morango - {QntCobertMorango.Value}");
            }
        }

        private void QntCobertKiwi_ValueChanged(object sender, EventArgs e)
        {

            if (QntCobertKiwi.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Kiwi - {QntCobertKiwi.Value}");
            }
        }

        private void QntCobertAbacaxi_ValueChanged(object sender, EventArgs e)
        {
            if (QntCobertAbacaxi.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Abacaxi - {QntCobertAbacaxi.Value}");
            }
        }

        private void QntCobertChoco_ValueChanged(object sender, EventArgs e)
        {
            if (QntCobertChoco.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Chocolate - {QntCobertChoco.Value}");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (listBoxComplementos.Items.Count >= 4)
            {
                MessageBox.Show("O limite de 4 itens foi atingido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
