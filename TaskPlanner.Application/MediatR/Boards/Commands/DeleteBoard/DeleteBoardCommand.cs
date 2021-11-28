using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Application.MediatR.Boards.Commands.DeleteBoard
{
    class DeleteBoardCommand : IRequest
    {
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}
