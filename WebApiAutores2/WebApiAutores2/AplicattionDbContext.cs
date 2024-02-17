using Microsoft.EntityFrameworkCore;
using WebApiAutores2.Modelos;

namespace WebApiAutores2
{
    public class AplicattionDbContext: DbContext
    {
        public AplicattionDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }

    }
}
