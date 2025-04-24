﻿using MultApps.Models.Entities;
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

    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            //Carregar o status do usuário.
            var status = new[] { "inativo", "ativo", "excluido" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltro.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 Passo pegar os dados da tela.
            //try para capturar erros de conversão de valores.
            try
            {
                //Verifica se tem campos em branco.
                if (TemCamposEmBranco())
                {
                    return;
                }


                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txtCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = CriptografiaService.Criptografar(txtSenha.Text);
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2 Passo criar o objeto de repositório.
                var usuarioRepository = new UsuarioRepository();

                // Verifica se o email já existe.
                var emailJaExiste = usuarioRepository.EmailExistente(usuario.Email);
                if (emailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                    txtEmail.Focus();
                    return;
                }

                //3 Passo chamar o método de cadastro.
                var sucesso = usuarioRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
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


        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Campo Cpf é obrigatório");
                txtCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarTodosUsuario();
        }

        private void CarregarTodosUsuario()
        {
            var usuarioRepository = new UsuarioRepository();

            var listaUsuario = usuarioRepository.ListarUsuarios();
            dataGridView1.DataSource = listaUsuario;
        }

        private void LimparCampos()
        {
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtDataCadastro.Clear();
            txtUltimoAcesso.Clear();
            cmbStatus.SelectedIndex = 1;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usuarioRepositorio = new UsuarioRepository();
            switch (cmbFiltro.SelectedIndex)
            {
                case 0:
                    CarregarTodosUsuario();
                    break;

                case 1:
                    var usuariosAtivos = usuarioRepositorio.ListarUsuariosPorStatus("ativo");
                    dataGridView1.DataSource = usuariosAtivos;
                    break;

                case 2:
                    var usuariosInativos = usuarioRepositorio.ListarUsuariosPorStatus("inativo");
                    dataGridView1.DataSource = usuariosInativos;
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var usuarioId = (int)row.Cells[0].Value;
            var usuarioRepository = new UsuarioRepository();
            var usuario  = usuarioRepository.ObterUsuarioPorId(usuarioId);

            if (usuario == null)
            {
                MessageBox.Show($"Usuario : #{usuarioId} não encontrada");
                return;
            }

            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            cmbStatus.SelectedIndex = (int)usuario.Status;
            txtUltimoAcesso.Text = usuario.DataAlteracao.ToString("dd/MM/yyyy HH:mm");
            txtDataCadastro.Text = usuario .DataCriacao.ToString("dd/MM/yyyy HH:mm");
            
            btnDeletar.Enabled = true;
            btnSalvar.Text = "Salvar alterações";
        }
    }
}
