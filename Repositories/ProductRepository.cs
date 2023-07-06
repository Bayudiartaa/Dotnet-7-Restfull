namespace WebApi.Repositories;

using Dapper;
using WebApi.Entities;
using WebApi.Helpers;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int id);
    Task Create(Product product);
    Task Update(Product product);
    Task Delete(int id);
}

public class ProductRepository : IProductRepository
{
    private DataContext _context;

    public ProductRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        using var connection = _context.CreateConnection();
        var sql = """
            SELECT * FROM Product
        """;
        return await connection.QueryAsync<Product>(sql);
    }

    public async Task<Product> GetById(int id)
    {
        using var connection = _context.CreateConnection();
        var sql = """
            SELECT * FROM Product 
            WHERE Id = @id
        """;
        return await connection.QuerySingleOrDefaultAsync<Product>(sql, new { id });
    }

    public async Task Create(Product product)
    {
        using var connection = _context.CreateConnection();
        var sql = """
            INSERT INTO Product (Name, Price, Quantity, Description)
            VALUES (@Name, @Price, @Quantity, @Description)
        """;
        await connection.ExecuteAsync(sql, product);
    }

    public async Task Update(Product product)
    {
        using var connection = _context.CreateConnection();
        var sql = """
            UPDATE Product 
            SET Name = @Name,
                Price = @Price,
                Quantity = @Quantity, 
                Description = @Description
            WHERE Id = @Id
        """;
        await connection.ExecuteAsync(sql, product);
    }

    public async Task Delete(int id)
    {
        using var connection = _context.CreateConnection();
        var sql = """
            DELETE FROM Product 
            WHERE Id = @id
        """;
        await connection.ExecuteAsync(sql, new { id });
    }
}