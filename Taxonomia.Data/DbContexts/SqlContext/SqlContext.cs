using Microsoft.EntityFrameworkCore;
using Taxonomia.Domain.ClasseEntity;
using Taxonomia.Domain.DominioEntity;
using Taxonomia.Domain.EspecieEntity;
using Taxonomia.Domain.FamiliaEntity;
using Taxonomia.Domain.FiloEntity;
using Taxonomia.Domain.GeneroEntity;
using Taxonomia.Domain.OrdemEntity;
using Taxonomia.Domain.OrganismoEntity;
using Taxonomia.Domain.ReinoEntity;

namespace Taxonomia.Data.DbContexts.SqlContext
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        { }

        public DbSet<Dominio> Dominio { get; set; }
        public DbSet<Reino> Reino { get; set; }
        public DbSet<Filo> Filo { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Ordem> Ordem { get; set; }
        public DbSet<Familia> Familia { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Organismo> Organismo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=Taxonomia;Integrated Security=SSPI;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dominio>().ToTable("Dominio");
            modelBuilder.Entity<Reino>().ToTable("Reino");
            modelBuilder.Entity<Filo>().ToTable("Filo");
            modelBuilder.Entity<Classe>().ToTable("Classe");
            modelBuilder.Entity<Ordem>().ToTable("Ordem");
            modelBuilder.Entity<Familia>().ToTable("Familia");
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<Especie>().ToTable("Especie");
            modelBuilder.Entity<Organismo>().ToTable("Organismo");

            modelBuilder.Entity<Dominio>()
                .HasMany(r => r.Reino)
                .WithOne(f => f.Dominio)
                .HasForeignKey(f => f.DominioId);

            modelBuilder.Entity<Reino>()
                .HasMany(r => r.Filo)
                .WithOne(f => f.Reino)
                .HasForeignKey(f => f.ReinoId);

            modelBuilder.Entity<Filo>()
                .HasMany(f => f.Classe)
                .WithOne(c => c.Filo)
                .HasForeignKey(c => c.FiloId);

            modelBuilder.Entity<Classe>()
                .HasMany(c => c.Ordem)
                .WithOne(o => o.Classe)
                .HasForeignKey(o => o.ClasseId);

            modelBuilder.Entity<Ordem>()
                .HasMany(o => o.Familia)
                .WithOne(f => f.Ordem)
                .HasForeignKey(f => f.OrdemId);

            modelBuilder.Entity<Familia>()
                .HasMany(f => f.Genero)
                .WithOne(g => g.Familia)
                .HasForeignKey(g => g.FamiliaId);

            modelBuilder.Entity<Genero>()
                .HasMany(g => g.Especie)
                .WithOne(e => e.Genero)
                .HasForeignKey(e => e.GeneroId);

            modelBuilder.Entity<Especie>()
                .HasMany(e => e.Organismo)
                .WithOne(o => o.Especie)
                .HasForeignKey(o => o.EspecieId);
        }
    }
}
