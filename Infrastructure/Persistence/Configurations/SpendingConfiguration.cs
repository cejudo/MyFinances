using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class SpendingConfiguration : IEntityTypeConfiguration<Spending>
    {
        public void Configure(EntityTypeBuilder<Spending> builder)
        {
            builder.Property(t => t.SpendingDate)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
