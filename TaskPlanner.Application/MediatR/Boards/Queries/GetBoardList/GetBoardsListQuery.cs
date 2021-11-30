using MediatR;
using System;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardList
{
    class GetBoardsListQuery : IRequest<BoardsListVm>
    {
        public int Id { get; set; }
        public string CreatorId { get; set; }
    }
}
