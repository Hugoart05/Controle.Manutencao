using ControleManutencaoPreventiva.Context.Configurations;
using ControleManutencaoPreventiva.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleManutencaoPreventiva.Context
{
    public class PrevContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }

        public DbSet<Condominio> Condominio { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<RangeIps> Ips { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CondominioConfiguration());
            modelBuilder.ApplyConfiguration(new EquipamentoConfiguration());
            modelBuilder.ApplyConfiguration(new RangeIpsConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new CondominioConfiguration());
        }
    }
}
