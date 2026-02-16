using Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class Context : DbContext
    {
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<Etapa> Etapas { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pensamento> Pensamentos { get; set; }

        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caixa>().HasData(
                new Caixa { Id = 1, Name = "Criar pensamento" },
                new Caixa { Id = 2, Name = "Organizar pensamentos" },
                new Caixa { Id = 3, Name = "Talvez ou depois" },
                new Caixa { Id = 4, Name = "Próximas ações" },
                new Caixa { Id = 5, Name = "Projetos" },
                new Caixa { Id = 6, Name = "Calendario" }
            );
        }
    }
}