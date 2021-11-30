using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Domain.Models;

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
                CreatorId = request.CreatorId,
                Title = request.Title,
                Details = request.Details,
                CreatedOn = DateTime.Now,
                IsPrivate = request.IsPrivate,
                UpdatedOn = null,
            };

            await context.Boards.AddAsync(board, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            //looks like something that can not work
            return board.Id;
        }
    }
}
