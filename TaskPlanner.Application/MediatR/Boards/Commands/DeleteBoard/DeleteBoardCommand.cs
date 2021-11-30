using MediatR;


namespace TaskPlanner.Application.MediatR.Boards.Commands.DeleteBoard
{
    class DeleteBoardCommand : IRequest
    {
        public int Id { get; set; }
        public string CreatorId { get; set; }
    }
}
