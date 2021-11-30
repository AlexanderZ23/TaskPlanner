using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Application.Interfaces
{
    public interface IBoardDbContext
    {
        DbSet<Board> Boards { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
