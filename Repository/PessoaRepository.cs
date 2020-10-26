using System.Collections.Generic;
using webapi.Model;
using MySql.Data.MySqlClient;
using Dapper;

namespace webapi.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Pessoa> GetAll()
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Pessoa>(
                    "SELECT Codigo, Nome, Endereco FROM Pessoa ORDER BY Nome ASC"
                );
            }
        }
    }
}