using Microsoft.EntityFrameworkCore;
namespace LO2P02_2021GS650_2020MP_603.Models
{
    public class usuariosDbContext: DbContext
    {
        public usuariosDbContext(DbContextOptions<usuariosDbContext> options) : base(options) { }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<puestos> puestos { get; set; }
    }
}
