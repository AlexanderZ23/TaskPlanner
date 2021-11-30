using System;
using System.Collections.Generic;
using TaskPlanner.Domain.RelatedEntities;

namespace TaskPlanner.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public List<TaskPlannerUser> Users { get; set; }
        public List<Card> Cards { get; set; }
        public List<UserInBoards> UserInBoards { get; set; }
    }
}
