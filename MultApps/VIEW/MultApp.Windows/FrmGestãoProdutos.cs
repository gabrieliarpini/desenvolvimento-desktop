using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositoryes;
using MultApps.Models.Services;
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
    public partial class FrmGestãoProdutos : Form
    {
        public FrmGestãoProdutos()
        {
            InitializeComponent();
        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(cmbCategoria.Text))
            {
                MessageBox.Show("Campo Categoria é obrigatório");
                cmbCategoria.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Campo Descricao é obrigatório");
                txtDescricao.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Campo Preco é obrigatório");
                txtPreco.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("Campo Estoque é obrigatório");
                txtEstoque.Focus();
                return true;
            }

            return false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se tem campos em branco.
                if (TemCamposEmBranco())
                {
                    return;
                }


                var produto = new Produto();
                produto.Nome = txtNome.Text;
                produto.Categoria = cmbCategoriaEscolha.Text;
                produto.Descricao = txtDescricao.Text;
                produto.Preco = txtPreco.Text;
                produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2 Passo criar o objeto de repositório.
                var usuarioRepository = new UsuarioRepository();

                // Verifica se o email já existe.
                var emailJaExiste = usuarioRepository.EmailExistente(produto.Email);
                if (emailJaExiste)
                {
                    MessageBox.Show($"O email {produto.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }

                //3 Passo chamar o método de cadastro.
                var sucesso = usuarioRepository.CadastrarUsuario(produto);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {produto.Nome} cadastrado com sucesso!");
                    CarregarTodosUsuario();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {usuario.Nome}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            rbAtivo.ForeColor = Color.Blue;
            rbAtivo.ForeColor = Color.DimGray;
            rbAtivo.Checked = false;
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            rbInativo.ForeColor = Color.Blue;
            rbInativo.ForeColor = Color.DimGray;
            rbInativo.Checked = false;
        }
    }
}
