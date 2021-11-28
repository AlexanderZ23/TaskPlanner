using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Domain
{
    public class TaskPlannerUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime Joined { get; set; }
        public List<Board> WorkBoards { get; set; }
        public List<Card> WorkCards { get; set; }
    }
}
