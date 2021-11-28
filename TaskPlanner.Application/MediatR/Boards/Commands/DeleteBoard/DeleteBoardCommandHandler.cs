using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Common.Exceptions;
using TaskPlanner.Application.Interfaces;

namespace TaskPlanner.Application.MediatR.Boards.Commands.DeleteBoard
{
    class DeleteBoardCommandHandler : IRequestHandler<DeleteBoardCommand>
    {
        private readonly IBoardDbContext context;

        public DeleteBoardCommandHandler(IBoardDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteBoardCommand request, CancellationToken cancellationToken)
        {
            var board = await context.Boards.FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);

            if (board == null || board.UserId == request.UserId)
            {
                throw new BoardNotFoundException(nameof(board), request.Id);
            }

            context.Boards.Remove(board);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
