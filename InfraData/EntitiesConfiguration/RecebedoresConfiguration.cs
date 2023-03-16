using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration
{
    public class RecebedoresConfiguration : IEntityTypeConfiguration<Recebedores>
    {
        public void Configure(EntityTypeBuilder<Recebedores> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
        }
    }
}
