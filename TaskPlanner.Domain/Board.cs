using System;
using System.Collections.Generic;

namespace TaskPlanner.Domain
{
    public class Board
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public List<Card> Cards { get; set; }
    }
}
