using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Application.MediatR.Cards.Commands.CreateCard
{
    class CreateCardCommandHandler : IRequestHandler<CreateCardCommand>
    {
        private readonly ICardDbContext context;

        public CreateCardCommandHandler(ICardDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(CreateCardCommand request, CancellationToken cancellationToken)
        {
            var card = new Card
            {
                CreatorId = request.CreatorId,
                BoardId = request.BoardId,
                Title = request.Title,
                Details = request.Details,
                IsImportant = request.IsImportant,
                CreatedOn = DateTime.Now,
            };

            await context.Cards.AddAsync(card, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
