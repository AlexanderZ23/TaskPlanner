using System;
using TaskPlanner.Domain.Models;

namespace TaskPlanner.Domain.RelatedEntities
{
    public class UserInBoards
    {
        public string TaskPlannerUserId { get; set; }
        public TaskPlannerUser TaskPlannerUser { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public DateTime JoinedOn { get; set; }
    }
}
