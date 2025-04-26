using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositoryes
{
    internal class ProdutoRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";

        public bool CadastrarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto (nome, preco, descricao,estoque)
                                   VALUES(@Nome,@Preco, @Descricao, @Estoque)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Descricao", produto.Descricao);
                parametros.Add("@Estoque", produto.Estoque);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public bool ProdutoExistente(string nome)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT COUNT(*) FROM usuario WHERE nome = @Nome";
                var parametros = new DynamicParameters();
                parametros.Add("@Nome", nome);
                var resultado = db.ExecuteScalar<int>(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public DataTable ListarProduto()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          preco AS Preco, 
                                          descricao AS Descricao, 
                                          estoque AS Estoque,
                                          data_criacao AS DataCadastro,
                                          data_alteracao AS DataAlteracao
                                   FROM produto";
                var produtos = db.Query<Produto>(comandoSql).ToList();
                // Converte a lista de produto para um DataTable
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Preco", typeof(string));
                dataTable.Columns.Add("Descricao", typeof(string));
                dataTable.Columns.Add("Estoque", typeof(DateTime));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                        produto.Nome,
                        produto.Preco,
                        produto.Descricao,
                        produto.Estoque,
                        produto.dataCriacao,
                        produto.dataAlteracao);
                }
                return dataTable;
            }
        }
        public DataTable ListarProdutoPorStatus(int status)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          preco AS Preco, 
                                          descricao AS Descricao, 
                                          estoque AS Estoque,
                                          data_criacao AS DataCadastro,
                                          data_alteracao AS DataAlteracao 
                                   FROM produto
                                   WHERE status = @Status";

                var parametros = new DynamicParameters();
                parametros.Add("@Status", status);

                var produtos = db.Query<Produto>(comandoSql, parametros).ToList();
                // Converte a lista de usuários para um DataTable
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Preco", typeof(string));
                dataTable.Columns.Add("Descricao", typeof(string));
                dataTable.Columns.Add("Estoque", typeof(DateTime));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                        produto.Nome,
                        produto.Preco,
                        produto.Descricao,
                        produto.Estoque,
                        produto.dataCriacao,
                        produto.dataAlteracao);
                }
                return dataTable;
            }
        }
        public Produto ObterProdutoPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          preco AS Preco, 
                                          descricao AS Descricao, 
                                          estoque AS Estoque,
                                          data_criacao AS DataCadastro,
                                          data_alteracao AS DataAlteracao 
                                   FROM produto
                                   WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Produto>(comandoSql, parametros).FirstOrDefault();
                return resultado;

            }
        }
        public Produto ObterProdutoPorNome(string nome)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          preco AS Preco, 
                                          descricao AS Descricao, 
                                          estoque AS Estoque,
                                          data_criacao AS DataCadastro,
                                          data_alteracao AS DataAlteracao 
                                   FROM produto 
                                   WHERE nome = @Nome";
                var parametros = new DynamicParameters();
                parametros.Add("@Nome", nome);
                var resultado = db.Query<Produto>(comandoSql, parametros).FirstOrDefault();
                return resultado;

            }

        }
        
    }
}
