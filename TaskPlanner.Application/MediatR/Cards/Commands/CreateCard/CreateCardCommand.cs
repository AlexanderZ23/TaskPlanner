using MediatR;

namespace TaskPlanner.Application.MediatR.Cards.Commands.CreateCard
{
    class CreateCardCommand : IRequest
    {
        public int BoardId { get; set; }
        public string Title { get; set; }
        public string CreatorId { get; set; }
        public string Details { get; set; }
        public bool IsImportant { get; set; }
    }
}
