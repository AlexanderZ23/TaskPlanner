using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Common.Exceptions;
using TaskPlanner.Application.Interfaces;

namespace TaskPlanner.Application.MediatR.Boards.Commands.UpdateBoard
{
    class UpdateBoardCommandHandler : IRequestHandler<UpdateBoardCommand>
    {
        private readonly IBoardDbContext context;

        public UpdateBoardCommandHandler(IBoardDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateBoardCommand request, CancellationToken cancellationToken)
        {
            var board = await context.Boards.FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);

            if (board == null || board.UserId != request.UserId)
            {
                throw new BoardNotFoundException(nameof(board), request.Id);
            }

            board.Title = request.Title;
            board.Details = request.Details;
            board.UpdatedOn = DateTime.Now;
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
