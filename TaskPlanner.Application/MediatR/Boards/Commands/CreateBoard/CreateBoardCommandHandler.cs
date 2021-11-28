using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Domain;

namespace TaskPlanner.Application.MediatR.Boards.Commands.CreateBoard
{
    class CreateBoardCommandHandler : IRequestHandler<CreateBoardCommand, int>
    {
        private readonly IBoardDbContext context;

        public CreateBoardCommandHandler(IBoardDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Handle(CreateBoardCommand request, CancellationToken cancellationToken)
        {
            var board = new Board
            {
                UserId = request.UserId,
                Title = request.Title,
                Details = request.Details,
                CreatedOn = DateTime.Now,
                UpdatedOn = null,
            };

            await context.Boards.AddAsync(board, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return board.Id;
        }
    }
}
