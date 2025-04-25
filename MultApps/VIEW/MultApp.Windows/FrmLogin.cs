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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Usuário é obrigatorio");
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatoria");
                txtSenha.Focus();
                return;
            }
            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuarioPorEmail(txtUsuario.Text);

            if (usuario == null || usuario.Email != txtUsuario.Text)
            {
                MessageBox.Show("Usuário não encontrado");
                txtUsuario.Focus();
                return;
            }

            if (usuario.Status == StatusEnum.Inativo)
            {
                MessageBox.Show("O usuário esta inativo");
                txtUsuario.Focus();
                return;
            }

            var senhaConfere = CriptografiaService.Verificar(txtSenha.Text, usuario.Senha);

            if(senhaConfere)
            {
                MessageBox.Show("Usuario ou senha correto");
                
            }
            else
            {
                MessageBox.Show("Usuario e senha invalida");
            }
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe o email do seu usuário");
                txtUsuario.Focus();
                return;
            }
           var usuarioRepository= new UsuarioRepository();
           var novaSenha = CriptografiaService.Criptografar("123456");

           var senhaAtualizou = usuarioRepository.AtualizarSenha( novaSenha, txtUsuario.Text);

            if (senhaAtualizou)
            {
                MessageBox.Show("Senha atualizada com suceso. A nova senha é: 123456");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a senha");
            }
        }
    }
}
