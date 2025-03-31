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
            CalcularTotal();
        }

        private void btnSelecionar500ml_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Medio (500 ml) - R$ 20,00");
            CalcularTotal();
        }

        private void btnSelecionar700ml_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Grande (700 ml) - R$ 25,00");
            CalcularTotal();
        }

        private void btnSelecionar1L_Click(object sender, EventArgs e)
        {
            listBoxTamanho.Items.Add("Açaí Familia (1 L) - R$ 35,00");
            CalcularTotal();
        }

        private void QntBanana_ValueChanged(object sender, EventArgs e)
        {
           
            if (LimitarItens())
            {
                return;
            }

            if (QntBanana.Value > 0)
            {
                listBoxComplementos.Items.Add($"Banana - {QntBanana.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Banana - {QntBanana.Value + 1}");
            }
        }

        private void QntMorango_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }
            if (QntMorango.Value > 0)
            {
                listBoxComplementos.Items.Add($"Morango - {QntMorango.Value}");
            }
            else
            {
              listBoxComplementos.Items.Remove($"Morango - {QntMorango.Value + 1}");
            }
        }

        private void QntUva_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }
            if (QntUva.Value > 0)
            {
                listBoxComplementos.Items.Add($"Uva - {QntUva.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Uva - {QntUva.Value + 1}");
            }
        }

        private void QntKiwi_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }
            if (QntKiwi.Value > 0)
            {
                listBoxComplementos.Items.Add($"Kiwi - {QntKiwi.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Kiwi - {QntKiwi.Value + 1}");
            }

        }

        private void QntGranola_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }
            if (QntGranola.Value > 0)
            {
                listBoxComplementos.Items.Add($"Granola - {QntGranola.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Granola - {QntGranola.Value + 1}");
            }

        }

        private void QntGotasChoco_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }

            if (QntGotasChoco.Value > 0)
            {
                listBoxComplementos.Items.Add($"GotasChoco - {QntGotasChoco.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"GotasChoco - {QntGotasChoco.Value + 1}");
            }
        }

        private void QntLeiteEmPo_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }
            if (QntLeiteEmPo.Value > 0)
            {
                listBoxComplementos.Items.Add($"LeiteEmPo - {QntLeiteEmPo.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"LeiteEmPo - {QntLeiteEmPo.Value + 1}");
            }
        }

        private void QntOvomaltine_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens())
            {
                return;
            }
            if (QntOvomaltine.Value > 0)
            {
                listBoxComplementos.Items.Add($"Ovomaltine - {QntOvomaltine.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Ovomaltine - {QntOvomaltine.Value + 1}");
            }
        }

        private void QntCobertMorango_ValueChanged(object sender, EventArgs e)
        {

            if (LimitarItens2())
            {
                return;
            }

            if (LimitarItens())
            {
                return;
            }
            if (QntCobertMorango.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Morango - {QntCobertMorango.Value}");
            }
            else
            {
                listBoxCoberturas.Items.Remove($"Cobertura de Morango - {QntCobertMorango.Value + 1}");
            }
        }

        private void QntCobertKiwi_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItens2())
            {
                return;
            }

            if (QntCobertKiwi.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Kiwi - {QntCobertKiwi.Value}");
            }
            else
            {
                listBoxCoberturas.Items.Remove($"Cobertura de Kiwi - {QntCobertKiwi.Value + 1}");
            }
        }

        private void QntCobertAbacaxi_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItens2())
            {
                return;
            }
            if (QntCobertAbacaxi.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Abacaxi - {QntCobertAbacaxi.Value}");
            }
            else
            {
                listBoxCoberturas.Items.Remove($"Cobertura de Abacaxi - {QntCobertAbacaxi.Value + 1}");
            }
        }

        private void QntCobertChoco_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarItens2())
            {
                return;
            }
            if (QntCobertChoco.Value > 0)
            {
                listBoxCoberturas.Items.Add($"Cobertura de Chocolate - {QntCobertChoco.Value}");
            }
            else
            {
                listBoxCoberturas.Items.Remove($"Cobertura de Chocolate - {QntCobertChoco.Value + 1}");
            }
        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            lblSenha.Text = GerarSenhaCurta();
        }

        private string GerarSenhaCurta()
        {
            DateTime agora = DateTime.Now;

           
            string senhaComSegundos = $"{agora:MMddHHmmss}";
            return senhaComSegundos;
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (string item in listBoxTamanho.Items)
            {
                if (item.Contains("300 ml")) total += 15.00m;
                else if (item.Contains("500 ml")) total += 20.00m;
                else if (item.Contains("700 ml")) total += 25.00m;
                else if (item.Contains("1 L")) total += 35.00m;
            }

           
            lblTotal.Text = $"Total: R$ {total:F2}";
        }

       
        private bool LimitarItens()
        {
            if(listBoxComplementos.Items.Count > 3)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }
        private bool LimitarItens2()
        {
            if (listBoxCoberturas.Items.Count > 2)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }

      
    }
}
