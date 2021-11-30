using MediatR;

namespace TaskPlanner.Application.MediatR.Cards.Commands.DeteleCard
{
    class DeleteCardCommand : IRequest
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string CreatorId { get; set; }
    }
}
