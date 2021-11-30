using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Common.Exceptions;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Application.MediatR.Cards.Commands.UpdateCard
{
    class UpdateCardCommandHandler : IRequestHandler<UpdateCardCommand>
    {
        private readonly ICardDbContext context;

        public UpdateCardCommandHandler(ICardDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateCardCommand request, CancellationToken cancellationToken)
        {
            var card = await context.Cards.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (card == null || card.CreatorId != request.CreatorId)
            {
                throw new CardNotFoundException(nameof(Card), request.Id);
            }

            card.Title = request.Title;
            card.Details = request.Details;
            card.UpdatedOn = DateTime.Now;
            card.IsImportant = request.IsImportant;
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
