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
                    pictureBox1.Load(ImcImagem.MascSobrepeso);
                }

                else if (imc < 34.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 1.";
                    pictureBox1.Load(ImcImagem.FemObesidadeGrau1);
                }

                else if (imc < 39.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 2.";
                    pictureBox1.Load(ImcImagem.FemObesidadeGrau2);
                }

                else
                {
                    lblResultado.Text = $@"{textoBase} é obesidade grau 3.";
                    pictureBox1.Load(ImcImagem.FemObesidadeGrau3);
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
                    pictureBox1.Load(ImcImagem.FemAbaixoDoNormal);
                }

                else if (imc < 24.9)
                {
                    lblResultado.Text = $@"{textoBase} normal.";
                    pictureBox1.Load(ImcImagem.FemNormal);
                }

                else if (imc < 29.9)
                {
                    lblResultado.Text = $@"{textoBase} sobrepeso.";
                    pictureBox1.Load(ImcImagem.FemSobrepeso);
                }

                else if (imc < 34.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 1.";
                    pictureBox1.Load(ImcImagem.FemObesidadeGrau1);
                }

                else if (imc < 39.9)
                {
                    lblResultado.Text = $@"{textoBase} obesidade grau 2.";
                    pictureBox1.Load(ImcImagem.FemObesidadeGrau2);
                }

                else
                {
                    lblResultado.Text = $@"{textoBase} é obesidade grau 3.";
                    pictureBox1.Load(ImcImagem.FemObesidadeGrau3);
                }
                #endregion
            }

            if(chkCrianca.Checked)
            {
                #region Crianca

                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                var imc = peso / (altura * altura);
                var textoBase = $@"Meu IMC: {imc:N2} é";
                var coisa= cmbIdade.SelectedIndex;

                if (cmbIdade.SelectedIndex == 0 )
                {
                   if (imc < 14.9)
                    {
                        lblResultado.Text = $@"{textoBase} abaixo do normal.";
                        pictureBox1.Load(ImcImagem.CriancaAbaixoDoNormal);
                    }
                   else if(imc <= 17.9)
                    {
                        lblResultado.Text = $@"{textoBase} normal.";
                        pictureBox1.Load(ImcImagem.CriancaNormal);
                    }
                    else if(imc <= 19.9)
                    {
                        lblResultado.Text = $@"{textoBase} sobrepeso.";
                        pictureBox1.Load(ImcImagem.CriancaSobrepeso);
                    }
                   else if (imc > 20.0 )
                    {
                        lblResultado.Text = $@"{textoBase} obesidade.";
                        pictureBox1.Load(ImcImagem.CriancaObesidade);
                    }
                   
                }
                else if (cmbIdade.SelectedIndex == 1)
                {

                    if (imc < 15.5)
                    {
                        lblResultado.Text = $@"{textoBase} abaixo do normal.";
                        pictureBox1.Load(ImcImagem.CriancaAbaixoDoNormal);
                    }
                    else if (imc <= 18)
                    {
                        lblResultado.Text = $@"{textoBase} normal.";
                        pictureBox1.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 20)
                    {
                        lblResultado.Text = $@"{textoBase} sobrepeso.";
                        pictureBox1.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc > 20.0)
                    {
                        lblResultado.Text = $@"{textoBase} obesidade.";
                        pictureBox1.Load(ImcImagem.CriancaObesidade);
                    }
                }
                else if (cmbIdade.SelectedIndex == 2)
                {

                    if (imc < 16.0)
                    {
                        lblResultado.Text = $@"{textoBase} abaixo do normal.";
                        pictureBox1.Load(ImcImagem.CriancaAbaixoDoNormal);
                    }
                    else if (imc <= 19)
                    {
                        lblResultado.Text = $@"{textoBase} normal.";
                        pictureBox1.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 21)
                    {
                        lblResultado.Text = $@"{textoBase} sobrepeso.";
                        pictureBox1.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc > 21)
                    {
                        lblResultado.Text = $@"{textoBase} obesidade.";
                        pictureBox1.Load(ImcImagem.CriancaObesidade);
                    }
                }
                else if(cmbIdade.SelectedIndex == 3)
                {

                    if (imc < 17.0)
                    {
                        lblResultado.Text = $@"{textoBase} abaixo do normal.";
                        pictureBox1.Load(ImcImagem.CriancaAbaixoDoNormal);
                    }
                    else if (imc <= 24.9)
                    {
                        lblResultado.Text = $@"{textoBase} normal.";
                        pictureBox1.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc <= 29.9)
                    {
                        lblResultado.Text = $@"{textoBase} sobrepeso.";
                        pictureBox1.Load(ImcImagem.CriancaSobrepeso);
                    }
                    else if (imc > 30)
                    {
                        lblResultado.Text = $@"{textoBase} obesidade.";
                        pictureBox1.Load(ImcImagem.CriancaObesidade);
                    }
                }
            }
                

              


                #endregion


        }

        private void frmCalculadoraIMC_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

       
}

