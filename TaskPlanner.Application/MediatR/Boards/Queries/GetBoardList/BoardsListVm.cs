using System.Collections.Generic;
     
namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardList
{
    class BoardsListVm
    {
        public List<BoardsListDto> Boards { get; set; }
    }
}