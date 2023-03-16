using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfraData.EntitiesConfiguration
{
    public class EntradasConfiguration : IEntityTypeConfiguration<Entradas>
    {
        public void Configure(EntityTypeBuilder<Entradas> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Valor).HasPrecision(10, 2).IsRequired();
        }
    }
}
