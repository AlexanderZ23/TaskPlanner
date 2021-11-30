using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using TaskPlanner.Domain.RelatedEntities;
 
namespace TaskPlanner.Domain.Models
{
    public class TaskPlannerUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime Joined { get; set; }
        public List<Card> Cards { get; set; }
        public List<Board> Boards { get; set; }
        public List<UserInCards> UserInCards { get; set; }
        public List<UserInBoards> UserInBoards { get; set; }
    }
}
