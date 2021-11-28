using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Domain;

namespace TaskPlanner.Application.Interfaces
{
    public interface ICardDbContext
    {
        DbSet<Card> Cards { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
