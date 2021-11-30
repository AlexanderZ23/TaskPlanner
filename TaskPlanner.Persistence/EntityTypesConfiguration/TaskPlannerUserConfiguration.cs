using TaskPlanner.Domain.Models;
using Microsoft.EntityFrameworkCore;
using TaskPlanner.Domain.RelatedEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskPlanner.Persistence.EntityTypesConfiguration
{
    class TaskPlannerUserConfiguration : IEntityTypeConfiguration<TaskPlannerUser>
    {
        public void Configure(EntityTypeBuilder<TaskPlannerUser> builder)
        {
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.UserName).HasMaxLength(25);
            builder.Property(u => u.FirstName).HasMaxLength(50);
            builder.Property(u => u.LastName).HasMaxLength(50);
            builder.HasMany(u => u.Boards).WithMany(b => b.Users).UsingEntity<UserInBoards>(
                j => j
                .HasOne(uib => uib.Board)
                .WithMany(uib => uib.UserInBoards)
                .HasForeignKey(uib => uib.BoardId),
                j => j
                .HasOne(uib => uib.TaskPlannerUser)
                .WithMany(uib => uib.UserInBoards)
                .HasForeignKey(uib => uib.TaskPlannerUserId),
                j =>
                {
                    j.Property(uib => uib.JoinedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                    j.HasKey(t => new { t.TaskPlannerUserId, t.BoardId });
                });
            builder.HasMany(u => u.Cards).WithMany(b => b.Users).UsingEntity<UserInCards>(
                j => j
                .HasOne(uic => uic.Card)
                .WithMany(uic => uic.UserInCards)
                .HasForeignKey(uic => uic.CardId),
                j => j
                .HasOne(uic => uic.TaskPlannerUser)
                .WithMany(uic => uic.UserInCards)
                .HasForeignKey(uic => uic.TaskPlannerUserId),
                j =>
                {
                    j.Property(uib => uib.JoinedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                    j.HasKey(t => new { t.TaskPlannerUserId, t.CardId });
                });
        }
    }
}
