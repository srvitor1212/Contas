using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfraData.EntitiesConfiguration
{
    public class PagamentoDeDividasConfiguration : IEntityTypeConfiguration<PagamentoDeDividas>
    {
        public void Configure(EntityTypeBuilder<PagamentoDeDividas> builder)
        {
            builder.HasKey(x =>  x.Id);

            builder.Property(x => x.DataEfetivacao).IsRequired();
            builder.Property(x => x.DividasId).IsRequired();

            builder
                .HasOne(x => x.Dividas)
                .WithMany(x => x.PagamentoDeDividas)
                .HasForeignKey(x => x.DividasId);
        }
    }
}
