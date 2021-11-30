using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaskPlanner.Application.Interfaces;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardList
{
    class GetBoardsListQuetyHandler : IRequestHandler<GetBoardsListQuery, BoardsListVm>
    {
        private readonly IMapper mapper;
        private readonly IBoardDbContext context;

        public GetBoardsListQuetyHandler(IMapper mapper, IBoardDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<BoardsListVm> Handle(GetBoardsListQuery request, CancellationToken cancellationToken)
        {
            var entity = await context.Boards.Where(b => b.CreatorId == request.CreatorId)
                .ProjectTo<BoardsListDto>(mapper.ConfigurationProvider).ToListAsync(cancellationToken);

            return new BoardsListVm { Boards = entity };
        }
    }
}
