using MediatR;

namespace TaskPlanner.Application.MediatR.Cards.Commands.UpdateCard
{
    class UpdateCardCommand : IRequest
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsImportant { get; set; }
    }
}
