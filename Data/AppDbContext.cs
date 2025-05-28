using Microsoft.EntityFrameworkCore;
using ControleFuncionario.Models;

namespace ControleFuncionario.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
                .HasKey(f => f.cpf);  

            modelBuilder.Entity<Funcionario>()
                .HasOne(f => f.cargo)
                .WithMany(c => c.Funcionarios)
                .HasForeignKey(f => f.idCargo);
        }
    }
}
