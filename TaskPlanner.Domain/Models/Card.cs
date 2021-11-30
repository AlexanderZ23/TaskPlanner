using System;
using System.Collections.Generic;
using TaskPlanner.Domain.RelatedEntities;

namespace TaskPlanner.Domain.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsImportant { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Board Board { get; set; }
        public List<TaskPlannerUser> Users { get; set; }
        public List<UserInCards> UserInCards { get; set; }

    }
}
