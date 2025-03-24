using Dapper;
using Microsoft.Data.SqlClient;
using ProductWebApp.Models;

namespace ProductWebApp.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly string? _connectionString;

        public ProductRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<Product>("SELECT * FROM Products");
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryFirstOrDefaultAsync<Product>("SELECT * FROM Products WHERE Id = @Id", new { Id = id });
        }

        public async Task<int> AddAsync(Product product)
        {
            using var connection = new SqlConnection(_connectionString);
            string sql = "INSERT INTO Products (Name, Price, Description) VALUES (@Name, @Price, @Description); SELECT CAST(SCOPE_IDENTITY() as int)";
            return await connection.ExecuteScalarAsync<int>(sql, product);
        }

        public async Task UpdateAsync(Product product)
        {
            using var connection = new SqlConnection(_connectionString);
            string sql = "UPDATE Products SET Name = @Name, Price = @Price, Description = @Description WHERE Id = @Id";
            await connection.ExecuteAsync(sql, product);
        }

        public async Task DeleteAsync(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync("DELETE FROM Products WHERE Id = @Id", new { Id = id });
        }
    }
}
