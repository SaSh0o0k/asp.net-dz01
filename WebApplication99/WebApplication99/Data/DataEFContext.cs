using Microsoft.EntityFrameworkCore;
using WebApplication99.Data.Entities;

namespace WebApplication99.Data
{
    public class DataEFContext : DbContext
    {
        public DataEFContext(DbContextOptions<DataEFContext> options)
            : base(options) { }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
