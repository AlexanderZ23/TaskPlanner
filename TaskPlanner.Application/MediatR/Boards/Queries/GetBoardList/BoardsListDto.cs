using System;
using TaskPlanner.Domain.Models;
using TaskPlanner.Application.Common.Mapping;
using AutoMapper;

namespace TaskPlanner.Application.MediatR.Boards.Queries.GetBoardList
{
    class BoardsListDto : IMapWith<Board>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Board, BoardsListDto>()
                .ForMember(boardVm => boardVm.Id, opt => opt.MapFrom(board => board.Id))
                .ForMember(boardVm => boardVm.Title, opt => opt.MapFrom(board => board.Title))
                .ForMember(boardVm => boardVm.Details, opt => opt.MapFrom(board => board.Details))
                .ForMember(boardVm => boardVm.CreatedOn, opt => opt.MapFrom(board => board.CreatedOn))
                .ForMember(boardVm => boardVm.UpdatedOn, opt => opt.MapFrom(board => board.UpdatedOn));
        }
    }
}
