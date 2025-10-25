using Dapper;
using DapperDemo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;

namespace DapperDemo.Repositories
{
    public class StudentRepository
    {
        private readonly string _connectionString;
        public StudentRepository(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        private IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            using var connection = CreateConnection();
            return await connection.QueryAsync<Student>("Select * from Students");
        }
        public async Task<Student?> GetByIdAsync(int id)
        {
            using var connection = CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<Student>(
                "SELECT * FROM Students WHERE Id = @Id", new { Id = id });
        }   
        public async Task<int> CreateAsync(Student student)
        {
            using var connection= CreateConnection();
            var sql = "Insert Into Students (Name, Age, Email) VALUES (@Name, @Age, @Email)";
            return await connection.ExecuteAsync(sql, student);

        }
        public async Task<int> UpdateAsync(Student student)
        {
            using var connection =CreateConnection();
            var sql = "Update Students SET Name=@Name,Age=@Age,Email=@Email WHERE Id=@Id";
            return await connection.ExecuteAsync(sql, student);
        }
        public async Task<int> DeleteAsync (int id)
        {
            using var connection = CreateConnection();
            var sql = "Delete From Students Where Id=@Id";
            return await connection.ExecuteAsync(sql, new { Id = id });
        }

    }
}
