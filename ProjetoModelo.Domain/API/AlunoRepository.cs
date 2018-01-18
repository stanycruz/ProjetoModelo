using ProjetoModelo.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Concrete;
using ProjetoModelo.Domain.Concrete.Sql;
using Dapper;
using System;

namespace ProjetoModelo.Domain.API
{
    /// <summary>
    /// Classe de inserção, atualização e exclusão do registro de alunos
    /// </summary>
    public class AlunoRepository : IAlunoRepository
    {
        /// <summary>
        /// Lista todos os alunos
        /// </summary>
        public IEnumerable<Aluno> Alunos
        {
            get
            {
                var sql = SqlAluno.Aluno_Select;

                using (var connection = My.ConnectionFactory())
                {
                    connection.Open();

                    var alunos = connection.Query<Aluno>(sql).ToList();
                    return alunos;
                }
            }
        }

        /// <summary>
        /// Seleciona o aluno à partir do seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Aluno</returns>
        public Aluno GetAluno(int id)
        {
            var sql = SqlAluno.Aluno_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var aluno = connection.QueryFirstOrDefault<Aluno>(sql, new { Id = id });
                return aluno;
            }
        }

        /// <summary>
        /// Seleciona o aluno à partir do seu Id e retorna em uma lista para o relatório
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Aluno> GetAlunoReport(int id)
        {
            var sql = SqlAluno.Aluno_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var report = connection.Query<Aluno>(sql, new { Id = id }).ToList();
                return report;
            }
        }

        /// <summary>
        /// Insere um novo registro de aluno
        /// </summary>
        /// <param name="aluno">Aluno</param>
        public void InsertAluno(Aluno aluno)
        {
            var sql = SqlAluno.Aluno_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new
                {
                    DataCadastro = DateTime.Now,
                    Nome = aluno.Nome,
                    Endereco = aluno.Endereco,
                    Bairro = aluno.Bairro,
                    Cep = aluno.Cep,
                    Cidade = aluno.Cidade,
                    Uf = aluno.Uf,
                    Fone1 = aluno.Fone1,
                    Fone2 = aluno.Fone2,
                    Sexo = aluno.Sexo,
                    Cpf = aluno.Cpf,
                    Rg = aluno.Rg,
                    Nascimento = aluno.Nascimento,
                    Idade = aluno.Idade,
                    Email = aluno.Email,
                    EstadoCivil = aluno.EstadoCivil,
                    Profissao = aluno.Profissao,
                    Empresa = aluno.Empresa,
                    Debito = aluno.Debito,
                    Objetivo = aluno.Objetivo,
                    Matriculado = (Convert.ToBoolean(aluno.Matriculado) ? "S" : "N")
                });
            }
        }

        /// <summary>
        /// Atualiza os dados do aluno
        /// </summary>
        /// <param name="aluno">Aluno</param>
        public void UpdateAluno(Aluno aluno)
        {
            var sql = SqlAluno.Aluno_Update;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new
                {
                    Id = aluno.Id,
                    Nome = aluno.Nome,
                    Endereco = aluno.Endereco,
                    Bairro = aluno.Bairro,
                    Cep = aluno.Cep,
                    Cidade = aluno.Cidade,
                    Uf = aluno.Uf,
                    Fone1 = aluno.Fone1,
                    Fone2 = aluno.Fone2,
                    Sexo = aluno.Sexo,
                    Cpf = aluno.Cpf,
                    Rg = aluno.Rg,
                    Nascimento = aluno.Nascimento,
                    Idade = aluno.Idade,
                    Email = aluno.Email,
                    EstadoCivil = aluno.EstadoCivil,
                    Profissao = aluno.Profissao,
                    Empresa = aluno.Empresa,
                    Debito = aluno.Debito,
                    Objetivo = aluno.Objetivo,
                    Matriculado = (Convert.ToBoolean(aluno.Matriculado) ? "S" : "N")
                });
            }
        }

        /// <summary>
        /// Exclui o registro do aluno
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAluno(int id)
        {
            var sql = SqlAluno.Aluno_Delete;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new { Id = id });
            }
        }
    }
}
