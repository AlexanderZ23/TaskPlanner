using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlanner.Domain;

namespace TaskPlanner.Persistence.EntityTypesConfiguration
{
    class BoardConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.Title).HasMaxLength(150);
            builder.Property(b => b.Details).HasMaxLength(250);

        }
    }
}
