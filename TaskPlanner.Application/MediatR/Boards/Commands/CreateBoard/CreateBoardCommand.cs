using MediatR;
using System.Collections.Generic;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Application.MediatR.Boards.Commands.CreateBoard
{
    class CreateBoardCommand : IRequest<int>
    {
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsPrivate { get; set; }
    }
}
