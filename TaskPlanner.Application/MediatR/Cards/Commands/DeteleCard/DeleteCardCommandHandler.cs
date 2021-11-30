using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Domain.Models;
using Microsoft.EntityFrameworkCore;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Application.Common.Exceptions;

namespace TaskPlanner.Application.MediatR.Cards.Commands.DeteleCard
{
    class DeleteCardCommandHandler : IRequestHandler<DeleteCardCommand>
    {
        private readonly ICardDbContext context;

        public DeleteCardCommandHandler(ICardDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteCardCommand request, CancellationToken cancellationToken)
        {
            var card = await context.Cards.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (card == null || card.BoardId == request.BoardId || card.CreatorId == request.CreatorId)
            {
                throw new CardNotFoundException(nameof(Card), request.Id);
            }

            context.Cards.Remove(card);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
