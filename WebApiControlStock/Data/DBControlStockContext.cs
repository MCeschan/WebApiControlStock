using Microsoft.EntityFrameworkCore;
using WebApiControlStock.Models;

namespace WebApiControlStock.Data
{
    public class DBControlStockContext: DbContext
    {
        public DBControlStockContext(DbContextOptions<DBControlStockContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
