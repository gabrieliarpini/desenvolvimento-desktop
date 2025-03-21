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
    public partial class CarteirinhaParque : Form
    {
        public CarteirinhaParque()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var cpfDigitado= textBox2.Text;
            var nome = textBox1.Text;
            var nascimento = DateTime.Parse(dataNascimento.Text);
            var hoje = DateTime.Now.Year;

            int idade = hoje - nascimento.Year;

            lblIdadeResultado.Text =$" {idade.ToString()} Anos";
            lblResultadoNome.Text = nome;

            string cpf = textBox2.Text;

            string cpfOfuscado = OfuscarCPF(cpf);

            lblCpfResultado.Text = cpfOfuscado;

            if (idade <= 12)
            {
                panelCor.BackColor = Color.LightBlue;
                PictureImage.Load("https://cdn-icons-png.freepik.com/256/16776/16776929.png");
            }
            else if (idade <= 29)
            {
                panelCor.BackColor = Color.Yellow;
                PictureImage.Load("https://cdn-icons-png.freepik.com/256/4852/4852437.png");
            }
            else if(idade <= 59)
            {
                panelCor.BackColor = Color.DarkViolet;
                PictureImage.Load("https://cdn-icons-png.freepik.com/256/4547/4547050.png");
            }
            else if (idade >=  60)
            {
                panelCor.BackColor = Color.MediumSeaGreen;
                PictureImage.Load("https://cdn-icons-png.freepik.com/256/10448/10448170.png");
            }


        }
        private string OfuscarCPF(string cpf)
        {
            // Garante que o CPF tem 11 caracteres
            if (cpf.Length != 11)
                return "CPF inválido";

            // Pega os números do meio
            string parte1 = cpf.Substring(3, 3);
            string parte2 = cpf.Substring(6, 3);

            // Retorna o CPF ofuscado
            return $"***.{parte1}.{parte2}.***";
        }

        private void CarteirinhaParque_Load(object sender, EventArgs e)
        {

        }
    }
}




