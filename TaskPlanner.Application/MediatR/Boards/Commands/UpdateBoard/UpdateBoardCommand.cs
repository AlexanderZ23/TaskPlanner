using MediatR;

namespace TaskPlanner.Application.MediatR.Boards.Commands.UpdateBoard
{
    class UpdateBoardCommand : IRequest
    {
        public string UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
