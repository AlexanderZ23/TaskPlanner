using System;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Domain.RelatedEntities
{
    public class UserInCards
    {
        public string TaskPlannerUserId;
        public TaskPlannerUser TaskPlannerUser { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public DateTime JoinedOn { get; set; }
    }
}
