﻿using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultApps.Models.Repositoryes
{
    public class CategoriaRepository


    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";


        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO categoria (nome, status)
                                   VALUES(@Nome, @Status )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection((ConnectionString)))
            {
                var comandoSql = @"UPDATE categoria 
                                  SET nome= @Nome, status = @Status  
                                  WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", categoria.Id);
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status.ToString().ToLower());

                var resposta = db.Execute(comandoSql,parametros);
                return resposta > 0;

                
            }
        }

        public bool DeletarCategoria(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM categoria WHERE id= @Id ";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql,parametros);
                return resultado > 0;
            }
        }

        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id , nome, data_criacao AS DataCriacao, data_alteracao AS DataAlteracao, status
                                   FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;

            }
        }

        public Categoria ObterCategoriaPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id , nome, data_criacao AS DataCriacao, data_alteracao AS DataAlteracao, status
                                   FROM categoria WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }

        }
    }
}

