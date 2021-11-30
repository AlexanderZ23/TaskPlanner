using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Common.Exceptions;
using TaskPlanner.Application.Interfaces;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardDetails
{
    class GetBoardDetailsQueryHandler : IRequestHandler<GetBoardDetailsQuery, BoardDetailsVm>
    {
        private readonly IMapper mapper;
        private readonly IBoardDbContext context;

        public GetBoardDetailsQueryHandler(IMapper mapper, IBoardDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<BoardDetailsVm> Handle(GetBoardDetailsQuery request, CancellationToken cancellationToken)
        {
            var board = await context.Boards.FirstOrDefaultAsync(board => board.Id == request.Id, cancellationToken);

            if (board == null || board.CreatorId != request.CreatorId)
            {
                throw new BoardNotFoundException(nameof(Board), request.Id);
            }

            return mapper.Map<Board,BoardDetailsVm>(board);
        }
    }
}
