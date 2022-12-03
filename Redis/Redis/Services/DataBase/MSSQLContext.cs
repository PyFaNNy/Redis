using Microsoft.EntityFrameworkCore;
using Redis.Models;

namespace Redis.DataBase;

public class MSSQLContext : DbContext
{
    public MSSQLContext(DbContextOptions<MSSQLContext> options) :base(options)
    {
            
    }
    
    public DbSet<Product> Products
    {
        get;
        set;
    }
}