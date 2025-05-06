using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositoryes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class FrmGestãoProdutos : Form
    {
        public FrmGestãoProdutos()
        {
            InitializeComponent();
            //Carregar o status do usuário.
            var statusFiltro = new[] { "inativo", "ativo" };
            cmbStatus.Items.AddRange(statusFiltro);

            cmbStatus.SelectedIndex = 1;
            cmbStatus.SelectedIndex = 0;

        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(cmbCategoriaEscolha.Text))
            {
                MessageBox.Show("Campo Categoria é obrigatório");
                cmbCategoriaEscolha.Focus();
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
                string statusFiltro;

                if (rbAtivo.Checked)
                {
                    statusFiltro = "Ativo";
                }
                else if (rbInativo.Checked)
                {
                    statusFiltro = "Inativo";
                }
                else
                {
                    statusFiltro = "Não selecionado";
                }

                //Verifica se tem campos em branco.
                if (TemCamposEmBranco())
                {
                    return;
                }

               
               
                var categoriaSelecionada = (Categoria)cmbCategoriaEscolha.SelectedItem;

                var produto = new Produto();
                produto.Nome = txtNome.Text;
                produto.Estoque = txtEstoque.Text;
                produto.CategoriaId = categoriaSelecionada.Id;
                produto.Descricao = txtDescricao.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2 Passo criar o objeto de repositório.
                var produtoRepository = new ProdutoRepository();

                // Verifica se o email já existe.
                var nomeJaExiste = produtoRepository.ProdutoExistente(produto.Nome);
                if (nomeJaExiste)
                {
                    MessageBox.Show($"O produto {produto.Nome} já está cadastrado.");
                    txtNome.Focus();
                    return;
                }

                //3 Passo chamar o método de cadastro.
                var sucesso = produtoRepository.CadastrarProduto(produto);

                if (sucesso)
                {
                    MessageBox.Show($"Produto {produto.Nome} cadastrado com sucesso!");
                    CarregarTodosProdutos();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o produto {produto.Nome}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
     
        private void FrmGestãoProdutos_Load(object sender, EventArgs e)
        {
            var produtos = new CategoriaRepository();
            var preencheCombox = produtos.ObterTodasCategoria();

            
            cmbCategoriaEscolha.DisplayMember = "Nome";
            cmbCategoriaEscolha.ValueMember = "Id";
            cmbCategoriaEscolha.DataSource = preencheCombox;

            CarregarTodosProdutos();
            
        }

        private void CarregarTodosProdutos()
        {
            var produtosRepository = new ProdutoRepository();
            var listaDeProdutos = produtosRepository.ListarTodosProdutos();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                MinimumWidth = 100,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome do Produto",
                MinimumWidth = 300,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Preco",
                HeaderText = "Preço",
                MinimumWidth = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } 
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de Cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" },
                MinimumWidth = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" },
                MinimumWidth = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            });

            dataGridView1.DataSource = listaDeProdutos;

        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var produtoId = (int)row.Cells[0].Value;


            var produtoRepository = new ProdutoRepository();
            var produto = produtoRepository.ObterProdutoPorId(produtoId);

            if (produto == null)
            {
                MessageBox.Show($"Produto: #{produtoId} não encontrada");
                return;
            }


            var categoriaSelecionada = (Categoria)cmbCategoriaEscolha.SelectedItem;
            produto.CategoriaId = categoriaSelecionada.Id;

            produto.Nome = txtNome.Text;
            produto.CategoriaId = categoriaSelecionada.Id;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = Convert.ToDecimal(txtPreco.Text);
            produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

            btnSalvar.Text = "Salvar alterações";

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

        private void cmbStatusFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoRepositorio = new ProdutoRepository();
            switch (cmbStatus.SelectedIndex)
            {
                case 0:
                    CarregarTodosProdutos();
                    break;

                case 1:
                    var produtosAtivos = produtoRepositorio.ListarProdutoPorStatus(1);
                    dataGridView1.DataSource = produtosAtivos;
                    break;

                case 2:
                    var produtoInativos = produtoRepositorio.ListarProdutoPorStatus(0);
                    dataGridView1.DataSource = produtoInativos;
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                if (e.Value != null && e.Value is StatusEnum status)
                {
                    switch (status)
                    {
                        case StatusEnum.Inativo:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case StatusEnum.Ativo:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case StatusEnum.Excluido:
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }

       
    }
}

