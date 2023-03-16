using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfraData.EntitiesConfiguration
{
    public class DividasConfiguration : IEntityTypeConfiguration<Dividas>
    {
        public void Configure(EntityTypeBuilder<Dividas> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Valor).HasPrecision(10, 2).IsRequired();

            builder
                .HasOne(x => x.Recebedores)
                .WithMany(x => x.Dividas)
                .HasForeignKey(x => x.RecebedoresId);

            builder
                .HasOne(x => x.Pagamentos)
                .WithMany(x => x.Dividas)
                .HasForeignKey(x => x.PagamentosId);
        }
    }
}
