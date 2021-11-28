using Microsoft.EntityFrameworkCore;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Domain;
using TaskPlanner.Persistence.EntityTypesConfiguration;

namespace TaskPlanner.Persistence
{
    class TaskPlannerDbContext : DbContext, IBoardDbContext, ICardDbContext
    {
        public TaskPlannerDbContext(DbContextOptions<TaskPlannerDbContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BoardConfiguration());
            builder.ApplyConfiguration(new CardConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
