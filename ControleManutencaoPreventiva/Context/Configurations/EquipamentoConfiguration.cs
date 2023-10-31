using ControleManutencaoPreventiva.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleManutencaoPreventiva.Context.Configurations
{
    public class EquipamentoConfiguration : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder
                .HasOne(x => x.Condominio)
                .WithMany(x => x.Equipamentos)
                .HasForeignKey(x => x.CondominioId);
            builder.HasMany(x => x.Ips)
                .WithOne(x => x.Equipamento)
                .HasForeignKey(x => x.EquipamentoId);
            builder
                .Property(x => x.CondominioId)
                .IsRequired();
            builder
                .Property(x => x.Descricao)
                .HasMaxLength(100);
                
               
               
        }
    }
}
