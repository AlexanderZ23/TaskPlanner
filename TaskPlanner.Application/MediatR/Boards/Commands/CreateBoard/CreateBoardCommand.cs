using MediatR;

namespace TaskPlanner.Application.MediatR.Boards.Commands.CreateBoard
{
    class CreateBoardCommand : IRequest<int>
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
