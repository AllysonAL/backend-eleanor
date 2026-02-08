using Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class Context : DbContext
    {
        public DbSet<Etapa> Etapas { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pensamento> Pensamentos { get; set; }

        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
        }
    }
}