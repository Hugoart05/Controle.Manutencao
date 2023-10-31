using ControleManutencaoPreventiva.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleManutencaoPreventiva.Context.Configurations
{
    public class CondominioConfiguration : IEntityTypeConfiguration<Condominio>
    {
        public void Configure(EntityTypeBuilder<Condominio> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder.ToTable("condominio");
            builder
                .HasMany(x => x.Equipamentos)
                .WithOne(x => x.Condominio);
            builder
                .HasOne(x => x.Endereco)
                .WithOne(x => x.Condominio);
                
            builder
                .Property(x => x.Endereco)
                .IsRequired();
            builder
                .Property(x => x.Nome)
                .HasMaxLength(50);
            
        }
    }
}
