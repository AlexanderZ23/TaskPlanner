using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Persistence.EntityTypesConfiguration
{
    class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Title).HasMaxLength(150);
            builder.Property(c => c.Title).HasMaxLength(250);
        } 
    }
}
