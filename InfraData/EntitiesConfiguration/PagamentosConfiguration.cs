using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace InfraData.EntitiesConfiguration
{
    public class PagamentosConfiguration : IEntityTypeConfiguration<Pagamentos>
    {
        public void Configure(EntityTypeBuilder<Pagamentos> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
        }
    }
}
