using ControleManutencaoPreventiva.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleManutencaoPreventiva.Context.Configurations
{
    public class RangeIpsConfiguration : IEntityTypeConfiguration<RangeIps>
    {
        public void Configure(EntityTypeBuilder<RangeIps> builder)
        {
            builder.HasKey(x => x.Ip);
            builder.Property(x => x.Ip).IsRequired();
            builder
                .HasOne(x => x.Equipamento)
                .WithMany(x => x.Ips)
                .HasForeignKey(x => x.EquipamentoId);
           
        }
    }
}
