using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardDetails
{
    class GetBoardDetailsQuery : IRequest<BoardDetailsVm>
    {
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}
