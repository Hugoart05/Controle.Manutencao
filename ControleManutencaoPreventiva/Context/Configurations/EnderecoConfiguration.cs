using ControleManutencaoPreventiva.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleManutencaoPreventiva.Context.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .HasKey(e => e.Id);
            builder
                .HasOne(x => x.Condominio)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Condominio>(x => x.EnderecoId);
            builder
                .ToTable("endereco");
            builder
                .Property(e => e.Numero)
                .HasMaxLength(4)
                .HasColumnName("Nº");
              
        }
    }
}
