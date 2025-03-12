using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            lblImcAdulto.Text = "Z IMC para Criança";

            label6.Visible = true;
            cmbIdade.Visible = true;



        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DimGray;
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima dos 19";

            lblImcAdulto.Text = "IMC para Adulto";

            label6.Visible = false;
            cmbIdade.Visible = false;
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


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (chkAdulto.Checked && chkMasc.Checked)
            {
                #region Adulto Masculino 




                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";



                if (imc <= 18.5)
                {

                    lblResultado.Text = $@"{textoBase} abaixo do normal.";
                    pictureBox1.Load(ImcImagem.MascAbaixoDoNormal);
                }

                else if (imc < 24.9)
                {
                    lblResultado.Text = $@"{textoBase} normal.";
                    pictureBox1.Load(ImcImagem.MascNormal);
                }

                else if (imc < 29.9)
                {
                    lblResultado.Text = $@"{textoBase} sobrepeso.";
                    pictureBox1.Load(ManipuladorDeImagem("sobrepeso"));
                }

                else if (imc < 34.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 1.";
                    pictureBox1.Load(ManipuladorDeImagem("obesidade grau 1"));
                }

                else if (imc < 39.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 2.";
                    pictureBox1.Load(ManipuladorDeImagem("obesidade grau 2"));
                }

                else
                {
                    lblResultado.Text = $@"{textoBase} é obesidade grau 3.";
                    pictureBox1.Load(ManipuladorDeImagem("obesidade grau 3"));
                }

                #endregion
            }

            if (chkAdulto.Checked && chkFem.Checked)
            {
                #region Adulto Feminino 

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";



                if (imc <= 18.5)
                {

                    lblResultado.Text = $@"{textoBase} abaixo do normal.";
                    pictureBox1.Load("https://abeso.org.br/wp-content/uploads/2019/12/imc_m_06.png");
                }

                else if (imc < 24.9)
                {
                    lblResultado.Text = $@"{textoBase} normal.";
                    pictureBox1.Load("https://abeso.org.br/wp-content/uploads/2019/12/imc_m_05.png");
                }

                else if (imc < 29.9)
                {
                    lblResultado.Text = $@"{textoBase} sobrepeso.";
                    pictureBox1.Load("https://abeso.org.br/wp-content/uploads/2019/12/imc_m_04.png");
                }

                else if (imc < 34.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 1.";
                    pictureBox1.Load("https://abeso.org.br/wp-content/uploads/2019/12/imc_m_03.png");
                }

                else if (imc < 39.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 2.";
                    pictureBox1.Load("https://abeso.org.br/wp-content/uploads/2019/12/imc_m_02.png");
                }

                else
                {
                    lblResultado.Text = $@"{textoBase} é obesidade grau 3.";
                    pictureBox1.Load("https://abeso.org.br/wp-content/uploads/2019/12/imc_m_01.png");
                }
                #endregion
            }

            if(chkCrianca.Checked &&  chkMasc.Checked)
            {
                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";


            }


        }

        private string ManipuladorDeImagem(string grau )
        {
            switch (grau)
            {
                case "abaixo do normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_06.png";

                case "normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_05.png";

                case "sobrepeso":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_04.png";

                case "obesidade grau 1":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_03.png";

                case "obesidade grau 2":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_02.png";

                case "obesidade grau 3":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_01.png";

                default:"";

            }
        }string 
    }
}
