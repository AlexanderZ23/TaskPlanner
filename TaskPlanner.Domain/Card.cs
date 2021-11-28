using System;
using System.Collections.Generic;

namespace TaskPlanner.Domain
{
    public class Card
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public List<TaskPlannerUser> JoinedUsers { get; set; }

    }
}
