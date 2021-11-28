using System;
using TaskPlanner.Application.Common.Mapping;
using TaskPlanner.Domain;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardDetails
{
    public class CardsListVm : IMapWith<Card>
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Board Board { get; set; }
    }
}