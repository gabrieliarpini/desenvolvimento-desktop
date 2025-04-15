using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repositoryes
{
    public class UsuarioRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";


        public bool CadastrarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario (nome,cpf,senha,email,data_criacao,data_Alteracao, status)
                                   VALUES(@Nome,@Cpf,@Senha,@Email,@Data_criacao,@Data_Alteracao @Status )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Senha", usuario.Senha);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Data_Criacao", usuario.DataCriacao);
                parametros.Add("@Data_Alteracao", usuario.DataAlteracao);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection((ConnectionString)))
            {
                var comandoSql = @"UPDATE usuario
                                  SET nome= @Nome, email = @Email, cpf = @Cpf, senha = @Senha,  status = @Status 
                                  WHERE id = @Id";


                var parametros = new DynamicParameters();
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Senha", usuario.Senha);
                parametros.Add("@Status", usuario.Status.ToString().ToLower());

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;


            }
        }

        public bool DeletarUsuario (int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM usuario WHERE id= @Id ";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id , nome, cpf, email,senha, data_criacao AS DataCriacao, data_alteracao AS DataAlteracao, status
                                   FROM usuario";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;

            }
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id , nome, cpf, email,senha, data_criacao AS DataCriacao, data_alteracao AS DataAlteracao, status
                                   FROM usuario WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }

        }
    }
}

